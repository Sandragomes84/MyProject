﻿// See https://aka.ms/new-console-template for more information

using MyExercices;


/*
var v1 = new int[] {1, 2, 5};
var v2 = new int[] {6, 7, 10};
var v3 = new int[3];
var v4 = new int[] {5, 10, 15, 20};





//Vetor.Randomize(v4);

//Modulo5.Signos();

//var result = Vetor.Add(v1, v2);
//Vetor.Print2(result);



int lines = 5;
int cols = 5;

string[,] m = new string[lines, cols];

Matrix.DrawSquare(m, 'X');*/














List<Coin> coins = new List<Coin>();

coins.Add(new Coin("BTC", 20000));
coins.Add(new Coin("ETH", 1500));
coins.Add(new Coin("CHOW", 2.56m));
coins.Add(new Coin("TUGA", 1.23m));


Console.WriteLine("Quantas moedas vai registar?");
int qt = int.Parse(Console.ReadLine());

var count = 1;

for (int i = 0; i < qt; i++)
{
    Console.WriteLine($"Insira o nome da moeda {count++}: ");
    string name = Console.ReadLine().ToUpper().Trim();

     if(coins.Any(x => x.Name == name))
     {
        Console.WriteLine("Esta moeda já se encontra registada!");
     }
     else
     {
        Console.WriteLine($"Insira o preço da moeda {count - 1}: ");
        decimal price = decimal.Parse(Console.ReadLine());

        coins.Add(new Coin(name, price));
        Console.WriteLine();
     }
    
}
Console.WriteLine();
Console.WriteLine("MOEDAS JÁ REGISTADAS: ");
Console.WriteLine();
foreach (Coin coin in coins)
{
    coin.Print();
}
Console.ReadLine();





















