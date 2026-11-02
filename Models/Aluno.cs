
namespace SistemaAcademico.Models;

public class Aluno : Pessoa
{
    public string Matricula { get; private set; }

    public Aluno(int id, string nome, string email, string matricula)
        : base(id, nome, email)
    {
        if (string.IsNullOrWhiteSpace(matricula))
            throw new ArgumentException("Matrícula obrigatória.");

        Matricula = matricula;
    }

    public override string ObterDescricao()
    {
        return $"Aluno: {Nome} - Matrícula: {Matricula}";
    }
}
