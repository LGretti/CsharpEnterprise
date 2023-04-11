using props_metodos_e_construtores;
using System.Globalization;

//id, nome   sobrenome
(int, string, string, decimal) tupla = (1, "Lucas", "Gretti", 1.78M);

Console.WriteLine($"ID: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Altura: {tupla.Item4}");