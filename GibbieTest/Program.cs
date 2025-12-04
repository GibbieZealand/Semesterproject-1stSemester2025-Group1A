// See https://aka.ms/new-console-template for more information
using ProjectClassLibrary.Models;
using ProjectClassLibrary.Services;

Console.WriteLine("Hello, World!");

Boat Jolle1 = new Boat(BoatType.TERA, "Model", "12", "Is very good :3", 32, 23, 33, "1982");
Boat Jolle2 = new Boat(BoatType.FEVA, "Model", "21", "Is very bad :c", 32, 33, 23, "1985");

Console.WriteLine(Jolle1);
Console.WriteLine(Jolle2);

BoatRepository repository = new BoatRepository();

repository.AddBoat(Jolle1);
repository.AddBoat(Jolle2);
repository.PrintAllBoats();

repository.RemoveBoat("21");
repository.PrintAllBoats();
