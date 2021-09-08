using System;
using System.Collections.Generic;
using CasualEmployee.API.Data.Repos.Emp_Task;
using CasualEmployee.API.Models;

namespace CasualEmployee.API.Data.MockRepos
{
    public class ET_MockRepo : IEmpTaskRepo
    {
        public void CreateTask(Employee_Task task)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Employee_Task> GetAllTasks()
        {
            return new List<Employee_Task>
            {
                new Employee_Task{Id = 1, TaskName = "Dashboard", StartDate= Convert.ToDateTime("01-06-2021"), EndDate= Convert.ToDateTime("25-06-2021")},
                new Employee_Task{Id = 2, TaskName = "UX", StartDate= Convert.ToDateTime("01-07-2021"), EndDate= Convert.ToDateTime("25-08-2021")}
            };
        }

        public Employee_Task GetTask(int id)
        {
            return new Employee_Task { Id = 1, TaskName = "Dashboard", StartDate = Convert.ToDateTime("01-06-2021"), EndDate = Convert.ToDateTime("25-06-2021") };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateTask(Employee_Task task)
        {
            throw new System.NotImplementedException();
        }
    }
}