namespace CarRacing;

static class CarDealer
{
    static Random rnd = new Random();

    static string makes = "Seat,Opel,BWM,Mazda,Hyunday,Volvo,Bugati,Mercedes,McLaren,Ferrari,Porsche";
    static Char[] symbols = new char[] {'.', '+', '-', '*', '~', '»', '«'};


    internal static Car[] Getcars(int numCars)
    {
        var separators = new char[] { ' ', ',' };
        var brands = makes.Split(separators); //Seat, Opel, Maserati,...

        var cars = new Car[numCars];

        for (int i = 0; i < numCars; i++)
        {

            var brand = brands[rnd.Next(brands.Length)];
            var symbol = symbols[rnd.Next(symbols.Length)];

            cars[i] = new Car(brand, symbol);

        }

        return cars;

    }






}
