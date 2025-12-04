// See https://aka.ms/new-console-template for more information
using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Models;
using ProjectClassLibrary.Services;

//Console.WriteLine("Hello, World!");

DateTime now = DateTime.Now;
Booking booking = new Booking(now, now.AddHours(8), isBooked: true, "DestinationA");
Console.WriteLine("Booking: " + booking);
IBookingRepository bookingRepository = new BookingRepository();
bookingRepository.AddBooking(booking);

Blog blog = new Blog("HeaderA", "DescriptionA", DateTime.Now, "AuthorA", "Picture.png");
Console.WriteLine("Blog: " + blog);
IBlogRepository blogRepository = new BlogRepository();
blogRepository.AddBlog(blog);