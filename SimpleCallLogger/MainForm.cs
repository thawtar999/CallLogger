using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCallLogger
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewCustomerForm form = new AddNewCustomerForm();
            form.Show();
        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCustomerForm form = new UpdateCustomerForm();
            form.Show();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewStaffForm form = new AddNewStaffForm();
            form.Show();
        }

        private void updateStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStaffForm form = new UpdateStaffForm();
            form.Show();
        }

        private void logCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogCallForm form = new LogCallForm();
            form.Show();
        }

        private void byStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportByCustomer form = new ReportByCustomer();
            form.Show();
        }

        private void byStaffToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportByStaff form = new ReportByStaff();
            form.Show();
        }

        private void byDateRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportByDate form = new ReportByDate();
            form.Show();
        }

        private void byDurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportByDuration form = new ReportByDuration();
            form.Show();
        }
    }
}
