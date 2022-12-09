using System;

namespace exe35._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            Console.WriteLine("Qual o 1º lado do triângulo ?");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o 2º lado do triângulo ?");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o 3º lado do triângulo ?");
            C = int.Parse(Console.ReadLine());

            bool TrianguloResultado = teste(A, B, C);
            Console.WriteLine();
            if (TrianguloResultado == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Triângulo inválido!");
                Console.ResetColor();
            }
    
            else if (A == B && B == C)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Triângulo Equilátero");
            }

            else if (A == B || A == C || B == C)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Triângulo Isóceles");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Triângulo Escaleno");
            }

            Console.ReadKey();
        }
        static bool teste(int A, int B, int C)
        {
            bool teste;
            if (A + B < C || A+C < B || B+C<A)
            {
                teste = false;
            }
            else
            {
                teste = true;
            }
            return teste;

        }
    }
    }

