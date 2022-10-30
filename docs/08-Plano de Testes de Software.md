# Plano de Testes de Software e Usabilidade

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

 Os requisitos para realização dos testes de software são:
- Navegador da Internet: Chrome, Opera GX e Microsoft Edge.
- Conectividade de Internet para acesso às plataformas (APIs)
Os testes funcionais a serem realizados no aplicativo são descritos a seguir.

| **Caso de Teste** 	| **CT-01 – Funcionalidade da página “home”** 	|
|:---:	|:---:	|
|	Requisito Associado 	| Home |
| Objetivo do Teste 	| Verificar se o site carregou todas as aplicações |
| Passos 	| 1) Acessar o navegador; 2) Informar o endereço do site; 3) Visualizar a página home e rolar nas demais.
 |
|Critério de Êxito | •	Home ficar visível em toda a extensão da página; •	Quando utilizarmos determinado botão ele deve redirecionar para a parte correta da página.

 


| **Caso de Teste** 	| **CT-02 – Funcionamento da página “como funciona”** 	|
|:---:	|:---:	|
|	Requisito Associado 	| Como Funciona |
| Objetivo do Teste 	| Verificar se o se o vídeo explicativo carregou e se o passo a passo sobre o serviço carregou. |
| Passos 	| 1) Acessar o navegador; 2) Informar o endereço do site; 3) Visualizar a página quem somos; 4) Carregar e dar play no vídeo explicativo; 5) Carregar o passo a passo explicativo sobre o serviço.
 |
|Critério de Êxito | •	Usuário é redirecionado para uma página com vídeo e material explicativo
 |

 | **Caso de Teste** 	| **CT-03 – Funcionamento da página “quem somos”** 	|
|:---:	|:---:	|
|	Requisito Associado 	| Como Funciona  |
| Objetivo do Teste 	| Verificar se o material informativo sobre a empresa carregou |
| Passos 	| 1) Acessar o navegador; 2) Informar o endereço do site; 3) Visualizar a página quem somos com textos e imagens informativas. 
 |
|Critério de Êxito | •	Usuário é redirecionado para uma página com textos e imagens informativas sobre a empresa

 

 | **Caso de Teste** 	| **CT-04 – Funcionamento da página “ajuda”** 	|
|:---:	|:---:	|
|	Requisito Associado 	| Ajuda |
| Objetivo do Teste 	| Verificar se o formulário carregou e se todos os campos estão liberados para preenchimento |
| Passos 	| 1) Acessar o navegador; 2) Informar o endereço do site; 3) Visualizar a página ajuda e verificar se o formulário está apto para ser preenchido; 4) Preencher todos os dados solicitados; 5) Clicar em enviar; 6) Receber o formulário
 |
|Critério de Êxito | •	Usuário é redirecionado para uma página de ajuda onde tem um formulário para preencher com seus dados e sua dúvida; •	Área de suporte receber e responder a dúvida do formulário.

 

 | **Caso de Teste** 	| **CT-05 – Funcionamento da página “cadastro” (criar conta)** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-02 |
| Objetivo do Teste 	| Verificar se o cadastro carregou, se coletou todos os dados, salvou os dados, criou a conta e registrou login/senha e editar algum dado incorreto. |
| Passos 	| 1) Acessar o navegador; 2) Informar o endereço do site; 3) Clicar no botão criar conta; 4) Visualizar a página cadastro e verificar se o formulário está apto para ser preenchido; 5) Preencher todos os dados solicitados; 6) Criar login e senha;  7) Salvar todos os dados.
 |
|Critério de Êxito | •	Usuário é redirecionado para uma página de cadastro onde tem um formulário para preencher com seus dados pessoais •	Criar login e senha, salvar ou editar esses dados




 | **Caso de Teste** 	| **CT-06 – Funcionamento da página “login”** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-02 |
| Objetivo do Teste 	| Verificar se a página carregou, se o formulário de acesso está apto para colocar login/senha, se clicar entrar o usuário acessa a conta. |
| Passos 	| 1) Acessar o navegador; 2) Informar o endereço do site; 3) Visualizar a página login e verificar se o formulário está apto para ser preenchido; 4) Preencher dados de login/senha; 5) Clicar no botão entrar; 6) Acessar a conta.
 |
