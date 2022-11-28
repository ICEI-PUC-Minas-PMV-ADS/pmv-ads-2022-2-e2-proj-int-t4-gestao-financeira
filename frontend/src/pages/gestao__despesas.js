import { CommunicateAPI } from "../services/CommunicatesAPI.js";
import { oninputEvent } from "../utils/format__currency.js"; 

export const registerOfExpenses = () => {

    return `    
        <section class="containter__section__expenditure">

            <div class="container__list__initial" >
            <header class="container__header__expenditure" >
                <div class="quantidade__itens" >
                    <p id="quantidade__itens" >0</p>
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
                <form id="form__expenditure" class="form__expenditure">
                  <div class="container__input__expenditure" id="container__input__expenditure__text" ></div>
                  <div class="container__input__expenditure" id="container__input__expenditure__value" ></div>
                  <button class="button__add__expenditure" id="button__add__expenditure" >Adicionar</button>
                </form>
                <div id="container__list__expenditure" class="container__list__expenditure" ></div>
            <footer id="contianer__footer__expenditure" class="contianer__footer__expenditure">
                <button id="button__clear" >Limpar Todos</button>
            </footer>
            </div>

        </section>
    `;

};

let inputValue = document.createElement("input");
let inputText = document.createElement("input");

export const dynamicallyGenerateInput = () => {

    inputText.type = "text";
    inputText.id = "title__item";
    inputText.value = "";
    inputText.placeholder = "Título da despesa...";
  
    document.getElementById("container__input__expenditure__text").appendChild(inputText);

    inputValue.type = "text";
    inputValue.id = "item__value";
    inputValue.value = "";
    inputValue.placeholder = "R$ 00,00";

    inputValue.oninput = (event) => oninputEvent(event);
  
    document.getElementById("container__input__expenditure__value").appendChild(inputValue);
};

export const buttonTransaction = () => {

  let arrayItens = [];

    document.getElementById('button__add__expenditure').addEventListener('click', (e) => {
      e.preventDefault();
      
      let itemTitle =  document.getElementById('title__item').value;
      let itemValue =  document.getElementById('item__value').value;

      //Verifica se foi informado um nome para a despesa;
      if (!itemTitle) {
        alert("É necessário informar o nome da despesa.")
        return new Error("É necessário informar o nome da despesa.");
      };

      //Verifica se foi informado um valor para a despesa.
      if (!itemValue) {
        alert("É necessário informar o valor da despesa.")
        return new Error("É necessário informar o valor da despesa.");
      };

      let expenditureItem = document.createElement('div');
      expenditureItem.className = 'list__expenditure';

      let titleItem = document.createElement('h2');
      titleItem.innerText = itemTitle;

      let valueItem = document.createElement('p');
      valueItem.innerText = `R$ ${itemValue}`;

      let containerValueButons = document.createElement('div');
      containerValueButons.className = 'container__value__and__buttons__expenditure';

      let buttonDelete = document.createElement('button');
      buttonDelete.innerText = 'Deletar';
      buttonDelete.id = 'button__delete';

      buttonDelete.onclick = () => {
        let paiButtonDelete = buttonDelete.parentNode;
        let avoButtonDelete = paiButtonDelete.parentNode;
        avoButtonDelete.parentNode.removeChild(avoButtonDelete);
        arrayItens = arrayItens.filter(item => item.id !== parseInt(avoButtonDelete.id) - 1);
        document.getElementById('quantidade__itens').innerText = `${arrayItens.length}`
      };

      expenditureItem.appendChild(titleItem);
      expenditureItem.appendChild(valueItem);

      containerValueButons.appendChild(buttonDelete);

      expenditureItem.appendChild(containerValueButons);
      
      //Transforma de string em número com casas decimais
      itemValue = parseFloat(itemValue.split(' ')[1].replace('.', '').replace(',','.'));

      arrayItens.push({ nome: itemTitle, value: itemValue, id: arrayItens.length + 1 });

      document.getElementById('quantidade__itens').innerText = `${arrayItens.length}`

      expenditureItem.id = `${arrayItens.length + 1}`;

      document.getElementById('container__list__expenditure').prepend(expenditureItem);
      inputValue.value = '';
      inputText.value = '';
    }); 

    document.getElementById('button__clear').addEventListener('click', () => {
      arrayItens = [];
      document.getElementById('container__list__expenditure').innerHTML = '';
      document.getElementById('quantidade__itens').innerText = `${arrayItens.length}`
    });

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
      //Pega o valor do input para inserção de valores.
      let transactionValue = document.getElementById("input__valor").value
  
      //Se não tiver nenhum valor para ser inserido ou subtraído
      if (!transactionValue) {
        alert("É necessário informar o valor da transação para continuar.")
        return new Error("É necessário informar o valor da transação.");
      }
  
      //Transforma de string em número com casas decimaisf
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
