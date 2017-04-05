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
using MetroFramework;
using System.Data;
using Entity_Layer;
namespace Computer_Management_Software
{
    public partial class Entry_Product : MetroForm
    {
        public Bo_class bo;
        public Entry_Product( Bo_class bo1)
        {
            InitializeComponent();
            bo = bo1;
        }

        
        
        private void Entry_Product_Load(object sender, EventArgs e)
        {
            metroLabel1.Select();
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            //Home login = new Home(bo);
            //login.Show();
            this.Close();
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            serial_no_textbox.Clear();
            product_no_textbox.Clear();
            model_no_textbox.Clear();
            brand_textbox.Clear();
            importer_textbox.Clear();
            warrenty_textbox.Clear();
            short_description_textbox.Clear();
            long_description_textbox.Clear();
            buy_price_textbox.Clear();
            sell_price_textbox.Clear();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string message;
            string username = bo.mainname;
            try
            {
                double buyprice = Convert.ToDouble(buy_price_textbox.Text);
                double sellprice = Convert.ToDouble(sell_price_textbox.Text);
                message = bo.add_product(serial_no_textbox.Text, product_no_textbox.Text, model_no_textbox.Text, brand_textbox.Text, importer_textbox.Text, warrenty_textbox.Text, short_description_textbox.Text, long_description_textbox.Text, buyprice, sellprice, username);
                if (message == "Successfull")
                {
                    MetroMessageBox.Show(this, "Saved successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    
                }
                else
                {
                    MetroMessageBox.Show(this, message, "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {

                string m = "Input Buy and sell price perfectly";
                MetroMessageBox.Show(this, m, "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            } 
           // MessageBox.Show(username);
            
            serial_no_textbox.Clear();
            product_no_textbox.Clear();
            model_no_textbox.Clear();
            brand_textbox.Clear();
            importer_textbox.Clear();
            warrenty_textbox.Clear();
            short_description_textbox.Clear();
            long_description_textbox.Clear();
            buy_price_textbox.Clear();
            sell_price_textbox.Clear();
            display("", "", "");
        }
        DataSet ds;
        private void all_product_button_Click(object sender, EventArgs e)
        {
            //DataSet ds;
            ds = bo.all_product();

            g_serial_no.DataPropertyName = "serial_no";
            g_product_no.DataPropertyName = "product_no";
            g_model_no.DataPropertyName = "model_no";
            g_brand.DataPropertyName = "brand";
            g_importer.DataPropertyName = "importer";   
            g_warrenty.DataPropertyName = "warrenty";
            g_short_description.DataPropertyName = "short_description";
            g_long_description.DataPropertyName = "long_description";
            g_entry_date.DataPropertyName = "entry_date";
            g_unit_price.DataPropertyName = "unit_price";
            g_sell_price.DataPropertyName = "sell_price";
            g_sold_status.DataPropertyName = "sold_status";
            g_employee_id.DataPropertyName = "employee_id";

            grid_product.DataSource = ds;
            grid_product.DataMember = "product";
            
            
           
        }
       
        private void search_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void grid_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void product_search_box_TextChanged(object sender, EventArgs e)
        {
            string m1, m2, m3;
            m1 = product_search_box.Text;
            m2 = "";
            m3 = "";
            
            display(m1, m2, m3);
        }

        private void model_no_search_box_TextChanged(object sender, EventArgs e)
        {
            string m1, m2, m3;
            m1 = "";
            m2 = model_no_search_box.Text;
            m3 = "";

            display(m1, m2, m3);
        }

        private void brand_search_box_TextChanged(object sender, EventArgs e)
        {
            string m1, m2, m3;
            m1 = "";
            m2 = "";
            m3 = brand_search_box.Text;

            display(m1, m2, m3);
        }

        void display(string m1, string m2, string m3)
        {



            DataSet dt = new DataSet();
            try
            {
                if (m1 == "" && m2 == "" && m3 == "")
                {
                    dt = bo.all_product();
                }
                else 
                {
                    dt = bo.advance_search(m1, m2, m3);
                }
                
                g_serial_no.DataPropertyName = "serial_no";
                g_product_no.DataPropertyName = "product_no";
                g_model_no.DataPropertyName = "model_no";
                g_brand.DataPropertyName = "brand";
                g_importer.DataPropertyName = "importer";
                g_warrenty.DataPropertyName = "warrenty";
                g_short_description.DataPropertyName = "short_description";
                g_long_description.DataPropertyName = "long_description";
                g_entry_date.DataPropertyName = "entry_date";
                g_unit_price.DataPropertyName = "unit_price";
                g_sell_price.DataPropertyName = "sell_price";
                g_sold_status.DataPropertyName = "sold_status";
                g_employee_id.DataPropertyName = "employee_id";

                grid_product.DataSource = dt;
                grid_product.DataMember = "product";

            }
            catch (Exception ex)
            {

            }
        }
        private void search_button_Click(object sender, EventArgs e)
        {
            string m1, m2, m3;
            m1 = product_search_box.Text;
            m2 = model_no_search_box.Text;
            m3 = brand_search_box.Text;


            DataSet dt = new DataSet();
            try
            {
                dt = bo.advance_search(m1, m2, m3);
                g_serial_no.DataPropertyName = "serial_no";
                g_product_no.DataPropertyName = "product_no";
                g_model_no.DataPropertyName = "model_no";
                g_brand.DataPropertyName = "brand";
                g_importer.DataPropertyName = "importer";
                g_warrenty.DataPropertyName = "warrenty";
                g_short_description.DataPropertyName = "short_description";
                g_long_description.DataPropertyName = "long_description";
                g_entry_date.DataPropertyName = "entry_date";
                g_unit_price.DataPropertyName = "unit_price";
                g_sell_price.DataPropertyName = "sell_price";
                g_sold_status.DataPropertyName = "sold_status";
                g_employee_id.DataPropertyName = "employee_id";

                grid_product.DataSource = dt;
                grid_product.DataMember = "product";

            }
            catch (Exception ex)
            {

                               
            }
        }

        private void product_search_box_Click(object sender, EventArgs e)
        {

        }

        private void sell_price_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                save_button_Click((object)sender, (EventArgs)e);
            }
        }

        

        
    }
}
