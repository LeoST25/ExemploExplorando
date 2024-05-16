using ExemploExplorando.Models;
using System.Globalization;

string dataString = "2024-05-16 14:04";

bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

if (sucesso)
{
    System.Console.WriteLine($"Conversão com sucesso! Data: {data}");
}
else
{
    System.Console.WriteLine($"{dataString} não é uma data válida");
}
































/* CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 1582.40M;

Console.WriteLine(valorMonetario.ToString("N2"));

double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##")); */

















/* string numero1 = "10";
string numero2 = "20";

string resultado = numero1 + numero2;

Console.WriteLine(resultado); */





















/* Pessoa p1 = new Pessoa(nome: "Leonardo", sobrenome: "Matheus");
Pessoa p2 = new Pessoa(nome: "Maria", sobrenome: "Joaquina");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos(); */











































/* Pessoa p1 = new Pessoa();
p1.Nome = "Leonardo";
p1.Sobrenome = "Matheus";
p1.Idade = 25;
p1.Apresentar(); */
