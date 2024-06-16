using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\CarRental\\CarRental\\CarRentalDB.mdf; Integrated Security=True;");
        SqlCommand cmd;
        SqlDataReader dr;

        private void logBtn_Click(object sender, EventArgs e)
        {
            string userName = userTxt.Text;
            string password = pwTxt.Text;
           
            cmd = new SqlCommand("SELECT * FROM login WHERE username = @username AND password = @password", con);
            cmd.Parameters.AddWithValue("@username", userName);
            cmd.Parameters.AddWithValue("@password", password);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                dr.Close();
                con.Close();
                this.Hide();
                Home home = new Home();
                home.Show();
               
            }
            else
            {
                dr.Close();
                con.Close();
                MessageBox.Show("Incorrect Username or Password");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
