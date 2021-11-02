using System;

namespace PesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, pesoIdeal;
            string sexo;

            Console.Write("Digite sua altura em m..........: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Sexo [M]Masculino / [F]Feminino..: ");
            sexo = Console.ReadLine().ToUpper().Trim();

            if (sexo != "M" && sexo != "F")
            {
                Console.WriteLine("Não é possível realizar o cálculo");
            }
            else
            {
                if (sexo == "M")
                {
                    pesoIdeal = (altura * 72.7) - 58.0;
                }
                else
                {
                    pesoIdeal = (altura * 62.1) - 44.7;
                }
                Console.WriteLine($"Seu peso ideal é {pesoIdeal:N2}kg.");
            }
        }
    }
}
