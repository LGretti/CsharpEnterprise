using ExemploFundamentos.Models;

for (int x = 1; x <= 10; x++) {
    Console.WriteLine($"------{x}------");
    for (int y = 1; y <= 10; y++) {
        Console.WriteLine($"{x} x {y} = {x * y}");
    }
}

