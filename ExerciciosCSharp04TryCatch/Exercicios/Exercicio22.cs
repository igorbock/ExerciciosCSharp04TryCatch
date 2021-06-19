using System;

namespace ExerciciosCSharp04TryCatch.Exercicios
{
    public class Exercicio22 : BaseExercicio
    {
        public Exercicio22()
        {
            try
            {
                Console.WriteLine("Digite o nome: ");
                var nome = Console.ReadLine();
                if (nome.Equals(""))
                {
                    throw new ExercicioException(5, "O nome não deve estar vazio");
                }
                Console.WriteLine("Digite a idade: ");
                var idade = Console.ReadLine();
                if (idade.Equals(""))
                {
                    throw new ExercicioException(6, "A idade não deve estar vazia");
                }
                Console.WriteLine("Digite o tempo de serviço: ");
                var tempo = Console.ReadLine();
                if (tempo.Equals(""))
                {
                    throw new ExercicioException(7, "O tempo de serviço não deve estar vazio");
                }
                Pessoa pessoa = new Pessoa(nome, int.Parse(idade), int.Parse(tempo));
                if (aposentadoria(pessoa))
                {
                    Console.WriteLine($"O(A) {pessoa.Nome} pode se aposentar com {pessoa.Idade} anos e {pessoa.TempoServico} anos de serviço.");
                }
                else
                {
                    Console.WriteLine($"O(A) {pessoa.Nome} não pode se aposentar com {pessoa.Idade} anos e {pessoa.TempoServico} anos de serviço.");
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
        }
        private bool aposentadoria(Pessoa pessoa)
        {
            if(pessoa.Idade >= 65 || pessoa.TempoServico >= 30 || pessoa.Idade >= 60 && pessoa.TempoServico >= 25)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Pessoa
    {
        public Pessoa(string nome, int idade, int tempoServico)
        {
            Nome = nome;
            Idade = idade;
            TempoServico = tempoServico;
        }
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public int TempoServico { get; private set; }
    }
}
