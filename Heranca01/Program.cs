using Heranca01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionários deseja cadastrar? ");
            int nFuncionarios = Convert.ToInt32(Console.ReadLine());

            List<Empregados> empregados = new List<Empregados>();
            

            for (int i = 0; i < nFuncionarios ; i++)
            {
                

                Console.WriteLine("Nome: ");
                string nomeDoFuncionario = Console.ReadLine();

                Console.WriteLine("Quantas horas trabalhadas? ");
                int horasFuncionario = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Valor por hora: ");
                double valorHoraFuncionario = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("O funcionário é terceirizado?  (S / N)");
                string respTerceirizado = Console.ReadLine();

                if (respTerceirizado.ToUpper() == "S")
                {
                    Console.WriteLine("Valor adicional: ");
                    double valorAdicionalFuncionario = Convert.ToDouble(Console.ReadLine());

                    EmpregadosTerceirizados empregadosTerceirizados = new EmpregadosTerceirizados()
                    {
                        DespesaAdicional = valorAdicionalFuncionario,
                        HorasTrabalhadas = horasFuncionario,
                        Nome = nomeDoFuncionario,
                        ValorPorHora = valorHoraFuncionario
                    };

                    empregados.Add(empregadosTerceirizados);
                }
                else
                {
                    Empregados empregado = new Empregados()
                    {
                        ValorPorHora = valorHoraFuncionario,
                        Nome = nomeDoFuncionario,
                        HorasTrabalhadas = horasFuncionario

                    };


                    empregados.Add(empregado);
                }


            }

            foreach (var pessoa in empregados)
            {
                Console.WriteLine("Nome: " + pessoa.Nome);
                Console.WriteLine("Pagamento: " + pessoa.Pagamento());
            }

            Console.ReadLine();
        }
    }
}
