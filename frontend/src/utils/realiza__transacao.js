import { CommunicateAPI } from "../services/CommunicatesAPI.js";

document
  .getElementById("button__inserir__valor")
  .addEventListener("click", () => {
    let transactionType = document.getElementById(
      "select__tipo__transacao"
    ).value;
    let transactionValue = parseInt(
      document.getElementById("input__valor").value
    );

    if (!transactionType) {
      console.log("erro value");
      throw new Error("");
    }

    if (!transactionValue) {
      console.log("erro value");
      throw new Error("");
    }

    let endPoint = "";

    if (transactionType === "saque")
      endPoint = "/api/Transacao/transacao-saque";
    if (transactionType === "deposito")
      endPoint = "/api/Transacao/transacao-deposito";

    let body = {
      valor: transactionValue,
      tipoTransacao: transactionType,
    };

    const { novoSaldo, historicoTransacao } = new CommunicateAPI(endPoint).post(
      body
    );

    historicoTransacao.forEach((historico) => {
      let { valor, tipoTransacao } = historico;

      if (tipoTransacao === "Saque")
        document.getElementById("valor__entrada").innerHTML = `R$ ${valor}`;
      if (tipoTransacao === "Deposito")
        document.getElementById("valor__saida").innerHTML = `R$ ${valor}`;
    });

    document.getElementById("saldo__valor").innerHTML = `R$ ${novoSaldo}`;
  });
