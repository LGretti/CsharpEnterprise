using props_metodos_e_construtores;

Pessoa p1 = new Pessoa(nome: "Lucas", sobrenome: "Gretti");
//p1.Nome = "Lucas";
//p1.Sobrenome = "Gretti";

Pessoa p2 = new Pessoa("João", "Silva");
//p1.Nome = "Joao";
//p1.Sobrenome = "Silva";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();