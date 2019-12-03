using AntojitoModel.DTO;
using AntojitoModel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AntojitoBusiness
{
    public interface IClientService
    {
        bool SaveClient(ClientDTO clientDTO);
        List<Client> GetAllClient();
    }
}
