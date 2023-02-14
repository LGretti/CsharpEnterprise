using ExemploFundamentos.Models;

int numero = 0;
int contador = 0;

do {
    Console.WriteLine("Digite um número (0 para parar)");
    numero = Convert.ToInt32(Console.ReadLine());

    contador += numero;
} while (numero != 0);

Console.WriteLine($"soma = {contador}");




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