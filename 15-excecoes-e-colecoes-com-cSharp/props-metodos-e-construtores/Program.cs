using props_metodos_e_construtores;
using System.Globalization;


string dataString = "2023-05-19 18:00";


bool sucesso = DateTime.TryParseExact(dataString
                                     ,"yyyy-MM-dd HH:mm"
                                     ,CultureInfo.InvariantCulture
                                     ,DateTimeStyles.None
                                     ,out DateTime data);

if (sucesso) {
    Console.WriteLine("Sucesso! " + data);
} else {
    Console.WriteLine("Erro de conversão para " + dataString    );
}








/*DateTime data = DateTime.Parse("19/05/2020 15:00");

Console.WriteLine(data.ToShortDateString);
Console.WriteLine(data.ToShortTimeString);*/



































/*CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");


decimal valorMonetario = 82.40M;

Console.WriteLine($"{valorMonetario.ToString("C2")}"); //pra cada numero 1 casa decimal





double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P"));


int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));*/




















/*string numero1 = "10";
int numero2 = 20;
string resultado = numero1 + numero2;

Console.WriteLine(resultado); //vai retornar 1020*/




/*Pessoa p1 = new Pessoa(nome: "Lucas", sobrenome: "Gretti");
//p1.Nome = "Lucas";
//p1.Sobrenome = "Gretti";

Pessoa p2 = new Pessoa("João", "Silva");
//p1.Nome = "Joao";
//p1.Sobrenome = "Silva";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();*/