using Data.Models;
using DataAccessLayer.Mapping;
using Shared.DTOs;
using System.Collections.Generic;

namespace DataAccessLayer.Data
{
    public class UserData
    {
        private ConduitContext db  = new ConduitContext();
        private UserMap userMap = new UserMap();
        public UserDTO Add(UserDTO userDTO)
        {
            try
            {
                User user = new User()
                {
                    Id = userDTO.Id,
                    Username = userDTO.Username,
                    Token = userDTO.Token,
                    Bio = userDTO.Bio,
                    Email = userDTO.Email,
                    Image = userDTO.Image,
                    Articles = new List<Article>()
                };
               
                var dbUser =  db.Users.Add(user);
                db.SaveChanges();
                return userMap.ToDTO(dbUser);
            }
            catch
            {
                return null;
            }
        }
    }
}
