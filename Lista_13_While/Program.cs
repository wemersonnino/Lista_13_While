using System;

namespace Lista_13_While
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo lerTecla;
            bool continua = true;
            do
            {
                Console.Clear();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("| OPÇÃO      | EXERCÍCIOS");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("| F1      | EXERCÍCIOS 2");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("| F2      | EXERCÍCIOS 3");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("| F3      | EXERCÍCIOS 4");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("| ESC      | SAIR                  ");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("| Selecione os Exercicios |");
                lerTecla = Console.ReadKey();

                if (lerTecla.Key == ConsoleKey.F1 || lerTecla.Key == ConsoleKey.F2 || lerTecla.Key == ConsoleKey.F3 || lerTecla.Key == ConsoleKey.Escape)
                {
                    continua = false;
                }
                else
                {
                    Console.WriteLine("\nOpção errada!\nEscolha uma das opções acima!");
                    Console.ReadKey();
                }

            } while (continua);



            switch (lerTecla.Key)
            {
                case ConsoleKey.F1:
                    {
                        int numero, count = 0;
                        bool testprimo = true;
                        

                        do
                        {
                            count = 0;
                            Console.Clear();
                            Console.WriteLine("Digite um numero para descobrir se ele é um numero primo:");
                            numero = Convert.ToInt32(Console.ReadLine());

                            for (int i = 1; i <= numero; i++)
                            {
                                if (numero % i == 0)
                                {
                                    count++;
                                }
                            }
                            if (count == 2)
                            {
                                testprimo = false;
                            }

                        } while (testprimo);

                        Console.WriteLine("O {0} é um numero primo", numero);

                    }

                    break;
                case ConsoleKey.F2:
                    {
                        int numero, soma = 0;

                        Console.Clear();
                        Console.WriteLine("\n");
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("| Programa soma numeros inteiros: |");
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("| Digite o numero 0 para encerrar |");
                        Console.WriteLine(" ----------------------------------");
                        Console.WriteLine("\n");

                        do
                        {
                            Console.WriteLine("Digite um numero: ");
                            numero = Convert.ToInt32(Console.ReadLine());

                            if (numero != 0)
                            {
                                soma += numero;
                            }

                        } while (numero != 0);

                        Console.WriteLine("A soma dos numeros digitados é {0}", soma);
                        Console.WriteLine("Fim do Programa");
                    }
                    break;
                case ConsoleKey.F3:
                    {
                        int numero, soma = 1;

                        Console.Clear();
                        Console.WriteLine("\n");
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("| Programa soma numeros Positivos: |");
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("| Digite o numero -1 para encerrar |");
                        Console.WriteLine(" ----------------------------------");
                        Console.WriteLine("\n");

                        Console.WriteLine("Digite um numero: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        while (numero > 0)
                        {
                            Console.WriteLine("Digite um numero: ");
                            numero = Convert.ToInt32(Console.ReadLine());

                            if (numero > 0)
                            {
                                soma += numero;
                                soma++;
                            }
                        }
                        Console.WriteLine("A soma dos numeros digitados é {0}", soma);
                        Console.WriteLine("Fim do Programa");
                    }
                    break;
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("\n Saindo do Programa!");
                    }
                    break;
            }

            Console.ReadKey();

        }
    }
}
