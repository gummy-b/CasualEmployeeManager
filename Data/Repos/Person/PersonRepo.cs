using System.Collections.Generic;
using System.Linq;
using CasualEmployee.API.Models;

namespace CasualEmployee.API.Data.Repos.Persons
{
    public class PersonRepo : IPersonRepo
    {
        private readonly CEContext _con;

        public PersonRepo(CEContext con)
        {
            _con = con;
        }
        public IEnumerable<Person> AllPeople()
        {
            return _con.People.ToList();
        }

        public Person GetPerson(int id)
        {
            return _con.People.FirstOrDefault(x => x.Id == id);
        }
    }
}