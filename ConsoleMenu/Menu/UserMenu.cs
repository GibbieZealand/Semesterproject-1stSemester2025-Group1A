using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu.Menu
{
    public class UserMenu
    {

        private static string mainMenuChoices = "\t1.Vis Medlemmer\n\t2.Vis Både\n\t3.Vis Blogs\n\t4.Vis Bookinger\n\t5.Vis Events\n\t6.Vis Vedligehold\n\tQ.Afslut\n\n\tIndtast valg:";

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
                        //_boatRepository.PrintAll();
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
                    default:
                        Console.WriteLine("Angiv et tal fra 1..6 eller q for afslut");
                        break;
                }
                theChoice = ReadChoice(mainMenuChoices);
            }
        }
    }

    //public void ShowMenu()
    //{
    //    string theChoice = ReadChoice(mainMenuChoices);
    //    while (theChoice != "q")
    //    {
    //        switch (theChoice)
    //        {
    //            case "1":
    //                Console.WriteLine("Valg 1");

    //                showMenuItemController.ShowAllMenuItems();
    //                Console.ReadLine();
    //                break;
    //            case "2":
    //                Console.WriteLine("Valg 2");
    //                _customerRepository.PrintAllCustomers();
    //                Console.ReadLine();
    //                break;
    //            case "3":
    //                Console.WriteLine("Valg 3");
    //                Console.WriteLine("Indlæs navn:");
    //                string name = Console.ReadLine();
    //                Console.WriteLine("Indlæs mobil nr:");
    //                string mobile = Console.ReadLine();
    //                Console.WriteLine("Indlæs adresse:");
    //                string address = Console.ReadLine();
    //                Console.WriteLine("Vil du være clubmember y/n");
    //                string clubMemberString = Console.ReadLine().ToLower();
    //                bool isClubMember = (clubMemberString[0] == 'y') ? true : false;
    //                AddCustomerController addCustomerController = new AddCustomerController(name, mobile, address, isClubMember, _customerRepository);
    //                addCustomerController.AddCustomer();
    //                break;
    //            case "4":
    //                Console.WriteLine("Valg 4");
    //                Console.WriteLine("Indlæs navn:");
    //                string itemName = Console.ReadLine();
    //                Console.WriteLine("Indlæs Pris:");
    //                string imputPrice = Console.ReadLine();
    //                double itemPrice = double.Parse(imputPrice);
    //                Console.WriteLine("Indlæs Beskrivelse:");
    //                string itemDescription = Console.ReadLine();
    //                Console.WriteLine("Indlæs Menutype");
    //                string inputMenuType = Console.ReadLine();
    //                MenuType itemMenuType = (MenuType)Enum.Parse(typeof(MenuType), inputMenuType);
    //                AddMenuItemController addMenuItemController = new AddMenuItemController(itemName, itemDescription, itemPrice, itemMenuType, _menuItemRepository);
    //                addMenuItemController.AddMenuItem();
    //                break;
    //            default:
    //                Console.WriteLine("Angiv et tal fra 1..4 eller q for afslut");
    //                break;
    //        }
    //        theChoice = ReadChoice(mainMenuChoices);
    //    }
}

