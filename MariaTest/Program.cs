// See https://aka.ms/new-console-template for more information
using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Models;
using ProjectClassLibrary.Services;
using System.ComponentModel;

IEvent e1 = new Event("Standerhejsning", "Flaget bliver hejst og der åbnes for sejlads.", new DateTime(2025,12,05,10,00,00), new DateTime(2025, 12, 05, 10, 00, 00));
IEvent e2 = new Event("Julefrokost", "Vi afholder den årlige julefrokost. Alle medbringer en ret.", new DateTime(2025, 12, 10, 13, 00, 00), new DateTime(2025, 12, 10, 18, 00, 00));
Console.WriteLine("----------------------Test af nyt Event objekt----------------------");
Console.WriteLine("");
Console.WriteLine(e1);
Console.WriteLine("--------------------------------------------");
Console.WriteLine(e2);
Console.WriteLine("");
Console.WriteLine("-----------------------Test af AddEvent og PrintAll metoderne---------------------");
Console.WriteLine("");

//Vi laver en ny EventRepositoryList kaldet eventList1
IEventRepository eventList1 = new EventRepository();

//Vi tilføjer events til vores eventList1
eventList1.AddEvent(e1);
eventList1.AddEvent(e2);
//Vi tester vores PrintAll metode, som printer alle vores events ud:
eventList1.PrintAll();

List<IEvent> events = eventList1.GetAllEvents();

Console.WriteLine("");
Console.WriteLine("-----------------------Test af RemoveEvent metoden---------------------");
Console.WriteLine("");
//Vi tester om vores Remove metode virker
eventList1.RemoveEvent(e2);
eventList1.PrintAll();

Console.WriteLine("");
Console.WriteLine("-----------------------Test af AssignMember metoden---------------------");
Console.WriteLine("");
IMember member1 = new Member("Kasper", "Møller", "23456789", "Skovvej 111", "Næstved", "Kasper@hotmail.com", MemberType.Adult, MemberRole.Member);
IMember member2 = new Member("Gibbie", "Mølgaard", "53764901", "Kildehusvej 2E", "Roskilde", "Gibbie@gmail.com", MemberType.Adult, MemberRole.Member);
e1.AssignMember(member1);
e1.AssignMember(member2);
e1.AssignMember(member1);
Console.WriteLine(e1);

Console.WriteLine("");
Console.WriteLine("-----------------------Test af UpdateEvent metoden---------------------");
Console.WriteLine("--Vi ændrer tidspunktet for event e3 ved at erstatte det med et nyt event e4--");
Console.WriteLine("");
IEvent e3 = new Event("Standerhejsning", "Flaget bliver hejst og der åbnes for sejlads.", new DateTime(2025, 12, 05, 10, 00, 00), new DateTime(2025, 12, 05, 10, 00, 00));
IEvent e4 = new Event("Standerhejsning", "Flaget bliver hejst og der åbnes for sejlads.", new DateTime(2025, 12, 05, 12, 00, 00), new DateTime(2025, 12, 05, 13, 00, 00));
eventList1.AddEvent(e3);
eventList1.AddEvent(e4);
eventList1.UpdateEvent(2, e4);
Console.WriteLine(e4);

