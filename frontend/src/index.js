import { getaoSaldo, dynamicallyGenerateInput } from "./pages/gestao__saldo.js";
import { menuHamburguer } from "./components/menu/index.js";

document.getElementById("container__principal").innerHTML = getaoSaldo();
dynamicallyGenerateInput();
document.getElementById("container__principal").prepend(menuHamburguer());
