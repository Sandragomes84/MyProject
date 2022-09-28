using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercices
{
    internal class Modulo5
    {

        //Exercício 1


        public static void Calculos()
        {
            bool op1 = 2 == 3;
            bool op2 = 8 != 12;
            bool op3 = 14 > 15;
            bool op4 = "true" == "false";
            bool op5 = 'a' == 'a';
            bool op6 = 'a' == 'b';
            bool op7 = 2 < 3 && 3 > 4;
            bool op8 = 2 > 3 || 3 > 4;
            bool op9 = !(2 < 3 || 3 > 4);


            Console.WriteLine($"O resultado da primeira operação é: {op1}");
            Console.WriteLine($"O resultado da segunda operação é: {op2}");
            Console.WriteLine($"O resultado da terceira operação é: {op3}");
            Console.WriteLine($"O resultado da quarta operação é: {op4}");
            Console.WriteLine($"O resultado da quinta operação é: {op5}");
            Console.WriteLine($"O resultado da sexta operação é: {op6}");
            Console.WriteLine($"O resultado da sétima operação é: {op7}");
            Console.WriteLine($"O resultado da oitava operação é: {op8}");
            Console.WriteLine($"O resultado da nona operação é: {op9}");


        }


        //Exercício 2 - Sérgio retirou este exercício




        //Exercício 3

        public static void ParPositivo(int n)
        {

            if ((n % 2 == 0) && (n >= 0))
            {
                Console.WriteLine("Este é um número par e positivo");
            }

            else
            {
                Console.WriteLine("Este número NÃO é par e positivo");
            }
        }


        //Exercicio 4


        public static void PSalarioSemanal()
        {
            Console.WriteLine("Digite, por favor, o número de horas trabalhadas na semana.");
            double horasTrabalho = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite, por favor, o valor referente ao salário/hora.");
            double salarioHora = double.Parse(Console.ReadLine());


            double horasExtra = (horasTrabalho - 40) * (2 * salarioHora);


            double salariototal = horasExtra + ((salarioHora * 40));


            if (horasTrabalho <= 40)
            {
                double salarioSemanal = horasTrabalho * salarioHora;
                Console.WriteLine($"O salário semanal é de {salarioSemanal.ToString("F2")} Euros");

            }
            else
            {

                Console.WriteLine($"O salário semanal é de {salariototal.ToString("F2")} Euros");

            }



        }


        //Exercício 5

        public static void OMaior()
        {

            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número:");
            int n3 = int.Parse(Console.ReadLine());


            if ((n1 > n2) && (n1 > n3))
            {

                Console.WriteLine($" O número {n1}, é o maior!");

            }
            else if ((n2 > n3) && (n2 > n1))
            {
                Console.WriteLine($" O número {n2}, é o maior!");
            }
            else
            {
                Console.WriteLine($" O número {n3}, é o maior!");

            }

        }

        //Exercício 6


        public static void NotaFinal(double nota1, double nota2)
        {

            double notaMediaFinal = (nota1 + nota2) / 2;

            if (notaMediaFinal >= 8)
            {
                Console.WriteLine("Formando Aprovado!");
            }
            else
            {
                Console.WriteLine("Formando não aprovado!");
            }



        }



        //Exercício 7

        public static void OpTernario()
        {

            Console.WriteLine("Digite a sua nota:");
            double nota = double.Parse(Console.ReadLine());

            string positive = "Parabéns!";
            string negative = "Ups, deve marcar novo exame!";

            var resultado = (nota > 10) ? positive : negative;

            Console.WriteLine(resultado);


        }

        //Exercicio 8

        public static void AnoBissexto(int ano)
        {

            if (ano % 4 == 0 && ano % 100 != 0)
            {
                Console.WriteLine(" Este é um ano Bissexto!");
            }
            else
            {
                Console.WriteLine("Este é um ano Comum!");
            }

            Console.ReadLine();


        }

        //Exercicio 9

        public static void OrdemCres()
        {
            Console.WriteLine(" Digite, por favor, o primeiro número:");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine(" Digite, por favor, o segundo número:");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine(" Digite, por favor, o terceiro número:");
            double n3 = double.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                double aux = n1;
                n1 = n2;
                n2 = aux;

            }
            if (n1 > n3)
            {
                double aux = n1;
                n1 = n3;
                n3 = aux;

            }
            if (n2 > n3)
            {
                double aux = n2;
                n2 = n3;
                n3 = aux;

            }

            Console.WriteLine($" Os valores ordenados de forma crescente: {n1}, {n2}, {n3} ");
        }

        //Exercício 10

        public static void PrecoporArtigo()
        {
            Console.WriteLine(" Digite o número que corresponde ao artigo:\n 1 - Bens essenciais\n 2 - Bens de luxo\n 3 - Outros ");

            int opcaoEscolhida = int.Parse(Console.ReadLine().ToLower().Trim());

            Console.WriteLine("Digite o preço do produto, sem iva:");

            double precoSemIva = double.Parse(Console.ReadLine().ToLower().Trim());



            if (opcaoEscolhida == 1)
            {

                double precoFinal = ((double)precoSemIva * 0.05) + precoSemIva;

                Console.WriteLine($"O valor total a pagar é: {precoFinal.ToString("F2")}");
            }
            else if (opcaoEscolhida == 2)
            {

                double precoFinal = ((double)precoSemIva * 0.3) + precoSemIva;

                Console.WriteLine($"O valor total a pagar é: {precoFinal.ToString("F2")}");

            }
            else if (opcaoEscolhida == 3)
            {
                double precoFinal = ((double)precoSemIva * 0.2) + precoSemIva;

                Console.WriteLine($"O valor total a pagar é: {precoFinal.ToString("F2")}");
            }
            else
            {
                Console.WriteLine("A opção escolhida não é válida!");
            }


        }

        // Exercício 11

        public static void Triangulo(int a, int b, int c)
        {

            if ((a + b) > c && (a + c) > b && (b + c) > a)
            {
                Console.WriteLine("Os três lados formam um triângulo!");

                if (a == b && a == c)
                {
                    Console.WriteLine("É um triângulo Equilátro!");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("É um triângulo Esósceles!");
                }
                else
                {
                    Console.WriteLine("É um triângulo Escaleno!");
                }


            }
            else
            {
                Console.WriteLine("As três medidas apresentadas, NÃO formam um triângulo!");
            }

        }

        // Exercício 12

        public static void ReturnString(int num)
        {

            switch (num)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("Um");
                    break;
                case 2:
                    Console.WriteLine("Dois");
                    break;
                case 3:
                    Console.WriteLine("Três");
                    break;
                case 4:
                    Console.WriteLine("Quatro");
                    break;
                case 5:
                    Console.WriteLine("Cinco");
                    break;
                case 6:
                    Console.WriteLine("Seis");
                    break;
                case 7:
                    Console.WriteLine("Sete");
                    break;
                case 8:
                    Console.WriteLine("Oito");
                    break;
                case 9:
                    Console.WriteLine("Nove");
                    break;

                default:
                    Console.WriteLine("Valor não aceite!");
                    break;
            }
        }


        public static void NumExtenso(int inicial, int final)
        {
            for (int i = 0; i <= final; i++)
            {
                Console.WriteLine($"O número {i}, por extenso é:");

                ReturnString(i);
            }

        }

        //Exercicio 13

        public static void VogalouConsoante()
        {

            Console.WriteLine("Digite uma letra minúscula: ");
            char n = char.Parse(Console.ReadLine().ToLower().Trim());


            switch (n)
            {
                case 'a':
                    Console.WriteLine("A letra digitada é uma vogal!");
                    break;
                case 'e':
                    Console.WriteLine("A letra digitada é uma vogal!");
                    break;
                case 'i':
                    Console.WriteLine("A letra digitada é uma vogal!");
                    break;
                case 'o':
                    Console.WriteLine("A letra digitada é uma vogal!");
                    break;
                case 'u':
                    Console.WriteLine("A letra digitada é uma vogal!");
                    break;
                default:
                    Console.WriteLine("A letra digitada é uma Consoante!");
                    break;
            }
        }

        //Exercício 14


        public static void Signos()
        {

            int dia = 0;
            int mes = 0;

            Console.WriteLine("Digite o NÚMERO correspondente ao mês do seu nascimento [MM]: ");
            mes = int.Parse(Console.ReadLine().ToLower().Trim());

            Console.WriteLine("Digite o dia do seu nascimento [DD]:");
            dia = int.Parse(Console.ReadLine().ToLower().Trim());


            switch (mes)
            {
                case 1:
                    if (dia < 21)
                        Console.WriteLine("O teu signo é Capricórnio!");
                    else
                    {
                        Console.WriteLine("O teu signo é Aquário!");
                    }
                    break;
                case 2:
                    if (dia < 21)
                        Console.WriteLine("O teu signo é Aquário!");
                    else
                    {
                        Console.WriteLine("O teu signo é Peixes!");
                    }
                    break;
                case 3:
                    if (dia < 21)
                        Console.WriteLine("O teu signo é Peixes!");
                    else
                    {
                        Console.WriteLine("O teu signo é Carneiro!");
                    }
                    break;
                case 4:
                    if (dia < 21)
                        Console.WriteLine("O teu signo é Carneiro!");
                    else
                    {
                        Console.WriteLine("O teu signo é Touro!");
                    }
                    break;
                case 5:
                    if (dia < 21)
                        Console.WriteLine("O teu signo é Touro!");
                    else
                    {
                        Console.WriteLine("O teu signo é Gémeos!");
                    }
                    break;
                case 6:
                    if (dia < 21)
                        Console.WriteLine("O teu signo é Gémeos!");
                    else
                    {
                        Console.WriteLine("O teu signo é Carneiro!");
                    }
                    break;
                case 7:
                    if (dia < 21)
                        Console.WriteLine("O teu signo é Carneiro!");
                    else
                    {
                        Console.WriteLine("O teu signo é Leão!");
                    }
                    break;
                case 8:
                    if (dia < 21)
                        Console.WriteLine("O teu signo é Leão!");
                    else
                    {
                        Console.WriteLine("O teu signo é Virgem!");
                    }
                    break;
                case 9:
                    if (dia < 21)
                        Console.WriteLine("O teu signo é Virgem!");
                    else
                    {
                        Console.WriteLine("O teu signo é Balança!");
                    }
                    break;
                case 10:
                    if (dia < 21)
                        Console.WriteLine("O teu signo é Balança!");
                    else
                    {
                        Console.WriteLine("O teu signo é Escorpião!");
                    }
                    break;
                case 11:
                    if (dia < 21)
                        Console.WriteLine("O teu signo é Escorpião!");
                    else
                    {
                        Console.WriteLine("O teu signo é Sagitário!");
                    }
                    break;
                case 12:
                    if (dia < 21)
                        Console.WriteLine("O teu signo é Sagitário!");
                    else
                    {
                        Console.WriteLine("O teu signo é Capricórnio!");
                    }
                    break;

                default:
                    Console.WriteLine("Erro ao digitar!");
                    break;

            }

        }



    }


}    




       

        







    



    
