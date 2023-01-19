using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca01.Entities
{
    public class EmpregadosTerceirizados : Empregados
    {
        public double DespesaAdicional { get; set; }

        public override double Pagamento()
        {
            return (HorasTrabalhadas * ValorPorHora) + (1.1 * DespesaAdicional);
        }
    }
}
