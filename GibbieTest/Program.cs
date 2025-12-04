// See https://aka.ms/new-console-template for more information
using ProjectClassLibrary.Exceptions;
using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Models;
using ProjectClassLibrary.Services;

//Console.WriteLine("Hello, World!");

#region Object Creation Test
Console.WriteLine("----Boat Object Creation Test Start----");
Boat Jolle1 = new Boat(BoatType.TERA, "Model", "16-3335", "Is very good :3", 32, 23, 33, "1982");
Boat Jolle2 = new Boat(BoatType.FEVA, "Model", "19-2225", "Is very bad :c", 32, 33, 23, "1985");

Console.WriteLine(Jolle1);
Console.WriteLine(Jolle2);
Console.WriteLine();
#endregion
#region Repository AddBoat Test
Console.WriteLine("----Repository AddBoat Test Start");
BoatRepository repository = new BoatRepository();

repository.AddBoat(Jolle1);
repository.AddBoat(Jolle2);
repository.PrintAllBoats();
Console.WriteLine();
#endregion
#region Repository RemoveBoat Test
Console.WriteLine("----RemoveBoat Test Start----");
repository.RemoveBoat("21");
repository.PrintAllBoats();
Console.WriteLine();
#endregion
#region UpdateBoat Test
Console.WriteLine("----UpdateBoat Test Start----");
Console.WriteLine("Creating Updated Boat..");
IBoat updatedJolle1 = new Boat(BoatType.LASERJOLLE, "Model2", "16-3335", "Is not as good as before :/", 12, 32, 45, "1892");

Console.WriteLine("Updating Boat...");
repository.UpdateBoat(updatedJolle1);
Console.WriteLine();

Console.WriteLine("Printing Boat1...");
Console.WriteLine(Jolle1.ToString());
Console.WriteLine();
#endregion
#region Boat Exception Test
Console.WriteLine("----Boat Exception Test Start----");
Console.WriteLine("Creating 2 New Boat Objects..");
IBoat Jolle5 = new Boat(BoatType.TERA, "Model 3", "16-6666", "Is very good!", 7, 30, 30, "2000");
IBoat Jolle6 = new Boat(BoatType.TERA, "Model 4", "16-6666", "Is very good!", 7, 30, 30, "2000");
Console.WriteLine("Created Jolle 5 & 6\n");
Console.WriteLine("Adding Jolle5 to Repository...");
repository.AddBoat(Jolle5);
Console.WriteLine("\nAdding Jolle6 to Repository...");
try
{
    repository.AddBoat(Jolle6);
}
catch (BoatSailnumberExistsException bex)
{
    Console.WriteLine(bex.Message);
}
#endregion
Console.WriteLine("----Test End----");
