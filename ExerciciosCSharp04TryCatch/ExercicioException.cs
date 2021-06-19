using System;

namespace ExerciciosCSharp04TryCatch
{
    public class ExercicioException : FormatException
    {
        public ExercicioException(int codigo, string mensagem) : base($"{mensagem}. Erro do cógigo: {codigo}")
        {

        }
    }
}
