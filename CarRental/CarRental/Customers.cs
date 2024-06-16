using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            loadCustomers();
            textChangedEvents();
            custAddBtn.Enabled = false;
            generateNewCustomerID();
        }        

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\CarRental\\CarRental\\CarRentalDB.mdf; Integrated Security=True;");
        SqlCommand cmd;
        SqlDataReader dr;
        bool insert = true;
        string selectedNo;
        
        private void textChangedEvents()
        {
            custIDTxt.TextChanged += new EventHandler(TextFields_TextChanged);
            nicTxt.TextChanged += new EventHandler(TextFields_TextChanged);
            nameTxt.TextChanged += new EventHandler(TextFields_TextChanged);
            contactTxt.TextChanged += new EventHandler(TextFields_TextChanged);
        }

        private void TextFields_TextChanged(object sender, EventArgs e)
        {
            custAddBtn.Enabled = !string.IsNullOrWhiteSpace(custIDTxt.Text) &&
                                 !string.IsNullOrWhiteSpace(nicTxt.Text) &&
                                 !string.IsNullOrWhiteSpace(nameTxt.Text) &&
                                 !string.IsNullOrWhiteSpace(contactTxt.Text);
        }

        private void generateNewCustomerID()
        {
            con.Open();
            cmd = new SqlCommand("SELECT ISNULL(MAX(CAST(reg_no AS INT)), 3000) + 1 FROM customers", con);
            int newID = (int)cmd.ExecuteScalar();
            con.Close();
            custIDTxt.Text = newID.ToString();
        }
        
        private void custAddBtn_Click(object sender, EventArgs e)
        {
            string regNo = custIDTxt.Text;
            string nic = nicTxt.Text;
            string name = nameTxt.Text;
            string contact = contactTxt.Text;

            con.Open();
            cmd = new SqlCommand("SELECT COUNT(*) FROM customers WHERE reg_no = @reg_no", con);
            cmd.Parameters.AddWithValue("@reg_no", regNo);
            int count = (int)cmd.ExecuteScalar();
            con.Close();

            if (insert == true)
            {
                if (count > 0)
                {
                    MessageBox.Show("Customer already exists with this registration number.");
                    return;
                }
                con.Open();
                cmd = new SqlCommand("INSERT INTO customers (reg_no, nic, name, contact) VALUES (@reg_no, @nic, @name, @contact);", con);
                cmd.Parameters.AddWithValue("@reg_no", regNo);
                cmd.Parameters.AddWithValue("@nic", nic);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Customer added to the sytem successfully");
            }
            else
            {              
                con.Open();
                cmd = new SqlCommand("UPDATE customers SET nic = @nic, name = @name, contact = @contact WHERE reg_no = @reg_no;", con);
                cmd.Parameters.AddWithValue("@nic", nic);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.Parameters.AddWithValue("@reg_no", selectedNo);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Customer details updated successfully");
                insert = true;
            }
            custIDTxt.Clear();
            nicTxt.Clear();
            nameTxt.Clear();
            contactTxt.Clear();
            generateNewCustomerID();
        }


        public void loadCustomers()
        {
            cmd = new SqlCommand("SELECT * FROM customers", con);
            con.Open();
            dr = cmd.ExecuteReader(); dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
            }
            con.Close();
        }

        public void getCustomerDetails(String customerRegNo)
        {
            cmd = new SqlCommand("SELECT * FROM customers WHERE reg_no = '" + customerRegNo + "' ", con);
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                custIDTxt.Text = dr[0].ToString();
                nameTxt.Text = dr[1].ToString();
                nicTxt.Text = dr[2].ToString();
                contactTxt.Text = dr[3].ToString();
            }

            con.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["editCol"].Index && e.RowIndex >= 0)
            {
                insert = false;
                selectedNo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                getCustomerDetails(selectedNo);
            }
            else if (e.ColumnIndex == dataGridView1.Columns["deleteCol"].Index && e.RowIndex >= 0)
            {
                string deleteID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                con.Open();
                cmd = new SqlCommand("DELETE FROM customers WHERE reg_no = @reg_no", con);
                cmd.Parameters.AddWithValue("@reg_no", deleteID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Customer deleted from the system successfully");
            }
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            loadCustomers();
        }




        private void Customers_Load(object sender, EventArgs e)
        {

        }

    }
}
