using System;

namespace exe21
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, Z;
            Console.WriteLine("Digite um valor para A");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para B");
            B = int.Parse(Console.ReadLine());

            Z = A;
            A = B;
            B = Z;

            Console.WriteLine("Valor invertido de B = {0}", B);
            Console.WriteLine("Valor invertido de A = {0)", A);
            Console.ReadKey();
        }
    }
}
