using AntojitoModel;
using AntojitoModel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AntojitoBusiness
{
    public class RolService:IRolService
    {
        private readonly AntojoDbContext context;

        public RolService(AntojoDbContext thisContext)
        {
            context = thisContext;
        }

        public List<Rol> GetAllRol()
        {
            try
            {
                return context.Rol.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
