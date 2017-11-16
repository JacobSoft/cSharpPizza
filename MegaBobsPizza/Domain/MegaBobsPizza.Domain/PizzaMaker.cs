using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaBobsPizza.DTO;

namespace MegaBobsPizza.Domain
{
    public class PizzaMaker
    {
        public static void CreateOrder(DTO.DTOorder orderFromDTO)
        {
            orderFromDTO.TotalPrice = PizzaPrice.calculateCosts(orderFromDTO);
            Persistence.Repository.CreateOrder(orderFromDTO);
        }
        /*
        private static decimal calculateCosts(DTOorder orderFromDTO)
        {
            decimal totalCost = 0;
            totalCost += calculateSizeCost(orderFromDTO);
            totalCost += calculateCrustCost(orderFromDTO);
            totalCost += calculateToppingsCost(orderFromDTO);

            return totalCost;
        }
        

        private static decimal calculateToppingsCost(DTOorder orderFromDTO)
        {
            decimal toppingsCost = 0;
            if (orderFromDTO.Sausage == true)
                toppingsCost += 2;
            if (orderFromDTO.Pepperoni == true)
                toppingsCost += Convert.ToDecimal(1.50);
            if (orderFromDTO.Onion == true)
                toppingsCost += 1;
            if (orderFromDTO.GreenPeppers == true)
                toppingsCost += 1;

            return toppingsCost;
        }

        private static decimal calculateCrustCost(DTOorder orderFromDTO)
        {
            decimal crustCost = 0;
            if (orderFromDTO.PizzaCrust == DTO.Enums.PizzaCrust.Thick)
                crustCost += 2;
            else crustCost = 0;
            return crustCost;

        }

        private static decimal calculateSizeCost(DTOorder orderFromDTO)
        {
            decimal sizePrice = 0;

            if (orderFromDTO.PizzaSize == DTO.Enums.PizzaSize.Small)
                sizePrice = 12;
            if (orderFromDTO.PizzaSize == DTO.Enums.PizzaSize.Medium)
                sizePrice = 14;
            if (orderFromDTO.PizzaSize == DTO.Enums.PizzaSize.Large)
                sizePrice = 16;

            return sizePrice;
        }
        */
        
    }
}
