using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp04TryCatch.Exercicios
{
    public class Exercicio23 : BaseExercicio
    {
        public Exercicio23()
        {
            try
            {
                Console.WriteLine("Digite o ano e saiba se é bissexto ou não: ");
                valor1 = int.Parse(Console.ReadLine());
                if (AnoBissexto(Convert.ToInt32(valor1)))
                {
                    Console.WriteLine($"O ano {valor1} é bissexto.");
                }
                else
                {
                    Console.WriteLine($"O ano {valor1} não é bissexto.");
                }
            }
            catch(FormatException e)
            {
                Console.WriteLine($"Um erro aconteceu: {e.Message}");
            }
        }
        private bool AnoBissexto(int ano)
        {
            if(ano % 400 == 0 || ano % 4 == 0 && ano % 100 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
