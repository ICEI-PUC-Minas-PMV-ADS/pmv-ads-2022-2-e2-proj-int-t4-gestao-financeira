# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Nesta seção são apresentados os detalhes técnicos da solução criada pela equipe, tratando dos componentes que fazem parte da solução e do ambiente de hospedagem da solução.

### Diagrama de Componentes

![componentes](https://user-images.githubusercontent.com/103227669/198908242-5d5c3521-84c9-40b2-990c-292338817a89.png)

A solução implementada conta com os seguintes módulos:
- Navegador - Interface básica do sistema 
- Páginas Web - Conjunto de arquivos HTML, CSS, JavaScript e imagens que implementam as funcionalidades do sistema.
- Hospedagem - local na Internet onde as páginas são mantidas e acessadas pelo navegador. 
Hospedagem
O site utiliza a plataforma do Heroku como ambiente de hospedagem do site do projeto. O site é mantido no ambiente da URL: 
https://link_exemplo.herokuapp.com 
A publicação do site no Heroku é feita por meio de uma submissão do projeto (push) via git para o repositório remoto.

### Diagrama de Caso de Uso

> - [Diagrama de Caso de Uso](img/DiagramaCasoDeUso.jpg "Figura 9: Diagrama de Caso de Uso")

### Modelagem de Dados

> - [Modelagem de dados](img/modeloBancoDados.jpeg)
### Diagrama de Classes

Os componentes que fazem parte da solução são apresentados na Figura que se segue.

> - [Diagramas de Classes](img/modeloClasses.jpeg)

### Modelo de Entidade e Relacionamento (Projeto Conceitual)

O Modelo ER representa através de um diagrama como as entidades se relacionam entre si na aplicação interativa.

- [Modelo de entidade e relacionamento](img/modeloEntidadeRelacionamento.jpeg)

