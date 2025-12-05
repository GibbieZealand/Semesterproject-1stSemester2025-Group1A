using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Models;
using ProjectClassLibrary.Services;

// Tests of Maintenance class and repository
IBoat jolle1 = new Boat(BoatType.TERA, "Model", "16-3335", "Is very good :3", 32, 23, 33, "1982");
IMember member1 = new Member("Kasper", "Møller", "23456789", "Skovvej 111", "Næstved", "Kasper@hotmail.com", MemberType.Adult, MemberRole.Member);

Maintenance m1 = new Maintenance("Hul i skroget", DateTime.Now,jolle1,member1);
Maintenance m2 = new Maintenance("Hul i dækket", DateTime.Now,jolle1,member1);

MaintenanceRepository mRepo = new MaintenanceRepository();
mRepo.AddMaintenance(m1);
mRepo.AddMaintenance(m2);

m2.Fixed();

mRepo.PrintAll();

