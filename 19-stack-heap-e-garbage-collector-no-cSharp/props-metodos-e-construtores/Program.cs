using props_metodos_e_construtores;
using System.Globalization;
using Newtonsoft.Json;
using Microsoft.VisualBasic;
using System.ComponentModel.Design;


int numero = 30;
bool par = false;

//if ternario
//variavel int numero recebeu agora esse EhPar();
par = numero.EhPar();

string mensagem = "O número " + numero + " é " + (par ? "par" : "impar");























/*MeuArray<int> arrayInteiro = new MeuArray<int>();

arrayInteiro.AdicionarElementoArray(30);

Console.WriteLine(arrayInteiro[0]);



MeuArray<string> arrayString = new MeuArray<string>();

arrayString.AdicionarElementoArray("Teste");

Console.WriteLine(arrayString[0]);*/