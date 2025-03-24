Nome do Projeto: tpII-helpstop-backend
Descrição Geral: Um aplicativo feito para ajudar o usuário
Quem são os usuários: Pessoas que tem problemas e dificuldades com alguma situação que precisa de ajuda como pesquisas e afins
Tecnologias: GiThub,Visual Studio,SQL_Server,Firebase,C#
Qual problema resolve: Ele facilita a comunicação de quem precisa de ajuda e quem pode ajudar né
Funcionalidades: Cadastro de usuário, Agenda de compromissos, Organização de tarefas, Segurança restrita
Arquitetura do Projeto: Estrutura por camadas: Domain(Aonde se hospeda o site ou aplicativo), Application(Em qual mês é utilizado), Infrastructure(A estrutura que o site segue), Interface(Interação com usuário)
Padrões utilizados: DDD(Se baseia na compreensão de domínio que Será aplicado no software), Clean Architecture(Um estilo de arquitetura)
Princípios SOLID Aplicados:
5.1. S - Single Responsibility Principle
Repositorio
5.2. O - Open/Closed Principle
Infra.Data
5.3. L - Liskov Substitution Principle
Entites
5.4. I - Interface Segregation Principle
Appication
5.5. D - Dependency Inversion Principle
Infra.Data
Tecnologias e Ferramentas:
Linguagem: C# (.NET Core)
Banco de Dados: SQL Server
Ambiente: Azure App Services
IDE: Visual Studio / VS Code
ORM: Entity Framework Core
Testes: xUnit ou NUnit (conforme usado)
Controle de Versão: Git + GitHub
Como Rodar o Projeto:
1. Faça um clone do repositório atual 
2. Abrir o programa no qual você executa 
3. Verificar a conexão no app settings.json
4. Executar Update-Database
5. Executar a aplicação 
6. Realização de testes
Testes Automatizados:
Quais camadas possuem testes: Application
Como executar os testes: Abra a solução no Visual Studio. Navegue até o Test Explorer (Menu: Test > Test Explorer). Clique em Run All para executar todos os testes. Para um teste específico, clique com o botão direito no teste e selecione Run
Ferramentas usadas: xUnit
Qual cobertura foi priorizada: regras de negócio
Estrutura de Pastas:
HelpApp/ ├── Domain/ │ └── Entities/ │   └── Interfaces/ ├── Application/ │   └── UseCases/ ├── Infrastructure/ │   └── Data/ │   └── Services/ ├── Interfaces/ │   └── Controllers/ ├── Tests/ └── Program.cs
Autores:
Luana de Brito quintal Báthory: front-end
William Correia: back-end
Victor Matos: documentação 
Luiz Gustavo: modelagem de banco de dados 
Victor Santos: testes
Licença: uso acadêmico
