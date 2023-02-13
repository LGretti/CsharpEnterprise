using ExemploFundamentos.Models;

string apresentacao = "Olá, seja bem vindo";

//Pega a hora da maquina que a app ta rodando com o mesmo formato
//DateTime dataAtual = DateTime.Now;

DateTime dataAtual = DateTime.Now.AddDays(1);

Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm:ss"));







/*
int quantidade = 1;
Console.WriteLine("O valor da variável quantidade é:" + quantidade);

quantidade = 10;
Console.WriteLine("O valor da variável quantidade é:" + quantidade);
*/

/*
double altura = 1.8;

decimal preco = 1.80M;

bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("O valor da variável quantidade é:" + quantidade);
Console.WriteLine("O valor da variável altura é:" + altura.ToString("0.00"));
Console.WriteLine("O valor da variável preco é:" + preco);
Console.WriteLine("O valor da variável condicao é:" + condicao);
*/

/*Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Buta";
pessoa1.Idade = 26;
pessoa1.Apresentar();

Pessoa pessoa_FisicaRepresentacao = new Pessoa();

*/