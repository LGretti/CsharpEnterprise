using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace props_metodos_e_construtores {
    public class Pessoa {
        private string _nome;

        public string Nome {
            get => _nome.ToUpper();

            set {
                if ((value == "") || (value == null)) {
                    throw new ArgumentException("Nome não pode ser vazio");
                }

                _nome = value;
            }
        }

        public int Idade { get; set; }

        public void Apresentar() {
            Console.WriteLine($"Olá, me chamo {Nome}.");
        }
    }
}
