
namespace SistemaAcademico.Models;

public class Matricula
{
    public int Id { get; private set; }
    public Aluno Aluno { get; private set; }
    public Disciplina Disciplina { get; private set; }
    public double Nota { get; private set; }

    public Matricula(int id, Aluno aluno, Disciplina disciplina)
    {
        if (id <= 0)
            throw new ArgumentException("ID inválido.");

        Id = id;
        Aluno = aluno ?? throw new ArgumentNullException(nameof(aluno));
        Disciplina = disciplina ?? throw new ArgumentNullException(nameof(disciplina));
        Nota = 0;
    }

    public void RegistrarNota(double nota)
    {
        if (nota < 0 || nota > 10)
            throw new ArgumentException("A nota deve estar entre 0 e 10.");

        Nota = nota;
    }
}
