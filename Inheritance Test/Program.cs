using Inheritance_Test.Models;
using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Models;
using ProjectClassLibrary.Services;

IBoat motorBåd = new MotorBoat(BoatType.SNIPEJOLLE, "12", "17-876", "Good :)", 21, 21, 21, "1289", EngineType.DieselEngine);
IBoat sejlBåd = new SailBoat(BoatType.EUROPAJOLLE, "21", "21-457", "Bad :)", 13, 21, 21, "1459", SailType.MainSail);

IBoatRepository bRepo = new BoatRepository();

bRepo.AddBoat(motorBåd);
bRepo.AddBoat(sejlBåd);
bRepo.PrintAllBoats();