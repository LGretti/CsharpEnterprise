using props_metodos_e_construtores;
using System.Globalization;


try {
    string[] linhas = File.ReadAllLines("files/testaae.txt");

    foreach (string line in linhas) {
        Console.WriteLine(line);
    }
} catch(FileNotFoundException errMsg) { //Começa pelas tratativas específicas e termina na generalista
    Console.WriteLine($"Arquivo não encontrado: {errMsg}");

} catch (DirectoryNotFoundException errMsg) {
    Console.WriteLine($"Diretório não encontrado: {errMsg}");

} catch(Exception errMsg) { //Mais geral, todas vêm daqui
    Console.WriteLine($"Ocorreu um erro: {errMsg}");
} finally { //Finalmente (executa dando erro ou não)
    Console.WriteLine("Chegou até aqui");
}

