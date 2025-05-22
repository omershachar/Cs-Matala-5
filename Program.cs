using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Program
    {
        static void Main(string[] args)
        {
            User[] basicUsers = new User[]
                {
                new User("123456789", "David", "Levi", "Dave", "050-1234567", new
                DateTime(1995, 4, 23)),
                new User("987654321", "Sara", "Cohen", "Sari", "052-7654321", new
                DateTime(1998, 9, 15))
                };

            RegisteredUser[] registeredUserAccounts = new RegisteredUser[]
            {
                new RegisteredUser("456123789", "michael@example.com",
                "MikeSecure1", "Michael", "Rosen", "Mike", "054-9876543", new DateTime(2000, 1, 5)),
                new RegisteredUser("321789654", "rachel@example.com", "RachG1234",
                "Rachel", "Gold", "Rachi", "053-5678910", new DateTime(1993, 7, 10))
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
        }
    }
}
