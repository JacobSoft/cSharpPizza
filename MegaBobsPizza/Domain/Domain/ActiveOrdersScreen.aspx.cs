using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaBobsPizza.Web
{
    public partial class ActiveOrdersScreen : System.Web.UI.Page
    {
        protected GridView GridView1;

        protected void Page_Load(object sender, EventArgs e)
        {
            displayOrders();

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = GridView1.Rows[index];
            var value = row.Cells[1].Text.ToString();
            var orderID = Guid.Parse(value);

            Domain.OrderGrabber.CompleteOrder(orderID);

            displayOrders();
        }

        public void displayOrders()
        {
            var currentOrders = Domain.OrderGrabber.GrabOrders();
            GridView1.DataSource = currentOrders;
            GridView1.DataBind();
        }
    }
}