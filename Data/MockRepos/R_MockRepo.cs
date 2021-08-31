using System.Collections.Generic;
using CasualEmployee.API.Models;

namespace CasualEmployee.API.Data.MockRepos
{
    public class R_MockRepo : IRolesRepo
    {
        public void AddRole(Roles role)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Roles> GetAllRoles()
        {
            return new List<Roles>
            {
                new Roles {Id = 1, RoleName = "Cas Employee 1", RoleRate = 20.99M},
                new Roles {Id = 2, RoleName = "Cas Employee 2", RoleRate = 40.99M},
                new Roles {Id = 3, RoleName = "Cas Employee 3", RoleRate = 60.99M}
            };
        }

        public Roles GetRoles(int id)
        {
            return new Roles
            {
                Id = 1,
                RoleName = "Cas Employee 1",
                RoleRate = 20.99M
            };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}