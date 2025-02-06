Desafio Final - Bootcamp: Arquiteto(a) de Software
============

Este projeto tem como objetivo a criação de uma API RESTful seguindo o padrão arquitetural MVC, com funcionalidades de CRUD para Produtos. O desenvolvimento foca em boas práticas de arquitetura de software, design patterns e modelagem arquitetural.

---
## Tecnologias Utilizadas

- **Linguagem:** C#
- **Framework:** .NET 8
- **Banco de Dados:** MySQL
- **Padrão Arquitetural:** MVC
---

## Funcionalidades da API
- **CRUD (Create, Read, Update, Delete)**
- **Count**: Retornar o número total de registros
- **Find All**: Retornar todos os registros
- **Find By ID**: Buscar um registro por ID
- **Find By Name**: Retornar registros pelo nome

---
## Estrutura do Projeto (MVC)
```
|-- src/
    |-- controllers/  # Controlador REST
    |-- models/       # Modelos de dados
    |-- repository/   # Repositórios para interação com o banco de dados
    |-- services/     # Lógica de negócios
```
