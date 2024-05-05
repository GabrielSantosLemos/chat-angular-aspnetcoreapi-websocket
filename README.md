# chat-angular-aspnetcoreapi-websocket

Este projeto consiste em um frontend construído em Angular e um backend em ASP.NET Core API, utilizando WebSockets para comunicação em tempo real.

![](/app.png?raw=true)

## Funcionalidades Principais:

- **Conversação em Tempo Real**: O usuário envia uma mensagem para o servidor eo servidor retorna a mensagem como respota em tempo real.

## Tecnologias Utilizadas:

- **Frontend**: Web App Angular v16.2.0
- **Backend**: Web API ASP.NET Core .NET v7.0
- **Comunicação em Tempo Real**: WebSockets

## Estrutura do Projeto:

- `frontend/`: Contém o código-fonte do aplicativo frontend em Angular.
- `backend/`: Contém o código-fonte do aplicativo backend em ASP.NET Core API.
- `README.md`: Este arquivo, contendo informações sobre o projeto e sua estrutura.
- `.gitignore`: Arquivo de configuração do Git para ignorar arquivos e diretórios específicos.

## Como Executar:

1. Clone este repositório: `git clone https://github.com/GabrielSantosLemos/chat-angular-aspnetcoreapi-websocket.git`
2. Navegue até o diretório do frontend: `cd frontend/chat-webapp`
3. Instale as dependências: `npm install`
4. Inicie o servidor de desenvolvimento: `ng serve`
5. Navegue até [http://localhost:4200/](http://localhost:4200/) em seu navegador para visualizar o aplicativo frontend.
6. Para executar o backend, navegue até o diretório `backend/Chat.WebAPI` e inicie a aplicação conforme necessário.

## Contribuição:

Contribuições são bem-vindas! Se você encontrar bugs ou desejar propor melhorias, sinta-se à vontade para abrir uma issue ou enviar um pull request.

## Licença:

Este projeto é licenciado sob a Licença MIT.
