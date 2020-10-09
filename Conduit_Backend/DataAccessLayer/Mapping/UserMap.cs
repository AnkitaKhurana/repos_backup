using Data.Models;
using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    public class UserMap
    {
        public UserDTO ToDTO(User user)
        {
            UserDTO userDTO = new UserDTO()
            {
                Id = user.Id,
                Username = user.Username,
                Email = user.Email,
                Bio = user.Bio,
                Image = user.Image,
                Token = user.Token,

            };
            return userDTO;

        }

        public User ToDB(UserDTO userDTO)
        {
            User user = new User()
            {
                Id = userDTO.Id,
                Username = userDTO.Username,
                Email = userDTO.Email,
                Bio = userDTO.Bio,
                Image = userDTO.Image,
                Token = userDTO.Token,

            };
            return user;

        }
    }
}
