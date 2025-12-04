using ProjectClassLibrary.Models;
using ProjectClassLibrary.Services;

// Tests of Maintenance class and repository
Maintenance m1 = new Maintenance("Hul i skroget", DateTime.Now);
Maintenance m2 = new Maintenance("Hul i dækket", DateTime.Now);

MaintenanceRepository mRepo = new MaintenanceRepository();
mRepo.AddMaintenance(m1);
mRepo.AddMaintenance(m2);

m2.Fixed();

mRepo.PrintAll();

