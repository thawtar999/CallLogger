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
    public partial class LogCallForm : Form
    {
        string conString = "Data Source=.;Initial Catalog=SimpleCallLoggerDB;Integrated Security=True";
        int staffId, customerId;
        TimeSpan duration; decimal durationInMins;

        public LogCallForm()
        {
            InitializeComponent();
        }

        private void LogCallForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);

            con.Open();

            int id = 0;
            string selectId = @"select CallLogId from CallLog";
            SqlCommand cmd = new SqlCommand(selectId, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                id = Convert.ToInt32(reader[0]);
            }

            id += 1;
            txtLogNumber.Text = id.ToString();

            reader.Dispose();

            string selectStaff = @"select StaffName from Staff";

            SqlCommand cmdStaff = new SqlCommand(selectStaff, con);

            reader = cmdStaff.ExecuteReader();

            while (reader.Read())
                cboCallOwner.Items.Add(reader[0].ToString());

            reader.Dispose();

            string selectCustomer = @"select CustomerName from Customer";

            SqlCommand cmdCustomer = new SqlCommand(selectCustomer, con);

            reader = cmdCustomer.ExecuteReader();

            while (reader.Read())
                cboCustomer.Items.Add(reader[0].ToString());

            con.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);

            con.Open();

            string insertLog = "insert into CallLog values(@id,@sId,@cId,@date,@startTime,@endTime,@duration,@note)";

            SqlCommand cmd = new SqlCommand(insertLog, con);
            cmd.Parameters.AddWithValue("@id", int.Parse(txtLogNumber.Text));
            cmd.Parameters.AddWithValue("@sId", staffId);
            cmd.Parameters.AddWithValue("@cId", customerId);
            cmd.Parameters.AddWithValue("@date", datePicker.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@startTime", startTimePicker.Value.ToLongTimeString());
            cmd.Parameters.AddWithValue("@endTime", endTimePicker.Value.ToLongTimeString());
            cmd.Parameters.AddWithValue("@duration", durationInMins);
            cmd.Parameters.AddWithValue("@note", txtNote.Text);


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
            txtLogNumber.Text = null;
            txtDuration.Text = null;
            txtNote.Text = null;
            cboCallOwner.SelectedIndex = -1;
            cboCustomer.SelectedIndex = -1;
            datePicker.ResetText();
            startTimePicker.ResetText();
            endTimePicker.ResetText();
        }

        private void cboCallOwner_SelectedIndexChanged(object sender, EventArgs e)
        {
            staffId = cboCallOwner.SelectedIndex + 1;
        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            customerId = cboCustomer.SelectedIndex + 1;
        }

        private void btnDuration_Click(object sender, EventArgs e)
        {
            duration = DateTime.Parse(endTimePicker.Text) - DateTime.Parse(startTimePicker.Text);

            txtDuration.Text = duration.ToString();

            durationInMins = Math.Round(decimal.Parse(duration.TotalMinutes.ToString()),2);

        }
    }
}
