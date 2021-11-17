using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestaurant
{
    public partial class Main : Form
    {
        Restaurant.RestaurantMain restaurantForm = new Restaurant.RestaurantMain();
        Products.ProductMain productsForm = new Products.ProductMain();
        Order.OrderMain orderForm = new Order.OrderMain();

        public Main()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (pnlContent.Contains(productsForm)) this.productsForm.Close();
            if (pnlContent.Contains(orderForm)) this.orderForm.Close();
            restaurantForm.TopLevel = false;
            restaurantForm.Parent = pnlContent;
            restaurantForm.Dock = DockStyle.Fill;
            restaurantForm.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            if (pnlContent.Contains(restaurantForm)) this.restaurantForm.Close();
            if (pnlContent.Contains(orderForm)) this.orderForm.Close();
            productsForm.TopLevel = false;
            productsForm.Parent = pnlContent;
            productsForm.Dock = DockStyle.Fill;
            productsForm.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (pnlContent.Contains(restaurantForm)) this.restaurantForm.Close();
            if (pnlContent.Contains(productsForm)) this.productsForm.Close();
            orderForm.TopLevel = false;
            orderForm.Parent = pnlContent;
            orderForm.Dock = DockStyle.Fill;
            orderForm.Show();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(709, 519);
            this.Name = "Main";
            this.ResumeLayout(false);

        }
    }
}
