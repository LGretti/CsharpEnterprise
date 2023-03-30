using props_metodos_e_construtores;
using System.Globalization;


try {
    string[] linhas = File.ReadAllLines("files/testaae.txt");

    foreach (string line in linhas) {
        Console.WriteLine(line);
    }
} catch(Exception errMsg) {
    Console.WriteLine($"Ocorreu um erro: {errMsg}");
}

