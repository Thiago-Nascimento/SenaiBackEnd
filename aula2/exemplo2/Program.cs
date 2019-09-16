using System;

namespace exemplo2 {
    class Program {
        static void Main (string[] args) {
            double n1, n2, n3, media;
            string resultado;

            Console.Write ("Digite a primeira nota: ");
            n1 = double.Parse (Console.ReadLine ());

            Console.Write ("Digite a segunda nota: ");
            n2 = double.Parse (Console.ReadLine ());

            Console.Write ("Digite a primeira nota: ");
            n3 = double.Parse (Console.ReadLine ());

            media = (n1 + n2 + n3) / 3;

            Console.WriteLine($"A média foi {media}");

            if (media >= 6) {
               resultado = "Aprovado";
            } else {
                if (media >= 4) {
                    resultado = "Recuperação";;
                } else {
                    resultado = "Reprovado";;
                }
            }

            Console.WriteLine(resultado);
        }
    }
}