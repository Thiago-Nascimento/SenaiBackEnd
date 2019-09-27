using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 2\n");
            MostraDiaDaSemana();
        }

        static void MostraDiaDaSemana() {
            DateTime diaSemana = DateTime.Today.Day;                        
            Console.WriteLine(diaSemana.DayOfWeek);
        }
    }
}
