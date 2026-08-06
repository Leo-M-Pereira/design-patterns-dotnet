# Factory Method

> *Understanding the problem is the first step toward understanding the pattern.*

---

# Introdução

O Factory Method é um dos padrões criacionais definidos pelo Gang of Four (GoF).

Seu propósito é desacoplar o processo de criação de objetos do código que os consome, permitindo que novas implementações sejam introduzidas com menor impacto sobre os consumidores.

Mais do que uma técnica para instanciar objetos, o Factory Method representa uma mudança na forma de projetar software: o foco deixa de estar na criação de implementações concretas e passa para a abstração do processo de criação.

---

# Motivação

Todo Design Pattern surge para resolver um problema recorrente.

Antes de estudar a implementação do Factory Method, é importante compreender quais dificuldades motivaram sua criação.

Ao longo deste diretório, veremos como uma solução inicialmente simples pode tornar-se rígida, difícil de manter e pouco extensível à medida que novas regras de negócio são incorporadas.

O Factory Method surge como uma resposta para esse cenário.

---

# Objetivos

- Compreender o problema que motivou o Pattern.
- Identificar situações em que sua aplicação é apropriada.
- Implementar a solução clássica proposta pelo GoF.
- Reconhecer variações modernas utilizadas em aplicações .NET.
- Avaliar os trade-offs envolvidos em sua utilização.

---

# Estrutura deste diretório

| Diretório | Objetivo |
|-----------|----------|
| **00-Before** | Apresenta uma implementação inicial, semelhante ao que normalmente encontramos em projetos reais, evidenciando as limitações que motivam a adoção do Pattern. |
| **01-GoF** | Implementação clássica descrita pelo Gang of Four. |
| **02-Console** | Aplicação do Pattern em um projeto Console. |
| **03-DI** | Evolução utilizando Injeção de Dependência. |
| **04-AspNetCore** | Aplicação em um cenário ASP.NET Core. |
| **05-RealWorld** | Exemplo inspirado em um cenário próximo ao encontrado em projetos reais. |
| **Shared** | Objetos compartilhados entre os exemplos deste Pattern. |

---

# Fluxo recomendado de estudo

Os exemplos foram organizados para serem estudados em sequência.

Embora seja possível acessar diretamente qualquer implementação, recomenda-se seguir a ordem proposta.

Cada etapa representa uma evolução da solução, permitindo compreender não apenas como o Pattern funciona, mas principalmente por que ele existe.

A sequência sugerida é:

1. Compreender o problema.
2. Identificar as limitações da solução inicial.
3. Estudar a proposta do GoF.
4. Explorar implementações modernas.
5. Avaliar vantagens, limitações e trade-offs.

---

# O que este material não pretende

Este diretório não tem como objetivo apresentar o Factory Method como uma solução universal.

Nem todo problema exige um Design Pattern.

Ao longo dos exemplos serão discutidos os custos introduzidos pelo Pattern, os cenários em que sua utilização agrega valor e aqueles em que uma solução mais simples continua sendo a melhor escolha.

---

# Pré-requisitos

Recomenda-se conhecimento básico sobre:

- C#
- Programação Orientada a Objetos
- Interfaces
- Herança
- Polimorfismo

Não é necessário conhecimento prévio sobre Design Patterns.

---

# Referências

## Livros

- Gamma, Erich; Helm, Richard; Johnson, Ralph; Vlissides, John. *Design Patterns: Elements of Reusable Object-Oriented Software.*

## Documentação

- Microsoft Learn
- Documentação oficial do .NET

---

# Comece por aqui

Inicie pelo diretório **00-Before**.

Antes de estudar qualquer implementação, procure compreender o problema que motivou o surgimento do Factory Method.

Quando o problema é compreendido, a solução deixa de parecer uma técnica e passa a ser uma consequência natural do processo de evolução do software.

---

> *Understanding the problem is the first step toward understanding the pattern.*

> *The goal is not to memorize the pattern, but to understand the problem that led to its creation.*