# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

## Personas

Paulo de Abreu tem 22 anos, é entregador de Delivery e pensa em adquirir uma moto nova, pois adora andar de moto e realizar trilhas. Quando Paulo completou 18 anos fez o financiamento de uma moto, mas devido a uma demissão sem aviso prévio não conseguiu pagar suas dívidas e por isso acumulou juros até que seu nome foi parar no Serasa. Agora Paulo busca uma forma de organizar melhor suas finanças para assim poder quitar suas dividas e realizar seu sonho.

Dalva Maria tem 46 anos, é Confeiteira e pensa em abrir uma loja no centro de sua cidade. Depois de ter um problema com seu antigo chefe decidiu sair da empresa e dedicar-se em tempo integral à confeitaria, mas infelizmente Dalva não possui verba para inovação, cursos de aperfeiçoamento e expansão dos seus negócios. Por conta disso, Dalva está buscando uma forma de fazer uma melhor gestão da sua renda para quem sabe, com um pouco de planejamento, poder realizar seu sonho de ter sua própria confeitaria.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Paulo de Abreu      |Definir suas despesas de curto e longo prazo   | Para manter controle dos gastos. |
|Paulo de Abreu      |Manter uma reserva de emergência  | Para imprevistos. |
|Paulo de Abreu      |Caixa extra | Para adquirir uma moto nova |
|Dalva Maria    |Registrar movimentações financeiras | Para ter controle dos seus gastos |
|Dalva Maria     |Definir metas e objetivos | Para ampliar seus negócios. |
|Dalva Maria     |Gráficos que apontem seu percentual de crescimento | Para visualizar novas metas |

## Requisitos

O sistema deve, principalmente, criar um gráfico pizza e mostrar os fluxos de gastos do dinheiro. Uma aba específica para registro de todas as movimentações financeiras com campos específicos informando objetivos, planejamento e saldo de reserva de emergência. Caso o usuário trabalhe com outras moedas o sistema informará a cotação das principais moedas mundiais através de um botão de redirecionamento.  Desse modo é possível deixar claro para o usuário como ele deve se organizar financeiramente.

### Requisitos Funcionais

O sistema será formado por abas, sendo elas: homepage; registro de movimentações; objetivos financeiros; planejamento de compras; saldo de reserva de emergência e um botão para a cotação das principais moedas.

| ID    | Descrição do Requisito                              | Prioridade |
|-------|-----------------------------------------------------|------------|
|RF-001 | Menu fixo           |    MÉDIA    | 
|RF-002 | Abas: Registro de movimentações               |    ALTA   |
|RF-002 |Botão de cotação de moedas             |    MÉDIA   |

### Requisitos não Funcionais

|ID     | Descrição do Requisito                              | Prioridade |
|-------|-----------------------------------------------------|------------|
|RNF-001| A velocidade do sistema dependerá do hardware, e da velocidade de navegação do usuário;      |  MÉDIA     |
|RNF-002|A facilidade de uso pode ser medida pelo número de janelas ou o tempo de treino do usuário|    BAIXA   | 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                                      |
|--|----------------------------------------------------------------|
|01| Servidor para o sistema          |

Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

## Diagrama de Casos de Uso

- [Clique aqui](./img/diagramaCasosDeUso.png) para visualizar o diagrama de casos de uso.
