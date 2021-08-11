# Softplan.TechnicalChallenge
Softplan.TechnicalChallenge
A Solução criada com o nome "Softplan.TechnicalChallenge" contêm 3 projetos, sendo:
1 - Application: camada de aplicação, responsável pelo projeto principal, pois é onde será desenvolvido os controladores e serviços da API. Tem a função de receber todas as requisições e direcioná-las a algum serviço para executar uma determinada ação.
Possui referência da camadas Business.
Possui dependência: Microsoft.AspNetCore.Mvc.Versioning e Swashbuckle.AspNetCore (Swagger).

2 - Business: seria o “coração” do projeto, pois é nela que é feita todas as regras de negócio e todas as validações.

3 - Test: projeto responsável por realizar testes automatizados na api, especificamente nos 3 métodos utilizados pela API.
Possui referência da camadas Business.
Possui dependência: Microsoft.NET.Test.Sdk, Moq, xunit, xunit.extensibility, xunit.runner.visualstudio
