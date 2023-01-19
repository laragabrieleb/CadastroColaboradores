using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca01.Entities
{
    public class Empregados
    {
        public string Nome { get; set; }

        public int HorasTrabalhadas { get; set; }

        public double ValorPorHora { get; set; }

        public Empregados()
        {
        }

        public Empregados(string nome, int horasTrabalhadas, double valorPorHora)
        {
            Nome = nome;
            HorasTrabalhadas = horasTrabalhadas;
            ValorPorHora = valorPorHora;
        }

        public virtual double Pagamento()
        {
            return HorasTrabalhadas * ValorPorHora;
        }
    }
}