|Critério de Êxito | •	Usuário é redirecionado para uma página de login/senha onde tem um formulário para preencher com seus dados já cadastrados. •	Clicar no botão entrar e acessar sua conta de cliente


 

 | **Caso de Teste** 	| **CT-07 – Funcionamento da página “conta do cliente”** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-02 |
| Objetivo do Teste 	| Verificar se a página carregou, se todos os campos do formulário de dados pessoais estão disponíveis, salvar e editar os dados |
| Passos 	| 1) Acessar o navegador;     2) Informar o endereço do site; 3) Visualizar a página conta do cliente; 4) Preencher dados pessoais; 5) Salvar e editar os dados; 
 |
|Critério de Êxito | •	Usuário é redirecionado para uma página de conta do cliente onde ele pode alterar os dados pessoais. •	Clicar no botão salvar ou editar e o sistema salva os dados ou liberar edição para atualização de dados.


 

 | **Caso de Teste** 	| **CT-08 – Funcionamento da página “registro de movimentações”** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-03 e RF-04
 |
| Objetivo do Teste 	| Verificar se a página carregou, se todos os campos de registro estão acessíveis, consegue informar os dados, fazer upload de arquivo, salvar e editar os dados.  |
| Passos 	| 1) Acessar o navegador; 2) Informar o endereço do site; 3) Visualizar a página registro de movimentações; 4) Preencher as informações; 5) Consultar saldos e movimentações atuais; 6) Cadastrar novo saldo; 7) Salvar e editar os dados; 
 |
|Critério de Êxito | •	Usuário é redirecionado para uma página de registro de movimentações onde ele vai inserir tudo de relevante as suas movimentações; •	Disponibilidade de consultar saldos atuais, tela para cadastrar novo saldo;  •	Clicar no botão salvar ou editar e o sistema salva os dados ou liberar edição para corrigir alguma informação


 

 | **Caso de Teste** 	| **CT-09 – Funcionamento da página “objetivos financeiros”** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-05 e RF-06
 |
| Objetivo do Teste 	| Verificar se a página carregou, se consegue visualizar todos os objetivos e seu progresso, cadastrar e salvar novos objetivos |
| Passos 	| 1) Acessar o navegador; 2) Informar o endereço do site; 3) Visualizar a página de objetivos financeiros, todos os campos e seu progresso; 4) Preencher as informações; 5) Salvar e editar os dados; 
 |
|Critério de Êxito | •	Usuário é redirecionado para uma página de objetivos financeiros onde ele vai inserir tudo de relevante aos seus objetivos, cadastra, visualizar e acompanhar seu progresso  •	Clicar no botão salvar ou editar e o sistema salva os dados ou liberar edição para corrigir alguma informação


 


| **Caso de Teste** 	| **CT-10 – Funcionamento da página “planejamento de compras”** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-07 |
| Objetivo do Teste 	| Verificar se a página carregou, se consegue visualizar todos os campos da lista de planejamento e formulário de cadastro de compras, cadastrar e salvar novo planejamento |
| Passos 	| 1) Acessar o navegador; 2) Informar o endereço do site; 3) Visualizar a página de planejamento de compras; 4) Preencher as informações da lista de planejamento; 5) Cadastrar/editar formulário de compras 6) Salvar e editar os dados; 
 |
|Critério de Êxito |•	Usuário é redirecionado para uma página de planejamento de compras onde ele vai inserir tudo de relevante aos seus planejamentos, visualizar as listas de compras e cadastrar e editar um formulário novo de compras •	Clicar no botão salvar ou editar e o sistema salva os dados ou liberar edição para corrigir alguma informação


 

 | **Caso de Teste** 	| **CT-11 – Funcionamento da página “reserva de emergência”** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-08 e RF-09
 |
| Objetivo do Teste 	| Verificar se a página carregou, se consegue visualizar o saldo da reserva, cadastrar e salvar novo objetivo |
| Passos 	| 1) Acessar o navegador; 2) Informar o endereço do site; 3) Visualizar a página de reserva de emergência; 4) Preencher as informações da lista de reserva 5) Visualizar o saldo da reserva; 6) Cadastrar/editar novos objetivos; 7) Salvar e editar os dados; 
 |
|Critério de Êxito | •	Usuário é redirecionado para uma página de reserva de emergência onde ele vai inserir tudo de relevante aos seus saldos, visualizar as listas de saldos e objetivos e cadastrar e editar um novo objetivo ou saldo; •	Clicar no botão salvar ou editar e o sistema salva os dados ou liberar edição para corrigir alguma informação


 