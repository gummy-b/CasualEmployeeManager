using System;
using System.Collections.Generic;
using System.Linq;
using CasualEmployee.API.Data.Repos.Emp_Task;
using CasualEmployee.API.Models;

namespace CasualEmployee.API.Data.Repos.Casual_Emp
{
    public class EmpTaskRepo : IEmpTaskRepo
    {
        private readonly CEContext _context;

        public EmpTaskRepo(CEContext context)
        {
            _context = context;
        }
        public void CreateTask(Employee_Task task)
        {
            if (task == null)
            {
                throw new ArgumentNullException(nameof(task));
            }

            _context.EmployeeTasks.Add(task);
        }

        public IEnumerable<Employee_Task> GetAllTasks()
        {
            return _context.EmployeeTasks.ToList();
        }

        public Employee_Task GetTask(int id)
        {
            return _context.EmployeeTasks.FirstOrDefault(t => t.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateTask(Employee_Task task)
        {
            // nothing here
        }
    }
}