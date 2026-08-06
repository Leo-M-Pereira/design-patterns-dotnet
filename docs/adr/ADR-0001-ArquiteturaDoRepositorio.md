# ADR-0001 - Arquitetura do Repositório

## Status

Aceita.

---

## Contexto

Este projeto foi criado com o objetivo de estudar e documentar os Design Patterns utilizando C# e .NET.

Desde o início, buscou-se uma organização que favorecesse a evolução incremental do conteúdo, permitindo que novos exemplos fossem adicionados sem impactar a estrutura existente.

Também era desejável que cada Design Pattern pudesse evoluir de forma independente, mantendo alta coesão e baixo acoplamento entre os exemplos.

---

## Decisão

O repositório será organizado por categoria de Design Pattern (Creational, Structural e Behavioral).

Cada Design Pattern possuirá um único projeto, contendo todos os seus exemplos de implementação.

Os exemplos serão organizados em subpastas, representando diferentes etapas da evolução da solução ou diferentes abordagens para o mesmo problema.

Exemplo:

```text
src/
└── Creational/
    └── FactoryMethod/
        ├── FactoryMethod.csproj
        ├── README.md
        ├── Shared/
        ├── 00-Before/
        ├── 01-GoF/
        ├── 02-Refactoring/
        ├── 03-DependencyInjection/
        └── ...
```

A estrutura dos exemplos poderá variar conforme as características de cada Pattern.

---

## Justificativa

Esta organização foi escolhida por proporcionar:

- Alta coesão entre os exemplos de um mesmo Pattern;
- Facilidade para estudar diferentes abordagens em um único projeto;
- Simplicidade de navegação;
- Liberdade para evolução incremental;
- Isolamento entre os Patterns.

Além disso, manter apenas um projeto por Pattern reduz a quantidade de projetos da solução, tornando sua manutenção mais simples.

---

## Trade-offs

A decisão implica alguns trade-offs conhecidos.

- Todos os exemplos de um Pattern são compilados em conjunto.
- Pode existir duplicação intencional entre Patterns.
- A pasta `Shared` é restrita ao próprio Pattern, mesmo que existam elementos semelhantes em outros.

Esses trade-offs foram considerados aceitáveis diante do propósito educacional do projeto.

---

## Consequências

A estrutura adotada facilita a inclusão de novos exemplos sem necessidade de reorganizar o repositório.

Também permite que cada Pattern evolua de forma independente, acompanhando novos recursos da plataforma .NET e diferentes estilos de implementação.

Caso a experiência prática demonstre uma abordagem superior, esta decisão poderá ser revisada por meio de uma nova ADR.

---

## Alternativas consideradas

Durante o planejamento foram avaliadas outras possibilidades, entre elas:

- Um projeto para cada exemplo;
- Compartilhamento global de código entre Patterns;
- Organização baseada apenas em tecnologias ou frameworks.

Embora essas alternativas apresentem vantagens em determinados cenários, optou-se por uma organização centrada em cada Design Pattern, priorizando a experiência de estudo e a evolução do conteúdo.