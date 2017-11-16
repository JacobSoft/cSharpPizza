using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaBobsPizza.Web
{
    public partial class Default : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            //Domain.PizzaMaker pizza = new Domain.PizzaMaker();

        }

        protected void orderButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Trim().Length == 0)
            {
                errorLabel.Text = "You must enter a name for your order.";
                return;
            }

            if (addressTextBox.Text.Trim().Length == 0)
            {
                errorLabel.Text = "You must enter an address for your order.";
                return;
            }

            if (zipTextBox.Text.Trim().Length == 0)
            {
                errorLabel.Text = "You must enter a zipcode for your order.";
                return;
            }

            if (phoneTextBox.Text.Trim().Length == 0)
            {
                errorLabel.Text = "You must enter a phone number for your order.";
                return;
            }
            if (!cashRadioButton.Checked && !creditRadioButton.Checked)
            {
                errorLabel.Text = "Please select a payment type.";
                return;
            }

            try
            {
                var newOrder = createOrder();
                Domain.PizzaMaker.CreateOrder(newOrder);
                Response.Redirect("SuccessPage.aspx");
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
                return;
            }

            //Domain.PizzaMaker.CreateOrder();
        }

        protected void displayCost(object sender, EventArgs e)
        {
            var order = createOrder();
            resultLabel.Text = Domain.PizzaPrice.calculateCosts(order).ToString(String.Format("{0:C}", order.TotalPrice));
        }

        private DTO.DTOorder createOrder()
        {
            //DTO.Enums.PizzaSize pizzaSize;

            var order = new DTO.DTOorder();
            order.OrderID = Guid.NewGuid();
            order.PizzaSize = getPizzaSize();
            order.PizzaCrust = getCrust();
            order.Sausage = sausageCheckbox.Checked;
            order.Pepperoni = pepperoniCheckbox.Checked;
            order.Onion = onionsCheckbox.Checked;
            order.GreenPeppers = greenPeppersCheckbox.Checked;
            order.Name = nameTextBox.Text;
            order.Completed = false;

            return order;
        }

        private DTO.Enums.PizzaSize getPizzaSize()
        {
            DTO.Enums.PizzaSize pizzaSize;
            if (!Enum.TryParse(SizeList.SelectedValue, out pizzaSize))
            {
                errorLabel.Text = "Please select a pizza size.";
            }
            return pizzaSize;
        }

        private DTO.Enums.PizzaCrust getCrust()
        {
            DTO.Enums.PizzaCrust pizzaCrust;
            if (!Enum.TryParse(CrustList.SelectedValue, out pizzaCrust))
            {
                errorLabel.Text = "Please select a crust type.";
            }
            return pizzaCrust;
        }
    }
}