using ExerciciosCSharp04TryCatch.Exercicios;
using System;

namespace ExerciciosCSharp04TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] exercicios = new int[] { 21, 22, 23, 24};
                Console.WriteLine("Escolha o número do exercício: ");
                foreach(int i in exercicios)
                {
                    Console.WriteLine($"---> Exercício {i}");
                }
                var opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "21":
                        Console.Clear();
                        Exercicio21 exercicio21 = new Exercicio21();
                        break;
                    case "22":
                        Console.Clear();
                        Exercicio22 exercicio22 = new Exercicio22();
                        break;
                    case "23":
                        Console.Clear();
                        Exercicio23 exercicio23 = new Exercicio23();
                        break;
                    case "24":
                        Console.Clear();
                        Exercicio24 exercicio24 = new Exercicio24();
                        break;

                    default:
                        Console.WriteLine("Número não reconhecido. Encerrando...");
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Um erro aconteceu: {e.Message}");
            }
        }
    }
}
