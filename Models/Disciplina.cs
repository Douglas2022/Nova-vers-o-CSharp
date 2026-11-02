
namespace SistemaAcademico.Models;

public class Disciplina
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public int CargaHoraria { get; private set; }

    public Disciplina(int id, string nome, int cargaHoraria)
    {
        if (id <= 0)
            throw new ArgumentException("ID inválido.");

        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("Nome obrigatório.");

        if (cargaHoraria <= 0)
            throw new ArgumentException("Carga horária inválida.");

        Id = id;
        Nome = nome;
        CargaHoraria = cargaHoraria;
    }
}
