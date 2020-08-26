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
    public partial class ReportByCustomer : Form
    {
        public ReportByCustomer()
        {
            InitializeComponent();
        }

        private void ReportByCustomer_Load(object sender, EventArgs e)
        {
            
           
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
                ReportDocument rpdoc = new ReportDocument();
                rpdoc.Load(@"C:\Users\thawt\documents\visual studio 2012\Projects\SimpleCallLogger\SimpleCallLogger\Report\CrystalReportByCustomer.rpt");

                ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                crParameterDiscreteValue.Value = txtCustName.Text;
                crParameterFieldDefinitions = rpdoc.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["customerName"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;

                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                DataSetReport ds = new DataSetReport();
                DataSetReportTableAdapters.DataTable1TableAdapter ta = new DataSetReportTableAdapters.DataTable1TableAdapter();

                ta.Fill(ds.DataTable1);

                rpdoc.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpdoc;
            } 
        
    }
}
