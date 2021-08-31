using System;
using System.Collections.Generic;
using System.Linq;

namespace CasualEmployee.API.Data.Repos.Roles
{
    public class RolesRepo : IRolesRepo
    {
        private readonly CEContext _con;

        public RolesRepo(CEContext con)
        {
            _con = con;
        }

        public void AddRole(Models.Roles role)
        {
            if (role == null)
            {
                throw new ArgumentNullException(nameof(role));
            }

            _con.Roles.Add(role);
        }

        public IEnumerable<Models.Roles> GetAllRoles()
        {
            return _con.Roles.ToList();
        }

        public Models.Roles GetRoles(int id)
        {
            return _con.Roles.FirstOrDefault(r => r.Id == id);
        }

        public bool SaveChanges()
        {
            return (_con.SaveChanges() >= 0);
        }
    }
}