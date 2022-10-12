

using System.Runtime.Serialization;

namespace MyExercices;

internal class Modulo8
{

    //Exercício 1
    public static void CreateV(int[] v, int n)
    {
        int[] vet = new int[n];

        for (int i = 0; i < vet.Length; i++)
        {
            vet[i] = i;
            var str = $"[{string.Join(", ", vet[i])}]";
            Console.Write(str + " ");
        }
        Console.WriteLine();

        vet[3] = 20;
        vet[9] = 30;

        Console.WriteLine($" O novo valor do índice 3 é: [{vet[3]}]\n");
        Console.WriteLine($" O novo valor do índice 9 é: [{vet[9]}]");

        Console.Read();
    }

    //Exercício 2

    public static void MultiplySumAvg(int[] v, int n)
    {
        var produto = 1;

        for (int i = 0; i < v.Length; i++)
        {

            produto = produto * v[i];

        }
        Console.WriteLine("A multiplicação do vetor é: " + produto);
        Console.WriteLine();

        double soma = 0.0;

        for (int i = 0; i < v.Length; i++)
        {

            soma = soma + v[i];

        }
        Console.WriteLine("A soma do vetor é: " + soma.ToString("F2"));
        Console.WriteLine();

        double avg = soma / n;
        Console.WriteLine("O valor médio do vetor é: " + avg.ToString("F2"));
        Console.Read();
    }


    //Exercício 3

    public static void Find(int[] v, int n)
    {
        int maior = v[0];
        int iMaior = 0;
        int menor = v[0];
        int iMenor = 0;

        for (int i = 0; i < v.Length; i++)
        {
            if (v[i] > maior)
            {
                maior = v[i];
            }

            if (v[i] > v[iMaior])
            {
                iMaior = i;
            }

            if (v[i] < menor)
            {
                menor = v[i];
            }

            if (v[i] < v[iMenor])
            {
                iMenor = i;
            }
        }
        Console.WriteLine($"O maior valor é:{maior} e encontra-se no índice: {iMaior}");
        Console.WriteLine($"O menor valor é:{menor} e encontra-se no índice: {iMenor}");
    }

    //Exercício 4

    public static void VetForVar(int[] v, int n)
    {
        var varInteira = 0;

        foreach (var item in v)
        {
            varInteira = item;
            Console.Write($" {varInteira} ");
        }
        Console.Read();

    }
    //Exercício 5

    public static void VetMax100(int[] v)
    {
        Console.WriteLine("Pode inserir um máximo de 100 números Reais!\n Quantos números pretende inserir?");
        int n = int.Parse(Console.ReadLine());
        int nR;
        int soma = 0;
        int[] v1 = new int[n];

        for (int i = 0; i < v1.Length; i++)
        {
            if (n > 100)
            {
                Console.WriteLine("Número inválido. Não pode inserir mais de 100 números");
                break;
            }
            else
            {
                Console.WriteLine($"Por favor, insira o número {i + 1}: ");
                nR = int.Parse(Console.ReadLine());

                v1[i] = nR;
                soma = soma + nR;
            }
        }
        Console.WriteLine($" O resultado da soma é: {soma} ");
        Console.Read();
    }


    //Exercício 6
    public static void ReadNumbers(int[] v)
    {
        Console.WriteLine("Digite, por favor, qual o número que pretende pesquisar no vetor: ");
        int n = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 0; i < v.Length; i++)
        {
            if (v[i] == n)
            {
                count++;
                Console.WriteLine($"O número {n} foi encontrado {count} vez(es)!");
            }
        }

        if (count == 0)
        {
            Console.WriteLine(" Número não encontrado!! \n -1 ");
        }

    }

    public static void VetAreEquals(int[]v1, int[] v2)
    {
        bool equal= true;

        for (int i = 0; i < v1.Length; i++)
        {
            for (i  = 0; i < v2.Length; i++)
            {
                if(v1[i] == v2[i])
                {
                    equal = true;
                }
                else
                {
                    equal = false;
                }
            }
            Console.WriteLine(equal);
            Console.Read();
        }
    }


    //Exercício 8

    public static void MatrixRead()
    {
        Console.WriteLine("Digite o número de linhas e colunas!");
        string[] s1 = Console.ReadLine().Split(' ');
        int m = int.Parse(s1[0]);
        int n = int.Parse(s1[1]);

        int[,] matrix = new int[m, n];

        Console.WriteLine("Digite 3 números em cada linha!");

        for (int i = 0; i < m; i++)
        {
            string[] s = Console.ReadLine().Split(' ');

            for (int j = 0; j < n; j++)
            {
                matrix[i,j]= int.Parse(s[j]);
            }
        }

        Console.WriteLine();

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.ReadLine();

    }












}





