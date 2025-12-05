// See https://aka.ms/new-console-template for more information
using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Models;
using ProjectClassLibrary.Services;

//Console.WriteLine("Hello, World!");

DateTime now = DateTime.Now;
IMember member1 = new Member("Kasper", "Møller", "23456789", "Skovvej 111", "Næstved", "Kasper@hotmail.com", MemberType.Adult, MemberRole.Member);
IBoat jolle1 = new Boat(BoatType.TERA, "Model", "16-3335", "Is very good :3", 32, 23, 33, "1982");
IBooking booking = new Booking(now, now.AddHours(8), isBooked: true, "DestinationA",member1,jolle1);
Console.WriteLine("Booking: " + booking);
IBookingRepository bookingRepository = new BookingRepository();
bookingRepository.AddBooking(booking);

Blog blog = new Blog("HeaderA", "DescriptionA", DateTime.Now, "AuthorA", "Picture.png");
Console.WriteLine("Blog: " + blog);
IBlogRepository blogRepository = new BlogRepository();
blogRepository.AddBlog(blog);