import { CommunicateAPI } from '../services/CommunicatesAPI.js';

document.getElementById('button__inserir__valor').addEventListener('click', () => {

    let transactionType = document.getElementById('select__tipo__transacao').value;
    let transactionValue = parseInt(document.getElementById('input__valor').value);

    if (!transactionType) {
        console.log('erro value')
        throw new Error('')
    };

    if (!transactionValue) {
        console.log('erro value')
        throw new Error('')
    };  

    if (transactionValue <= 0) {
        
    }

    const transaction = {
        transactionValue,
        transactionType
    };

    const { 
        inputValue, 
        exitValue, 
        balance 
    } = new CommunicateAPI('newTransaction').post(transaction);

    if (transactionType === 'Saque') document.getElementById('valor__entrada').innerHTML = `R$ ${inputValue}`;
    if (transactionType === 'Deposito') document.getElementById('valor__saida').innerHTML = `R$ ${exitValue}`;
    
    document.getElementById('saldo__valor').innerHTML = `R$ ${balance}`;
});