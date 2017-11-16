using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaBobsPizza.Persistence
{
    public class OrderGrabber
    {

        public static List<DTO.DTOorder> GrabOrders()
        {
            var db = new PizzaEntities2();
            var ordersList = db.PizzaOrders.Where(p => p.Completed == false).ToList();
            var DTOorders = sendToDTO(ordersList);
            return DTOorders;

        }

        private static List<DTO.DTOorder> sendToDTO(List<PizzaOrder> ordersList)
        {
            var DTOorders = new List<DTO.DTOorder>();

            foreach (var order in ordersList)
            {
                var DTOorder = new DTO.DTOorder();
                DTOorder.OrderID = order.OrderId;
                DTOorder.PizzaCrust = order.Crust;
                DTOorder.PizzaSize = order.Size;
                DTOorder.Sausage = order.Sausage;
                DTOorder.Pepperoni = order.Pepperoni;
                DTOorder.Onion = order.Onions;
                DTOorder.GreenPeppers = order.GreenPeppers;
                DTOorder.TotalPrice = order.TotalCost;
                DTOorder.Name = order.Name;

                DTOorders.Add(DTOorder);
            }

            return DTOorders;
        }

        public static void CompleteOrder (Guid orderID)
        {
            var db = new PizzaEntities2();
            var order = db.PizzaOrders.FirstOrDefault(p => p.OrderId == orderID);
            order.Completed = true;
            db.SaveChanges();
        }
    }
}
