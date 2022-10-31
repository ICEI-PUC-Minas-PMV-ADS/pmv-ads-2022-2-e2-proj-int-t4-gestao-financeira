import { CommunicateAPI } from "../services/CommunicatesAPI";

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
                            <h3 id="valor__entrada" class="valor__entrada" >R$ R$ ${
                              novoSaldo ? novoSaldo : "0.000,00"
                            }/h3>
                        </div>
                    </div>
                    <div class="container__valor" >
                        <h2 class="flexa flexa__baixo">↓</h2>
                        <div>
                            <p class="label__valor" >Valor Saída</p>
                            <h3 id="valor__saida" class="valor__saida" >R$ R$ ${
                              novoSaldo ? novoSaldo : "0.000,00"
                            }</h3>
                        </div>
                    </div>
                </div>
            </div>
            <div class="container__adiciona__saldo">
                <div class="container__inputs__inserir__valor">
                    <div class="container__inserir__valor">
                        <label class="label__inserir__valor" for="valor" >Insira o valor</label>
                        <input id="input__valor" class="input__inserir__valor" type="text" name="valor" placeholder="R$ 00,00" >
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
