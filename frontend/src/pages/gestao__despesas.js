import { CommunicateAPI } from "../services/CommunicatesAPI.js";
import { oninputEvent } from "../utils/format__currency.js"; 

export const registerOfExpenses = () => {

    return `    
        <section class="containter__section__expenditure">

            <div class="container__list__initial" >
            <header class="container__header__expenditure" >
                <div class="quantidade__itens" >
                    <p>10</p>
                </div>
                <div class="valor__total__expenditure" >
                    <p>R$ 1.000,00</p>
                </div>
                <div class="buttons__select__type__expenditure" >
                    <button id="botao__expenditure__variaveis" >Variáveis</button>
                    <button id="botao__expenditure__fixas" class="SelectedExpenditure" >Fixas</button>
                </div>
            </header>
            <div class="container__form__and__list__expenditure" >
                <form class="form__expenditure">
                <div class="container__input__expenditure" >
                    <input type="text" placeholder="Título da despesa..." >
                </div>
                <div class="container__input__expenditure" id="container__input__expenditure" ></div>
                    <button id="button__add__expenditure" >Adicionar</button>
                </form>
                <div class="container__list__expenditure" >
                <div class="list__expenditure">
                    <h2>Contas de Luz</h2>
                    <p>R$: 250,00</p>
                    <div class="container__value__and__buttons__expenditure" >
                    <button>Editar</button>
                    <button>Deletar</button>
                    </div>
                </div>
            </div>
            <footer id="contianer__footer__expenditure" class="contianer__footer__expenditure">
                <button id="button__clear" >Limpar Todos</button>
            </footer>
            </div>

        </section>
    `;

};

export const dynamicallyGenerateInput = () => {
    let inputValue = document.createElement("input");
  
    inputValue.type = "text";
    inputValue.id = "input__valor";
    inputValue.value = "";
    inputValue.className = "input__inserir__valor";
    inputValue.placeholder = "R$ 00,00";
    inputValue.name = "valor";
  
    inputValue.oninput = (event) => oninputEvent(event);
  
    document.getElementById("container__input__expenditure").appendChild(inputValue);
};

export const buttonTransaction = () => {

    let transactionType = '';

    let buttonExpenditureVariavel = document.getElementById('botao__expenditure__variaveis');
    let buttonExpenditureFixa = document.getElementById('botao__expenditure__fixas');

    buttonExpenditureVariavel.addEventListener('click', () => { 
        transactionType = 'variavel';
        buttonExpenditureFixa.className = '';
        buttonExpenditureVariavel.className = 'SelectedExpenditure'; 
    });

    buttonExpenditureFixa.addEventListener('click', () => { 
        transactionType = 'fixa';
        buttonExpenditureVariavel.className = ''; 
        buttonExpenditureFixa.className = 'SelectedExpenditure';
    });
  
    const newButton = document.createElement('button');
    newButton.id = 'button__save';
    newButton.innerText = 'Salvar';

    newButton.onclick = () => {
        console.log(transactionType)

      //Pega o valor do input para inserção de valores.
      let transactionValue = document.getElementById("input__valor").value
  
      //Se não tiver nenhum valor para ser inserido ou subtraído
      if (!transactionValue) {
        alert("É necessário informar o valor da transação para continuar.")
        return new Error("É necessário informar o valor da transação.");
      }
  
      //Transforma de string em número com casas decimais
      transactionValue = parseFloat(transactionValue.split(' ')[1].replace('.', '').replace(',','.'));
  
      let endPoint = "";
  
      //Verifica se a despesa é do tipo "Variável"
      if (transactionType === "variavel") {
        //Saque emergencial
        if (document.getElementById("emergency__account").checked) {
          endPoint = "ReservaEmergencial/reserva-saque";
        }
  
        //Saque comum
        if (document.getElementById("commom__account").checked) {
          endPoint = "Transacao/transacao-saque";
        }
      }
  
      //Verifica se a despesa é do tipo "Fixa"
      if (transactionType === "fixa") {
        //Saque comum
        if (document.getElementById("emergency__account").checked) {
          endPoint = "ReservaEmergencial/reserva-deposito";
        }
  
        //Deposito comum
        if (document.getElementById("commom__account").checked) {
          endPoint = "Transacao/transacao-deposito";
        }
      }
  
      let body = {
        valor: transactionValue,
        tipoTransacao: transactionType,
      };
    };
  
    document.getElementById('contianer__footer__expenditure').appendChild(newButton);
};
