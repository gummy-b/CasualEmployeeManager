using System.Collections.Generic;
using CasualEmployee.API.Data.Repos.Persons;
using CasualEmployee.API.Models;

namespace CasualEmployee.API.Data.MockRepos
{
    public class P_MockRepo : IPersonRepo
    {
        public IEnumerable<Person> AllPeople()
        {
            return new List<Person>
            {
                new Person {Id = 1, FirstName = "Jessica", LastName = "Doe", PhoneNumber = 0786541365, ProfilePicture = "img.jpg", Email = "jdoe@example.com"},
                new Person {Id = 2, FirstName = "John", LastName = "Doe", PhoneNumber = 0786541365, ProfilePicture = "img.jpg", Email = "jdoe@example.com"},
                new Person {Id = 3, FirstName = "Berryl", LastName = "Pascal", PhoneNumber = 0786541365, ProfilePicture = "img.jpg", Email = "bdoe@example.com"},
                new Person {Id = 4, FirstName = "Zoe", LastName = "Fisher", PhoneNumber = 0786541365, ProfilePicture = "img.jpg", Email = "zdoe@example.com"}
            };

        }

        public Person GetPerson(int id)
        {
            return new Person { Id = 1, FirstName = "Jessica", LastName = "Doe", PhoneNumber = 0786541365, ProfilePicture = "img.jpg", Email = "jdoe@example.com" };
        }
    }
}