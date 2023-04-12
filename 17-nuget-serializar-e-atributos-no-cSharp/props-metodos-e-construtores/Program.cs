using props_metodos_e_construtores;
using System.Globalization;
using Newtonsoft.Json;
using Microsoft.VisualBasic;

string conteudoArquivo = File.ReadAllText("files/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda) {
    Console.WriteLine($"Venda Id. {venda.Id} - " +
                      $"Produto: {venda.Produto} - " +
                      $"R${venda.Preco} - " +
                      $"Data: {venda.DataVenda.ToString("dd/MM/yyyy")}");
}

/*List<Venda> listaVendas = new List<Venda>();

//DateTime dataAtual = DateTime.Now;

Venda venda1 = new Venda(1, "materiais de esc", 25.00M, dataAtual);
Venda venda2 = new Venda(1, "licenca software", 2500.00M, dataAtual);

listaVendas.Add(venda1);
listaVendas.Add(venda2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("files/vendas.json", serializado);

Console.WriteLine(serializado);*/