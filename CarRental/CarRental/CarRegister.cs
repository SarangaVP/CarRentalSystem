using System;
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
    public partial class CarRegister : Form
    {
        public CarRegister()
        {
            InitializeComponent();
            loadCars();
            textChangedEvents();
            carAddBtn.Enabled = false;
            generateNewCarID();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\CarRental\\CarRental\\CarRentalDB.mdf; Integrated Security=True;");
        SqlCommand cmd;
        SqlDataReader dr;
        bool insert = true;
        string selectedNo;


        private void generateNewCarID()
        {
            con.Open();
            cmd = new SqlCommand("SELECT ISNULL(MAX(CAST(reg_no AS INT)), 1000) + 1 FROM cars", con);
            int newID = (int)cmd.ExecuteScalar();
            con.Close();
            carIDTxt.Text = newID.ToString();
        }

        private void textChangedEvents()
        {
            carIDTxt.TextChanged += new EventHandler(TextFields_TextChanged);
            npTxt.TextChanged += new EventHandler(TextFields_TextChanged);
            modelTxt.TextChanged += new EventHandler(TextFields_TextChanged);
            avaTxt.TextChanged += new EventHandler(TextFields_TextChanged);
        }

        private void TextFields_TextChanged(object sender, EventArgs e)
        {
            carAddBtn.Enabled = !string.IsNullOrWhiteSpace(carIDTxt.Text) &&
                                 !string.IsNullOrWhiteSpace(npTxt.Text) &&
                                 !string.IsNullOrWhiteSpace(modelTxt.Text) &&
                                 !string.IsNullOrWhiteSpace(avaTxt.Text);
        }

        public void loadCars()
        {
            cmd = new SqlCommand("SELECT * FROM cars", con);
            con.Open();
            dr = cmd.ExecuteReader(); dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
            }
            con.Close();
        }

        private void carAddBtn_Click(object sender, EventArgs e)
        {
            string regNo = carIDTxt.Text;
            string numPlate = npTxt.Text;
            string model = modelTxt.Text;
            string available = avaTxt.SelectedItem.ToString();

            con.Open();
            cmd = new SqlCommand("SELECT COUNT(*) FROM cars WHERE reg_no = @reg_no", con);
            cmd.Parameters.AddWithValue("@reg_no", regNo);
            int count = (int)cmd.ExecuteScalar();
            con.Close();

            if (insert == true)
            {
                if (count > 0)
                {
                    MessageBox.Show("Car already exists with this registration number.");
                    return; 
                }
                con.Open();
                cmd = new SqlCommand("INSERT INTO cars (reg_no, num_plate, model, available) VALUES (@reg_no, @num_plate, @model, @available);", con);
                cmd.Parameters.AddWithValue("@reg_no", regNo);
                cmd.Parameters.AddWithValue("@num_plate", numPlate);
                cmd.Parameters.AddWithValue("@model", model);
                cmd.Parameters.AddWithValue("@available", available);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Car added to the system successfully");
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("UPDATE cars SET num_plate = @num_plate, model = @model, available = @available WHERE reg_no = @reg_no;", con);
                cmd.Parameters.AddWithValue("@num_plate", numPlate);
                cmd.Parameters.AddWithValue("@model", model);
                cmd.Parameters.AddWithValue("@available", available);
                cmd.Parameters.AddWithValue("@reg_no", selectedNo);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Car details updated successfully");
                insert = true;
            }
            carIDTxt.Clear();
            modelTxt.Clear();
            npTxt.Clear();
            avaTxt.SelectedIndex = -1;
            generateNewCarID();
        }

        public void getCarDetails(String carRegNo)
        {
            cmd = new SqlCommand("SELECT * FROM cars WHERE reg_no = '" + carRegNo + "' ", con);
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                carIDTxt.Text = dr[0].ToString();
                modelTxt.Text = dr[1].ToString();
                npTxt.Text = dr[2].ToString();
                avaTxt.Text = dr[3].ToString();
            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["editCol"].Index && e.RowIndex >= 0)
            {
                insert = false;
                selectedNo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                getCarDetails(selectedNo);
            }

            else if (e.ColumnIndex == dataGridView1.Columns["deleteCol"].Index && e.RowIndex >= 0)
            {
                string deleteID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                con.Open();
                cmd = new SqlCommand("DELETE FROM cars WHERE reg_no = @reg_no", con);
                cmd.Parameters.AddWithValue("@reg_no", deleteID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Car deleted from the system successfully");              
            }
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            loadCars();
        }





        private void CarRegister_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
