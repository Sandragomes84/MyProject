using System.Collections;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace MyExercices.Utilities;

public static class Vetor
{

    //Min
    public static void Min(int[] v1)
    {
        var menor = v1[0];

        for (int i = 1; i < v1.Length; i++)
        {
            if (v1[i] < menor)
            {
                menor = v1[i];

            }

        }
        Console.WriteLine($"Valor mínimo = {menor}");
    }


    //Max
    public static void Max(int[] v)
    {
        if (v == null || v.Length == 0) { Console.WriteLine($" 0 "); }

        var maior = v[0];

        for (int i = 1; i < v.Length; i++)
        {
            if (v[i] > maior)
            {
                maior = v[i];
            }
        }
        Console.WriteLine($"Valor máximo = {maior}");

    }

    //AVG
    public static void ValorMedio(int[] v)
    {
        double sum = 0;

        for (int i = 0; i < v.Length; i++)
        {
            sum += v[i];

        }

        var avg = sum / v.Length;
        Console.WriteLine($" A media é = {avg}");

    }


    //Concat
    public static int[] Concat(int[] v1, int[] v2)
    {

        int tam = v1.Length + v2.Length;
        var result = new int[tam];

        for (int i = 0; i < v1.Length; i++)
        {
            result[i] = v1[i];
        }

        for (int i = 0; i < v2.Length; i++)
        {
            result[v1.Length + i] = v2[i];
        }
        return result;

    }


    //Print
    public static void Print(int[] v1)
    {
        Console.WriteLine("[");
        foreach (var item in v1)
        {
            Console.Write(item);
            Console.WriteLine(", ");
        }
        Console.WriteLine("]");
    }

    //Print 2
    public static void Print2(int[] v1)
    {
        var str = $"[{string.Join(", ", v1)}]";
        Console.WriteLine(str);

    }


    //Print 3
    public static void Print3(int[] v1)
    {
        var str = $"[{string.Join(", ", v1)}]";
        Console.WriteLine(str);

    }



    //Reverse

    public static int[] Reverse(int[] v)
    {
        var reversed = new int[v.Length];

        var j = v.Length - 1;

        foreach (var item in v)
        {
            reversed[j--] = item;

        }

        return reversed;


    }


    //Randomize
    public static void Randomize(int[] v)
    {

        Random r = new Random();


        for (int i = 0; i < v.Length; i++)
        {
          

        }



    }

    //GetRandomElement

    public static void GetRandom(int[] v)
    {
        Random r = new Random();

        int posicao = r.Next(v.Length);

        int element = v[posicao];

        Console.WriteLine(element);
    }



    //Multiply

    public static void Multiply(int[] vet)
    {
        int prod;

        foreach (int item in vet)
        {
            prod = item * 8;
            Console.Write($"[{prod}] ");
        }


    }



    //Sum

    public static void Sum(int[] v1)
    {
        int soma = 0;

        for (int i = 0; i < v1.Length; i++)
        {
            soma = soma + v1[i];
        }
        Console.Write($"[{soma}] ");

    }


    //ADD + 5

    public static void Add5(int[] v)
    {
        int add;

        foreach (int item in v)
        {
            add = item + 5;
            Console.Write($"[{add}] ");
        }

    }


    //ADD

    public static void Add(int[] v1, int[] v2)
    {
        int v3 = 0;

        for (int i = 0; i < v1.Length; i++)
        {
            v3 = v1[i] + v2[i];

            var str = $"[{string.Join(", ", v3)}]";
            Console.Write(str);

        }

    }



    // First

    public static void First(int[] x)
    {
        int count = 100;
        for (int i = 0; i < x.Length; i++)
        {
            x[i] = count;
            count++;

            var str = $"[{string.Join(", ", x)}]";
            Console.WriteLine(str);

        }

    }

}


