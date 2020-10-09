using DataAccessLayer.Data;
using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Logic
{
    class UserLogic
    {
        private UserData userData = new UserData();

        public UserDTO Register(UserDTO user)
        {
            try
            {
                UserDTO userDTO = new UserDTO();
                user.Token = GenerateToken();
                user.Id = Guid.NewGuid();
                userDTO = userData.Add(user);
                return userDTO;
            }
            catch 
            {
                return null;
            }
        }

        private string GenerateToken()
        {
            return "";
        }

    }
}
