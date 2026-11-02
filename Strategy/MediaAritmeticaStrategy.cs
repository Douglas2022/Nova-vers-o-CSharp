
using SistemaAcademico.Interfaces;

namespace SistemaAcademico.Strategies;

public class MediaAritmeticaStrategy : ICalculadoraNota
{
    public double Calcular(double nota)
    {
        return Math.Round(nota, 2);
    }
}
