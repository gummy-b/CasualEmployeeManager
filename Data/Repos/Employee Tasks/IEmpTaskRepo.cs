using System.Collections.Generic;
using CasualEmployee.API.Models;

namespace CasualEmployee.API.Data.Repos.Emp_Task
{
    public interface IEmpTaskRepo
    {
        IEnumerable<Employee_Task> GetAllTasks();
        Employee_Task GetTask(int id);
        void CreateTask(Employee_Task task);
        void UpdateTask(Employee_Task task);
        bool SaveChanges();
    }
}