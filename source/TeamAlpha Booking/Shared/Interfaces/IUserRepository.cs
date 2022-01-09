using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;

namespace Shared.Interfaces
{
    public interface IUserRepository
    {
        int InsertUser(User user);
        List<User> GetAllUsers();
        int UpdateUserData(User UpdatedUser);
        int RemoveUser(int UserId);

        Boolean EmailExists(string email);

        string GetPassByEmail(string email);
    }
}
