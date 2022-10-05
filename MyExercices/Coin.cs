using System.Xml.Schema;
using System.Security.AccessControl;
namespace MyExercices;


public class Coin
{
    public string Name { get; private set; }
    public decimal Price { get; set; }

   
    public Coin(string name, decimal price)
    {
        Name = name;
        Price = price;  
    }


    internal void Print()
    {
        Console.WriteLine($"{Name}, {Price}");
    }


}
