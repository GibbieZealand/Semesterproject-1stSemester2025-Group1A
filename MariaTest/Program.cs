// See https://aka.ms/new-console-template for more information
using ProjectClassLibrary.Exceptions;
using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Models;
using ProjectClassLibrary.Services;
using System.ComponentModel;

IMember member1 = new Member("Maria", "Strauss", "23328120", "Glostrupvej 111", "Glostrup", "Maria@hotmail.com", MemberType.Adult, MemberRole.Member);
IMember member2 = new Member("Frederik", "Holm", "11111111", "Grevevej 2E", "Greve", "Frederik@gmail.com", MemberType.Adult, MemberRole.Member);

IEvent e1 = new Event("Standerhejsning", "Flaget bliver hejst og der åbnes for sejlads.", new DateTime(2025,12,05,10,00,00), new DateTime(2025, 12, 05, 10, 00, 00), member1);
IEvent e2 = new Event("Julefrokost", "Vi afholder den årlige julefrokost. Alle medbringer en ret.", new DateTime(2025, 12, 10, 13, 00, 00), new DateTime(2025, 12, 10, 18, 00, 00), member2);
IEvent e6 = new Event("Ny", "Ny event", DateTime.Now, DateTime.Now.AddHours(6), member1);
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
IMember member3 = new Member("Kasper", "Møller", "23456789", "Skovvej 111", "Næstved", "Kasper@hotmail.com", MemberType.Adult, MemberRole.Member);
IMember member4 = new Member("Gibbie", "Mølgaard", "53764901", "Kildehusvej 2E", "Roskilde", "Gibbie@gmail.com", MemberType.Adult, MemberRole.Member);
e1.AssignMember(member3);
e1.AssignMember(member4);
e1.AssignMember(member3);
Console.WriteLine(e1);

Console.WriteLine("");
Console.WriteLine("-----------------------Test af UpdateEvent metoden---------------------");
Console.WriteLine("--Vi ændrer tidspunktet for event e3 ved at erstatte det med et nyt event e4--");
Console.WriteLine("");
IEvent e3 = new Event("Kaffe og kage", "Vi drikker kaffe og spiser kage inden sejlads.", new DateTime(2025, 12, 05, 10, 00, 00), new DateTime(2025, 12, 05, 10, 00, 00), member2);
IEvent e4 = new Event("Kaffe og kage", "Vi drikker kaffe og spiser kage inden sejlads.", new DateTime(2025, 12, 05, 12, 00, 00), new DateTime(2025, 12, 05, 13, 00, 00), member2);
eventList1.AddEvent(e3);
eventList1.AddEvent(e4);
eventList1.UpdateEvent(2, e4);
Console.WriteLine(e3);
Console.WriteLine("");
Console.WriteLine(e4);
Console.WriteLine("");
Console.WriteLine("-----------------------Test af AddEvent Exception---------------------");
Console.WriteLine("");
//Vi tester om vores AddEvent Exception virker

try
{
    eventList1.AddEvent(e4);
}
catch (EventIdExistsException eex)
{
    Console.WriteLine(eex.Message);
}


