using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CarRental
{
    public partial class RentCar : Form
    {
        public RentCar()
        {
            InitializeComponent();
            getAllCars();
            getAllCustomers();
            getAllRentals();
            loadRentals();
            rentBtn.Enabled = false;
            generateNewRentalID();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\CarRental\\CarRental\\CarRentalDB.mdf; Integrated Security=True;");
        SqlCommand cmd;
        SqlDataReader dr;


        private void textChangedEvents()
        {
            rentIDTxt.TextChanged += new EventHandler(TextFields_TextChanged);
            carCombo.TextChanged += new EventHandler(TextFields_TextChanged);
            carModTxt.TextChanged += new EventHandler(TextFields_TextChanged);
            customerCombo.TextChanged += new EventHandler(TextFields_TextChanged);
            custoNameTxt.TextChanged += new EventHandler(TextFields_TextChanged);
            pickDate.TextChanged += new EventHandler(TextFields_TextChanged);
            retDate.TextChanged += new EventHandler(TextFields_TextChanged);
            feeTxt.TextChanged += new EventHandler(TextFields_TextChanged);
        }

        private void TextFields_TextChanged(object sender, EventArgs e)
        {
            rentBtn.Enabled = !string.IsNullOrWhiteSpace(rentIDTxt.Text) &&
                                  !string.IsNullOrWhiteSpace(carCombo.Text) &&
                                  !string.IsNullOrWhiteSpace(carModTxt.Text) &&
                                  !string.IsNullOrWhiteSpace(customerCombo.Text) &&
                                  !string.IsNullOrWhiteSpace(custoNameTxt.Text) &&
                                  !string.IsNullOrWhiteSpace(pickDate.Text) &&
                                  !string.IsNullOrWhiteSpace(retDate.Text) &&
                                  !string.IsNullOrWhiteSpace(feeTxt.Text);
        }

        private void generateNewRentalID()
        {
            con.Open();
            cmd = new SqlCommand("SELECT ISNULL(MAX(CAST(rent_id AS INT)), 5000) + 1 FROM rentals", con);
            int newID = (int)cmd.ExecuteScalar();
            con.Close();
            rentIDTxt.Text = newID.ToString();
        }

        public void getAllCars()
        {
            cmd = new SqlCommand("SELECT reg_no FROM cars", con); 
            con.Open();
            dr = cmd.ExecuteReader(); 
            while (dr.Read())
            {
                carCombo.Items.Add(dr["reg_no"].ToString());
            }
            dr.Close(); 
            con.Close();
        }

        public void getAllCustomers()
        {
            cmd = new SqlCommand("SELECT reg_no FROM customers", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                customerCombo.Items.Add(dr["reg_no"].ToString());
            }
            dr.Close();
            con.Close();
        }

        public void getAllRentals()
        {
            cmd = new SqlCommand("SELECT rent_id FROM rentals WHERE rent_status = 'Return pending'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                rentalCombo.Items.Add(dr["rent_id"].ToString());
            }           
            dr.Close();
            con.Close();
        }

        public void loadRentals()
        {
            cmd = new SqlCommand("SELECT * FROM rentals", con);
            con.Open();
            dr = cmd.ExecuteReader();
            dataGridRental.Rows.Clear();
            while (dr.Read())
            {
                dataGridRental.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7], dr[8]);
            }
            dr.Close();
            con.Close();
        }

        private void carCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carCombo.SelectedIndex != -1)
            {
                string selectedCarRegNo = carCombo.SelectedItem.ToString();
                cmd = new SqlCommand("SELECT * FROM cars WHERE reg_no = '" + selectedCarRegNo + "'", con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    carModTxt.Text = dr["model"].ToString();
                    string status;
                    status = dr["available"].ToString();
                    if (status == "No")
                    {
                        statusLabel.Text = "This car is not available at the moment";
                        customerCombo.Enabled = false;
                        custoNameTxt.Enabled = false;
                        pickDate.Enabled = false;
                        retDate.Enabled = false;
                        feeTxt.Enabled = false;
                        rentBtn.Enabled = false;
                    }
                    else
                    {
                        statusLabel.Text = "";
                        customerCombo.Enabled = true;
                        custoNameTxt.Enabled = true;
                        pickDate.Enabled = true;
                        retDate.Enabled = true;
                        feeTxt.Enabled = true;
                        rentBtn.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("No car found");
                }
                con.Close();
            }
        }

        private void customerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerCombo.SelectedIndex != -1)
            {
                string selectedCustomerRegNo = customerCombo.SelectedItem.ToString();
                cmd = new SqlCommand("SELECT * FROM customers WHERE reg_no = '" + selectedCustomerRegNo + "'", con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    custoNameTxt.Text = dr["name"].ToString();

                }
                else
                {
                    MessageBox.Show("No customer found");
                }
                dr.Close();
                con.Close();
            }
        }

        private void rentBtn_Click(object sender, EventArgs e)
        {
            string rentID = rentIDTxt.Text;
            string carID = carCombo.SelectedItem.ToString();
            string customerID = customerCombo.SelectedItem.ToString();
            string customerName = custoNameTxt.Text;
            string pickupDate = pickDate.Value.Date.ToString("dd-MM-yyyy");
            string returnDate = retDate.Value.Date.ToString("dd-MM-yyyy");
            string fee = feeTxt.Text;
            int extraFee = 0;
            string rentStatus = "Return pending";

            con.Open();
            cmd = new SqlCommand("SELECT COUNT(*) FROM rentals WHERE rent_id = @rent_id", con);
            cmd.Parameters.AddWithValue("@rent_id", rentID);
            int count = (int)cmd.ExecuteScalar();
            con.Close();

            if (count > 0)
            {
                MessageBox.Show("Rental already exists with this ID.");
                return; 
            }

            con.Open();
            cmd = new SqlCommand("INSERT INTO rentals (rent_id, car_id, cust_id, cust_name, pickup_date, return_date, fee, extra_fee, rent_status) VALUES (@rent_id, @car_id, @cust_id, @cust_name, @pickup_date, @return_date, @fee, @extra_fee, @rent_status)", con);
            cmd.Parameters.AddWithValue("@rent_id", rentID);
            cmd.Parameters.AddWithValue("@car_id", carID);
            cmd.Parameters.AddWithValue("@cust_id", customerID);
            cmd.Parameters.AddWithValue("@cust_name", customerName);
            cmd.Parameters.AddWithValue("@pickup_date", pickupDate);
            cmd.Parameters.AddWithValue("@return_date", returnDate);
            cmd.Parameters.AddWithValue("@fee", fee);
            cmd.Parameters.AddWithValue("@extra_fee", extraFee);
            cmd.Parameters.AddWithValue("@rent_status", rentStatus);
            cmd.ExecuteNonQuery();

            string sq1N = "UPDATE cars SET available = 'No' WHERE reg_no = @regno";
            SqlCommand cmdN = new SqlCommand(sq1N, con);
            cmdN.Parameters.AddWithValue("@regno", carID);
            cmdN.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Rental confirmed");

            rentIDTxt.Clear();
            feeTxt.Clear();
            custoNameTxt.Clear();
            carModTxt.Clear();
            statusLabel.Text = "";
            rentalCombo.Items.Clear();
            getAllRentals();
            generateNewRentalID();
            carCombo.SelectedIndex = -1;
            customerCombo.SelectedIndex = -1;
        }
       
        private void returnBtn_Click(object sender, EventArgs e)
        {
            string returnDate = returnedDate.Value.Date.ToString("dd-MM-yyyy");
            string extraFee = extraTxt.Text;
            string selectedRentID = rentalCombo.SelectedItem.ToString();
            string selectedCarID = null;
            string newRentStatus = "Completed";

            cmd = new SqlCommand("SELECT * FROM rentals WHERE rent_id = '" + selectedRentID + "'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                selectedCarID = dr["car_id"].ToString();

            }
            else
            {
                MessageBox.Show("No rental found for this ID");
            }
            con.Close();

            con.Open();
            SqlCommand cmdR = new SqlCommand("UPDATE rentals SET return_date = @return_date, extra_fee = @extra_fee, rent_status = @rent_status WHERE rent_id = @rentID", con);
            cmdR.Parameters.AddWithValue("@return_date", returnDate);
            cmdR.Parameters.AddWithValue("@extra_fee", extraFee);
            cmdR.Parameters.AddWithValue("@rent_status", newRentStatus);
            cmdR.Parameters.AddWithValue("@rentID", selectedRentID);
            cmdR.ExecuteNonQuery();

            SqlCommand cmdN = new SqlCommand("UPDATE cars SET available = 'Yes' WHERE reg_no = @regno", con);
            cmdN.Parameters.AddWithValue("@regno", selectedCarID);
            cmdN.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Rental concluded successfully");

            extraTxt.Clear();
            rentalCombo.SelectedIndex = -1;
        }
        
        private void reloadBtn_Click(object sender, EventArgs e)
        {
            loadRentals();
        }






        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RentCar_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rentalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
