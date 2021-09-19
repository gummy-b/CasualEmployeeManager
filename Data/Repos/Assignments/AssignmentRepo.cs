using System;
using System.Collections.Generic;
using System.Linq;
using CasualEmployee.API.Models;

namespace CasualEmployee.API.Data.Repos.Assignments
{
    public class AssignmentRepo : IAssignmentRepo
    {
        private readonly CEContext _con;

        public AssignmentRepo(CEContext con)
        {
            _con = con;
        }
        public void AssignTask(Assign_Task assignment)
        {
            if (assignment == null)
            {
                throw new ArgumentNullException(nameof(assignment));
            }

            _con.Assign_Tasks.Add(assignment);
        }

        public IEnumerable<Assign_Task> GetAllAssignments()
        {
            return _con.Assign_Tasks.ToList();
        }

        public Assign_Task GetAssignedTask(int id)
        {
            return _con.Assign_Tasks.FirstOrDefault(a => a.Id == id);
        }

        public bool SaveChanges()
        {
            return (_con.SaveChanges() >= 0);
        }

        public void UpdateAssignment(Assign_Task assignment)
        {
            // nothing here
        }
    }
}