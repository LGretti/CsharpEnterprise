using props_metodos_e_construtores;
using System.Globalization;
using Newtonsoft.Json;
using Microsoft.VisualBasic;
using System.ComponentModel.Design;



Pessoa p1 = new Pessoa("Lucas", "gretti");
Pessoa p2 = p1;

//o p1 e o p2 estão como Vinicius gretti
p2.Nome = "Vinicius";


Console.WriteLine(p1.NomeCompleto);
Console.WriteLine(p2.NomeCompleto);




























//int numero = 30;
//bool par = false;

////if ternario
////variavel int numero recebeu agora esse EhPar();
//par = numero.EhPar();

//string mensagem = "O número " + numero + " é " + (par ? "par" : "impar");























/*MeuArray<int> arrayInteiro = new MeuArray<int>();

arrayInteiro.AdicionarElementoArray(30);

Console.WriteLine(arrayInteiro[0]);



MeuArray<string> arrayString = new MeuArray<string>();

arrayString.AdicionarElementoArray("Teste");

Console.WriteLine(arrayString[0]);*/