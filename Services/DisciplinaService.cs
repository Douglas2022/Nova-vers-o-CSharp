
using SistemaAcademico.Models;
using SistemaAcademico.Interfaces;

namespace SistemaAcademico.Services;

public class DisciplinaService : IRepository<Disciplina>
{
    private readonly List<Disciplina> disciplinas = new();

    public void Adicionar(Disciplina disciplina)
    {
        if (disciplinas.Any(d => d.Id == disciplina.Id))
            throw new ArgumentException("Disciplina já cadastrada.");

        disciplinas.Add(disciplina);
    }

    public List<Disciplina> Listar() => disciplinas.ToList();
}
