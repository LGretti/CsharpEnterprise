﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace props_metodos_e_construtores {
    public class Venda {
        public int Id { get; set; }

        [JsonProperty("Nome_Produto")] //O produto vai ser considerado como Nome_Produto no JSON
        public string Produto { get; set; }

        public decimal Preco { get; set; }

        public DateTime DataVenda { get; set; }



        public Venda(int id, string produto, decimal preco, DateTime dataVenda) {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda;
        }


    }
}
