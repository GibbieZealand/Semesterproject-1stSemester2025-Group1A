// See https://aka.ms/new-console-template for more information
using ProjectClassLibrary.Exceptions;
using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Models;
using ProjectClassLibrary.Services;
using System;


#region Test af blog metoder
DateTime now = DateTime.Now;
IMember member1 = new Member("Kasper", "Møller", "23456789", "Skovvej 111", "Næstved", "Kasper@hotmail.com", MemberType.Adult, MemberRole.Member);
IBookingRepository bookingRepository = new BookingRepository();
IBlog blog = new Blog("HeaderA", "DescriptionA", DateTime.Now, member1, "Picture.png");
IBlogRepository blogRepository = new BlogRepository();
blogRepository.AddBlog(blog);
blogRepository.PrintAll();
IBlog blog2 = new Blog("HeaderB", "DescriptionB", DateTime.Now, member1, "Picture2.png");
blogRepository.UpdateBlog(blog.Id, blog2);
blogRepository.PrintAll();
Console.WriteLine();
#endregion

#region Nye båd- og memberobjekter skabes
IBoat jolle1 = new Boat(BoatType.TERA, "Model", "16-3335", "Is very good :3", 32, 23, 33, "1982");
IBoat jolle2 = new Boat(BoatType.TERA, "Model", "19-4325", "Is very good :3", 32, 23, 33, "1982");
IMember member2 = new Member("Gibbie", "Lund Mølgaard", "53764901", "Kildehusvej", "Roskilde", "mail@gmail.com", MemberType.Adult, MemberRole.Member);
#endregion

#region Test af BookBoat og overlapning af bookingtider
Console.WriteLine("\nadding booking for jolle1");
try
{
    IBooking booking1 = new Booking(now, now.AddHours(6), "Helsingør", member1, jolle1);
    bookingRepository.AddBooking(booking1);

    Console.WriteLine("\nadding booking for jolle2 by member2");
    IBooking booking2 = new Booking(now, now.AddHours(3), "Helsingør", member2, jolle2);
    bookingRepository.AddBooking(booking2);

    Console.WriteLine("\nadding booking for jolle2 by member2");
    IBooking booking3 = new Booking(new DateTime(2025, 12, 05, 12, 00, 00), new DateTime(2025, 12, 05, 13, 00, 00), "Roskilde", member2, jolle2);
    bookingRepository.AddBooking(booking3);

    Console.WriteLine("\nadding booking for jolle2 by member2");
    IBooking booking4 = new Booking(new DateTime(2025, 12, 04, 12, 00, 00), new DateTime(2025, 12, 04, 13, 00, 00), "Holbæk", member2, jolle2);
    bookingRepository.AddBooking(booking4);

    Console.WriteLine("\nadding booking for jolle1 by member2");
    IBooking booking5 = new Booking(new DateTime(2025, 12, 03, 12, 00, 00), new DateTime(2025, 12, 03, 13, 00, 00), "Aarhus", member2, jolle1);
    bookingRepository.AddBooking(booking5);

    Console.WriteLine("\ntesting invalid booking");
    IBooking booking6 = new Booking(now.AddHours(2), now.AddHours(4), "Stockholm", member2, jolle1);
    bookingRepository.AddBooking(booking6);

    Console.WriteLine("\nadding booking for jolle2 after first booking");
    IBooking booking7 = new Booking(now.AddHours(4), now.AddHours(6), "Bornholm", member1, jolle2);
    bookingRepository.AddBooking(booking7);

    Console.WriteLine("\nadding booking for jolle2 after second booking");
    IBooking booking8 = new Booking(now.AddHours(6), now.AddHours(12), "Dublin", member2, jolle2);
    bookingRepository.AddBooking(booking8);

    Console.WriteLine("\nPrinting all bookings");
    bookingRepository.PrintAll();
}
catch (NullReferenceException nRex)
{
    Console.WriteLine(nRex.Message);
}
catch (InvalidDateException iDex)
{
    Console.WriteLine(iDex.Message);
}
catch (InvalidBookingException iBex)
{
    Console.WriteLine(iBex.Message);
}
catch (OverlappingDateException oex)
{
    Console.WriteLine(oex.Message);
}

Console.WriteLine();
Console.WriteLine("Jolle1 er blevet booked " + jolle1.BookedNrOfTimes + " gange");
Console.WriteLine("Jolle2 er blevet booked " + jolle2.BookedNrOfTimes + " gange");
Console.WriteLine();
#endregion

#region Print booking counts for each member test
Dictionary<string, int> memberBookings = bookingRepository.GetAllBookingsForMembers();
foreach (KeyValuePair<string, int> kvp in memberBookings)
{
    Console.WriteLine($"Name: {kvp.Key} - Bookings: {kvp.Value}");
}
Console.WriteLine();
#endregion

#region Test af statistik over, hvilken båd der har været booket flest gange
IBoat b1 = new Boat(BoatType.TERA, "TEST-MODEL", "TEST-01", "TEST-ENGINEINFO", 30, 30, 30, "2011");
IBoat b2 = new Boat(BoatType.FEVA, "TEST-MODEL", "TEST-02", "TEST-ENGINEINFO", 30, 30, 30, "2011");
IBoat b3 = new Boat(BoatType.LASERJOLLE, "TEST-MODEL", "TEST-03", "TEST-ENGINEINFO", 30, 30, 30, "2011");
IBoat b4 = new Boat(BoatType.EUROPAJOLLE, "TEST-MODEL", "TEST-04", "TEST-ENGINEINFO", 30, 30, 30, "2011");
IBoat b5 = new Boat(BoatType.SNIPEJOLLE, "TEST-MODEL", "TEST-05", "TEST-ENGINEINFO", 30, 30, 30, "2011");
IBoat b6 = new Boat(BoatType.WAYFARER, "TEST-MODEL", "TEST-06", "TEST-ENGINEINFO", 30, 30, 30, "2011");
IBoat b7 = new Boat(BoatType.LYNÆS, "TEST-MODEL", "TEST-07", "TEST-ENGINEINFO", 30, 30, 30, "2011");

IBoatRepository bRepo = new BoatRepository();
bRepo.AddBoat(b1);
bRepo.AddBoat(b2);
bRepo.AddBoat(b3);
bRepo.AddBoat(b4);
bRepo.AddBoat(b5);
bRepo.AddBoat(b6);
bRepo.AddBoat(b7);
IBooking b9 = new Booking(now, now.AddHours(2), "Sydafrika", member1, b2);
bookingRepository.AddBooking(b9);
Console.WriteLine();
foreach (IBoat b in bRepo.GetAllBoats())
{
    Console.WriteLine(b.SailNumber + " Er blevet booket: " + b.BookedNrOfTimes + " gange");
}
#endregion

#region Test af SailCompleted property
b9.SailCompleted = true;
Console.WriteLine(b9);
#endregion