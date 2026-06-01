# LojinhaDevoNada

Sistema de gerenciamento de clientes e dívidas desenvolvido em C#, Windows Forms, Entity Framework Core e PostgreSQL.

## Tecnologias Utilizadas

- C#
- .NET
- Windows Forms
- Entity Framework Core
- PostgreSQL
- Npgsql
- LINQ
- Git
- GitHub

---

## Estrutura do Projeto

### Models

#### Clientes

Representa os clientes cadastrados no sistema.

Atributos:

- Id
- Nome
- Email
- Cpf
- Data_nasc

#### Dividas

Representa as dívidas cadastradas.

Atributos:

- Id
- Valor
- Status
- Data_criacao
- Data_pagamento
- ClienteId

---

## Relacionamento

Um cliente pode possuir apenas uma dívida.

```text
Cliente 1 ----- 1 Dívida
```

---

## Serviços

### ClientesService

Responsável pelas regras de negócio dos clientes.

Métodos:

- Criar()
- Atualizar()
- Deletar()
- Buscar()
- Listar()
- Pesquisa()
- TotalDividas()

Validações:

- CPF único
- Cliente maior de 18 anos
- Campos obrigatórios

---

### DividasService

Responsável pelas regras de negócio das dívidas.

Métodos:

- Criar()
- Atualizar()
- Deletar()
- Buscar()
- Listar()
- Pesquisa()
- TotalRegistros()

Validações:

- Valor maior que zero
- Cliente existente
- Apenas uma dívida por cliente

---

## Entity Framework Core

Recursos utilizados:

### DbContext

Gerenciamento da conexão com o banco.

### Include

Carregamento de relacionamentos.

Exemplo:

```csharp
_context.Dividas
    .Include(d => d.Cliente)
```

### FirstOrDefault

Busca de registros.

### Any

Verificação de existência.

### Count

Contagem de registros.

### SaveChanges

Persistência dos dados.

---

## LINQ Utilizado

### Where

Filtragem de dados.

### OrderBy

Ordenação crescente.

### OrderByDescending

Ordenação decrescente.

### Any

Verificação de existência.

### Count

Contagem de registros.

### Sum

Somatório de valores.

### Skip

Paginação.

### Take

Limitação de registros.

---

## Funcionalidades

### Clientes

- Cadastro
- Atualização
- Exclusão
- Pesquisa
- Paginação
- Validação de CPF
- Validação de idade

### Dívidas

- Cadastro
- Atualização
- Exclusão
- Pesquisa
- Paginação
- Controle de pagamento
- Associação com cliente

---

## Paginação

O sistema exibe 10 registros por página.

Métodos utilizados:

- Skip()
- Take()

---

## Banco de Dados

SGBD utilizado:

- PostgreSQL

Provedor:

- Npgsql

ORM:

- Entity Framework Core

---

## Controle de Versão

Ferramentas:

- Git
- GitHub

Comandos utilizados durante o desenvolvimento:

```bash
git init
git add .
git commit -m "mensagem"
git push
git pull
git branch
git checkout
```

---

## Conceitos Aplicados

- Programação Orientada a Objetos (POO)
- Encapsulamento
- Classes e Objetos
- Relacionamentos entre entidades
- CRUD
- LINQ
- Entity Framework Core
- Paginação
- Validações
- Arquitetura em Camadas
- Persistência de Dados

---

## Autor

Projeto desenvolvido por Antony M. N. Pereira e Rafael W. B. Alves para fins acadêmicos e aprendizado de:

- C#
- Windows Forms
- PostgreSQL
- Entity Framework Core
- Git e GitHub
- Programação Orientada a Objetos
