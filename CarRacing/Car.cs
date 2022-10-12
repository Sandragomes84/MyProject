namespace CarRacing;

public class Car
{

    public int Kms { get; set; }
    public string Marca { get; set; }
    public char Symbol { get; set; }
    private ConsoleColor _color;

    Random _rnd;


    //Construtor por cópia

    public Car(Car car)
    {
        Kms = car.Kms;
        Marca = car.Marca;
        Symbol = car.Symbol;

    }
    //Construtor por cópia ^



    public Car(string marca)
    {
        _rnd = new Random();
        _color = (ConsoleColor)_rnd.Next(1, 16);
        Marca = marca;
        Symbol = '.';

    }

    // Call another constructor (constructor chaining) that accepts only the Make
    // but helps to construct the Car

    public Car(string marca, char symbol) : this(marca)
    {

        Symbol = symbol;

    }



    public void Print()
    {

        Console.ForegroundColor = _color;

        for (int i = 0; i < Kms; i++)
        {
            Console.Write(Symbol);

        }

        Console.WriteLine($"{Marca}, {Kms} Kms");

        Console.ResetColor();
    }


    public static int KmPercorridos()
    {

        return 10;
    }



    public void Mover()
    {
        Kms += _rnd.Next(1, 8);
    }


}













