import { CommunicateAPI } from "../services/CommunicatesAPI.js";
import { oninputEvent } from "../utils/format__currency.js";

export const getaoSaldo = () => {
  const { novoSaldo, historicoTransacao } = new CommunicateAPI("Transacao/transacao-saldo").get();

  const teste = () => {
    console.log('teste')
  }

  return `    
        <div class="container__gestao__saldo" >
            <div class="container__apresenta__saldo" >
                <div class="container__saldo" >
                    <p class="label__valor" >Saldo</p>
                    <h3 id="saldo__valor" >R$ ${
                      novoSaldo ? novoSaldo : "0.000,00"
                    }</h3>
                </div>
                <div class="container__transacoes">
                    <div class="container__valor" >
                        <h2 class="flexa flexa__cima" >↑</h2>
                        <div>
                            <p class="label__valor" >Valor Entrada</p>
                            <h3 id="valor__entrada" class="valor__entrada" >R$ ${
                              novoSaldo ? novoSaldo : "0.000,00"
                            }</h3>
                        </div>
                    </div>
                    <div class="container__valor" >
                        <h2 class="flexa flexa__baixo">↓</h2>
                        <div>
                            <p class="label__valor" >Valor Saída</p>
                            <h3 id="valor__saida" class="valor__saida" >R$ ${
                              novoSaldo ? novoSaldo : "0.000,00"
                            }</h3>
                        </div>
                    </div>
                </div>
            </div>
            <div id="container__adiciona__saldo" class="container__adiciona__saldo">
                <div class="container__inputs__inserir__valor">
                    <div id="container__inserir__valor" class="container__inserir__valor">
                        <label class="label__inserir__valor" for="valor" >Insira o valor</label>
                    </div>
                    <div class="container__account">
                        <h2>Conta</h2>
                        <div class="container__types" >
                            <div class="container__type__account selected__effect__checkbox" id="checkBoxInput__comum" >
                                <label >Comum</label>
                                
                            </div>
                            <div class="container__type__account" id="checkBoxInput__emergency" >
                                <label >Emergêncial</label>
                                
                            </div>
                        </div>
                    </div>
                    <select id="select__tipo__transacao" class="select__tipo__transacao" >
                        <option value="" disabled selected>Tipo de Transação</option>
                        <option value="Saque" >Saque</option>
                        <option value="Deposito" >Deposito</option>
                    </select>
                </div>
            </div>
        </div>
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

  document.getElementById("container__inserir__valor").appendChild(inputValue);
};

export const checkBox = () => {
  let checkBoxInputAccountEmergency = document.createElement("input");
  let checkBoxInputAccountCommom = document.createElement("input");

  checkBoxInputAccountCommom.type = "radio";
  checkBoxInputAccountCommom.name = "type__account";
  checkBoxInputAccountCommom.id = "commom__account";
  checkBoxInputAccountCommom.value = "commom__account";
  checkBoxInputAccountCommom.style = "cursor: pointer;";
  checkBoxInputAccountCommom.checked = true;

  checkBoxInputAccountCommom.onclick = () => {
    document.getElementById("checkBoxInput__comum").className =
      "container__type__account selected__effect__checkbox";
    document.getElementById("checkBoxInput__emergency").className =
      "container__type__account";
  };

  document
    .getElementById("checkBoxInput__comum")
    .addEventListener("click", () => {
      document.getElementById("commom__account").checked = true;
      document.getElementById("emergency__account").checked = false;

      document.getElementById("checkBoxInput__comum").className =
        "container__type__account selected__effect__checkbox";
      document.getElementById("checkBoxInput__emergency").className =
        "container__type__account";
    });

  document
    .getElementById("checkBoxInput__emergency")
    .addEventListener("click", () => {
      document.getElementById("emergency__account").checked = true;
      document.getElementById("commom__account").checked = false;

      document.getElementById("checkBoxInput__emergency").className =
        "container__type__account selected__effect__checkbox";
      document.getElementById("checkBoxInput__comum").className =
        "container__type__account";
    });

  checkBoxInputAccountEmergency.type = "radio";
  checkBoxInputAccountEmergency.name = "type__account";
  checkBoxInputAccountEmergency.style = "cursor: pointer;";
  checkBoxInputAccountEmergency.value = "emergency__account";
  checkBoxInputAccountEmergency.id = "emergency__account";

  checkBoxInputAccountEmergency.onclick = () => {
    document.getElementById("checkBoxInput__emergency").className =
      "container__type__account selected__effect__checkbox";
    document.getElementById("checkBoxInput__comum").className =
      "container__type__account";
  };

  document
    .getElementById("checkBoxInput__comum")
    .appendChild(checkBoxInputAccountCommom);

  document
    .getElementById("checkBoxInput__emergency")
    .appendChild(checkBoxInputAccountEmergency);
};

export const buttonTransaction = () => {
  
  const newButton = document.createElement('button');
  newButton.className = 'button__inserir__valor';
  newButton.innerText = '+';
  
  newButton.onclick = () => {
    //Pega o valor o input para seleção do tipo de transação
    let transactionType = document.getElementById(
      "select__tipo__transacao"
    ).value;

    //Pega o valor do input para inserção de valores.
    let transactionValue = document.getElementById("input__valor").value

    //Se não tiver nenhum valor para ser inserido ou subtraído
    if (!transactionValue) {
      alert("É necessário informar o valor da transação para continuar.")
      return new Error("É necessário informar o valor da transação.");
    }

    //Transforma de string em número com casas decimais
    transactionValue = parseFloat(transactionValue.split(' ')[1].replace('.', '').replace(',','.'));

    //Se não tiver sido selecionada nenhuma transação;
    if (!transactionType) {
      alert("É necessário selecionar um tipo de transação para continuar")
      return new Error("É necessário selecionar um tipo de transação para continuar.");
    };

    let endPoint = "";

    //Verifica se é uma transação do tipo "Saque"
    if (transactionType === "saque") {
      //Saque emergencial
      if (document.getElementById("emergency__account").checked) {
        endPoint = "ReservaEmergencial/reserva-saque";
      }

      //Saque comum
      if (document.getElementById("commom__account").checked) {
        endPoint = "Transacao/transacao-saque";
      }
    }

    //Verifica se é uma transação do tipo "Deposito"
    if (transactionType === "deposito") {
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

  document.getElementById('container__adiciona__saldo').appendChild(newButton);
};
