using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Leonardo", sobrenome: "Matheus");
Pessoa p2 = new Pessoa(nome: "Maria", sobrenome: "Joaquina");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();











































/* Pessoa p1 = new Pessoa();
p1.Nome = "Leonardo";
p1.Sobrenome = "Matheus";
p1.Idade = 25;
p1.Apresentar(); */
