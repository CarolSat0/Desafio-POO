using EX_03.Models;

ContaCorrente CC = new ContaCorrente(500);

CC.NomeCorrentista = "Carolina Sato";
CC.NumeroAgencia = 1234;
CC.NumeroConta = 12345;

CC.Sacar(10);
CC.ExibirSaldo();