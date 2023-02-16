using ExemploFundamentos.Common.Models;

Pessoa p = new Pessoa();

Console.WriteLine("Digite o nome");
p.Nome = Console.ReadLine();
Console.WriteLine("Digite a idade");
p.Idade = Convert.ToInt32(Console.ReadLine());

if (p.Idade < 18) {
    Console.WriteLine("Representante legal (vazio se não tiver)");
    p.NomeRepresentanteLegalDaPessoaFisica = Console.ReadLine();
}

if (!p.PermitidaEntrada()) {
    Console.WriteLine("Acesso negado");
} else {
    p.Apresentar();
}