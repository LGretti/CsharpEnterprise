using props_metodos_e_construtores;
using System.Globalization;


string[] linhas = File.ReadAllLines("files/teste.txt");

foreach (string line in linhas) {
    Console.WriteLine(line);
}

