using ExemploFundamentos.Models;

while (true) {
    Console.Clear();

    Console.WriteLine("Digite a opção");
    Console.WriteLine("1 - cadastrar cliente");
    Console.WriteLine("2 - buscar cliente");
    Console.WriteLine("3 - apagar cliente");
    Console.WriteLine("4 - encerrar sessão");
    int opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao) {
        case 1:
            Console.WriteLine("cadastrar cliente");
            break;
        case 2:
            Console.WriteLine("buscar cliente");
            break;
        case 3:
            Console.WriteLine("apagar cliente");
            break;
        case 4:
            Console.WriteLine("encerrar");
            Environment.Exit(0);//Sair do programa
            break;

        default:
            Console.WriteLine("Opçao inválida");
            break;
    }

}




















/*int numero = 0;
int contador = 0;

do {
    Console.WriteLine("Digite um número (0 para parar)");
    numero = Convert.ToInt32(Console.ReadLine());

    contador += numero;
} while (numero != 0);

Console.WriteLine($"soma = {contador}");*/




/*while (contador <= 10) {
    Console.WriteLine($"{contador + 1}º Execução: {numero} x {contador} = {numero * contador}");
    contador++;

    if (contador == 6) {
        break;
    }
}*/

/*for (int x = 1; x <= 10; x++) {
    Console.WriteLine($"------{x}------");
    for (int y = 1; y <= 10; y++) {
        Console.WriteLine($"{x} x {y} = {x * y}");
    }
}

*/