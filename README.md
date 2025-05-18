
# CP2 - Sistema de Gestão de Motos e Garagens

Este é um projeto em .NET 8 que implementa um sistema de gerenciamento de motos e garagens utilizando Entity Framework Core, arquitetura em camadas e banco de dados relacional.

## 📁 Estrutura do Projeto

```
CP2/
├── CP2/
│   ├── Controllers/              # Lida com requisições HTTP
│   │   ├── MotoController.cs
│   │   └── GaragemController.cs
│   ├── Domain/
│   │   ├── Entity/              # Entidades do domínio (Moto, Garagem)
│   │   └── Enums/               # Enumeração de StatusMoto
│   ├── Infrastructure/
│   │   ├── Context/             # DbContext (MottuContext)
│   │   ├── Mappings/            # Mapeamentos Entity Framework
│   │   └── Persistence/Repositories/ # Interface e implementação genérica de repositório
│   ├── Migrations/              # Migrações geradas pelo EF Core
│   ├── appsettings.json         # Configurações da aplicação
│   ├── Program.cs               # Ponto de entrada da aplicação
│   └── CP2.csproj               # Arquivo de projeto .NET
```

## 🧰 Tecnologias Utilizadas

- [.NET 8](https://dotnet.microsoft.com/en-us/download)
- ASP.NET Core
- Entity Framework Core
- SQLite ou outro provedor relacional
- RESTful API

## 🚀 Como executar o projeto

1. **Clone o repositório:**

   ```bash
   git clone <link-do-repositório>
   cd CP2/CP2
   ```

2. **Restaure os pacotes e compile:**

   ```bash
   dotnet restore
   dotnet build
   ```

3. **Aplique as migrações no banco de dados:**

   ```bash
   dotnet ef database update
   ```

4. **Execute a aplicação:**

   ```bash
   dotnet run
   ```

5. Acesse via navegador ou ferramentas como Postman: `https://localhost:5001/swagger` (caso Swagger esteja configurado).

## 📌 Funcionalidades

- Cadastro e listagem de garagens
- Cadastro, listagem e controle de status das motos
- Relacionamento entre motos e garagens
- Persistência em banco de dados com EF Core

## 📄 Licença

Este projeto é acadêmico e pode ser utilizado como base para estudos.


## 🔍 Observações

A string de conexão com o banco Oracle foi definida diretamente no arquivo `appsettings.json`.  
Essa abordagem foi adotada porque, se usassemos o arquivo .env teriamos que mandar esse arquivo por fora e nós não saberiamos fazer isso, senão sendo inserido pelo Github.
