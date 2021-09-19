using System.Collections.Generic;
using CasualEmployee.API.Models;

namespace CasualEmployee.API.Data.Repos.Assignments
{
    public interface IAssignmentRepo
    {
        IEnumerable<Assign_Task> GetAllAssignments();
        Assign_Task GetAssignedTask(int id);
        void AssignTask(Assign_Task assignment);
        void UpdateAssignment(Assign_Task assignment);
        bool SaveChanges();
    }
}