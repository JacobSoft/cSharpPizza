using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaBobsPizza.DTO
{
    public class DTOorder
    {
        public System.Guid OrderID { get; set; }
        public MegaBobsPizza.DTO.Enums.PizzaSize PizzaSize { get; set; }
        public MegaBobsPizza.DTO.Enums.PizzaCrust PizzaCrust { get; set; }
        public bool Sausage { get; set; }
        public bool Pepperoni { get; set; }
        public bool Onion { get; set; }
        public bool GreenPeppers { get; set; }
        public decimal TotalPrice { get; set; }
        public string Name { get; set; }
        public bool Completed { get; set; }
    }
}
