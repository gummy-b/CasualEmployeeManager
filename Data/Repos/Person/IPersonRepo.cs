using System.Collections.Generic;
using System.Threading.Tasks;
using CasualEmployee.API.Models;

namespace CasualEmployee.API.Data.Repos.Persons
{
    public interface IPersonRepo
    {
        IEnumerable<Person> AllPeople();
        Person GetPerson(int id);
        Task<Person> AddPerson(Person person);
        bool SaveChanges();

        void Update(Person person);
    }
}