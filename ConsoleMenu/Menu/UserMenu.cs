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
            "1.Vis Medlemmer" +
            "\n2.Vis Både" +
            "\n3.Vis Blogs" +
            "\n4.Vis Bookinger" +
            "\n5.Vis Events" +
            "\n6.Vis Maintenance" +
            "\n7.Tilføj Medlem" +
            "\n8.Tilføj Båd" +
            "\n9.Tilføj Blog" +
            "\n10.Tilføj Booking" +
            "\n11.Tilføj Event" +
            "\n12.Tilføj Maintenance" +
            "\nQ.Afslut" +
            "\n\nIndtast valg:";

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
                        _maintenanceRepository.PrintAll();
                        Console.ReadLine();
                        break;
                    case "7":
                        AddAndCreateMember();
                        break;
                    case "8":
                        AddAndCreateBoat();
                        break;
                    case "9":
                        AddAndCreateBlog();
                        break;
                    case "10":
                        AddAndCreateBooking();
                        break;
                    case "11":
                        AddAndCreateEvent();
                        break;
                    case "12":
                        AddAndCreateMaintenance();
                        break;
                    default:
                        Console.WriteLine("Angiv et tal fra 1..12 eller q for afslut");
                        break;
                }
                theChoice = ReadChoice(mainMenuChoices);
            }
        }

        private void AddAndCreateMaintenance()
        {
            Console.WriteLine("Indtast beskrivelse");
            string description = Console.ReadLine();
            Console.WriteLine("Indtast dato");
            DateTime date = ReadDate();
            IBoat boat = AddAndCreateBoat();
            IMember member = AddAndCreateMember();
            IMaintenance maintenance = new Maintenance(description, date, boat, member);
            _maintenanceRepository.AddMaintenance(maintenance);
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
            Console.WriteLine("Indtast startdato (dd-mm-yyyy-HH):");
            DateTime startDate = ReadDate();
            Console.WriteLine("Indtast slutdato (dd-mm-yyyy-HH):");
            DateTime endDate = ReadDate();
            Console.WriteLine("Indtast destination");
            string destination = Console.ReadLine();
            IMember member = AddAndCreateMember();
            IBoat boat = AddAndCreateBoat();
            IBooking booking = new Booking(startDate, endDate, destination, member, boat);
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
            IMember member = AddAndCreateMember();
            IBlog blog = new Blog(headline, description, date, member, "");
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

        private static double ReadDouble()
        {
            double value;
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Indtast et tal");
            }

            return value;
        }

        public DateTime ReadDate()
        {
            DateTime date;
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd-mm-yyyy-HH", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                Console.WriteLine("Indtast en gyldig dato (dd-mm-yyyy-HH)");
            }
            return date;
        }
    }
}

