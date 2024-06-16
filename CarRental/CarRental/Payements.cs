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
    public partial class Payements : Form
    {
        public Payements()
        {
            InitializeComponent();
            loadRentalCharges();
            loadRentalIDs();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\CarRental\\CarRental\\CarRentalDB.mdf; Integrated Security=True;");
        SqlCommand cmd;
        SqlDataReader dr;
        
        public void loadRentalCharges()
        {
            cmd = new SqlCommand("SELECT rent_id, fee, extra_fee FROM rentals", con);
            con.Open();
            dr = cmd.ExecuteReader(); dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                decimal totalCharge = Convert.ToDecimal(dr[1]) + Convert.ToDecimal(dr[2]);
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], totalCharge);
            }
            con.Close();
        }

        public void loadRentalIDs()
        {
            cmd = new SqlCommand("SELECT rent_id FROM rentals", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                startCombo.Items.Add(dr[0]);
                endCombo.Items.Add(dr[0]);
            }
            con.Close();
        }


        private decimal CalculateSum(int startId, int endId)
        {
            decimal sumTotal = 0;
            cmd = new SqlCommand("SELECT fee, extra_fee FROM rentals WHERE rent_id BETWEEN @startId AND @endId", con);
            cmd.Parameters.AddWithValue("@startId", startId);
            cmd.Parameters.AddWithValue("@endId", endId);

            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                decimal totalCharge = Convert.ToDecimal(dr[0]) + Convert.ToDecimal(dr[1]);
                sumTotal += totalCharge;
            }
            con.Close();

            return sumTotal;
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            if (startCombo.SelectedItem != null && endCombo.SelectedItem != null)
            {
                int startId = Convert.ToInt32(startCombo.SelectedItem);
                int endId = Convert.ToInt32(endCombo.SelectedItem);
                if (startId < endId)
                {
                    decimal sumTotal = CalculateSum(startId, endId);
                    sumLabel.Text = "Total earnings for this period: Rs " + sumTotal.ToString();
                }
                else
                {
                    MessageBox.Show("Please select valid start and end IDs.");
                }
            }
            else
            {
                MessageBox.Show("Please select valid start and end IDs.");
            }
        }

        private void Payements_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
