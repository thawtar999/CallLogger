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
    public partial class AddNewStaffForm : Form
    {
        string conString = "Data Source=.;Initial Catalog=SimpleCallLoggerDB;Integrated Security=True";

        public AddNewStaffForm()
        {
            InitializeComponent();
        }

        private void AddNewStaffForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);

            con.Open();

            int id = 0;
            string selectId = @"select StaffId from Staff";
            SqlCommand cmd = new SqlCommand(selectId, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                id = Convert.ToInt32(reader[0]);
            }

            con.Close();

            id += 1;
            txtStaffNumber.Text = id.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);

            con.Open();

            string insertCustomer = "insert into Staff values(@name,@email,@contact,@address)";

            SqlCommand cmd = new SqlCommand(insertCustomer, con);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@contact", txtContact.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);

            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                MessageBox.Show("Saved!");
                Clear();
            }

            con.Close();
        }

        private void Clear()
        {
            txtStaffNumber.Text = null;
            txtName.Text = null;
            txtEmail.Text = null;
            txtContact.Text = null;
            txtAddress.Text = null;
        }
    }
}
