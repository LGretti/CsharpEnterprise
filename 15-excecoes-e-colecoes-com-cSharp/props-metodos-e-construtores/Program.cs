using props_metodos_e_construtores;
using System.Globalization;

         //chave, valor
Dictionary<string, string> estados = new Dictionary<string, string>();

//Estados do brasil
estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");


foreach (KeyValuePair<string, string> item in estados) {
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}


Console.WriteLine("------------------");

estados.Remove("MG"); //remove pela chave
estados["SP"] = "São-Paulo";

foreach (KeyValuePair<string, string> item in estados) {
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}


//Verificar se uma chave existe
string chave = "BA";
Console.WriteLine($"Verificando a chve {chave}");

if (estados.ContainsKey(chave)) {
    Console.WriteLine($"Valor Já existente para a chave {chave}.");
} else {
    Console.WriteLine($"Valor disponível para a chave {chave}.");
}


Console.WriteLine(estados["SP"]);













/*

Stack<int> pilha = new Stack<int>();


//Insere um obj no topo da pilha
pilha.Push(0);
pilha.Push(1);
pilha.Push(2);
pilha.Push(3);


foreach (int i in pilha) {
    Console.WriteLine(i);
}


Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

pilha.Push(4);

Console.WriteLine();



foreach (int i in pilha) {
    Console.WriteLine(i);
}


*/































//Queue<int> fila = new Queue<int>();

////adicionar elemento na fila na ultima posicao
//fila.Enqueue(1);
//fila.Enqueue(2);
//fila.Enqueue(3);
//fila.Enqueue(4);

//foreach (int i in fila) {
//    Console.WriteLine(i);
//}

////remove sempre o PRIMEIRO ELEMENTO da fila
//fila.Dequeue();

//Console.WriteLine("");
//Console.WriteLine("dequeue");
//foreach (int i in fila) {
//    Console.WriteLine(i);
//}