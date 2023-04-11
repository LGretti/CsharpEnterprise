using props_metodos_e_construtores;
using System.Globalization;
using Newtonsoft.Json;

//transforamndo essa venda em json
Venda venda1 = new Venda(1, "materiais de esc", 25.00M);

//metodo SerializeObject - ler documentacao
//ele transofrma esse objeto em uma string json
string serializado = JsonConvert.SerializeObject(venda1, Formatting.Indented);

//Escreve todo o texto em um arquivo json
File.WriteAllText("files/vendas.json", serializado);

Console.WriteLine(serializado);