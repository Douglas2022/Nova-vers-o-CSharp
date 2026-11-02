
namespace SistemaAcademico.Models;

public abstract class Pessoa
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string Email { get; private set; }

    protected Pessoa(int id, string nome, string email)
    {
        if (id <= 0)
            throw new ArgumentException("ID inválido.");

        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("Nome obrigatório.");

        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("E-mail obrigatório.");

        Id = id;
        Nome = nome;
        Email = email;
    }

    public abstract string ObterDescricao();
}
