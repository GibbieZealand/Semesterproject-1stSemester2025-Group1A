// See https://aka.ms/new-console-template for more information
using ProjectClassLibrary.Exceptions;
using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Models;
using ProjectClassLibrary.Services;
using System;


#region Region 1
DateTime now = DateTime.Now;
IMember member1 = new Member("Kasper", "Møller", "23456789", "Skovvej 111", "Næstved", "Kasper@hotmail.com", MemberType.Adult, MemberRole.Member);
IBoat jolle1 = new Boat(BoatType.TERA, "Model", "16-3335", "Is very good :3", 32, 23, 33, "1982");
//IBooking booking = new Booking(now, now.AddHours(8), isBooked: true, "DestinationA",member1,jolle1);
//Console.WriteLine(booking);
//Console.WriteLine("");

//Console.WriteLine("Booking: " + booking);
IBookingRepository bookingRepository = new BookingRepository();
//bookingRepository.AddBooking(booking);
////bookingRepository.PrintAll();
//IBooking booking2 = new Booking(now, now.AddHours(12), isBooked: true, "DestinationB", member1, jolle1);
////Test af UpdateBooking
////bookingRepository.UpdateBooking(booking.Id, booking2);
//bookingRepository.PrintAll();


IBlog blog = new Blog("HeaderA", "DescriptionA", DateTime.Now, member1, "Picture.png");
//Console.WriteLine("Blog: " + blog);
IBlogRepository blogRepository = new BlogRepository();
blogRepository.AddBlog(blog);
blogRepository.PrintAll();
IBlog blog2 = new Blog("HeaderB", "DescriptionB", DateTime.Now, member1, "Picture2.png");
blogRepository.UpdateBlog(blog.Id, blog2);
blogRepository.PrintAll();
Console.WriteLine();
#endregion
IBoat jolle2 = new Boat(BoatType.TERA, "Model", "19-4325", "Is very good :3", 32, 23, 33, "1982");
IMember member2 = new Member("Gibbie", "Lund Mølgaard", "53764901", "Kildehusvej", "Roskilde", "mail@gmail.com", MemberType.Adult, MemberRole.Member);
//IBooking booking3 = new Booking(now.AddHours(3), now.AddHours(8), isBooked: true, "DestinationB", member2, jolle2);
//bookingRepository.AddBooking(booking3);


// Test af BookBoat og overlapning af bookingtider
Console.WriteLine("\nadding booking for jolle1");
try
{
    bookingRepository.BookBoat(jolle1, member1, now, now.AddHours(6), "Helsingør");

    Console.WriteLine("\nadding booking for jolle2 by member2");
    bookingRepository.BookBoat(jolle2, member2, now, now.AddHours(3), "Helsingør");

    Console.WriteLine("\nadding booking for jolle2 by member2");
    bookingRepository.BookBoat(jolle2, member2, new DateTime(2025, 12, 05, 12, 00, 00), new DateTime(2025, 12, 05, 13, 00, 00), "Roskilde");

    Console.WriteLine("\nadding booking for jolle2 by member2");
    bookingRepository.BookBoat(jolle2, member2, new DateTime(2025, 12, 04, 12, 00, 00), new DateTime(2025, 12, 04, 13, 00, 00), "Holbæk");

    Console.WriteLine("\nadding booking for jolle1 by member2");
    bookingRepository.BookBoat(jolle1, member2, new DateTime(2025, 12, 03, 12, 00, 00), new DateTime(2025, 12, 03, 13, 00, 00), "Aarhus");

    Console.WriteLine("\ntesting invalid booking");
    bookingRepository.BookBoat(jolle1, member2, now.AddHours(2), now.AddHours(4), "Stockholm");

    //Console.WriteLine("\ntesting invalid time");
    //bookingRepository.BookBoat(jolle2, member1, now.AddHours(6), now.AddHours(4));

    Console.WriteLine("\nadding booking for jolle2 after first booking");
    bookingRepository.BookBoat(jolle2, member1, now.AddHours(4), now.AddHours(6), "Bornholm");

    Console.WriteLine("\nadding booking for jolle2 after second booking");
    bookingRepository.BookBoat(jolle2, member2, now.AddHours(6), now.AddHours(12), "Dublin");

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

// GetBookingCountForMember test - OLD
//int bookingCount1 = bookingRepository.GetBookingCountForMember(member1);
//int bookingCount2 = bookingRepository.GetBookingCountForMember(member2);
//Console.WriteLine($"{member1.Name} booking count: {bookingCount1}");
//Console.WriteLine($"{member2.Name} booking count: {bookingCount2}");
//Console.WriteLine();

//List<int> bookings = bookingRepository.GetAllBookingsForMembers();
//foreach(var o in bookings)
//{
//Console.WriteLine(o);
//}
//Console.WriteLine(bookings);

// Print booking counts for each member test
Dictionary<string, int> memberBookings = bookingRepository.GetAllBookingsForMembers();
foreach(KeyValuePair<string, int> kvp in memberBookings)
{
    Console.WriteLine($"Name: {kvp.Key} - Bookings: {kvp.Value}");
}
Console.WriteLine();

//STATISTIC TEST
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
bookingRepository.BookBoat(b2, member1, now, now.AddHours(2), "Sydafrika");
Console.WriteLine();
foreach (IBoat b in bRepo.GetAllBoats())
{
    Console.WriteLine(b.SailNumber + " Er blevet booket: " + b.BookedNrOfTimes + " gange");
}

//Test af SailCompleted metode


