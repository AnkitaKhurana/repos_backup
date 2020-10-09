using EShopping.Shared.DTOs;
using EShopping.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EShopping.DAL.Mapping
{
    public class Map
    {
        public static EShopping.Data.Models.Customer MapToCustomer(CustomerDTO customerDTO)
        {

            EShopping.Data.Models.Customer result = new EShopping.Data.Models.Customer
            {
                ID = customerDTO.ID,
                Email = customerDTO.Email,
                Name = customerDTO.Name,
                RoleId = customerDTO.RoleId,
                Password = customerDTO.Password,
                Address1 = customerDTO.Address1,
                Address2 = customerDTO.Address2,
                Address3 = customerDTO.Address3
            };
          
            return result;
        }
    }
}