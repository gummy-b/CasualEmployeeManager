using System.Collections.Generic;
using CasualEmployee.API.Models;

namespace CasualEmployee.API.Data
{
    public interface IRolesRepo
    {
        IEnumerable<Roles> GetAllRoles();
        Roles GetRoles(int id);
    }
}