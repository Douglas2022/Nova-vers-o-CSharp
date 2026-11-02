
using SistemaAcademico.Models;

namespace SistemaAcademico.Factories;

public static class PessoaFactory
{
    public static Pessoa CriarAluno(
        int id, string nome, string email, string matricula)
    {
        return new Aluno(id, nome, email, matricula);
    }

    public static Pessoa CriarProfessor(
        int id, string nome, string email, string especialidade)
    {
        return new Professor(id, nome, email, especialidade);
    }
}
