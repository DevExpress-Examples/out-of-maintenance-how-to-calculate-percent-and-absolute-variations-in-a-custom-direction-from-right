using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwindDataSet.CustomerReports' table. You can move, or remove it, as needed.
            this.customerReportsTableAdapter.Fill(this.nwindDataSet.CustomerReports);

        }

        private void pivotGridControl1_CustomCellDisplayText(object sender, DevExpress.XtraPivotGrid.PivotCellDisplayTextEventArgs e)
        {
            if (e.DataField.Name == "fieldVariation")
            {
                Object nextValue = e.GetNextColumnCellValue(e.DataField);
                if (nextValue == null)
                {
                    e.DisplayText = string.Empty;
                    return;
                }
                decimal current = Convert.ToDecimal(e.Value);
                decimal next = Convert.ToDecimal(nextValue);
                if (next == 0)
                {
                    e.DisplayText = "100%";
                    return;
                }
                current = (current - next) / next;
                e.DisplayText = current.ToString("P");
            }
        }
    }
}