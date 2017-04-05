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
    public partial class Income : MetroForm
    {
        Bo_class bo;
        public Income(Bo_class bo1)
        {
            InitializeComponent();
            bo = bo1;
        }

        private void Income_Load(object sender, EventArgs e)
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
        DataSet ds1;
        private void all_income_button_Click(object sender, EventArgs e)
        {
            try
            {
                ds = bo.all_income();
                ds1 = bo.all_income_value();

                g_invoice_no.DataPropertyName = "invoice_no";
                g_income_id.DataPropertyName = "income_id";
                g_service.DataPropertyName = "service";
                g_product_sell.DataPropertyName = "product_sell";
                g_extra_sell.DataPropertyName = "extra_sell";
                g_date_time.DataPropertyName = "date_time";

                DataTable dt = new DataTable();
                dt = ds1.Tables["income"];
                service_textbox.Text = dt.Rows[0]["s"].ToString();
                product_sell_textbox.Text = dt.Rows[0]["p"].ToString();
                extra_textbox.Text = dt.Rows[0]["e"].ToString();

                grid_income.DataSource = ds;
                grid_income.DataMember = "income";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string date;
            DateTime now = DateTime.Now;
            date = now.ToString("yyyy/MM/dd");

            try
            {
                ds = bo.all_income_today(date);
                ds1 = bo.all_income_value_today(date);

                g_invoice_no.DataPropertyName = "invoice_no";
                g_income_id.DataPropertyName = "income_id";
                g_service.DataPropertyName = "service";
                g_product_sell.DataPropertyName = "product_sell";
                g_extra_sell.DataPropertyName = "extra_sell";
                g_date_time.DataPropertyName = "date_time";

                DataTable dt = new DataTable() ;
                dt = ds1.Tables["income"];
                service_textbox.Text = dt.Rows[0]["s"].ToString();
                product_sell_textbox.Text = dt.Rows[0]["p"].ToString();
                extra_textbox.Text = dt.Rows[0]["e"].ToString();

                grid_income.DataSource = ds;
                grid_income.DataMember = "income";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void last_7_days_button_Click(object sender, EventArgs e)
        {
            string date;
            DateTime seven_ago = DateTime.Today.AddDays(-8);
            date = seven_ago.ToString("yyyy/MM//dd");
            //MessageBox.Show(date);
            try
            {
                ds = bo.all_income_week(date);
                ds1 = bo.all_income_value_week(date);

                g_invoice_no.DataPropertyName = "invoice_no";
                g_income_id.DataPropertyName = "income_id";
                g_service.DataPropertyName = "service";
                g_product_sell.DataPropertyName = "product_sell";
                g_extra_sell.DataPropertyName = "extra_sell";
                g_date_time.DataPropertyName = "date_time";

                DataTable dt = new DataTable();
                dt = ds1.Tables["income"];
                service_textbox.Text = dt.Rows[0]["s"].ToString();
                product_sell_textbox.Text = dt.Rows[0]["p"].ToString();
                extra_textbox.Text = dt.Rows[0]["e"].ToString();

                grid_income.DataSource = ds;
                grid_income.DataMember = "income";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void this_month_button_Click(object sender, EventArgs e)
        {
            string date;
            DateTime seven_ago = DateTime.Now;
            date = seven_ago.ToString("yyyy/MM");
            //MessageBox.Show(date);
            try
            {
                ds = bo.all_income_thismonth(date);
                ds1 = bo.all_income_value_thismonth(date);

                g_invoice_no.DataPropertyName = "invoice_no";
                g_income_id.DataPropertyName = "income_id";
                g_service.DataPropertyName = "service";
                g_product_sell.DataPropertyName = "product_sell";
                g_extra_sell.DataPropertyName = "extra_sell";
                g_date_time.DataPropertyName = "date_time";

                DataTable dt = new DataTable();
                dt = ds1.Tables["income"];
                service_textbox.Text = dt.Rows[0]["s"].ToString();
                product_sell_textbox.Text = dt.Rows[0]["p"].ToString();
                extra_textbox.Text = dt.Rows[0]["e"].ToString();

                grid_income.DataSource = ds;
                grid_income.DataMember = "income";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
