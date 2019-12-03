using AntojitoModel;
using AntojitoModel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AntojitoModel.DTO;

namespace AntojitoBusiness
{
    public class UserService : IUserService
    {
        private readonly AntojoDbContext context;

        public UserService(AntojoDbContext thisContext)
        {
            context = thisContext;
        }

        public bool SaveUser(UserDTO data)
        {
            try
            {
                Users user = new Users
                {
                    Login = data.Login,
                    Password = data.Password,
                    StateId = long.Parse(data.StateId),
                    CreationDate = DateTime.Now
                };

                context.Users.Add(user);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public List<Users> GetAllUser()
        {
            List<Users> lstU = new List<Users>();
            try
            {
                lstU = context.Users.Select(j => new Users
                {
                    Id = j.Id,
                    Login = j.Login,
                    StateId = j.StateId
                }).ToList();
                return lstU;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public UserDTO Login(UserDTO userDTO)
        {
            Users user = context.Users.Where(j => j.Login == userDTO.Login && j.Password == userDTO.Password).FirstOrDefault();
            if (user != null && user.Id > 0)
            {
                userDTO.Id = user.Id.ToString();
            }


            return userDTO;
        }
    }
}
