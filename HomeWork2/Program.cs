using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {

            var users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });


            Console.WriteLine("All users:");
            foreach (var user in users)
                Console.WriteLine(user.Name + "  " + user.Password);
            var usersHello = users.Where(t => t.Password == "hello");

            Console.WriteLine("\nUsers with password \"hello\":");
            foreach (var user in usersHello)
                Console.WriteLine(user.Name + "  " + user.Password);

            var userLowerCase = users.Find(t => t.Password == t.Name.ToLower());
            users.Remove(userLowerCase);

            Console.WriteLine("\nRemove users with password same as lower case name:");
            foreach (var user in users)
                Console.WriteLine(user.Name + "  " + user.Password);

            var firstHello = users.FirstOrDefault(t => t.Password == "hello");
            users.Remove(firstHello);

            Console.WriteLine("\nRemove first user with password \"hello\":");
            foreach (var user in users)
                Console.WriteLine(user.Name + "  " + user.Password);
        }
    }
}
