using props_metodos_e_construtores;
using System.Globalization;
using Newtonsoft.Json;
using Microsoft.VisualBasic;
using System.ComponentModel.Design;

bool? desejaReceberEmail = null;

if (desejaReceberEmail.HasValue && desejaReceberEmail.Value) {//pra verificar se é null
    Console.WriteLine("Aceita");
} else {
    Console.WriteLine("Não deseja ou não optou");
}
