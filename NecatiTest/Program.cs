using ProjectClassLibrary.Exceptions;
using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Models;
using ProjectClassLibrary.Services;

#region Nye objekter af boat, member og maintenance skabes
IBoat jolle1 = new Boat(BoatType.TERA, "Model", "16-3335", "Is very good :3", 32, 23, 33, "1982");
IMember member1 = new Member("Kasper", "Møller", "23456789", "Skovvej 111", "Næstved", "Kasper@hotmail.com", MemberType.Adult, MemberRole.Member);

Maintenance m1 = new Maintenance("Hul i skroget", DateTime.Now,jolle1,member1);
Maintenance m2 = new Maintenance("Hul i dækket", DateTime.Now,jolle1,member1);
#endregion

#region Test af AddMaintenance
Console.WriteLine("Test af AddMaintenance metode...");
MaintenanceRepository mRepo = new MaintenanceRepository();
mRepo.AddMaintenance(m1);
mRepo.AddMaintenance(m2);
mRepo.PrintAll();
#endregion

#region Test af Fixed metode
Console.WriteLine("Test af Fixed metode...");
m2.Fixed();
Console.WriteLine(m2);
#endregion

#region Test af exception
Console.WriteLine("");
Console.WriteLine("Test af exception...");
try
{
    m2.Fixed();
}
catch (BoatAlreadyFixedException ex)
{
    Console.WriteLine(ex.Message);
}
#endregion