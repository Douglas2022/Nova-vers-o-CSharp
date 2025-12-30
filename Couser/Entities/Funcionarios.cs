using System.Globalization;
using System;

namespace Couser.Entities
{
    class Funcionarios : IComparable
    {
        public string Name { get; set; }
        public double Salario { get; set; }

        public Funcionarios(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0].Trim();
            Salario = double.Parse(vect[1].Trim(), CultureInfo.InvariantCulture);
        }
        public override string ToString()
        {
            return Name + ", " + Salario.ToString("F2",CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Funcionarios))
            {
                throw new ArgumentException("Compare o erro: se o argumento não for um funcionário");

            }
            Funcionarios outro = obj as Funcionarios;
            return outro.Name.CompareTo(Name);
        }
    }
}
