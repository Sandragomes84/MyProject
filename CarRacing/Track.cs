
namespace CarRacing;

public class Track
{

    public int Kms { get; private set; }
    public string Name { get; set; }
    private Car[] _cars;



    public Track(int kms, Car[] cars)
    {

        this.Kms = kms;
        _cars = cars;


    }


    public void Print()
    {
        Console.Clear();

        var border = "".PadLeft(Kms, '-');

        Console.WriteLine(border);

        foreach (var car in _cars)
        {
            car.Print();
        }

        Console.WriteLine(border);


    }


    public Car GetWinner()
    {
        foreach (var car in _cars)
        {
            if (car.Kms >= this.Kms)
                return car;

        }
        return null;

    }


    public void MoveCars()
    {
        foreach (var car in _cars)
        {
            car.Mover();

        }

    }



}

