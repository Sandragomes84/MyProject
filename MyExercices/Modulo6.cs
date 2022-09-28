using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyExercices
{
    internal class Modulo6
    {

        //Exercício 1

        public static void Drawrectangulo()
        {

            Console.WriteLine("Digite a medida do comprimento do retangulo:");
            int comprimento = int.Parse(Console.ReadLine().Trim());


            Console.WriteLine("Digite a medida da largura do retangulo:");
            int largura = int.Parse(Console.ReadLine().Trim());


            Console.WriteLine(" ");

            for (int x = 1; x <= comprimento; x++)
            {
                for (int y = 1; y <= largura; y++)
                {
                    Console.Write("0 ", y);
                }

                Console.WriteLine(" ");
            }


        }

        //Exercício 2

        public static void NumImpar()
        {

            int y = 50;

            Console.WriteLine("Os números ímpares, são:");

            for (int i = 0; i <= y; i++)
            {

                if (i % 2 != 0)
                {
                    Console.WriteLine($"{i}");
                }

            }

        }


        //Exercício 3

        public static void Incremento3()
        {
            int y = 100;
            int i = 4;
            int count = 0;



            for (i = 4; i < y; i = i + 3)
            {

                count = count + i;

                Console.WriteLine(i);


            }

        }


        //Exercício 4 

        public static void IntervaloNum(int x, int y)
        {

            for (int i = x + 1; i < y; i++)
            {
                Console.WriteLine(i);

            }

        }


        //Exercicio 5

        public static void IntervaloNum2(int x, int y)
        {
            int i = x;
            int Count = 0;

            for (i = x + 1; i < y; i++)
            {
                Console.WriteLine(i);

                Count = Count + i;
            }

            Console.WriteLine("A Soma de todos os números é:" + Count);
        }



        //exercício 6

        public static void MaxMin()
        {

            int maximo, minimo, numero;


            Console.WriteLine("Introduza um número inteiro:");
            numero = int.Parse(Console.ReadLine());
            maximo = numero;
            minimo = numero;


            while (numero != 0)
            {

                Console.WriteLine("Introduza o próximo número:");
                numero = int.Parse(Console.ReadLine());
                if (numero != 0)
                {
                    if (maximo < numero) maximo = numero;
                    if (minimo > numero) minimo = numero;

                }
            }

            Console.WriteLine("O valor máximo é = " + maximo);
            Console.WriteLine("O valor mínimo é = " + minimo);

        }

        // Exercício 7

        public static void MaxMinSum()
        {

            int maior, menor, numero, soma;


            Console.WriteLine("Introduza um número inteiro:");
            numero = int.Parse(Console.ReadLine());

            soma = 0;

            while (numero != 0)
            {

                Console.WriteLine("Introduza o próximo número:");
                numero = int.Parse(Console.ReadLine());
                if (numero > 0)
                {
                    soma = soma + numero;


                }
            }

            Console.WriteLine($"A soma dos números inteiros positivos é: {soma}");

        }

        //Exercício 8

        public static void Altura(int n)
        {
            double max, min, conta, soma;
            conta = 1;

            Console.WriteLine($"Digite a altura do funcionário {conta}, em centímetros:");
            double altura = double.Parse(Console.ReadLine());

            max = altura;
            min = altura;
            soma = 0;

            while (conta > 0 && conta <= n)
            {
                conta = conta + 1;
                Console.WriteLine($"Digite a altura do funcionário {conta}, em centímetros:");
                altura = double.Parse(Console.ReadLine());
                soma = soma + altura;


                if (conta > 1 && conta <= n)
                {
                    if (max < altura) max = altura;
                    if (min > altura) min = altura;

                }

            }


            Console.WriteLine($"A altura do funcionário mais baixo é: {min.ToString("F2")} cm");
            Console.WriteLine($"A altura do funcionário mais alto é: {max.ToString("F2")} cm");
            Console.WriteLine("A altura média dos funcionários é: " + (double)(soma / n) + "cm");

        }


        //Exercicio 9

        public static void SomarDigitos(int n)
        {

            int numero, digito;
            int soma = 0;

            Console.WriteLine("Digite um número inteiro:");
            numero = Convert.ToInt32(Console.ReadLine());


            while (numero > 0)
            {

                digito = numero % 10;
                soma = soma + digito;
                numero = numero / 10;

            }
            Console.WriteLine("A Soma dos digitos é = " + soma);

            Console.Read();
        }

        //Exercício 10 - Analisar programa

        //Exercício 11


        public static void Aleatorio()
        {

            int n;

            Random rnd = new Random();
            int numerosecreto = rnd.Next(1, 6);
            int count = 0;

            do
            {
                Console.WriteLine("Introduza um número: ");
                n = Convert.ToInt32(Console.ReadLine());
                count = count + 1;
            }
            while(numerosecreto != n);
            Console.WriteLine($" Acertou com {count} tentativas");

        }



        //Exercício 12

        public static void Idade(int n)
        {
           
            int conta, soma, idade;
          
            conta = 1;

            Console.WriteLine($"Digite a idade do funcionário {conta}:");
            idade = int.Parse(Console.ReadLine());
                      
            soma = 0;

            while (conta >= 1 && conta < n)
            {
                conta = conta + 1;
                Console.WriteLine($"Digite a idade do funcionário {conta}:");
                idade = int.Parse(Console.ReadLine());
                soma = soma + idade;
   
            }
            
            double media = soma / (n-1);

            Console.WriteLine("A idade média dos funcionários é de : " + media + "anos!");

            
            if (media > 0 && media <= 25)
            {
                Console.WriteLine("A maioria dos funcionários  são JOVENS! ");
            }
            else if(media > 25 && media <= 60)
            {
                Console.WriteLine("A maioria dos funcionários são ADULTOS! ");

            }
            else
            {
                Console.WriteLine("A maioria dos funcionários são IDOSOS! ");

            }


        }


        // Exercício 13

        public static void PrecoNoite(int x)
        {
            Console.WriteLine("Introduza o número de noites que dormiu no hotel:");
            int n = int.Parse(Console.ReadLine());
                                   
            int i = 1;
            double soma = 0;

            double precoDiario = 50;
            double ValoraPagar = 50;
            double precoFinal = precoDiario;

            for (i = 1; i <= n; i++)
            {
                ValoraPagar = precoDiario / i;

                precoFinal = ValoraPagar;

                soma = soma + ValoraPagar;

                Console.WriteLine($"O preço de {i} noite/s é de: {precoFinal.ToString("F2")} Euros");
  
            }

            Console.WriteLine($"O preço total relativo às {n} noite/s é de: {soma.ToString("F2")} Euros");
        }




        //Exercício 14


        public static void TaxasCrescimento()
        {
            
            double PA = 80000;
            double taxaCrescimentoA = 1.03;
            double PB = 200000;
            double taxaCrescimentoB = 0.015;
            double tempo = 0;

            
            while(PA <= PB)
            {

                 PA= (PA * taxaCrescimentoA);

                 PB= PB + (PB * taxaCrescimentoB);


                 tempo ++;

      
            }

            Console.WriteLine(" A população do País A, demorou " + tempo.ToString("F2") + " anos, para igualar a população do pais B");

            Console.Read();

        }








    }

}