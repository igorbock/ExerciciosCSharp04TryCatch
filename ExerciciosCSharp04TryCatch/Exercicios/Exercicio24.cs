using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp04TryCatch.Exercicios
{
    public class Exercicio24
    {
        public Exercicio24()
        {
            try
            {
                Console.WriteLine("Digite o valor do produto: ");
                var valor = Console.ReadLine();
                if(!double.TryParse(valor, out double numero))
                {
                    throw new ExercicioException(10, "O valor deve ser numérico");
                }
                else
                {
                    ValorProduto = double.Parse(valor);
                }
                Console.WriteLine("Escolha um estado para enviar o produto:");
                foreach(string est in Estados)
                {
                    Console.WriteLine($"Estado --> {est}");
                }
                var estado = Console.ReadLine();
                switch (estado)
                {
                    case "MG":
                        ValorProduto += (7 * ValorProduto) / 100;
                        Console.WriteLine($"O valor do produto para MG: {ValorProduto}");
                        break;
                    case "SP":
                        ValorProduto += (12 * ValorProduto) / 100;
                        Console.WriteLine($"O valor do produto para SP: {ValorProduto}");
                        break;
                    case "RJ":
                        ValorProduto += (15 * ValorProduto) / 100;
                        Console.WriteLine($"O valor do produto para RJ: {ValorProduto}");
                        break;
                    case "MS":
                        ValorProduto += (8 * ValorProduto) / 100;
                        Console.WriteLine($"O valor do produto para MS: {ValorProduto}");
                        break;

                    default:
                        Console.WriteLine("Estado não reconhecido. Encerrando...");
                        break;
                }
            }
            catch(ExercicioException e)
            {
                Console.WriteLine($"Um erro aconteceu: {e.Message}");
            }
        }

        public double ValorProduto { get; private set; }
        private string[] Estados = new string[] { "MG", "SP", "RJ", "MS" };
    }
}
