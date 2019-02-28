using System;
#nullable enable
namespace NonNullableTypesDemo
{
    class Program
    {
        static void Main()
        {
            var user = new User("Jan", "Kowalski");
            Console.WriteLine($"{user.FirstName} {user.LastName} {user.Boss.FirstName}");
        }
    }

    class User
    {
        public User(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public User Boss { get; set; }
    }
}
