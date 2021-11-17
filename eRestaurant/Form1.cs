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
    public partial class Form1 : Form
    {
        private UserService userService;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userService = new UserService();
            User user = new User();
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;

            User userFromDb = userService.Login(user);
            MessageBox.Show(userFromDb.Email + user.Role);
        }
    }
}
