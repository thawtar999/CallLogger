using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace SimpleCallLogger
{
    public partial class ReportByDate : Form
    {
        public ReportByDate()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click_1(object sender, EventArgs e)
        {
            try
            {
                ReportDocument rpdoc = new ReportDocument();
                rpdoc.Load(@"C:\Users\thawt\documents\visual studio 2012\Projects\SimpleCallLogger\SimpleCallLogger\Report\CrystalReportByDateRange.rpt");

                ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                crParameterDiscreteValue.Value = txtFrom.Text;
                crParameterFieldDefinitions = rpdoc.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["fromDate"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;

                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                crParameterDiscreteValue.Value = txtTo.Text;
                crParameterFieldDefinitions = rpdoc.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["toDate"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;

                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                DataSetReport ds = new DataSetReport();
                DataSetReportTableAdapters.DataTable1TableAdapter ta = new DataSetReportTableAdapters.DataTable1TableAdapter();

                ta.Fill(ds.DataTable1);

                rpdoc.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpdoc;
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter from date and to date!");
            }
        }
    }
}
