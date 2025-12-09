// See https://aka.ms/new-console-template for more information
using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Models;
using ProjectClassLibrary.Services;

//Console.WriteLine("Hello, World!");

DateTime now = DateTime.Now;
IMember member1 = new Member("Kasper", "Møller", "23456789", "Skovvej 111", "Næstved", "Kasper@hotmail.com", MemberType.Adult, MemberRole.Member);
IBoat jolle1 = new Boat(BoatType.TERA, "Model", "16-3335", "Is very good :3", 32, 23, 33, "1982");
IBooking booking = new Booking(now, now.AddHours(8), isBooked: true, "DestinationA",member1,jolle1);

//Console.WriteLine("Booking: " + booking);
IBookingRepository bookingRepository = new BookingRepository();
//bookingRepository.AddBooking(booking);
//bookingRepository.PrintAll();
//IBooking booking2 = new Booking(now, now.AddHours(12), isBooked: true, "DestinationB", member1, jolle1);
//bookingRepository.UpdateBooking(booking.Id, booking2);
//bookingRepository.PrintAll();

Blog blog = new Blog("HeaderA", "DescriptionA", DateTime.Now, member1, "Picture.png");
//Console.WriteLine("Blog: " + blog);
IBlogRepository blogRepository = new BlogRepository();
blogRepository.AddBlog(blog);
blogRepository.PrintAll();
Blog blog2 = new Blog("HeaderB", "DescriptionB", DateTime.Now, member1, "Picture2.png");
blogRepository.UpdateBlog(blog.Id, blog2);
blogRepository.PrintAll();
Console.WriteLine();

IBoat jolle2 = new Boat(BoatType.TERA, "Model", "19-4325", "Is very good :3", 32, 23, 33, "1982");
IMember member2 = new Member("Gibbie", "Lund Mølgaard", "53764901", "Kildehusvej", "Roskilde", "mail@gmail.com", MemberType.Adult, MemberRole.Member);
IBooking booking3 = new Booking(now.AddHours(3), now.AddHours(8), isBooked: true, "DestinationB", member2, jolle2);
bookingRepository.AddBooking(booking3);



Console.WriteLine("\nadding booking for jolle1");
bookingRepository.BookBoat(jolle1, member1, now, now.AddHours(6));

Console.WriteLine("\nadding booking for jolle2");
bookingRepository.BookBoat(jolle2, member2, now, now.AddHours(3));

//Console.WriteLine("\ntesting invalid booking");
//bookingRepository.BookBoat(jolle2, member1, now.AddHours(2), now.AddHours(4));

//Console.WriteLine("\ntesting invalid time");
//bookingRepository.BookBoat(jolle2, member1, now.AddHours(6), now.AddHours(4));

Console.WriteLine("\nadding booking for jolle2 after first booking");
bookingRepository.BookBoat(jolle2, member1, now.AddHours(4), now.AddHours(6));