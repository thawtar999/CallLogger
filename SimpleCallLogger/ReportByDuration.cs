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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace SimpleCallLogger
{
    public partial class ReportByDuration : Form
    {
        public ReportByDuration()
        {
            InitializeComponent();
        }

        private void ReportByDuration_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            ReportDocument rpdoc = new ReportDocument();
            rpdoc.Load(@"C:\Users\thawt\documents\visual studio 2012\Projects\SimpleCallLogger\SimpleCallLogger\Report\CrystalReportByDuration.rpt");

            if (rdbOneHour.Checked)
            {
                DataSetReport2 ds2 = new DataSetReport2();
                DataSetReport2TableAdapters.DataTable1TableAdapter ta2 = new DataSetReport2TableAdapters.DataTable1TableAdapter();

                ta2.Fill(ds2.DataTable1);
                rpdoc.SetDataSource(ds2);
            }
            else if (rdbThirtySeconds.Checked)
            {
                DataSetReport3 ds3 = new DataSetReport3();
                DataSetReport3TableAdapters.DataTable1TableAdapter ta3 = new DataSetReport3TableAdapters.DataTable1TableAdapter();

                ta3.Fill(ds3.DataTable1);
                rpdoc.SetDataSource(ds3);
            }
            else if (rdbAll.Checked)
            {
                DataSetReport ds = new DataSetReport();
                DataSetReportTableAdapters.DataTable1TableAdapter ta = new DataSetReportTableAdapters.DataTable1TableAdapter();

                ta.Fill(ds.DataTable1);
                rpdoc.SetDataSource(ds);
            }
            else
                MessageBox.Show("Please select one duration!");

            crystalReportViewer1.ReportSource = rpdoc;
        }
    }
}
