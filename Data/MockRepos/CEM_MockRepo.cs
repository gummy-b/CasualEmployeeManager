using System.Collections.Generic;
using CasualEmployee.API.Data.Repos.Casual_Emp;
using CasualEmployee.API.Models;

namespace CasualEmployee.API.Data.MockRepos
{
    public class CEM_MockRepo : ICasualEmpRepo
    {
        public IEnumerable<CEmployee> GetAllEmployees()
        {
            return new List<CEmployee>
            {
                new CEmployee { Id = 1, Name = "Ted", Surname="Lasso", Role="Casual employee 1", ProfilePicture="img.png"},
                new CEmployee { Id = 1, Name = "Tasha", Surname="Lasso", Role="Casual employee 3", ProfilePicture="img.jpg"},
                new CEmployee { Id = 1, Name = "Tebo", Surname="Lasso", Role="Casual employee 2", ProfilePicture="img.png"}
            };
        }

        public CEmployee GetEmployee(int id)
        {
            return new CEmployee { Id = 1, Name = "Ted", Surname = "Lasso", Role = "Casual employee 1", ProfilePicture = "img.1" };
        }
    }
}