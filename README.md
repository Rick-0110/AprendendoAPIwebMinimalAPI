# AprendendoAPIweb: Minimal API - To Do List (Dados em Memória)

[![.NET](https://img.shields.io/badge/.NET-8-blue.svg)](https://dotnet.microsoft.com/download/dotnet/8.0)
[![Status](https://img.shields.io/badge/Status-Funcional-brightgreen.svg)]()

Este projeto é um Back-end de lista de tarefas desenvolvido com **ASP.NET Core Minimal APIs**.

O foco é a arquitetura de serviços: rotas em **Endpoints** e lógica de negócios em **Services**. O armazenamento é feito em **memória RAM**.

## 🚀 Tecnologias Essenciais

* **Framework:** .NET 8
* **Padrão:** Minimal APIs
* **Documentação:** Swagger/OpenAPI
* **Arquitetura:** Injeção de Dependência (`ITodoService`)

## 🏗 Estrutura do Projeto

* **`Endpoints/`:** Define as rotas HTTP e a chamada dos serviços.
* **`Services/`:** Contém a lógica de negócios e o repositório em memória.
* **`Models/`:** Contém o Model da aplicação .

## ⚙️ Como Rodar o Projeto

### Pré-requisitos

1.  [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Passos de Execução

1.  **Clone o Repositório:**
    ```bash
    git clone https://github.com/Rick-0110/AprendendoAPIwebMinimalAPI
    ```
2.  **Rode a Aplicação:**
    ```bash
    dotnet run
    ```

## 📚 Teste (Swagger)

A documentação interativa para testar os *endpoints* (`GET` e `POST`) estará disponível em:

👉 **`localhost:7123/swagger`**

---

## Próximos Passos

1.  Integrar **Entity Framework Core (EF Core)** para persistência de dados.
2.  Implementar os métodos **PUT** e **DELETE** (CRUD completo).
