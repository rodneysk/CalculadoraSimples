using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Calculadora Simples

            int numero1, numero2, resultado = 0;
            string opcao = "";
                          
            Console.WriteLine("CALCULADORA SIMPLES\n");

            Console.WriteLine("DIGITE O PRIMEIRO NÚMERO:");
            numero1 = int.Parse(Console.ReadLine());
            while (numero1 < 0)
            {
                Console.WriteLine("\nNÚMERO INVÁLIDO, DIGITE UM NÚMERO MAIOR QUE ZERO:");
                numero1 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nDIGITE A OPERAÇÃO:");
            opcao = Console.ReadLine();

            Console.WriteLine("\nDIGITE O SEGUNDO NÚMERO:");
            numero2 = int.Parse(Console.ReadLine());
            while (numero2 < 0)
            {
                Console.WriteLine("\nNÚMERO INVÁLIDO, DIGITE UM NÚMERO MAIOR QUE ZERO:");
                numero2 = int.Parse(Console.ReadLine());
            }

            switch(opcao)
            {
                case "+":
                    resultado = numero1 + numero2;
                    Console.WriteLine(resultado);
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                 case "*":
                    resultado = numero1 * numero2;
                    break;
                 case "/":
                    resultado = numero1 / numero2;
                    break;
                
            }

            Console.WriteLine("\n============\n{0} {1} {2} = {3}", numero1, opcao, numero2, resultado);
            Console.ReadKey(true);
        }
    }
}