using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using BO_Layer;
namespace Computer_Management_Software
    
{
    public partial class Invoice : MetroForm
    {
        Bo_class bo;
        public Invoice(Bo_class bo1)
        {
            InitializeComponent();
            bo = bo1;
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            metroLabel1.Select();
            
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            
            //Home home = new Home(bo);
            //home.Show();
            this.Close();
        }
        DataSet ds;

        void display(string m1, string m2, string m3)
        {



            DataSet dt = new DataSet();
            try
            {
                if (m1 == "" && m2 == "" && m3 == "")
                {
                    dt = bo.all_invoice();
                }
                else
                {
                    dt = bo.advance_search_invoice(m1, m2, m3);
                }

                g_invoice_no.DataPropertyName = "invoice_no";
                g_customer_name.DataPropertyName = "customer_name";
                g_customer_id.DataPropertyName = "customer_id";
                g_date_time.DataPropertyName = "date_time";
                g_ammount.DataPropertyName = "ammount";
                g_sub_total.DataPropertyName = "sub_total";
                g_discount.DataPropertyName = "discount";
                g_grand_total.DataPropertyName = "grand_total";

                g_employee_id.DataPropertyName = "employee_id";

                grid_invoice.DataSource = dt;
                grid_invoice.DataMember = "invoice";

            }
            catch (Exception ex)
            {

            }
        }
        private void all_invoice_button_Click(object sender, EventArgs e)
        {
            try
            {
                ds = bo.all_invoice();

                g_invoice_no.DataPropertyName = "invoice_no";
                g_customer_name.DataPropertyName = "customer_name";
                g_customer_id.DataPropertyName = "customer_id";
                g_date_time.DataPropertyName = "date_time";
                g_ammount.DataPropertyName = "ammount";
                g_sub_total.DataPropertyName = "sub_total";
                g_discount.DataPropertyName = "discount";
                g_grand_total.DataPropertyName = "grand_total";

                g_employee_id.DataPropertyName = "employee_id";

                grid_invoice.DataSource = ds;
                grid_invoice.DataMember = "invoice";
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void grid_invoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_invoice_button_TextChanged(object sender, EventArgs e)
        {
            string m1, m2, m3;
            m1 = search_invoice_button.Text;
            m2 = "";
            m3 = "";
            display(m1, m2, m3);
        }

        private void search_customer_name_button_TextChanged(object sender, EventArgs e)
        {
            string m1, m2, m3;
            m1 = "";
            m2 = search_customer_name_button.Text;
            m3 = "";
            display(m1, m2, m3);

        }

        private void search_customer_id_button_TextChanged(object sender, EventArgs e)
        {
            string m1, m2, m3;
            m1 = "";
            m2 = "";
            m3 = search_customer_id_button.Text;
            display(m1, m2, m3);
        }
    }
}
