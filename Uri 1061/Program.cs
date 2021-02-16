using System;

namespace Uri_1061
{
    class Program
    {
        static void Main(string[] args)
        {
            int diainicio, diafinal, horainicio, minutoinicio, segundoinicio, horafinal,minutofinal,segundofinal, dias, horas, minutos, segundos;

            Console.WriteLine();
            Console.Write("Dia : ");
            diainicio = int.Parse(Console.ReadLine());

            Console.WriteLine();
            string[]vetor = Console.ReadLine().Split(':');
            horainicio = int.Parse(vetor[0]);
            minutoinicio = int.Parse(vetor[1]);
            segundoinicio = int.Parse(vetor[2]);


            Console.WriteLine();
            Console.Write("Dia : ");
            diafinal = int.Parse(Console.ReadLine());

            Console.WriteLine();
            string[] vetor1 = Console.ReadLine().Split(':');
            horafinal = int.Parse(vetor1[0]);
            minutofinal = int.Parse(vetor1[1]);
            segundofinal = int.Parse(vetor1[2]);

            dias = (diafinal- diainicio)-1;

            horas = 24-(horainicio - horafinal);

            minutos = minutofinal - minutoinicio;

            segundos = segundofinal - segundoinicio;

            Console.WriteLine();
            Console.WriteLine(dias + " dia(s)");
            Console.WriteLine();
            Console.WriteLine(horas + " horas(s)");
            Console.WriteLine();
            Console.WriteLine(minutos + " Minuto(s)");
            Console.WriteLine();
            Console.WriteLine(segundos + " Minuto(s)");
            Console.WriteLine();




        }
    }
}
