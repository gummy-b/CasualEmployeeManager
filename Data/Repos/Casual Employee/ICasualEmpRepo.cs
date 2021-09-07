using System.Collections.Generic;
using CasualEmployee.API.Models;

namespace CasualEmployee.API.Data.Repos.Casual_Emp
{
    public interface ICasualEmpRepo
    {
        IEnumerable<CEmployee> GetAllEmployees();
        CEmployee GetEmployee(int id);
        bool SaveChanges();
        void CreateEmployee(CEmployee employee);
    }
}