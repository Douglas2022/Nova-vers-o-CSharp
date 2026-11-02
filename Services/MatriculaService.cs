
using SistemaAcademico.Models;

namespace SistemaAcademico.Services;

public class MatriculaService
{
    private readonly List<Matricula> matriculas = new();

    public void Adicionar(Matricula matricula)
    {
        if (matriculas.Any(m => m.Id == matricula.Id))
            throw new ArgumentException("Matrícula já cadastrada.");

        if (matriculas.Any(m =>
            m.Aluno.Id == matricula.Aluno.Id &&
            m.Disciplina.Id == matricula.Disciplina.Id))
            throw new ArgumentException("Aluno já matriculado nesta disciplina.");

        matriculas.Add(matricula);
    }

    public List<Matricula> Listar() => matriculas.ToList();
}
