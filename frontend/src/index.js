import { getaoSaldo, dynamicallyGenerateInput } from "./pages/gestao__saldo.js";

document.getElementById("container__principal").innerHTML = getaoSaldo();
dynamicallyGenerateInput();
