using AntojitoModel.DTO;
using AntojitoModel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AntojitoBusiness
{
    public interface IUserService
    {
        bool SaveUser(UserDTO user);
        List<Users> GetAllUser();
        UserDTO Login(UserDTO userDTO);
    }
}
