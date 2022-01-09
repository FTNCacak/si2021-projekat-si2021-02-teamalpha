using Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class UserBusiness
    {
        IUserRepository userRepo;
        public Boolean CheckPassword(string email, string password)
        {
            if (userRepo.EmailExists(email))
            {
                return password.Equals(userRepo.GetPassByEmail(email));
            }
            return false;
        }
    }
}
