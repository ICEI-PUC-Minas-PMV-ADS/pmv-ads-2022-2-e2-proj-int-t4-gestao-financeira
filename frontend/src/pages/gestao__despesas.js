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
                <button id="botao__expenditure__fixas" >Fixas</button>
                </div>
            </header>
            <div class="container__form__and__list__expenditure" >
                <form class="form__expenditure">
                <div class="container__input__expenditure" >
                    <input type="text" placeholder="Título da despesa..." >
                </div>
                <div class="container__input__expenditure" >
                    <input type="number" min="1" placeholder="R$ 0.000,00" >
                </div>
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
                <div class="list__expenditure">
                    <h2>Contas de Luz</h2>
                    <p>R$: 250,00</p>
                    <div class="container__value__and__buttons__expenditure" >
                    <button>Editar</button>
                    <button>Deletar</button>
                    </div>
                </div>
                <div class="list__expenditure">
                    <h2>Contas de Luz</h2>
                    <p>R$: 250,00</p>
                    <div class="container__value__and__buttons__expenditure" >
                    <button>Editar</button>
                    <button>Deletar</button>
                    </div>
                </div>
                </div>
            </div>
            <footer class="contianer__footer__expenditure">
                <button id="button__clear" >Limpar Todos</button>
                <button id="button__save" >Salvar</button>
            </footer>
            </div>

        </section>
    `;

};