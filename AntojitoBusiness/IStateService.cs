using AntojitoModel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AntojitoBusiness
{
    public interface IStateService
    {
        bool SaveState(States states);
        List<States> GetAllStates();
    }
}
