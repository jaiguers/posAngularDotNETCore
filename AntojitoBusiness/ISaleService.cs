using AntojitoModel.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace AntojitoBusiness
{
    public interface ISaleService
    {
        bool SaveUser(SaleDTO data);
        List<SaleDTO> GetAllSale();
    }
}
