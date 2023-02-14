using ExemploFundamentos.Models;

int numero = 5;
int contador = 0;

while (contador <= 10) {
    Console.WriteLine($"{contador + 1}º Execução: {numero} x {contador} = {numero * contador}");
    contador++;
}




/*for (int x = 1; x <= 10; x++) {
    Console.WriteLine($"------{x}------");
    for (int y = 1; y <= 10; y++) {
        Console.WriteLine($"{x} x {y} = {x * y}");
    }
}

*/