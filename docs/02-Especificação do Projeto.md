# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

## Personas

![PersonaDalva](https://user-images.githubusercontent.com/103227669/198908044-5a782310-8d6b-42b0-b8dd-c303c16f8662.jpg)

![PersonaPaulo](https://user-images.githubusercontent.com/103227669/198908064-2b09af34-f873-4c03-beda-d0d9003e32c7.jpg)

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Paulo de Abreu      |Definir minhas despesas de curto e longo prazo   | Para manter controle dos gastos. |
|Paulo de Abreu      |Manter uma reserva de emergência  | Para imprevistos. |
|Paulo de Abreu      |Caixa extra | Para adquirir uma moto nova |
|Dalva Maria    |Registrar movimentações financeiras | Para ter controle dos meus gastos |
|Dalva Maria     |Definir metas e objetivos | Para ampliar meus negócios. |
|Dalva Maria     |Gráficos que apontem seu percentual de crescimento | Para visualizar novas metas |

## Requisitos

O sistema deve, principalmente, mostrar as movimentações financeiras. Uma aba específica para registro de todas as movimentações financeiras com campos específicos informando objetivos, planejamento e saldo de reserva de emergência. Caso o usuário trabalhe com outras moedas o sistema informará a cotação das principais moedas mundiais através de um botão de redirecionamento.  Desse modo é possível deixar claro para o usuário como ele deve se organizar financeiramente.

### Requisitos Funcionais

A tabela a seguir apresenta os requisitos do projeto, identificando a prioridade em que os mesmos devem ser entregues.

| ID    | Descrição do Requisito                              | Prioridade |
|-------|-----------------------------------------------------|------------|
|RF-01 | Menu fixo           |    Baixa    | 
|RF-02 | O usuário poderá fazer cadastro para login no sistema.               |    Alta   |
|RF-03 |O usuário consegue visualizar o registro de movimentações.              |    Alta   |
|RF-03 |O usuário consegue visualizar o registro de movimentações.              |    Alta   |
|RF-04 |O usuário poderá cadastrar suas movimentações financeiras.              |    Alta   |
|RF-05 |O usuário poderá criar objetivos financeiros.              |    Média   |
|RF-06 |O sistema apresenta o progresso dos seus objetivos financeiros.              |    Média   |
|RF-07 |O usuário poderá planejar compras              |    Baixa   |
|RF-08 |O usuário planejará uma reserva de emergência.              |    Baixa   |
|RF-09 |O usuário registrará o saldo da sua reserva de emergência.              |    Baixa   |
|RF-10 |Botão de cotação de moedas.             |    Baixa   |

### Requisitos não Funcionais

A tabela a seguir apresenta os requisitos não funcionais que o projeto deverá atender.

|ID     | Descrição do Requisito                              | Prioridade |
|-------|-----------------------------------------------------|------------|
|RNF-01| O sistema deve estar disponível pelo menos 90% das 24 horas do dia, nos 7 dias da semana.      |  Alta     |
|RNF-02|O login do usuário deve demorar no máximo 6 segundos.|    Média   | 
|RNF-03|O sistema deve ser implementado na linguagem JavaScript.|    Baixa   | 
|RNF-04|Os dados cadastrais do cliente devem estar disponíveis apenas para ele mesmo.|    Alta   | 
|RNF-05|Os dados financeiros inseridos pelo cliente no sistema devem estar disponíveis apenas para ele mesmo.|    Alta   | 


## Restrições

As questões que limitam a execução desse projeto e que se configuram como obrigações claras para o desenvolvimento do projeto em questão são apresentadas na tabela a seguir.

|ID| Restrição                                                      |
|--|----------------------------------------------------------------|
|RE-01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 11/12/2022.        |
|RE-02| O front-end do sistema deve ser escrito em html, CSS e JavaScript, sem o uso de frameworks.     |


## Diagrama de Casos de Uso

- [Clique aqui](docs\img\DiagramaCasoDeUso.jpg) para visualizar o diagrama de casos de uso.
