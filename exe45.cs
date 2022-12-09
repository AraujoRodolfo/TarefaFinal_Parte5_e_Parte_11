using System;

namespace kaskarias
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] estrutura = new string[3, 3];
            string turnos = "X";
            int rodadas = 1;
            int index = 1;

            Console.WriteLine("----- BEM VINDO AO JOGO DA VELHA -----");
            Console.WriteLine("");

            for (int i = 0; i < estrutura.GetLength(0); i++)
            {
                for (int j = 0; j < estrutura.GetLength(1); j++)
                {
                    estrutura[i, j] = index.ToString();
                    index++;
                }

            }

            for (int i = 0; i < estrutura.GetLength(0); i++)
            {
                for (int j = 0; j < estrutura.GetLength(1); j++)
                {
                    Console.Write($" [{estrutura[i, j]}]");
                }
                Console.WriteLine();
            }

            Console.WriteLine("");
            Console.WriteLine("DIGITE O NÚMERO A QUAL DESEJA JOGAR! LEMBRADO QUE SE COMEÇA COM O 'X'");

            string jogada = Console.ReadLine();
            Console.Clear();



            while (rodadas <= 9)
            {
                Console.WriteLine("----- BEM VINDO AO JOGO DA VELHA -----");
                Console.WriteLine("");

                for (int i = 0; i < estrutura.GetLength(0); i++)
                {
                    for (int j = 0; j < estrutura.GetLength(1); j++)
                    {
                        if (estrutura[i, j] == jogada)
                        {

                            estrutura[i, j] = turnos;

                        }
                    }
                }


                for (int i = 0; i < estrutura.GetLength(0); i++)
                {
                    for (int j = 0; j < estrutura.GetLength(1); j++)
                    {
                        Console.Write($" [{estrutura[i, j]}]");
                    }
                    Console.WriteLine();
                }
                Console.ResetColor();
                Console.WriteLine();

                if (estrutura[0, 0] == estrutura[1, 1] && estrutura[1, 1] == estrutura[2, 2] ||
                    estrutura[0, 2] == estrutura[1, 1] && estrutura[1, 1] == estrutura[2, 0])
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine("FIM DE JOGO!");
                    Console.WriteLine("-----------");
                    Console.WriteLine("Quem ganhou foi '{0}'", turnos);
                    break;
                }

                if (estrutura[0, 0] == estrutura[0, 1] && estrutura[0, 1] == estrutura[0, 2] ||
                   estrutura[1, 0] == estrutura[1, 1] && estrutura[1, 1] == estrutura[1, 2] ||
                   estrutura[2, 0] == estrutura[2, 1] && estrutura[2, 1] == estrutura[2, 2])
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine("FIM DE JOGO!");
                    Console.WriteLine("-----------");
                    Console.WriteLine("Quem ganhou foi '{0}'", turnos);
                    break;
                }

                if (estrutura[0, 0] == estrutura[1, 0] && estrutura[1, 0] == estrutura[2, 0] ||
                   estrutura[1, 0] == estrutura[1, 1] && estrutura[1, 1] == estrutura[2, 1] ||
                   estrutura[2, 0] == estrutura [2, 1] && estrutura [2,1] == estrutura [2, 2])
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine("FIM DE JOGO!");
                    Console.WriteLine("-----------");
                    Console.WriteLine("Quem ganhou foi '{0}'", turnos);
                    break;
                }

                if (rodadas == 9)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine("FIM DE JOGO!");
                    Console.WriteLine("-----------");
                    Console.WriteLine("!!! DEU VELHA !!!");
                    break;
                }



                if (turnos == "X")
                {
                  
                        turnos = "O";
                    
                }
                else
                {
                    turnos = "X";
                }

                
                Console.WriteLine("DIGITE O NÚMERO A QUAL DESEJA JOGAR! VEZ DE '{0}'", turnos);

                jogada = Console.ReadLine();

               if (rodadas == 9)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine("FIM DE JOGO!");
                    Console.WriteLine("-----------");
                    Console.WriteLine("  DEU VELHA  ");
                }

                rodadas++;
                Console.Clear();

            }
            Console.ReadKey();
        }
    }
}
