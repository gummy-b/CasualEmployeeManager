using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task<Person> AddPerson(Person person)
        {
            if (person == null)
            {
                throw new ArgumentNullException(nameof(person));
            }

            var personObj = await _con.People.AddAsync(person);

            return personObj.Entity;

        }

        public IEnumerable<Person> AllPeople()
        {
            return _con.People.ToList();
        }

        public Person GetPerson(int id)
        {
            return _con.People.FirstOrDefault(x => x.Id == id);
        }

        public bool SaveChanges()
        {
            return (_con.SaveChanges() >= 0);
        }

        void IPersonRepo.Update(Person person)
        {
            // Nothing here
        }
    }
}