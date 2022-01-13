using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;

namespace Shared.Interfaces
{
    public interface IUserBusiness
    {
        int RegisterUser(User user);
        Boolean CheckPassword(string email, string password);
        User GetUserByEmail(string email);
    }
}
