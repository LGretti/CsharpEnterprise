using props_metodos_e_construtores;
using System.Globalization;

LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("files/teste.txt");

if (sucesso) {
    //Console.WriteLine($"Quantidade de linhas: {quantidadeLinhas}");
    foreach (string linha in linhasArquivo) {
        Console.WriteLine(linha);
    }
} else {
    Console.WriteLine($"Não foi possível ler o arquivo!");
}




























////melhor forma
//(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Lucas", "Gretti", 1.78M);

////outra forma, so declara o tipo de cada item
//ValueTuple<int, string, string, decimal> tupla2 = (1, "Lucas", "Gretti", 1.78M);

////outra forma, so coloca o valor, ele pega o tipo sozinho
//var tupla3 = Tuple.Create(1, "Lucas", "Gretti", 1.78M);


//Console.WriteLine($"ID: {tupla.Id}");
//Console.WriteLine($"Nome: {tupla.Nome}");
//Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
//Console.WriteLine($"Altura: {tupla.Altura}");