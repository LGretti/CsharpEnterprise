using props_metodos_e_construtores;
using System.Globalization;
using Newtonsoft.Json;
using Microsoft.VisualBasic;
using System.ComponentModel.Design;


var tipoAnonimo = { Nome = "Lucas", Sobrenome = "Gretti", Altura = 1.78 };

Console.WriteLine(tipoAnonimo.Nome);














//string conteudoArquivo = File.ReadAllText("files/vendas.json");

//List<Venda>? listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

//foreach (Venda venda in listaVenda) {
//    Console.WriteLine($"Venda Id. {venda.Id} - " +
//                      $"Produto: {venda.Produto} - " +
//                      $"R${venda.Preco} - " +
//                      $"Data: {venda.DataVenda.ToString("dd/MM/yyyy")} - " +
//                      $"{(venda.Desconto.HasValue ? $"Desconto: {venda.Desconto}" : "")}");
//}