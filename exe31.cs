using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Calc();
            Console.ReadKey();
            }
        static void Calc()
        {
            int par = 0;
            int impar = 0;
            int positivo = 0;
            int negativo = 0;
            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Digite qualquer número");
                num[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            for (int j = 0; j < num.Length; j++)
            {
                if (num[j] % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
                if (num[j] >= 0)
                {
                    positivo++;
                }
                else
                {
                    negativo++;
                }
            }

                Console.WriteLine("Há {0} positivo(s)", positivo);
                Console.WriteLine("Há {0} negativo(s)", negativo);
                Console.WriteLine("Há {0} par(es)", par);
                Console.WriteLine("Há {0} impar(es)", impar);
            Console.Clear();
            Perg();
        }
        static void Perg()
        {
            string resposta;
            Console.WriteLine("Deseja encerrar o programa? Se sim digite (S), se não pressione outra tecla");
            resposta = Console.ReadLine();
                Console.Clear();
            if (resposta != "S" && resposta != "s")
            {
                Calc();
             
            }
           
        }
        }
    

}