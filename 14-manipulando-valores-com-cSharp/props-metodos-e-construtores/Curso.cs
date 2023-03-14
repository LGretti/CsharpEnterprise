using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace props_metodos_e_construtores {
    public class Curso {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno) {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados() {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno) {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos() {
            for (int count = 0; count < Alunos.Count; count++) {
                //string texto = "No. " + count + " " + Alunos[count].NomeCompleto;
                int numero = count + 1;
                string texto = $"No. {numero} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }
    }
}
