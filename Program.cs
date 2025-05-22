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
                User[] basicUsers = new User[]
                {
                new User("123456789", "David", "Levi", "Dave", "050-1234567", new DateTime(1995, 4, 23)),
                new User("987654321", "Sara", "Cohen", "Sari", "052-7654321", new DateTime(1998, 9, 15))
                };

                RegisteredUser[] registeredUserAccounts = new RegisteredUser[]
                {
                    new RegisteredUser("456123789", "michael@example.com",
                    "MikeSecure1", "Michael", "Rosen", "Mike", "054-9876543", new DateTime(2000, 1, 5)),
                    new RegisteredUser("321789654", "rachel@example.com",
                    "RachG1234", "Rachel", "Gold", "Rachi", "053-5678910", new DateTime(1993, 7, 10))
                };

                BusinessUser[] businessClients = new BusinessUser[]
                {
                    new BusinessUser("112233445", "fashionguru@example.com",
                    "FashionPass!", "Eli", "Adams", "EliA", "050-8765432", new DateTime(1987, 12, 1),
                    "https://instagram.com/eliadams"),
                    new BusinessUser("556677889", "trendsetter@example.com",
                    "Trend1234", "Noa", "Shalev", "NoaS", "052-3344556", new DateTime(1992, 6, 21),
                    "https://instagram.com/noastyle")
                };

                Console.WriteLine("---basic user tests---\n");
                //basicUsers[0].Print();
                //ClothingItem item1 = new ClothingItem("T-shirt", "#3a4a2b", Seasons.Summer, Size.M, Status.HighUsage);
                //basicUsers[0].AddClothingItem(item1);
                //basicUsers[0].Print();
                //basicUsers[0].RemoveClothingItem(item1);
                //basicUsers[0].Print();

                Console.WriteLine("\n---registered user tests---\n");
                registeredUserAccounts[0].Print();
                ClothingItem item2 = new ClothingItem("Jeans", "#4b5a6c", Seasons.Autumn, Size.XXL, Status.LowUsage);
                registeredUserAccounts[0].AddClothingItem(item2);
                registeredUserAccounts[0].Print();
                registeredUserAccounts[0].RemoveClothingItem(item2);
                registeredUserAccounts[0].Print();

                Console.WriteLine("\n---business user tests---\n");
                //PopupEvent event1 = new PopupEvent("123456789", "Summer Sale", "123 Main St", DateTime.Now, DateTime.Now.AddDays(3));
                //event1.AddClothingItem(item1);
                //event1.PrintEventDetails();


                //Fix this line to avoid index out of range exception!
                basicUsers[2].Print();

            }
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
        }
    }
}
