using props_metodos_e_construtores;
using System.Globalization;


string[] linhas = File.ReadAllLines("files/testaae.txt");

foreach (string line in linhas) {
    Console.WriteLine(line);
}

