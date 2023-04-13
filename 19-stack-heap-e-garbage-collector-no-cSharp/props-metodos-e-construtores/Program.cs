using props_metodos_e_construtores;
using System.Globalization;
using Newtonsoft.Json;
using Microsoft.VisualBasic;
using System.ComponentModel.Design;

MeuArray<int> arrayInteiro = new MeuArray<int>();

arrayInteiro.AdicionarElementoArray(30);

Console.WriteLine(arrayInteiro[0]);



MeuArray<string> arrayString = new MeuArray<string>();

arrayString.AdicionarElementoArray("Teste");

Console.WriteLine(arrayString[0]);