# Design Patterns em C# e .NET

> Uma jornada prática pelo universo dos Design Patterns, explorando não apenas suas implementações, mas também o contexto, a motivação, as alternativas e a evolução das soluções.

---

# Sobre o projeto

Este repositório reúne implementações práticas dos **Design Patterns** do *Gang of Four (GoF)* utilizando **C#** e **.NET**.

Mais do que apresentar código, o objetivo é compreender o problema que levou ao surgimento de cada Pattern, analisar diferentes abordagens para solucioná-lo e construir a implementação de forma evolutiva.

Sempre que possível, cada exemplo partirá de uma solução simples, passando por refatorações sucessivas até chegar à aplicação do Pattern e, posteriormente, à sua utilização em cenários mais próximos do desenvolvimento moderno em .NET.

Este projeto parte do princípio de que um **Design Pattern** não representa um objetivo em si, mas uma ferramenta para construir software mais organizado, extensível e de fácil manutenção.

---

# Objetivos

Este repositório foi criado com os seguintes objetivos:

- Estudar os Design Patterns do GoF de forma prática.
- Compreender o problema antes da solução.
- Apresentar diferentes formas de resolver um mesmo cenário.
- Explorar recursos modernos da plataforma .NET.
- Registrar decisões arquiteturais durante a evolução do projeto.
- Servir como material de consulta e aprendizado contínuo.

---

# Filosofia

Este projeto foi construído sobre alguns princípios simples.

- A compreensão do problema é mais importante do que conhecer o Pattern.
- A evolução da solução é mais importante do que apresentar apenas a versão final.
- Clareza vale mais do que abstrações prematuras.
- Cada decisão arquitetural deve possuir um contexto.
- Documentação faz parte da implementação.
- A coesão é mais importante do que eliminar duplicação prematuramente.
- Código é escrito para pessoas; o compilador é apenas o primeiro leitor.

Como Martin Fowler escreveu:

> *"Any fool can write code that a computer can understand. Good programmers write code that humans can understand."*

Essa ideia resume um dos principais objetivos deste repositório: produzir exemplos claros, bem organizados e fáceis de compreender, priorizando a leitura e o entendimento do código tanto quanto sua correta execução.

---

# Organização do repositório

```text
.
├── docs/
│   └── adr/
│
├── src/
│   ├── Creational/
│   ├── Structural/
│   └── Behavioral/
│
└── tests/
```

Cada categoria conterá seus respectivos **Design Patterns**.

Cada Pattern será organizado como um módulo independente, contendo sua própria documentação, exemplos e recursos compartilhados quando necessário.

---

# Estrutura de um Design Pattern

A organização abaixo representa a convenção adotada pelo projeto.

```text
FactoryMethod/

├── FactoryMethod.csproj
├── README.md
├── Shared/
├── 00-Before/
├── 01-GoF/
├── 02-Refactoring/
├── 03-DependencyInjection/
├── 04-AspNetCore/
└── ...
```

A sequência apresentada é apenas uma referência.

Cada Pattern poderá evoluir de maneira diferente, respeitando suas características e necessidades.

---

# Jornada de aprendizagem

Sempre que fizer sentido, os exemplos seguirão uma evolução semelhante à apresentada abaixo.

```text
00-Before
      │
      ▼
01-GoF
      │
      ▼
02-Refactoring
      │
      ▼
03-Dependency Injection
      │
      ▼
04-ASP.NET Core
      │
      ▼
...
```

O objetivo não é apenas mostrar **como** implementar um Pattern, mas compreender **por que** ele surge naturalmente durante a evolução do código.

---

# Design Patterns

## Creational

| Pattern | Status |
|----------|:------:|
| Singleton | ⏳ |
| Factory Method | ⏳ |
| Abstract Factory | ⏳ |
| Builder | ⏳ |
| Prototype | ⏳ |

---

## Structural

| Pattern | Status |
|----------|:------:|
| Adapter | ⏳ |
| Bridge | ⏳ |
| Composite | ⏳ |
| Decorator | ⏳ |
| Facade | ⏳ |
| Flyweight | ⏳ |
| Proxy | ⏳ |

---

## Behavioral

| Pattern | Status |
|----------|:------:|
| Chain of Responsibility | ⏳ |
| Command | ⏳ |
| Interpreter | ⏳ |
| Iterator | ⏳ |
| Mediator | ⏳ |
| Memento | ⏳ |
| Observer | ⏳ |
| State | ⏳ |
| Strategy | ⏳ |
| Template Method | ⏳ |
| Visitor | ⏳ |

---

# Tecnologias

- .NET 10
- C#
- xUnit *(quando aplicável)*
- Git
- GitHub
- JetBrains Rider

---

# Convenções adotadas

Este projeto procura manter consistência em sua organização.

Entre as convenções adotadas estão:

- Conventional Commits.
- Um projeto por Design Pattern.
- Documentação própria para cada Pattern.
- Exemplos organizados em ordem evolutiva.
- Utilização de *Architecture Decision Records (ADR)* para registrar decisões arquiteturais.

---

# Architecture Decision Records (ADR)

As principais decisões arquiteturais são registradas na pasta:

```text
docs/adr/
```

As ADRs documentam não apenas a decisão adotada, mas também o contexto, as alternativas avaliadas, os trade-offs considerados e a evolução do raciocínio ao longo do projeto.

---

# Roadmap

## Estrutura do projeto

- [x] Arquitetura inicial
- [x] Organização do repositório
- [x] ADR-0001
- [x] README inicial

## Design Patterns

- [ ] Creational
- [ ] Structural
- [ ] Behavioral

---

## Antes de começar

Se este é o seu primeiro contato com o projeto, recomendamos a leitura de:

- `docs/fundamentals.md`

# Licença

Este projeto está licenciado sob a licença **MIT**.

Consulte o arquivo `LICENSE` para mais informações.