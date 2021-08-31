using System.Collections.Generic;
using CasualEmployee.API.Models;

namespace CasualEmployee.API.Data.Repos.Persons
{
    public interface IPersonRepo
    {
        IEnumerable<Person> AllPeople();
        Person GetPerson(int id);
    }
}