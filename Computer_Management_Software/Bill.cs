using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO_Layer;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Computer_Management_Software
{
    public partial class Bill : MetroForm
    {
        //ReportDocument cryRpt;
        Bo_class bo;
        public Bill(Bo_class bo1)
        {
            bo = bo1;
            InitializeComponent();
            home_button.Visible = false;
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CrystalReport11;
            crystalReportViewer1.Refresh();
        }

        private void home_button_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        
        private void save_as_pdf_button_Click(object sender, EventArgs e)
        {
           
            try
            {
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(@"E:\Code\C# practice\Software Engineering Project\Computer_Management_Software\Computer_Management_Software\CrystalReport1.rpt");
                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
                
                cryRpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"E:\'"+bo.invoice+"'.pdf");
                MessageBox.Show("Exported Successful");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            bo.delete_all_temp_cart();
            home_button.Visible = true;
            //back_to_sale_button.Visible = false;
            save_as_pdf_button.Visible = false;

        
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
