using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SimpleCallLogger
{
    public partial class UpdateCustomerForm : Form
    {
        string conString = "Data Source=.;Initial Catalog=SimpleCallLoggerDB;Integrated Security=True";

        public UpdateCustomerForm()
        {
            InitializeComponent();
        }

        private void UpdateCustomerForm_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            string selectID = @"select CustomerId from Customer";
            SqlCommand cmd = new SqlCommand(selectID, connection);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
                cboCustNumber.Items.Add(reader[0].ToString());

            reader.Dispose();

            cboCustNumber.SelectedIndex = 0;
            string select = @"select * from Customer where CustomerId=@id";
            cmd = new SqlCommand(select, connection);
            cmd.Parameters.AddWithValue("@id", int.Parse(cboCustNumber.SelectedItem.ToString()));

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtName.Text = reader[1].ToString();
                txtEmail.Text = reader[2].ToString();
                txtContact.Text = reader[3].ToString();
                txtAddress.Text = reader[4].ToString();
            }


            connection.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);

            con.Open();

            string updateCust = "update Customer set CustomerName=@name,CustomerEmail=@email,ContactNumber=@contact,Address=@address where CustomerId=@id";

            SqlCommand cmd = new SqlCommand(updateCust, con);
            cmd.Parameters.AddWithValue("@id",int.Parse(cboCustNumber.SelectedItem.ToString()));
            cmd.Parameters.AddWithValue("@name",txtName.Text);
            cmd.Parameters.AddWithValue("@email",txtEmail.Text);
            cmd.Parameters.AddWithValue("@contact",txtContact.Text);
            cmd.Parameters.AddWithValue("@address",txtAddress.Text);

            int i = cmd.ExecuteNonQuery();

            if (i > 0)
                MessageBox.Show("Record Updated!");

            con.Close();
        }

        private void cboCustNumber_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            string selectCust = "select * from Customer where CustomerId=@id";
            SqlCommand cmd = new SqlCommand(selectCust, con);
            cmd.Parameters.AddWithValue("@id", int.Parse(cboCustNumber.SelectedItem.ToString()));

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtName.Text = reader[1].ToString();
                txtEmail.Text = reader[2].ToString();
                txtContact.Text = reader[3].ToString();
                txtAddress.Text = reader[4].ToString();
            }

            con.Close();
        }
    }
}
