
namespace SistemaAcademico.Interfaces;

public interface IRepository<T>
{
    void Adicionar(T item);
    List<T> Listar();
}
