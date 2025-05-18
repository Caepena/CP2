# CP2 - Sistema de Gestão de Motos e Garagens

Este é um projeto em .NET 8 que implementa uma API RESTful para gerenciamento de motos e garagens. Utiliza Entity Framework Core com banco Oracle, estruturado em camadas e baseado em boas práticas de desenvolvimento orientado a objetos.

---

## 📁 Estrutura do Projeto

```
CP2/
├── Controllers/                      # Controladores HTTP
│   ├── MotoController.cs
│   └── GaragemController.cs
├── Domain/
│   ├── Entity/                      # Entidades: Moto, Garagem
│   └── Enums/                       # Enumeração de status da moto
├── Infrastructure/
│   ├── Context/                     # DbContext (MottuContext)
│   ├── Mappings/                    # Mapeamento EF
│   └── Persistence/Repositories/    # Repositórios e interfaces
├── Migrations/                      # Migrações EF Core
├── appsettings.json                 # Configurações da aplicação
├── Program.cs                       # Entry point da aplicação
└── CP2.csproj                       # Projeto .NET
```

---

## 📡 Rotas Disponíveis

### 🚗 MotoController

- `GET /moto` – Listar todas as motos
- `GET /moto/{id}` – Buscar moto por ID
- `POST /moto` – Cadastrar nova moto
- `PUT /moto/{id}` – Atualizar moto
- `DELETE /moto/{id}` – Remover moto

### 🏢 GaragemController

- `GET /garagem` – Listar todas as garagens
- `GET /garagem/{id}` – Buscar garagem por ID
- `POST /garagem` – Cadastrar nova garagem
- `PUT /garagem/{id}` – Atualizar garagem
- `DELETE /garagem/{id}` – Remover garagem

---

## 🧰 Tecnologias Utilizadas

- .NET 8
- ASP.NET Core
- Entity Framework Core
- Oracle Database
- RESTful API

---

## 🚀 Como Executar o Projeto

1. **Clone o repositório:**
   ```bash
   git clone <link-do-repositorio>
   cd CP2/CP2
   ```

2. **Restaure os pacotes e compile:**
   ```bash
   dotnet restore
   dotnet build
   ```

3. **Atualize a string de conexão com o Oracle** no arquivo `appsettings.json`.

4. **Rode a aplicação:**
   ```bash
   dotnet run
   ```

5. **Acesse via navegador ou Postman:**
   ```
   https://localhost:5001/swagger
   ```

---

## 📌 Funcionalidades

- ✅ Cadastro e listagem de garagens
- ✅ Cadastro e controle de motos
- ✅ Associação entre motos e garagens
- ✅ Persistência em banco relacional com EF Core

---

## 👥 Integrantes

- Caetano Penafiel Matos – RM557984  
- Kauã Fermino Zipf – RM558957  
- Victor Egídio Lira – RM556653  

---


## 🔍 Observações

A string de conexão com o banco Oracle foi definida diretamente no arquivo `appsettings.json`.  
Essa abordagem foi adotada porque, se usassemos o arquivo .env teriamos que mandar esse arquivo por fora e nós não saberiamos fazer isso, senão sendo inserido pelo Github.
