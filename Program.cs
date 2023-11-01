
using ExemploExplorando.Models;

Pessoa P1 = new Pessoa(nome: "Tiago", sobrenome: "Sabath");

Pessoa P2 = new Pessoa();
P2.Nome = "felipe";
P2.Sobrenome = "Sousa";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(P1);
cursoDeIngles.AdicionarAluno(P2);
cursoDeIngles.ListarAlunos();
