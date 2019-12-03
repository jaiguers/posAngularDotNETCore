using AntojitoModel;
using AntojitoModel.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AntojitoModel.Model;

namespace AntojitoBusiness
{
    public class SaleService : ISaleService
    {
        private readonly AntojoDbContext context;

        public SaleService(AntojoDbContext thisContext)
        {
            context = thisContext;
        }

        public bool SaveUser(SaleDTO data)
        {
            try
            {
                Sales sale = new Sales
                {
                    ClientId = data.ClientId,
                    UserId = data.UserId,
                    Code = data.Code,
                    Iva = data.Iva,
                    NetoWorth = data.NetoWorth,
                    Total = data.Total,
                    PaymentMethodId = data.PaymentMethodId,
                    CreationDate = DateTime.Now
                };

                context.Sales.Add(sale);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public List<SaleDTO> GetAllSale()
        {
            List<SaleDTO> lstSale = new List<SaleDTO>();
            try
            {
                lstSale = context.Sales.Select(j => new SaleDTO
                {
                    Id = j.Id,
                    ClientId = j.ClientId,
                    UserId = j.UserId,
                    Code = j.Code,
                    Iva = j.Iva,
                    NetoWorth = j.NetoWorth,
                    Total = j.Total,
                    PaymentMethodId = j.PaymentMethodId

                }).ToList();

                return lstSale;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private string GetUserName(long id)
        {
            Users u = context.Users.Find(id);

            return (u == null || u.Id == 0) ? "" : u.Login;
        }
    }
}
