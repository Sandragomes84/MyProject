// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Globalization;
using System.IO.Pipes;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using MyExercices;

namespace MyExercices
{

    internal class Program
    {
        
        static void Main(string[] args)
        {
            int nAlunos;
            Console.WriteLine("Quantos Alunos?");
            int.TryParse(Console.ReadLine(), out nAlunos);
            
            int[] notas = new int[nAlunos];

            
            
            //Media

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Insira a nota " + (i + 1));
                int nota = int.Parse(Console.ReadLine());
                notas[i] = nota;
                
            }

            int sum = 0;

            for (int i = 0; i < nAlunos; i++)
            {
                sum = sum + notas[i];
                
            }
           
            var avg = sum / nAlunos;
            Console.WriteLine($"A nota média é de: {avg.ToString("F2")} valores");


            // MAX

            int maior = notas[0];
            int posicaoMaior = 0;

            for (int i = 0; i < nAlunos; i++)
            {
                if (notas[i] > maior)
                {
                    maior = notas[i];
                    posicaoMaior = i;
                }
            }

            Console.WriteLine($" O valor máximo é: {maior.ToString("F2")}, e está na posição {posicaoMaior}");
            


            //MIN

            int menor = notas[0];
            int posicaoMenor = 0;

            for (int i = 0; i < nAlunos; i++)
            {
                if (notas[i] < menor)
                {
                    menor = notas[i];
                    posicaoMenor = i;
                }
            }

            Console.WriteLine($" O valor mínimo é: {menor.ToString("F2")}, e está na posição {posicaoMenor}");

        }

    }




}

    




































