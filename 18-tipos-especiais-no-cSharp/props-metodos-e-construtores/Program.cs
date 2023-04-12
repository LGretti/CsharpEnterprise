using props_metodos_e_construtores;
using System.Globalization;
using Newtonsoft.Json;
using Microsoft.VisualBasic;
using System.ComponentModel.Design;

string conteudoArquivo = File.ReadAllText("files/vendas.json");

List<Venda>? listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

//minha var listaAnonima pega a listavenda e da um select no x (sendo o x o listaVenda)
//e ele da um new na lista anonima com prod e preco
var listaAnonima = listaVenda.Select(x => new{x.Produto, x.Preco});

foreach (var item in listaAnonima) {
    Console.WriteLine($"Produto {item.Produto}, preço: {item.Preco}");
}














//foreach (Venda venda in listaVenda) {
//    Console.WriteLine($"Venda Id. {venda.Id} - " +
//                      $"Produto: {venda.Produto} - " +
//                      $"R${venda.Preco} - " +
//                      $"Data: {venda.DataVenda.ToString("dd/MM/yyyy")} - " +
//                      $"{(venda.Desconto.HasValue ? $"Desconto: {venda.Desconto}" : "")}");
//}