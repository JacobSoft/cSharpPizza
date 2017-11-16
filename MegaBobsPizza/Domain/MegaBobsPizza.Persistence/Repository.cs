using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaBobsPizza.Persistence
{
    public class Repository
    {
        public static void CreateOrder(DTO.DTOorder orderFromDTO)
        {
            var db = new PizzaEntities2();

            var entityOrder = createOrderEntity(orderFromDTO);

            db.PizzaOrders.Add(entityOrder);

            db.SaveChanges();
        }

        private static PizzaOrder createOrderEntity(DTO.DTOorder orderFromDTO)
        {
            var entityOrder = new PizzaOrder();
            entityOrder.OrderId = orderFromDTO.OrderID;
            entityOrder.Size = orderFromDTO.PizzaSize;
            entityOrder.Crust = orderFromDTO.PizzaCrust;
            entityOrder.Sausage = orderFromDTO.Sausage;
            entityOrder.Pepperoni = orderFromDTO.Pepperoni;
            entityOrder.Onions = orderFromDTO.Onion;
            entityOrder.GreenPeppers = orderFromDTO.GreenPeppers;
            entityOrder.TotalCost = orderFromDTO.TotalPrice;
            entityOrder.Name = orderFromDTO.Name;
            entityOrder.Completed = orderFromDTO.Completed;

            return entityOrder;
        }
    }
}
