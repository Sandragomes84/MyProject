// See https://aka.ms/new-console-template for more information
using CarRacing;

Car car = new Car("bmw", '*');
var car1 = car;

car1.Marca = "Seat";


//Tamanho da pista
var trackTam = 100;
var delay = 500;
var numCars = 7;

var cars = CarDealer.Getcars(numCars);
var track = new Track(trackTam, cars);
var race = new Race(track, cars);

Car winner = race.Start(delay);
Console.WriteLine($" O vencedor é {winner.Marca} com ({winner.Kms} Kms)");

Console.Beep();

Console.Read();

