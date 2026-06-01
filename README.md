# Devo Nada

> Sistema CRUD desenvolvido em **C#** com integração ao **PostgreSQL** para gerenciamento de clientes e dividas.

<h3>About project</h3>
<p>Devo Nada é um projeto acadêmico criado com foco em aprendizado e prática de desenvolvimento back-end utilizando:</p>

- C#
- Windowns Forms
- PostgreSQL
- SQL
- Git/GitHub

<p>O sistema permite cadastrar clientes e controlar dividas de forma simples e organizada.</p>

<h3>Features</h3>

- Cadastro de Clientes
- Edição e Remoção de clientes
- Cadastro de Dividas
- Controle de status de pagamento
- Integração com banco PostgreSQL
- Interface desktop em Windows Forms
- Persistência de dados

<h3>Technologies</h3>

- **C#**
- **.NET**
- **Windowns Forms**
- **PostgreSQL**
- **Git**


<h3>▶ Run Project</h3>

**Clone o repositório**

```bash

  git clone https://github.com/AntonyCode101/LojinhaDevoNada.git

```

**Configure a conexão com o banco de dados**

[Como configurar a conexão](#configuração-do-banco-de-dados)

**Entre na pasta do projeto**

```bash

  cd LojinhaDevoNada

```

**Execute o projeto**

```bash

  dotnet run

```

## Configuração do Banco de dados

<details>
<summary>⚙ Configuração</summary>

> Instale o [PostgreSQL](https://www.postgresql.org/download/)

**Crie o Banco:**
```sql

  CREATE DATABASE db_devonada;
```

**Execute as tabelas:**

```sql
  CREATE TABLE clientes (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(150) NOT NULL,
    cpf VARCHAR(11) UNIQUE NOT NULL,
    data_nasc DATE NOT NULL,
    email VARCHAR(150) UNIQUE NOT NULL
  );

  CREATE TABLE dividas (
    id SERIAL PRIMARY KEY,
    cliente_id INT NOT NULL,
    valor NUMERIC(10, 2) NOT NULL,
    status BOOLEAN NOT NULL,
    data_criacao TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    data_pagamento DATE,
    CONSTRAINT fk_cliente
      FOREIGN KEY (cliente_id)
      REFERENCES clientes(id) ON DELETE CASCADE
  );
```

**Configure a string de conexão do arquivo *Program.cs*:**

```csharp
  Environment.SetEnvironmentVariable(
    "ConnectionStrings__DefaultConnection",
    "Host=localhost;" +
    "Port=5432;" +
    "Database=db_devonada;" +
    "Username=postgres;" +
    "Password=senha_usada_no_seu_postgresql"
  );
```

Pronto!

Banco configurado com sucesso!
</details>

## 👥 Contribuição e Desenvolvimento
Desenvolvido como projeto acadêmico por:
* **Antony Miguel Nogueira Pereira** - *Desenvolvedor* - [GitHub](https://github.com/AntonyCode101)
* **Rafael Willian Braga Alves** - *Desenvolvedor* - [GitHub](https://github.com/WillianBoy)



  
