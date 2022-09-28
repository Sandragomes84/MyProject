using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;

namespace MyExercices
{
    internal class Modulo4
    {

                                //Exercício 1

        public static void AreaRetangulo()
        {
            Console.WriteLine("Digite a largura do retangulo, em cm:");
            double largura;
            double.TryParse(Console.ReadLine(), out largura);


            Console.WriteLine("Digite a altura do retangulo, em cm:");
            double altura;
            double.TryParse(Console.ReadLine(), out altura);

            double area = altura * largura;

            Console.WriteLine($"A área do retangulo é de: {area} cm2");

            
        }

        

                                  //Exercício 2

        public static void ResultExpressoes()
        {

            int soma = 15 + 2;
            double divisão = (double)15 / 2;
            double resto = (double)15 % 2;

            Console.WriteLine(soma);
            Console.WriteLine(divisão);
            Console.WriteLine(resto);


        }



                                   //Exercício 3
        
        public static void ArrendondaNum()
        {

            double n1 = 8.456796;
            double n2 = 9.8;
            double n3 = 6;

            Console.WriteLine($"{n1.ToString("F3")}, {n2.ToString("F3")}, {n3.ToString("F3")}");
            Console.WriteLine($"{n1.ToString("F1")}, {n2.ToString("F1")}, {n3.ToString("F1")}");
            Console.WriteLine($"{n1.ToString("F0")}, {n2.ToString("F0")}, {n3.ToString("F0")}");


        }

      

                                //Exercício 4


        public static void Percentagem()
        {
            double n1Percent = 8.456796;
            double n2Percent = 9.8;
            double n3Percent = 6;

            Console.WriteLine(n1Percent.ToString("P"));
            Console.WriteLine(n2Percent.ToString("P"));
            Console.WriteLine(n3Percent.ToString("P"));


        }
             

                                //Exercício 5



        public static void ParteInteira()
        {

            Console.WriteLine("Por favor, digite um numero:");

            double numDigitado = double.Parse(Console.ReadLine());

            Console.WriteLine("O número inteiro obtido é: ");

            Console.WriteLine(Math.Truncate(numDigitado));



        }
                    


                                // Exercício 6


        public static void NomeApelido()
        {

            Console.WriteLine(" Digite, por favor, o seu primeiro nome e o seu apelido:");

            string nomeCompleto = Console.ReadLine();

            Console.WriteLine($"{nomeCompleto}, acabou de ganhar o 1ª prémio.Parabéns!");


        }
                    




                            //Exercício 7

        public static void MediaAritemetica()
        {
            Console.WriteLine("Por favor, digite o 1º valor(número inteiro)");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor, digite o 2º número inteiro:");
            int n2 = int.Parse(Console.ReadLine());

            int media = (n1 + n2) / 2;
            Console.WriteLine("A média aritmética dos dois valores é de :" + media);


        }
                   


                            // Exercício 8

        public static void ConvertDolarEuro()
        {

            Console.WriteLine("Por favor, digite o valor em USD:");


            double valoraConverter = double.Parse(Console.ReadLine());

            double valorConvertidoEuro = valoraConverter / 1.1579;

            Console.WriteLine($"A quantia inserida em USD equivale a {valorConvertidoEuro} euros.");



        }

            

                                     //Exercício 9


        public static void ConvertFahemCelsius()
        {

            Console.WriteLine("Por favor, insira a temperatura em graus Fahrenheit:");

            double grausFht = double.Parse(Console.ReadLine());

            var grausCelsius = 5.0 / 9.0 * (grausFht - 32);

            Console.WriteLine($"O número inserido corresponde a: {grausCelsius.ToString("F1")}");

        }

                    


                                    //Exercício 10

        public static void PrecocomIva()
        {

            Console.WriteLine("Insira o valor base do produto:");

            double precoBase, precoVenda;

            precoBase = double.Parse(Console.ReadLine());

            precoVenda = precoBase + (precoBase + 0.23);

            Console.WriteLine($" O valor de venda ao público é de {precoVenda.ToString("F2")}");


        }
                   



                                // Exercício 11

        public static void ValorFinalProduto()
        {

            double precoBase, percentagemIva, valorIva, valorFinal;


            Console.WriteLine("Insira o valor base do produto:");
            precoBase = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a percentagem relativa ao IVA:");
            percentagemIva = double.Parse(Console.ReadLine());

            valorIva = precoBase * percentagemIva / 100;

            valorFinal = precoBase + valorIva;

            Console.WriteLine($" O valor final do produto é de: {valorFinal.ToString("F2")}");

        }





                                //Exercício 12

        public static void ConvertSeconds()
        {

            Console.WriteLine("Digite o número corrrespondente ao total de segundos:");
            int totalSegundos = int.Parse(Console.ReadLine());

            int horas, minutos, segundos, resto;

            horas = totalSegundos / 3600;
            resto = totalSegundos % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine($"O número digitado, equivale a {horas} horas, {minutos} minutos, e {segundos} segundos.");


        }
                   



                                //Exercício 13

        public static void DespesaMediaDia()
        {
            
            double despesaInicial = 100;
            double despesaDiaria = despesaInicial;
            double incremento = 1.2;
            double despesaAcumulada= despesaInicial;

            for (int i = 1; i <= 3; i++)
            {
                despesaDiaria = despesaDiaria * incremento;

                
                despesaAcumulada = despesaDiaria + despesaAcumulada;
            }


            double despesaMediaDiaria = (double)despesaAcumulada / 4;


            Console.WriteLine($" A despesa média diária foi de: {despesaMediaDiaria.ToString("F2")} euros ");


        }


                            //Exercício 14
                
        public static void SalarioAuferido()
        {

            double x, y, p, v;

            Console.WriteLine(" Digite o Salário Base: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine(" Digite o valor da Comissão: ");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine(" Digite a Percentagem sobre o valor das vendas: ");
            p = double.Parse(Console.ReadLine());
            Console.WriteLine(" Digite o valor das Vendas: ");
            v = double.Parse(Console.ReadLine());


            double salarioAuferido = x + y + ((p / 100) * v);


            Console.WriteLine($" O salário auferido no mês é de: {salarioAuferido} Euros");


        }

                            // Exercício 15

        public static void TrocaValor()
        {

            int a = 10;
            int b = 20;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($" Valor de a = {a} e Valor de b = {b}");

        }


                            //Exercício 16


        public static void NumerosProximos()
        {

            Console.WriteLine("Por favor, digite um número inteiro:");

            int n = int.Parse(Console.ReadLine());

            int nMenosUm = n - 1;
            int nMaisUm = n + 1;

            Console.WriteLine($"O antecessor ao número digitado é: {nMenosUm} e o sucess or é: {nMaisUm}");


        }



    }


    
}






















    














