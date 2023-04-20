using System;

//TODO: Complete os espaços em branco com uma possível solução para o problema. 
class MinhaClasse {
  public static void Main (string[] args) {
    int n = int.Parse(Console.ReadLine());
    string[] texto = Console.ReadLine().Split(" ");
    
    int x = int.Parse(texto[0]), y = int.Parse(texto[1]);
    
    int totalNecessario = x + y; 
    
    if (totalNecessario > n)
    {
      Console.WriteLine("Deixa para amanha!");
    }
    else
    {
      Console.WriteLine("Farei hoje!");
    }
  }
}