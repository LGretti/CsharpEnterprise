using props_metodos_e_construtores;
using System.Globalization;



Queue<int> fila = new Queue<int>();

//adicionar elemento na fila na ultima posicao
fila.Enqueue(1);
fila.Enqueue(2);
fila.Enqueue(3);
fila.Enqueue(4);

foreach (int i in fila) {
    Console.WriteLine(i);
}

//remove sempre o PRIMEIRO ELEMENTO da fila
fila.Dequeue();

Console.WriteLine("");
Console.WriteLine("dequeue");
foreach (int i in fila) {
    Console.WriteLine(i);
}