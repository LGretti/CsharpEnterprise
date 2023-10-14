using Calculadora.Services;

CalculadoraImp calc = new CalculadoraImp();

int n1 = 1;
int n2 = 2;

Console.WriteLine("Soma: " + calc.Somar(n1, n2));
Console.WriteLine("Subtração: " + calc.Subtrair(n1, n2));
Console.WriteLine("Multiplicação: " + calc.Multiplicar(n1, n2));
Console.WriteLine("Divisão: " + calc.Dividir(n1, n2));
