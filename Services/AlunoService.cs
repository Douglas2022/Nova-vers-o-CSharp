
using SistemaAcademico.Models;
using SistemaAcademico.Interfaces;

namespace SistemaAcademico.Services;

public class AlunoService : IRepository<Aluno>
{
    private readonly List<Aluno> alunos = new();

    public void Adicionar(Aluno aluno)
    {
        if (alunos.Any(a => a.Id == aluno.Id ||
                            a.Matricula == aluno.Matricula))
            throw new ArgumentException("Aluno ou matrícula já cadastrado.");

        alunos.Add(aluno);
    }

    public List<Aluno> Listar() => alunos.ToList();
}
