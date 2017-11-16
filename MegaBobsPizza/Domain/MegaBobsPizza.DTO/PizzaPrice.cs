using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaBobsPizza.DTO
{
    public class PizzaPrice
    {
            public decimal smallPrice { get; set; }
            public decimal mediumPrice { get; set; }
            public decimal largePrice { get; set; }
            public decimal thinCrustPrice { get; set; }
            public decimal thickCrustPrice { get; set; }
            public decimal sausagePrice { get; set; }
            public decimal pepperoniPrice { get; set; }
            public decimal onionsPrice { get; set; }
            public decimal greenPeppersPrice { get; set; }
            public decimal totalCost { get; set; }

        public decimal sizeCostCalc(DTO.DTOorder orderFromDTO)
        {
            decimal sizePrice = 0;

            if (orderFromDTO.PizzaSize == DTO.Enums.PizzaSize.Small)
                sizePrice += 12;
            if (orderFromDTO.PizzaSize == DTO.Enums.PizzaSize.Medium)
                sizePrice += 14;
            if (orderFromDTO.PizzaSize == DTO.Enums.PizzaSize.Large)
                sizePrice += 16;

            return sizePrice;
        }

    }
}
