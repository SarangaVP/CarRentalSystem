using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void carRegBtn_Click(object sender, EventArgs e)
        {
            CarRegister carReg = new CarRegister();
            carReg.Show();
        }

        private void custRegBtn_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.Show();
        }

        private void rentBtn_Click(object sender, EventArgs e)
        {
            RentCar rentCar = new RentCar();
            rentCar.Show();
        }

        private void paymentBtn_Click(object sender, EventArgs e)
        {
            Payements paymentLog = new Payements();
            paymentLog.Show();
        }


        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
