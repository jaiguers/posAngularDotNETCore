using AntojitoModel;
using AntojitoModel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AntojitoModel.DTO;

namespace AntojitoBusiness
{
    public class ClientService : IClientService
    {
        private readonly AntojoDbContext context;

        public ClientService(AntojoDbContext thisContext)
        {
            context = thisContext;
        }

        public bool SaveClient(ClientDTO clientDTO)
        {
            try
            {
                Client client = new Client
                {
                    Name = clientDTO.Name,
                    Surnames = clientDTO.Surnames,
                    Identification = clientDTO.Identification,
                    Address = clientDTO.Address,
                    Phone = clientDTO.Phone,
                    Email = clientDTO.Email,
                    StateId = long.Parse(clientDTO.StateId),
                    Creationdate = DateTime.Now
                };

                context.Client.Add(client);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public List<Client> GetAllClient()
        {
            try
            {
                return context.Client.Select(j => new Client
                {
                    Id = j.Id,
                    Name = j.Name,
                    Surnames = j.Surnames,
                    Identification = j.Identification,
                    Address = j.Address,
                    Phone = j.Phone,
                    Email = j.Email,
                    StateId = j.StateId
                }).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
