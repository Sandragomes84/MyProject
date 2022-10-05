using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyExercices
{
    internal class Modulo7
    {



        //Exercício 1

        public static void Hello(string nome)
        {
            Console.WriteLine($" Olá, {nome}!"); 
        }


        //Exercício 2

        public static void Soma(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }


        //Exercício 3

        public static void Asteriscos()
        {
            Console.WriteLine("Introduza o número de asteriscos que pretende:");
            int n = int.Parse(Console.ReadLine());
            char x = '*';

            for (int i = 0; i <= n; i++)
            {
                Console.Write(" "+x);
            }

        }
        

        //Exercício 4

        public static void Calculator()
        {
            Console.WriteLine(" Escolha uma das seguintes opções:");
            Console.WriteLine(" 1 - Somar\n 2 - Substrair\n 3 - Dividir\n 4 - Multiplicar");
            int opcao= int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            
            if (opcao == 1)
            {
                int resultado = num1 + num2;
                Console.WriteLine($"O resultado da operação é: {resultado}"); 
               
            }
            else if (opcao == 2)
            {
                int resultado = num1 - num2;
                Console.WriteLine($"O resultado da operação é: {resultado}");

            }
            else if (opcao ==3)
            {
                int resultado = num1 / num2;
                Console.WriteLine($"O resultado da operação é: {resultado.ToString("F2")}");

            }
            else if (opcao == 4)
            {
                int resultado = num1 * num2;
                Console.WriteLine($"O resultado da operação é: {resultado}");

            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
             
        }   


        //Exercício 5

        public static void Maximo2(int a, int b)
        {
            if (a>b)
            {
                Console.WriteLine($"O maior número é: {a}");
            }
            else
            {
                Console.WriteLine($"O maior número é: {b}");
            }
        }

        //Exercício 6


        public static void Hipotenusa(double b, double c)
        {
            double a;
           
            b = b * b;
            c = c * c;
            a = b + c;
            a = Math.Sqrt(a);

            Console.WriteLine($"O valor da Hipotenusa é: {a.ToString("F2")}");

        }


        //Exercício 7

        public static void NumDigitos(int x)
        {
            int count = 0;

            while(x != 0)
            {
                x = x / 10;
                count++;
            }
            Console.WriteLine($"Número de digitos = {count}");


        }

        //Exercício 8 - Análise de um programa

        




        

             


    }




















}

