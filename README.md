# Natty or Not – Copy Studio (C# + AWS Bedrock + Polly)

## 📒 Descrição
Um mini app que transforma um tema/texto em duas versões:
- **NATTY**: reescrita mínima, tom natural;
- **FAKE NATTY**: versão “bombada” estilo viral.
Opcionalmente, gera **áudio** em pt-BR com Amazon Polly. Ideal para posts, roteiros curtos e teasers.

## 🤖 Tecnologias Utilizadas
- C# / .NET 8 (Minimal API)
- Amazon Bedrock (Claude 3 Haiku para geração de texto)
- Amazon Polly (Text-to-Speech pt-BR)
- (Opcional) Amazon S3 para armazenar MP3

## 🧐 Como rodar (resumo)
1. Clone/fork o repositório e abra a pasta do projeto:

```powershell
cd c:\Dev\IAgenerativaAWS
cd NattyOrNot.CopyStudio
```

2. Configure credenciais AWS (ex.: em variáveis de ambiente):

```powershell
$env:AWS_ACCESS_KEY_ID = "<sua-key>"
$env:AWS_SECRET_ACCESS_KEY = "<sua-secret>"
$env:AWS_REGION = "us-east-1"
```

3. Habilite o modelo Claude (Bedrock) no console da AWS se necessário.

4. Restaure e rode:

```powershell
dotnet restore
dotnet build
dotnet run
```

5. Exemplos de requisições (PowerShell / curl):

Gerar texto NATTY:

```powershell
curl -Method POST -Uri http://localhost:5174/api/generate -ContentType "application/json" -Body '{"topic":"Post para Instagram sobre ensaio de gestante ao pôr do sol","tone":"natty","length":"curto"}'
```

Gerar texto FAKE NATTY:

```powershell
curl -Method POST -Uri http://localhost:5174/api/generate -ContentType "application/json" -Body '{"topic":"Post para Instagram sobre ensaio de gestante ao pôr do sol","tone":"fake","length":"curto"}'
```

Gerar áudio (Polly):

```powershell
curl -Method POST -Uri http://localhost:5174/api/tts -ContentType "application/json" -Body '{"text":"Seu texto aqui em PT-BR"}' --output natty.mp3
```

## 🚀 Observações
- O projeto usa o AWS SDK para .NET. Certifique-se que a sua conta/role tem permissões para Bedrock/Polly.
- O upload para S3 foi deixado como exemplo comentado no `Program.cs`.

## 💭 Reflexão
Comparar “natty” vs “fake natty” evidencia como pequenas mudanças de prompt/temperatura já transformam a percepção de autenticidade. O desafio é equilibrar clareza, ética e performance.

# Natural ou Fake Natty? Como Vencer na Era das IAs Generativas

## 🚀 Introdução

> Woooow! Look at this 👀

Olá pessoal, Venilton da DIO aqui! Inspirado na hype _"Natty or Not"_ do fisiculturismo, este Lab da DIO te convida a conhecer o mundo das IAs Generativas, explorando o potencial dessas tendências tecnológicas incríveis!

## 🎯 Bora Pro Desafio!? Você Já Venceu 💪🤓

### Objetivos

1. **Explorar IAs Generativas**: Utilize essas tecnologias para criar conteúdos que sejam o mais realista possível. Seja criativo! Você pode produzir imagens, textos, áudios, vídeos ou combinações de tudo isso!
1. **Potfólio de Projetos**:
    1. Faça o "fork" deste repositório, criando uma cópia em seu GitHub pessoal;
    2. Edite seu README com os detalhes do seu projeto, siga nosso [Template](#template) (é só copiar, colar e preencher);
    3. Submeta o link do seu repositório na plataforma da DIO. Pronto, você acabou de fortalecer seu portfólio de projetos nos perfis do GitHub e DIO 🚀
1. **Efeito de Rede**: Compartilhe seus resultados nas redes sociais com a hashtag **#LabDIONattyOrNot**. Não esqueça de nos marcar: [DIO](https://www.linkedin.com/school/dio-makethechange) e [falvojr](https://www.linkedin.com/in/falvojr).

### Template

```markdown
# Título do Projeto Extremamente Aesthetic ;)

## 📒 Descrição
Breve descrição do seu projeto

## 🤖 Tecnologias Utilizadas
Liste as IAs Generativas e outras ferramentas usadas

## 🧐 Processo de Criação
Descreva como você criou o conteúdo

## 🚀 Resultados
Apresente os resultados do seu projeto

## 💭 Reflexão (Opcional)
Comente sobre o desafio de criar algo 'natty' com IA.
```

### Exemplos e Insigths

- [E-BOOK](/exemplos/E-BOOK.md)
- [Podcast](/exemplos/PODCAST.md)
- [Vídeo (Avatar Virtual)](/exemplos/VIDEO.md)

## Links Interessantes

[Base10: If You’re Not First, You’re Last: How AI Becomes Mission Critical](https://base10.vc/post/generative-ai-mission-critical/)

![Base10's Trend Map Generative AI](https://github.com/digitalinnovationone/lab-natty-or-not/assets/730492/f4df26e8-f8f7-4419-8252-c69d73ea930c)
