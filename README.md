# Outdoor Pro - Sistema de Gestão

## 📒 Descrição
Foi desenvolvido um sistema de gestão empresarial que auxilia no aluguel de painéis e mídias visuais, assim como geração de orçamentos, sistema de feedback para avaliar serviço e orçamentos recusados. Também foi implementado ferramentas internas capazes de aumentar a eficiência da comunicação interna da empresa, com comunicados gerais e também com comunicados individuais.

## 🤖 Tecnologias Utilizadas
Claude 4 Sonnet Thinking (Organização de Documento)
Gemini 2.5 Pro (Pesquisa inicial e desenvolvimento do escopo do projeto)
Base44 (Desenvolvimento e aperfeiçoamento do sistema)
Chat GPT 5 (Aprimoramento de conversa com termos naturais para prompts específicos)

## 🧐 Processo de Criação
1 Passo - Necessidade
Foi identificado um grave problema na estrutura empresarial, há cerca de 150 mídias externas distribuídas em 5 cidades do Oeste Baiano, entretanto, não havia um controle sobre localizações corretas, a codificação das mídias não era padronizada, não havia identificação da mídia por foto e o controle era via um sistema local extremamente antiquado.
2 Passo - Busca por soluções
Os sistemas apresentados como soluções no mercado, na maioria das vezes, era mais robusto e mais desenvolvido do que o necessário, causando uma overdose de informações e ferramentas que causariam uma difícil implementação, adaptação e uma etapa mais longa no processo de treinamento das vendedoras, financeiro e produção. Portanto, a IA Generativa surgiu como a solução perfeita.
3 Passo - Padronização e organização
Com auxilio do Gemini 2.5 Pro foi criado um novo padrão de codificação dos painéis, identificando cidade, estado e uma numeração que auxilia na busca interna e identificação externa também. Foi enviado para o Claude 4 Sonnet Thinking um PDF contendo todos os painéis da cidade atual e outro contendo os códigos novos, junto com um prompt que explica como deveriam ser renomeados e organizados
- PROMPT USADO -
[Segue as instruções para nova nomenclatura e descrições: Modelo do Código: Código simples, sendo apenas [SIGLA ESTADO-SIGLA CIDADE] [NUMERO COMEÇANDO EM 101] Exemplo: BA-LEM 101 Modelo da descrição: [CÓDIGO ESTADO/CIDADE/NUMERO] [CATEGORIA] [Tipo de Via Principal] [Nome/Número da Via], [Referência de Posição] [Lado/Direção], [Coordenadas GPS aproximadas]. [Detalhes Adicionais Fixos] Exemplo: Tipo de Via Principal: Ex: Rodovia, Avenida, Rua. Nome/Número da Via: Ex: BR-242, Av. Clériston Andrade. Referência de Posição: Ex: Km 800, próximo à interseção com [outra via pública], altura do número 500. Lado/Direção: Ex: Lado esquerdo (sentido centro), facing norte. Coordenadas GPS: Latitude e longitude aproximadas (ex: -12.150, -45.000), extraídas do mapa para precisão eterna. Detalhes Adicionais Fixos: Ex: Altura de 10m, visível de ambos os lados (apenas elementos físicos imutáveis).]
---
4 Passo - Criação de um Prompt Escopo do Sistema
Com auxilio do Gemini 2.5 Pro, foi realizado uma conversa onde foi feita a análise das necessidades e quais áreas seriam interessantes para o desenvolvimento do sistema de gestão.
5 Passo - Desenvolvimento Básico
Com o prompt básico, foi iniciado por meio do Base44 o desenvolvimento do sistema, no decorrer do processo foram identificadas algumas falhas e correções a serem melhoradas, o que gerou uma conversa com o Base44, um sistema robusto e mais completo adaptado para as necessidades da empresa.
6 Passo - Refinamento
A conversa gerada com o Base44 foi transcrita e inserida em um chat com o GPT 5 para que fosse desenvolvido um Prompt técnico, completo e que gerasse uma versão mais sólida e aperfeiçoada do nosso sistema.

## 🚀 Resultados
- Sistema de Gestão empresarial com acesso por autenticação e diferentes níveis de acesso por usuários
<img width="621" height="913" alt="image" src="https://github.com/user-attachments/assets/bbead7f2-d89c-4e33-9f2c-b48799cc09b5" />

- Dashboard inicial com informações rápidas e importantes
<img width="1904" height="991" alt="image" src="https://github.com/user-attachments/assets/b24ef09a-e2d6-452f-ad24-2e9ed635b71b" />

- Aba de Painéis com acesso de CEO, permitindo criação de novo painél, identificação de painéis alugados ou disponíveis por Kanban ou localização em mapa.
<img width="1642" height="991" alt="image" src="https://github.com/user-attachments/assets/6876e28e-e83e-4591-a1c4-0baa68258e33" />
<img width="1642" height="774" alt="image" src="https://github.com/user-attachments/assets/d6cfa6a5-e9de-4a3a-8cf6-fd2b37876644" />

- Criação de Novo Painel, com destaque para tipo do painel e última data que esteve disponível (Trazendo para o cliente os dados de quanto tempo aquele painel está sem locação)
<img width="1642" height="774" alt="image" src="https://github.com/user-attachments/assets/f051b5ec-3264-4b46-908f-c44c87460e08" />

