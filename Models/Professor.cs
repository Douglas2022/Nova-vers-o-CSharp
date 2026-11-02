
namespace SistemaAcademico.Models;

public class Professor : Pessoa
{
    public string Especialidade { get; private set; }

    public Professor(int id, string nome, string email, string especialidade)
        : base(id, nome, email)
    {
        if (string.IsNullOrWhiteSpace(especialidade))
            throw new ArgumentException("Especialidade obrigatória.");

        Especialidade = especialidade;
    }

    public override string ObterDescricao()
    {
        return $"Professor: {Nome} - Especialidade: {Especialidade}";
    }
}
