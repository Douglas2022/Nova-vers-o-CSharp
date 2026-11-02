
using SistemaAcademico.Models;
using SistemaAcademico.Interfaces;

namespace SistemaAcademico.Services;

public class ProfessorService : IRepository<Professor>
{
    private readonly List<Professor> professores = new();

    public void Adicionar(Professor professor)
    {
        if (professores.Any(p => p.Id == professor.Id))
            throw new ArgumentException("Professor já cadastrado.");

        professores.Add(professor);
    }

    public List<Professor> Listar() => professores.ToList();
}
