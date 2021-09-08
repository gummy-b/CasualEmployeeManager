using System;
using System.Collections.Generic;
using System.Linq;
using CasualEmployee.API.Models;

namespace CasualEmployee.API.Data.Repos.Casual_Emp
{
    public class CasualEmpRepo : ICasualEmpRepo
    {
        private readonly CEContext _context;

        public CasualEmpRepo(CEContext context)
        {
            _context = context;
        }
        public void CreateEmployee(CEmployee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }

            _context.Employees.Add(employee);
        }

        public IEnumerable<CEmployee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public CEmployee GetEmployee(int id)
        {
            return _context.Employees.FirstOrDefault(e => e.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateEmployee(CEmployee employee)
        {
            // nothing here
        }
    }
}