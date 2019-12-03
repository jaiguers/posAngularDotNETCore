using AntojitoModel;
using AntojitoModel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AntojitoBusiness
{
    public class StateService : IStateService
    {
        private readonly AntojoDbContext context;

        public StateService(AntojoDbContext thisContext)
        {
            context = thisContext;
        }

        public bool SaveState(States states)
        {
            try
            {
                context.States.Add(states);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public List<States> GetAllStates()
        {
            try
            {
                return context.States.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
