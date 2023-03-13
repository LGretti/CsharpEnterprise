using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace props_metodos_e_construtores {
    public class Pessoa {
        private string _nome;
        private string _sobrenome;
        private int _idade;

        public string Nome {
            get => _nome.ToUpper();

            set {
                if ((value == "") || (value == null)) {
                    throw new ArgumentException("Nome não pode ser vazio");
                }

                _nome = value;
            }
        }

        public string Sobrenome {
            get => _sobrenome.ToUpper();

            set {
                if ((value == "") || (value == null)) {
                    throw new ArgumentException("Nome não pode ser vazio");
                }

                _sobrenome = value;
            }
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}";

        public int Idade {
            get => _idade;

            set {
                if (value < 0) {
                    throw new ArgumentException("Idade não pode ser menor que 0.");
                }

                _idade = value;
            }
        }

        public void Apresentar() {
            Console.WriteLine($"Olá, me chamo {NomeCompleto}.");
        }
    }
}
