import { CommunicateAPI } from "../services/CommunicatesAPI.js";
import { oninputEvent } from "../utils/format__currency.js";

export const getaoSaldo = () => {
  const { novoSaldo, historicoTransacao } = new CommunicateAPI(
    "/api/Transacao/transacao-deposito"
  ).get();

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
            <div class="container__adiciona__saldo">
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
                <button id="button__inserir__valor" class="button__inserir__valor">+</button>
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
