using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestaurant.Order
{
    public partial class OrderMain : Form
    {
        public OrderMain()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // OrderMain
            // 
            this.ClientSize = new System.Drawing.Size(690, 482);
            this.Name = "OrderMain";
            this.ResumeLayout(false);

        }
    }
}