- Criação de Orçamento, com opção de editar o valor inicial em caso de descontos e adicionar itens extras, ao ser criado o orçamento é disponibilizado para ser enviado por email, ou baixar um PDF, também é possível aprovar e rejeitar. Para usuários com acesso de CEO é permitido excluir e editar.
<img width="1642" height="1010" alt="image" src="https://github.com/user-attachments/assets/199ddb02-0cb9-4cad-96b5-b1ee12a8d6d0" />
<img width="1642" height="1010" alt="image" src="https://github.com/user-attachments/assets/ab07ef31-cfbb-43d4-8089-02f748362ab4" />

- Ao rejeitar orçamento, é solicitado um feedback imediato
<img width="630" height="366" alt="image" src="https://github.com/user-attachments/assets/3db2eac5-a0b8-4f61-9704-14013dc7e6ee" />

- Ao aprovar o orçamento, surge uma aba com opções de pagamento que serão enviadas a aba financeira, também avisa que o painél será marcado como alugado.
<img width="504" height="540" alt="image" src="https://github.com/user-attachments/assets/85c9df3d-c00a-4ed1-8352-fea0c9f7f635" />

- Aba de clientes permite a criação de novos clientes, acesso a informações necessárias para emitir orçamentos e pagamentos.
<img width="1589" height="447" alt="image" src="https://github.com/user-attachments/assets/d634db6e-37f3-4ae4-a041-3aac2252383d" />

- Aba de minhas comissões mostra o quanto de comissão foi ganha pelo usuário, quantas já foram pagas e quantas ainda estão pendentes.
<img width="1589" height="447" alt="image" src="https://github.com/user-attachments/assets/b80faf62-988e-48df-98e5-a0ee6bda3277" />

- Criação de Tarefas, permite que seja criada uma função com título, descrição, data de prazo, horário e definir nível de prioriade da tarefa, também é possível categorizar o setor, escolher os/o funcionários/o responsável, criar etapas para a tarefa e também adicionar anexos se necessário.
<img width="1589" height="1026" alt="image" src="https://github.com/user-attachments/assets/da3998e6-f75a-48e5-be1f-8687c16614a5" />

- Ao ser criada, a tarefa fica registrada de acordo com andamento, pendente, atrasada ou concluída e também mostra o progresso por etapas definidas, assim como o responsável e data marcada pela tarefa, ao realizar um check é mostrado qual usuário realizou e qual foi a data + horário.
<img width="804" height="588" alt="image" src="https://github.com/user-attachments/assets/6d55ec9b-3753-4e2b-9935-85f49e89512c" />

- Na aba de comunicados o CEO pode definir um título, prioridade e se o comunicado é geral ou para algum usuário em específico, se o comunicado por individual, ele permite uma resposta por parte do funcionário que recebeu.
<img width="804" height="588" alt="image" src="https://github.com/user-attachments/assets/8783c334-ec4a-44f2-9818-fbd47a1e968f" />

- O comunicado aparece da seguinte maneira, datando com horário, marcando quem enviou e a categoria do comunicado
<img width="1580" height="248" alt="image" src="https://github.com/user-attachments/assets/36473747-f20d-4858-bebb-4a3700dbf43d" />

- Contas a Receber é possível verificar o que está em atraso, o que há para receber, o que foi recebido e parcelas para serem editadas ou confirmadas o pagamento
<img width="1580" height="836" alt="image" src="https://github.com/user-attachments/assets/f7b7eb5d-faed-4959-b662-d464cf6599dd" />

- Também é possível gerar uma nova conta e definir o meio e datas
<img width="1580" height="639" alt="image" src="https://github.com/user-attachments/assets/512347bf-0dd4-44ff-83ba-f78bfc45a4e8" />

- Na aba relatórios conseguimos ter uma visão geral das informações mais úteis por período selecionado, também é possível exportar a análise em PDF
<img width="1580" height="984" alt="image" src="https://github.com/user-attachments/assets/346238fe-bcb5-4214-ab49-a37f3f2c85a6" />
<img width="1580" height="735" alt="image" src="https://github.com/user-attachments/assets/8a74b87c-b9ed-4dc2-8825-40f4485c0578" />

- O CEO possui uma aba específica para criar comissões, podendo ter uma regra padrão ou uma comissão personalizada por vendedor
<img width="1580" height="735" alt="image" src="https://github.com/user-attachments/assets/40c80a4d-90a2-4c12-b848-5abffc754f64" />
<img width="1580" height="631" alt="image" src="https://github.com/user-attachments/assets/4216a1f0-fb67-469f-928a-1c383c5a37f8" />

- O sistema possui uma configuração de níveis de acesso por tipo de usuário, sendo os níveis de: CEO, Vendedor, Financeiro e Recepção. Ao lado do nome do usuário aparece um BADGE e identifica seu nível de acesso.
<img width="231" height="142" alt="image" src="https://github.com/user-attachments/assets/811ca1a6-4c09-4561-ad02-de02499ae7bb" />

## 💭 Reflexão (Opcional)
Um projeto bem robusto, mostrou que a diversidade e o conhecimento em vários tipos de IAs agregam e complementam o funcionamento, tornando capaz de transformar ideias em projetos reais com um alto nível de personalização, criando uma experiência complexa e potencializando os humanos. Sem dúvidas, a inteligência artificial se consolida cada vez mais no meio pessoal e empresarial como uma potente ferramenta organizacional, operacional e produtiva.
