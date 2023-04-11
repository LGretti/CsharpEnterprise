using props_metodos_e_construtores;
using System.Globalization;




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