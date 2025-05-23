using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Creating instances of the classes
                User[] basicUsers = new User[] //Creating User array
                {
                new User("123456789", "David", "Levi", "Dave", "050-1234567", new DateTime(1995, 4, 23)),
                new User("987654321", "Sara", "Cohen", "Sari", "052-7654321", new DateTime(1998, 9, 15))
                };

                RegisteredUser[] registeredUserAccounts = new RegisteredUser[] //Creating RegisteredUser array
                {
                    new RegisteredUser("456123789", "michael@example.com",
                    "MikeSecure1", "Michael", "Rosen", "Mike", "054-9876543", new DateTime(2000, 1, 5)),
                    new RegisteredUser("321789654", "rachel@example.com",
                    "RachG1234", "Rachel", "Gold", "Rachi", "053-5678910", new DateTime(1993, 7, 10))
                };

                BusinessUser[] businessClients = new BusinessUser[] //Creating BusinessUser array
                {
                    new BusinessUser("112233445", "fashionguru@example.com",
                    "FashionPass!", "Eli", "Adams", "EliA", "050-8765432", new DateTime(1987, 12, 1),
                    "https://instagram.com/eliadams"),
                    new BusinessUser("556677889", "trendsetter@example.com",
                    "Trend1234", "Noa", "Shalev", "NoaS", "052-3344556", new DateTime(1992, 6, 21),
                    "https://instagram.com/noastyle")
                };
                
                ClothingItem[] clothingItems = new ClothingItem[] //Creating ClothingItem array
                {
                    new ClothingItem("T-shirt", "#3a4a2b", Seasons.Summer, Size.M, Status.HighUsage),
                    new ClothingItem("Jeans", "#4b5a6c", Seasons.Autumn, Size.XXL, Status.LowUsage),
                    new ClothingItem("Jacket", "#1a2b3c", Seasons.Winter, Size.OS, Status.NotInUse),
                    new ClothingItem("Shorts", "#4d5e6f", Seasons.Spring, Size.S, Status.HighUsage),
                    new ClothingItem("Socks", "#3d2e6b", Seasons.Spring, Size.M, Status.HighUsage)
                };

                ClothingAd[] clothingAds = new ClothingAd[] //Creating ClothingAd array
                {
                    new ClothingAd(clothingItems[2].Id, registeredUserAccounts[0].User_id, "Address1"),
                    new ClothingAd(clothingItems[3].Id, registeredUserAccounts[1].User_id, "Address2")
                };

                PopupEvent[] popupEvents = new PopupEvent[] //Creating PopupEvent array
                {
                    new PopupEvent("123456789", "Summer Sale", "123 Main St", DateTime.Now, DateTime.Now.AddDays(3)),
                    new PopupEvent("987654321", "Winter Clearance", "456 Elm St", DateTime.Now, DateTime.Now.AddDays(5))
                };

                Console.WriteLine("Hello and welcome to ANOTHER closet assignment!");
                DisplayMenu(basicUsers,registeredUserAccounts,businessClients);
            }//End of try block
            
            //Exceptions handling
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"Error: {e.Message} - Please check the index used to access the array.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Error: {e.Message} - Please check the provided arguments.");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Error: {e.Message} - Please check the format of the input values.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Program execution completed.");
            }

        }//End of Main method
        public static void DisplayMenu(User[] basicUsers, RegisteredUser[] registeredUsers, BusinessUser[] businessUsers)
        {
            while (true)
            {
                Console.WriteLine("\n----- MAIN MENU -----");
                Console.WriteLine("1 - View basic users");
                Console.WriteLine("2 - View registered users");
                Console.WriteLine("3 - View business users");
                Console.WriteLine("0 - Exit");
                Console.Write("Your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\n--- Basic Users ---");
                        foreach (var user in basicUsers)
                            user.Print();
                        break;

                    case "2":
                        Console.WriteLine("\n--- Registered Users ---");
                        foreach (var user in registeredUsers)
                            user.Print();
                        break;

                    case "3":
                        Console.WriteLine("\n--- Business Users ---");
                        foreach (var user in businessUsers)
                            user.Print();
                        break;

                    case "0":
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid input. Try again.");
                        break;
                }

                Console.WriteLine("\nPress any key to return to menu...");
                Console.ReadKey();
                Console.Clear();
            }
        }//End of DisplayMenu method

    }//End of Program class
}//End of namespace
