using ExemploFundamentos.Common.Models;

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
//arrayInteiros[3] = 1;

int[] arrayDobro = new int[arrayInteiros.Length * 2];

//origem dos dados, destino, tamanho
Array.Copy(arrayInteiros, arrayDobro, arrayInteiros.Length);







Console.WriteLine("Array com For");
for (int i = 0; i < arrayInteiros.Length; i++) {
    Console.WriteLine($"Posição n{i} - {arrayInteiros[i]}");
}

















/*Console.WriteLine("Array com Foreach que não pode acessar o contador");
int con = 0;
foreach (int valor in arrayInteiros) {
    Console.WriteLine(valor + " " + con);
    con++;
}*/