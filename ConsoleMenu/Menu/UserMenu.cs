using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Models;
using ProjectClassLibrary.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ikke i brug

namespace ConsoleMenu.Menu
{
    public class UserMenu
    {

        private static string mainMenuChoices =
            "\t1.Vis Medlemmer" +
            "\n\t2.Vis Både" +
            "\n\t3.Vis Blogs" +
            "\n\t4.Vis Bookinger" +
            "\n\t5.Vis Events" +
            "\n\t6.Tilføj Medlem" +
            "\n\t7.Tilføj Båd" +
            "\n\t8.Tilføj Blog" +
            "\n\t9.Tilføj Booking" +
            "\n\t10.Tilføj Event" +
            "\n\tQ.Afslut" +
            "\n\n\tIndtast valg:";

        private MemberRepository _memberRepository = new MemberRepository();
        private BoatRepository _boatRepository = new BoatRepository();
        private BlogRepository _blogRepository = new BlogRepository();
        private BookingRepository _bookingRepository = new BookingRepository();
        private EventRepository _eventRepository = new EventRepository();
        private MaintenanceRepository _maintenanceRepository = new MaintenanceRepository();

        private static string ReadChoice(string choices)
        {
            Console.Clear();
            Console.Write(choices);
            string choice = Console.ReadLine();
            Console.Clear();
            return choice.ToLower();
        }

        public void ShowMenu()
        {
            string theChoice = ReadChoice(mainMenuChoices);
            while (theChoice != "q")
            {
                switch (theChoice)
                {
                    case "1":
                        _memberRepository.PrintAll();
                        Console.ReadLine();
                        break;
                    case "2":
                        _boatRepository.PrintAllBoats();
                        Console.ReadLine();
                        break;
                    case "3":
                        _blogRepository.PrintAll();
                        Console.ReadLine();
                        break;
                    case "4":
                        _bookingRepository.PrintAll();
                        Console.ReadLine();
                        break;
                    case "5":
                        _eventRepository.PrintAll();
                        Console.ReadLine();
                        break;
                    case "6":
                        AddAndCreateMember();
                        break;
                    case "7":
                        AddAndCreateBoat();
                        break;
                    case "8":
                        AddAndCreateBlog();
                        break;
                    case "9":
                        AddAndCreateBooking();
                        break;
                    case "10":
                        AddAndCreateEvent();
                        break;
                    default:
                        Console.WriteLine("Angiv et tal fra 1..10 eller q for afslut");
                        break;
                }
                theChoice = ReadChoice(mainMenuChoices);
            }
        }

        private void AddAndCreateEvent()
        {
            Console.WriteLine("Indtast navn");
            string name = Console.ReadLine();
            Console.WriteLine("Indtast beskrivelse");
            string description = Console.ReadLine();
            Console.WriteLine("Indtast startdato");
            DateTime startDate = ReadDate();
            Console.WriteLine("Indtast slutdato");
            DateTime endDate = ReadDate();
            IMember member = AddAndCreateMember();
            IEvent eventt = new Event(name, description, startDate, endDate, member);
            _eventRepository.AddEvent(eventt);
        }

        private IBooking AddAndCreateBooking()
        {
            Console.WriteLine("Indtast startdato (dd-mm-yyyy):");
            DateTime startDate = ReadDate();
            Console.WriteLine("Indtast slutdato (dd-mm-yyyy):");
            DateTime endDate = ReadDate();
            string destination = Console.ReadLine();
            IMember member2 = AddAndCreateMember();
            IBoat boat2 = AddAndCreateBoat();
            IBooking booking = new Booking(startDate, endDate, destination, member2, boat2);
            _bookingRepository.AddBooking(booking);
            return booking;
        }

        private IBlog AddAndCreateBlog()
        {
            Console.WriteLine("Indtast overskrift");
            string headline = Console.ReadLine();
            Console.WriteLine("Indtast beskrivelse");
            string description = Console.ReadLine();
            DateTime date = DateTime.Now;
            IMember member1 = AddAndCreateMember();
            IBlog blog = new Blog(headline, description, date, member1, "");
            _blogRepository.AddBlog(blog);
            return blog;
        }

        private IBoat AddAndCreateBoat()
        {
            Console.WriteLine("Indtast bådmodel");
            string model = Console.ReadLine();
            Console.WriteLine("Indtast sejlnummer");
            string sailNumber = Console.ReadLine();
            Console.WriteLine("Indtast motorinfo");
            string engineInfo = Console.ReadLine();
            Console.WriteLine("Indtast dybgang");
            double draft = ReadDouble();
            Console.WriteLine("Indtast bredde");
            double width = ReadDouble();
            Console.WriteLine("Indtast længde");
            double length = ReadDouble();
            Console.WriteLine("Indtast byggeår");
            string yearOfConstruction = Console.ReadLine();
            IBoat boat = new Boat(BoatType.WAYFARER, model, sailNumber, engineInfo, draft, width, length, yearOfConstruction);
            _boatRepository.AddBoat(boat);
            return boat;
        }

        private static double ReadDouble()
        {
            double draft;
            while (!double.TryParse(Console.ReadLine(), out draft))
            {
                Console.WriteLine("Indtast et tal");
            }

            return draft;
        }

        private IMember AddAndCreateMember()
        {
            Console.WriteLine("Indtast medlemsnavn");
            string name = Console.ReadLine();
            Console.WriteLine("Indtast efternavn");
            string surName = Console.ReadLine();
            Console.WriteLine("Indtast telefonnummer");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Indtast addresse");
            string address = Console.ReadLine();
            Console.WriteLine("Indtast by");
            string city = Console.ReadLine();
            Console.WriteLine("Indtast mail");
            string mail = Console.ReadLine();
            MemberType memberType = MemberType.Adult;
            MemberRole memberRole = MemberRole.Member;
            IMember member = new Member(name, surName, phoneNumber, address, city, mail, memberType, memberRole);
            _memberRepository.AddMember(member);
            return member;
        }

        public DateTime ReadDate()
        {
            DateTime date;
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd-mm-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                Console.WriteLine("Indtast en gyldig dato (dd-mm-yyyy)");
            }
            return date;
        }
    }
}

