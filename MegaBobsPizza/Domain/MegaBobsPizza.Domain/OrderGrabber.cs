using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaBobsPizza.Domain
{
    public class OrderGrabber
    {
        public static List<DTO.DTOorder> GrabOrders()
        {
            var orders = Persistence.OrderGrabber.GrabOrders();

            return orders;
        }

        public static void CompleteOrder(Guid OrderID)
        {
            Persistence.OrderGrabber.CompleteOrder(OrderID);
        }
    }
}
