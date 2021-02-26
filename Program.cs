using System;
using System.Collections.Generic;

namespace HSVC
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.Write("Insira a quantia que o bandido capturado tinha:");
            string tp = Console.ReadLine();
            int.TryParse(tp,out int quantiaB1);
            var soma = 0;

            int[] quantiaRoubada = new int[10];

            if (quantiaB1 > 0)
            {
                soma += quantiaB1;
                quantiaRoubada[0] = quantiaB1;

                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine("Insira a quantia que o "+ i +"ª bandido(a):");
                    tp = Console.ReadLine();
                    int.TryParse(tp, out int quantiaTodos);

                    if (quantiaTodos > 0){
                        if (quantiaTodos >= quantiaB1) {

                            if ((quantiaTodos % 10) == 0) {
                                soma += quantiaTodos;
                                quantiaRoubada[i] = quantiaTodos;
                            }
                        }

                    }
                    else {
                        Console.WriteLine("Número inserido errado!.");
                    }
                }
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("QUANTIA ROUBADA");
                Console.WriteLine(soma);
                Console.WriteLine("-------------------------------------");

                foreach (var item in quantiaRoubada)
                {
                    if (item > 0) { Console.WriteLine(item); }
                }
            }
            else {
                Console.WriteLine("Número inserido errado!.");
            }
        }
    }
}
