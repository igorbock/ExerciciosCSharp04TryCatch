using System;

namespace ExerciciosCSharp04TryCatch.Exercicios
{
    public class Exercicio21 : BaseExercicio
    {
        public Exercicio21()
        {
            try
            {
                ExibirMenu();
                var option = RetornaOpcao();
                switch (option)
                {
                    case '1':
                        Resultado = SomaNumeros();
                        Console.WriteLine($"O resultado é {Resultado}");
                        break;
                    case '2':
                        Resultado = DiferencaNumeros();
                        Console.WriteLine($"O resultado é {Resultado}");
                        break;
                    case '3':
                        Resultado = ProdutoNumeros();
                        Console.WriteLine($"O resultado é: {Resultado}");
                        break;
                    case '4':
                        Resultado = DivisaoNumeros();
                        Console.WriteLine($"O resultado é: {Resultado}");
                        break;

                    default:
                        Console.WriteLine("Comando não identificado.");
                        break;
                }
            }
            catch (ExercicioException e)
            {
                Console.WriteLine($"Um erro aconteceu: {e.Message}");
            }
        }
        public void ExibirMenu()
        {
            Console.WriteLine("Escolha a opção: ");
            Console.WriteLine("1- Soma de 2 números.");
            Console.WriteLine("2- Diferença entre 2 números (maior entre menor).");
            Console.WriteLine("3- Produto entre 2 números.");
            Console.WriteLine("4- Divisão entre 2 números (o denominador não pode ser zero).");
            Console.WriteLine("Opção");
        }
        public char RetornaOpcao()
        {
            var opcao = new char();
            try
            {
                opcao = char.Parse(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine($"Um erro aconteceu: {e.Message}");
            }
            return opcao;
        }
        public double SomaNumeros()
        {
            try
            {
                Console.WriteLine("Digite o primeiro número: ");
                valor1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                valor2 = double.Parse(Console.ReadLine());
            }
            catch(ExercicioException e)
            {
                Console.WriteLine($"Um erro aconteceu: {e.Message}");
            }
            catch(FormatException e)
            {
                Console.WriteLine($"Um erro aconteceu: {e.Message}");
            }

            return Resultado = Valor1 + Valor2;
        }
        public double DiferencaNumeros()
        {
            try
            {
                Console.WriteLine("Digite o primeiro número: ");
                valor1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                valor2 = double.Parse(Console.ReadLine());
                if(Valor1 >= Valor2)
                {
                    return Resultado = Valor1 - Valor2;
                }
                else
                {
                    throw new ExercicioException(3, $"Diferença somente entre maior e menor. {Valor1}-{Valor2} não é possível");
                }
            }
            catch(ExercicioException e)
            {
                Console.WriteLine($"Um erro aconteceu: {e.Message}");
            }
            catch(FormatException e)
            {
                Console.WriteLine($"Um erro aconteceu: {e.Message}");
            }
            return 0;
        }
        public double ProdutoNumeros()
        {
            try
            {
                Console.WriteLine("Digite o primeiro número: ");
                valor1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                valor2 = double.Parse(Console.ReadLine());
                return Resultado = Valor1 * Valor2;
            }
            catch(FormatException e)
            {
                Console.WriteLine($"Um erro aconteceu: {e.Message}");
            }
            return 0;
        }
        public double DivisaoNumeros()
        {
            try
            {
                Console.WriteLine("Digite o primeiro número: ");
                valor1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                valor2 = double.Parse(Console.ReadLine());
                if (Valor2.Equals(0))
                {
                    throw new ExercicioException(4, "O denominador não pode ser 0");
                }
                else
                {
                    return Resultado = Valor1 / Valor2;
                }
            }
            catch(ExercicioException e)
            {
                Console.WriteLine($"Um erro aconteceu: {e.Message}");
            }
            catch(FormatException e)
            {
                Console.WriteLine($"Um erro aconteceu: {e.Message}");
            }
            return 0;
        }
    }
}
