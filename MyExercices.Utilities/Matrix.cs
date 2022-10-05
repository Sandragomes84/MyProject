
using System;

namespace MyExercices.Utilities;

public class Matrix
{

    public static void Print(string[,] mat)
    {
        int lines = mat.GetLength(0);
        int cols = mat.GetLength(1);

        for (int i = 0; i < lines; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                var p = mat[i, j] != null ? mat[i, j] : " ";

                Console.Write(p + " ");
            }

            Console.WriteLine();

        }

    }

    public static void Print2(string[,] mat)
    {
        int lines = mat.GetLength(0);
        int cols = mat.GetLength(1);

        for (int i = 0; i < lines; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine(mat[i, j]);
            }
            Console.WriteLine();

        }

    }


    public static void Init(string[,] mat)
    {
        int lines = mat.GetLength(0);
        int cols = mat.GetLength(1);
        var count = 0;

        for (int i = 0; i < lines; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                mat[i, j] = (++count).ToString();

                Console.Write(mat[i, j] + " ");
            }

            Console.WriteLine();
        }

    }


    public static void Initialize(string[,] m, char c)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {

            for (int j = 0; j < m.GetLength(1); j++)
            {

                m[i, j] = c.ToString();
                m[i, j] = (i == 0) ? m[i, j] : " ";

                Console.WriteLine(m[i, j] + " ");
            }
            Console.WriteLine();

        }

    }

    public static void DrawSquare(string[,] m, char c)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {

            for (int j = 0; j < m.GetLength(1); j++)
            {
                Console.Write(m[i, j] = c.ToString() + " ");
            }
            Console.WriteLine();
        }
    }



    public static void Diagonal1(string[,] m, char c)
    {
     
        for (int i = 0; i < m.GetLength(0); i++)
        {

            for (int j = 0; j < m.GetLength(1); j++)
            {
                m[i, j] = c.ToString();
                m[i, j] = (i == j) ? m[i, j] : " ";

                Console.Write(m[i, j] + " ");

            }
            Console.WriteLine();



        }
     
    }


    public static void Diagonal2(string[,] m, char c)
    {

        for (int i = 0; i < m.GetLength(0); i++)
        {

            for (int j = 0; j < m.GetLength(1); j++)
            {
                m[i, j] = c.ToString();
                m[i, j] =  i == 1 && j == 1 || i == 2 && j == 0 || i == 0 && j == 2 ? m[i, j] : " ";

                Console.Write(m[i, j] + " ");

            }
            Console.WriteLine();

        }

    }

    /*
    public static void DrawX(string[,] m, char c)
    {

        for (int i = 0; i < m.GetLength(0); i++)
        {

            for (int j = 0; j < m.GetLength(1); j++)
            {
                m[i, j] = c.ToString();
                m[i, j] = i == j || i == 1 && j == 1 || i == 2 && j == 0 || i == 0 && j == 2 ? m[i, j] : " ";

                Console.Write(m[i, j] + " ");

            }
            Console.WriteLine();

        }

    }*/
    









    public static void DrawBorder(string[,] m, char c)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {

                if (i == 0 || i == m.GetLength(0) - 1 || j == 0 || j == m.GetLength(1) - 1)
                    m[i, j] = c.ToString();

                var p = m[i, j] != null ? m[i, j] : " ";
                Console.Write(p + " ");
            }
            Console.WriteLine();
        }
    }




    public static void DrawCross(string[,] m, char c)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                m[i, j] = c.ToString();
                m[i, j] = (i == 2 || j == 1) ? m[i, j] : " ";

                Console.Write(m[i, j] + " ");
            }
            Console.WriteLine();

        }

    }



   public static void DrawTriangle(string[,] m, char c)
   {
        for (int i = 0; i < m.GetLength(0); i++)
        {

            for (int j = 0; j < m.GetLength(1); j++)
            {
                m[i, j] = c.ToString();
                m[i, j] = (i == j || j == 0 || i == 3 || (j == 1 && i == 2) ? m[i, j] : " ");

                Console.Write(m[i, j] + " ");
            }
            Console.WriteLine();
        }
   }


}



    

