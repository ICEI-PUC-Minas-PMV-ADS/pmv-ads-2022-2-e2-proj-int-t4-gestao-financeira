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

  let arrayItensDespesaVariavel = [];
  let arrayItensDespesaFixa = [];
  let transactionType = '';

  const generateItemsInitialOrAlternateType = (arrayItems) => {
    arrayItems.map(item => {
      let itemList = document.createElement('div');

      itemList.className = 'list__expenditure';
      itemList.id = item.id;

      itemList.innerHTML = `
        <h2>${item.nome}</h2>
        <p>R$ ${item.value}</p>
        <div id="container__value__and__buttons__expenditure" class="container__value__and__buttons__expenditure"></div>
      `;

      let buttonDelete = document.createElement('button');
      buttonDelete.innerText = 'Deletar';
      buttonDelete.id = 'button__delete';
  
      buttonDelete.onclick = () => {
        let paiButtonDelete = buttonDelete.parentNode;
        let avoButtonDelete = paiButtonDelete.parentNode;
        avoButtonDelete.parentNode.removeChild(avoButtonDelete);

        if (transactionType === 'variavel') {
          arrayItensDespesaVariavel = arrayItensDespesaVariavel.filter(itemArray => itemArray.id !== parseInt(avoButtonDelete.id) - 1);
          document.getElementById('quantidade__itens').innerText = `${arrayItensDespesaVariavel.length}`
        } else {
          arrayItensDespesaFixa = arrayItensDespesaFixa.filter(itemArray => itemArray.id !== parseInt(avoButtonDelete.id) - 1);
          document.getElementById('quantidade__itens').innerText = `${arrayItensDespesaFixa.length}`
        }
      };

      document.getElementById('container__list__expenditure').prepend(itemList);
      document.getElementById('container__value__and__buttons__expenditure').appendChild(buttonDelete);
    });
  };

  const genereteItem = (values) => {
    let expenditureItem = document.createElement('div');
    expenditureItem.className = 'list__expenditure';

    let titleItem = document.createElement('h2');
    titleItem.innerText = values.title;

    let valueItem = document.createElement('p');
    valueItem.innerText = `R$ ${values.value}`;

    let containerValueButons = document.createElement('div');
    containerValueButons.className = 'container__value__and__buttons__expenditure';

    let buttonDelete = document.createElement('button');
    buttonDelete.innerText = 'Deletar';
    buttonDelete.id = 'button__delete';

    buttonDelete.onclick = () => {
      let paiButtonDelete = buttonDelete.parentNode;
      let avoButtonDelete = paiButtonDelete.parentNode;
      avoButtonDelete.parentNode.removeChild(avoButtonDelete);

      if (transactionType === 'variavel') {
        arrayItensDespesaVariavel = arrayItensDespesaVariavel.filter(item => item.id !== parseInt(avoButtonDelete.id) - 1);
        document.getElementById('quantidade__itens').innerText = `${arrayItensDespesaVariavel.length}`
      } else {
        arrayItensDespesaFixa = arrayItensDespesaFixa.filter(item => item.id !== parseInt(avoButtonDelete.id) - 1);
        document.getElementById('quantidade__itens').innerText = `${arrayItensDespesaFixa.length}`
      }
    };

    expenditureItem.appendChild(titleItem);
    expenditureItem.appendChild(valueItem);

    containerValueButons.appendChild(buttonDelete);

    expenditureItem.appendChild(containerValueButons);

    if (transactionType === 'variavel') {
      arrayItensDespesaVariavel.push({ nome: values.title, value: values.value, id: arrayItensDespesaVariavel.length + 1 });
      document.getElementById('quantidade__itens').innerText = `${arrayItensDespesaVariavel.length}`
      expenditureItem.id = `${arrayItensDespesaVariavel.length + 1}`;
    } else {
      arrayItensDespesaFixa.push({ nome: values.title, value: values.value, id: arrayItensDespesaFixa.length + 1 });
      document.getElementById('quantidade__itens').innerText = `${arrayItensDespesaFixa.length}`
      expenditureItem.id = `${arrayItensDespesaFixa.length + 1}`;
    }

    document.getElementById('container__list__expenditure').prepend(expenditureItem);
    inputValue.value = '';
    inputText.value = '';
  };

  

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

      //Transforma de string em número com casas decimais
      itemValue = parseFloat(itemValue.split(' ')[1].replace('.', '').replace(',','.'));

      genereteItem({ value: itemValue, title: itemTitle });

    }); 

    if (transactionType === 'variavel') {
      document.getElementById('button__clear').addEventListener('click', () => {
        arrayItensDespesaVariavel = [];
        document.getElementById('container__list__expenditure').innerHTML = '';
        document.getElementById('quantidade__itens').innerText = `${arrayItensDespesaVariavel.length}`
      });
    } else {
      document.getElementById('button__clear').addEventListener('click', () => {
        arrayItensDespesaFixa = [];
        document.getElementById('container__list__expenditure').innerHTML = '';
        document.getElementById('quantidade__itens').innerText = `${arrayItensDespesaFixa.length}`
      });
    }

    let buttonExpenditureVariavel = document.getElementById('botao__expenditure__variaveis');
    let buttonExpenditureFixa = document.getElementById('botao__expenditure__fixas');

    buttonExpenditureVariavel.addEventListener('click', () => { 
        document.getElementById('container__list__expenditure').innerHTML = '';
        transactionType = 'variavel';
        document.getElementById('quantidade__itens').innerText = `${arrayItensDespesaVariavel.length}`
        buttonExpenditureFixa.className = '';
        generateItemsInitialOrAlternateType(arrayItensDespesaVariavel);
        buttonExpenditureVariavel.className = 'SelectedExpenditure'; 
    });

    buttonExpenditureFixa.addEventListener('click', () => { 
        document.getElementById('container__list__expenditure').innerHTML = '';
        transactionType = 'fixa';
        document.getElementById('quantidade__itens').innerText = `${arrayItensDespesaFixa.length}`
        buttonExpenditureVariavel.className = ''; 
        generateItemsInitialOrAlternateType(arrayItensDespesaFixa);
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
