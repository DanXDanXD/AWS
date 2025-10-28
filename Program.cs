using Amazon;
using Amazon.BedrockRuntime;
using Amazon.BedrockRuntime.Model;
using Amazon.Polly;
using Amazon.Polly.Model;
using Amazon.S3;
using Amazon.S3.Transfer;
using System.Text;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Região (use uma região com Bedrock suportado, ex: us-east-1)
var region = RegionEndpoint.USEast1;

// Clientes AWS - usam o AWS SDK DefaultCredentialsChain (env vars, perfil, etc.)
var bedrock = new AmazonBedrockRuntimeClient(region);
var polly = new AmazonPollyClient(region);
var s3 = new AmazonS3Client(region); // opcional

var app = builder.Build();

app.MapPost("/api/generate", async (GenerateRequest req) =>
{
    if (string.IsNullOrWhiteSpace(req.Topic))
        return Results.BadRequest(new { error = "Topic is required" });

    var systemNatty = "Você é um editor cuidadoso. Reescreva mantendo o tom natural do usuário, alterando o mínimo necessário. Evite exageros, clichês e jargões de marketing.";
    var systemFake  = "Você é um copywriter viral. Reescreva com ganchos fortes, CTA, urgência leve e ritmo de redes sociais. Mantenha clareza, mas pode ‘bombar’ o estilo.";

    var toneLower = req.Tone?.Trim()?.ToLower();
    var system = toneLower == "fake" ? systemFake : systemNatty;
    var temperature = toneLower == "fake" ? 0.9 : 0.3;

    var userText = $"TEMA/BRIEF:\n{req.Topic}\n\nObservações/estilo extra:\n{req.Style ?? "(nenhuma)"}\n\nSaída em PT-BR. Tamanho: {req.Length ?? "curto"}.";

    var payload = new
    {
        anthropic_version = "bedrock-2023-05-31",
        max_tokens = req.MaxTokens is > 0 and <= 2000 ? req.MaxTokens : 600,
        temperature,
        system = new[] { new { type = "text", text = system } },
        messages = new[]
        {
            new {
                role = "user",
                content = new[] { new { type = "text", text = userText } }
            }
        }
    };

    var json = JsonSerializer.Serialize(payload);
    var request = new InvokeModelRequest
    {
        ModelId = "anthropic.claude-3-haiku-20240307-v1:0",
        ContentType = "application/json",
        Accept = "application/json",
        Body = new MemoryStream(Encoding.UTF8.GetBytes(json))
    };

    try
    {
        var response = await bedrock.InvokeModelAsync(request);
        using var reader = new StreamReader(response.Body);
        var body = await reader.ReadToEndAsync();

        // Tenta desserializar a resposta no formato esperado
        var data = JsonSerializer.Deserialize<ClaudeResponse?>(body, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        var text = data?.content?.FirstOrDefault()?.text ?? body ?? "(sem saída)";

        return Results.Ok(new { text });
    }
    catch (Exception ex)
    {
        return Results.Problem(detail: ex.Message);
    }
});

app.MapPost("/api/tts", async (TtsRequest req) =>
{
    if (string.IsNullOrWhiteSpace(req.Text))
        return Results.BadRequest(new { error = "Text is required" });

    try
    {
        var synth = await polly.SynthesizeSpeechAsync(new SynthesizeSpeechRequest
        {
            Text = req.Text,
            OutputFormat = OutputFormat.Mp3,
            VoiceId = VoiceId.Camila, // pt-BR
            LanguageCode = "pt-BR"
        });

        // Se quiser salvar no S3: (exemplo comentado)
        // var transferUtility = new TransferUtility(s3);
        // await transferUtility.UploadAsync(synth.AudioStream, "my-bucket", "natty.mp3");

        // Retorna o MP3 diretamente
        return Results.File(synth.AudioStream, "audio/mpeg", "voice.mp3");
    }
    catch (Exception ex)
    {
        return Results.Problem(detail: ex.Message);
    }
});

app.Run();

record GenerateRequest(string Topic, string? Tone, string? Style, string? Length, int MaxTokens = 600);
record TtsRequest(string Text);

class ClaudeResponse
{
    public List<ClaudeContent>? content { get; set; }
}
class ClaudeContent
{
    public string? type { get; set; }
    public string? text { get; set; }
}
