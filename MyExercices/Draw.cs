
using System;

namespace MyExercices;

public static class NewProject
{

    enum Opcao { drawline = 1, drawcolumn = 2, createtriangle = 3, multiplicationtable = 4, clear = 5, exit = 6 }


    public static void Start()
    {

        Console.WriteLine("Let's go!\nSelecione uma das opções abaixo, digitando o número corespondente[1,6]:");

        Console.WriteLine("1 - DrawLine (dl)\n2 - DrawColumn (dc)\n3 - Createtriangle (tri)\n4 - MultiplicationTable (mt)\n5 - Clear (c)\n6 - Exit (e)");


        int index = int.Parse(Console.ReadLine().ToLower().Trim());

        Opcao opcaoSelecionada = (Opcao)index;

        if (index >= 0 && index <= 6)
        {
            Console.WriteLine("Você selecionou a opção:" + (int)opcaoSelecionada + "," + opcaoSelecionada + "!");
        }
        else
            Console.WriteLine("Você selecionou a opção:" + (int)opcaoSelecionada);





        switch (opcaoSelecionada)
        {
            case Opcao.drawline:
                DrawLine();
                break;
            case Opcao.drawcolumn:
                DrawColumn();
                break;
            case Opcao.createtriangle:
                CreateTriangle();
                break;
            case Opcao.multiplicationtable:
                MultiplicationTable();
                break;
            case Opcao.clear:
                Clear();
                break;
            case Opcao.exit:
                Exit();
                break;
            default:
                Console.WriteLine("A opção escolhida não é válida!");
                Console.WriteLine();
                Console.WriteLine("As opções disponíveis são: " + " 1-" + Opcao.drawline + ", 2-" + Opcao.drawcolumn + ", 3-" + Opcao.createtriangle
                    + ", 4-" + Opcao.multiplicationtable + ", 5-" + Opcao.clear + "e 6-" + Opcao.exit);
                break;


        }

    }




    public static void DrawLine()
    {
        int numChars;
        char op;

        Console.WriteLine("Digite a quantidade de linhas que pretende: ");
        numChars = int.Parse(Console.ReadLine());
        op = '#';
        int count = 0;


        while (numChars > count)
        {
            Console.WriteLine(op);

            count++;
        }
    }


    public static void DrawColumn()
    {
        char op = '#';

        Console.WriteLine("Digite a quantidade de Colunas que pretende:");
        int numChars = int.Parse(Console.ReadLine());
        int count = 0;

        while (numChars > count)
        {
            Console.Write(op);

            count++;
        }
    }




    public static void CreateTriangle()
    {
        int largura;

        Console.WriteLine("Digite o número correspondente à altura do triangulo:");
        int altura = int.Parse(Console.ReadLine());


        for (int i = 1; i <= altura; i++)
        {
            for (largura = altura - i; largura > 0; largura--)
            {
                Console.Write(" ");
            }

            for (largura = 1; largura < i; largura++)
            {
                Console.Write("**");
            }
            Console.WriteLine("*");
        }



    }


    public static void MultiplicationTable()
    {
        Console.WriteLine("Digite o numero correspondente à tabuada:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            int result = i * n;
            Console.WriteLine(i + " x " + n + " = " + result);

        }

    }


    public static void Clear()
    {
        Console.Read();
        Console.Clear();
    }


    public static void Exit()
    {
        Console.WriteLine("Saiu do programa! ");
    }





    public static void DrawSquare()
    {

        Console.WriteLine("Digite o numero correspondente ao lado do quadrado!");
        int lado = int.Parse(Console.ReadLine());

        int x;



        Console.WriteLine(" ");
        for (int i = 1; i <= lado; i++)
        {
            for (x = 1; x <= lado; x++)
            {
                Console.Write("# ");
            }

            Console.WriteLine(" ");
        }

    }
}
























