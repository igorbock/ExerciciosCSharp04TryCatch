namespace ExerciciosCSharp04TryCatch
{
    public abstract class BaseExercicio
    {
        protected double Valor1;
        protected double Valor2;
        protected double Resultado { get; set; }
        protected double valor1
        {
            get { return Valor1; ; }
            set
            {
                if (value >= double.MinValue && value <= double.MaxValue)
                {
                    Valor1 = value;
                }
                else
                {
                    throw new ExercicioException(1, $"Os valores devem ser entre {double.MinValue} e {double.MaxValue}");
                }
            }
        }
        protected double valor2
        {
            get { return Valor2; ; }
            set
            {
                if (value >= double.MinValue && value <= double.MaxValue)
                {
                    Valor2 = value;
                }
                else
                {
                    throw new ExercicioException(1, $"Os valores devem ser entre {double.MinValue} e {double.MaxValue}");
                }
            }
        }
    }
}
