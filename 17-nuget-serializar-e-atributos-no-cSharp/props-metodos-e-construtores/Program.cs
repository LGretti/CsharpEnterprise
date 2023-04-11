using props_metodos_e_construtores;
using System.Globalization;
using Newtonsoft.Json;

DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();


Venda venda1 = new Venda(1, "materiais de esc", 25.00M, dataAtual);
Venda venda2 = new Venda(1, "licenca software", 2500.00M, dataAtual);

listaVendas.Add(venda1);
listaVendas.Add(venda2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("files/vendas.json", serializado);

Console.WriteLine(serializado);