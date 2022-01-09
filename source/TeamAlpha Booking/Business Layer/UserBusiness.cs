using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;
using Data_Layer;

namespace Business_Layer
{
    public class UserBusiness
    {

        private readonly UserRepository userRepository;
        
        public int  RegisterUser (User user) // pass validated instance
        {
            String email = user.Email;

            if (userRepository.IsEmailUnique(email)) { // check if entered email is unique  
                return userRepository.InsertUser(user); //insert new user into db
            }

            return -1;
        }
    }
}
