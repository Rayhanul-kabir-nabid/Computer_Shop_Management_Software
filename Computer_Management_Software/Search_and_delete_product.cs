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
using System.Data;
using MetroFramework;
namespace Computer_Management_Software
{
    public partial class Search_and_delete_product : MetroForm
    {
        Bo_class bo;
        public Search_and_delete_product(Bo_class bo1)
        {
            InitializeComponent();
            bo = bo1;
        }

        private void Search_and_delete_product_Load(object sender, EventArgs e)
        {
            metroLabel1.Select();
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            //Home login = new Home(bo);
            //login.Show();
            this.Close();
        }
        DataSet ds;

        private void all_product_button_Click(object sender, EventArgs e)
        {
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
            edit_button.Show();
        }

        void display(string m1, string m2, string m3,string m4,string m5)
        {
            
            

            DataSet dt = new DataSet();
            try
            {
                if (m1 == "" && m2 == "" && m3 == "" && m4 == "" && m5 == "" )
                {
                    dt = bo.all_product();
                    
                }
                else
                {
                    dt = bo.advance_search2(m1, m2, m3, m4, m5);
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

        private void serial_search_textbox_TextChanged(object sender, EventArgs e)
        {
            string m1, m2, m3, m4, m5;
            m1 = "";
            m2 = "";
            m3 = "";
            m4 = serial_search_textbox.Text;
            m5 = "";
            display(m1,m2,m3,m4,m5);
        }

        private void product_search_box_TextChanged(object sender, EventArgs e)
        {
            string m1, m2, m3, m4, m5;
            m1 = product_search_box.Text;
            m2 = "";
            m3 = "";
            m4 = "";
            m5 = "";
            display(m1, m2, m3, m4, m5);
        }

        private void model_no_search_box_TextChanged(object sender, EventArgs e)
        {
            string m1, m2, m3, m4, m5;
            m1 = "";
            m2 = model_no_search_box.Text;
            m3 = "";
            m4 = "";
            m5 = "";
            display(m1, m2, m3, m4, m5);
        }

        private void brand_search_box_TextChanged(object sender, EventArgs e)
        {
            string m1, m2, m3, m4, m5;
            m1 = "";
            m2 = "";
            m3 = brand_search_box.Text;
            m4 = "";
            m5 = "";
            display(m1, m2, m3, m4, m5);
        }

        private void importer_search_textbox_TextChanged(object sender, EventArgs e)
        {
            string m1, m2, m3, m4, m5;
            m1 = "";
            m2 = "";
            m3 = "";
            m4 = "";
            m5 = importer_search_textbox.Text;
            display(m1, m2, m3, m4, m5);
        }

        private void grid_product_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                DataGridViewRow dr = grid_product.SelectedRows[0];
                serial_no_textbox.Text = dr.Cells[0].Value.ToString();
                product_no_textbox.Text = dr.Cells[1].Value.ToString();
                model_no_textbox.Text = dr.Cells[2].Value.ToString();
                brand_textbox.Text = dr.Cells[3].Value.ToString();
                importer_textbox.Text = dr.Cells[4].Value.ToString();
                warrenty_textbox.Text = dr.Cells[5].Value.ToString();
                short_description_textbox.Text = dr.Cells[6].Value.ToString();
                long_description_textbox.Text = dr.Cells[7].Value.ToString();
                buy_price_textbox.Text = dr.Cells[9].Value.ToString();
                sell_price_textbox.Text = dr.Cells[10].Value.ToString();

                edit_button.Show();
                update_button.Hide();
                serial_no_textbox.Enabled = false;
                product_no_textbox.Enabled = false;
                model_no_textbox.Enabled = false;
                brand_textbox.Enabled = false;
                importer_textbox.Enabled = false;
                warrenty_textbox.Enabled = false;
                short_description_textbox.Enabled = false;
                long_description_textbox.Enabled = false;
                buy_price_textbox.Enabled = false;
                sell_price_textbox.Enabled = false;
            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            
                edit_button.Hide();
                update_button.Show();
                
                serial_no_textbox.Enabled = true;
                product_no_textbox.Enabled = true;
                model_no_textbox.Enabled = true;
                brand_textbox.Enabled = true;
                importer_textbox.Enabled = true;
                warrenty_textbox.Enabled = true;
                short_description_textbox.Enabled = true    ;
                long_description_textbox.Enabled = true;
                buy_price_textbox.Enabled = true;
                sell_price_textbox.Enabled = true;
            
            
        
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (edit_button.Visible == false)
            {
                double buyprice = Convert.ToDouble(buy_price_textbox.Text);
                double sellprice = Convert.ToDouble(sell_price_textbox.Text);
                string message;
                try
                {
                    message = bo.update_product(serial_no_textbox.Text, product_no_textbox.Text, model_no_textbox.Text, brand_textbox.Text, importer_textbox.Text, warrenty_textbox.Text, short_description_textbox.Text, long_description_textbox.Text, buyprice, sellprice, bo.mainname);
                    if (message == "Successfull")
                    {
                        MetroMessageBox.Show(this, "Updated successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);

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
                update_button.Hide();
                edit_button.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "Click edit before update", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                
            }
            
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            string message=null;
            
            DialogResult result =  MetroMessageBox.Show(this, "Are you sure to delete this?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None);
            if (result.ToString() == "Yes")
            {
                message = bo.delete_product(serial_no_textbox.Text);
                if (message == "Successfull")
                {
                    MetroMessageBox.Show(this, "Deleted successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                else
                {
                    MetroMessageBox.Show(this, message, "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                }
            }
            else
            {

            }
           
            
            
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
            edit_button.Show();
        }

        private void cancel_button_Click(object sender, EventArgs e)
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
            edit_button.Show();
        }

        private void grid_product_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                DataGridViewRow dr = grid_product.SelectedRows[0];
                serial_no_textbox.Text = dr.Cells[0].Value.ToString();
                product_no_textbox.Text = dr.Cells[1].Value.ToString();
                model_no_textbox.Text = dr.Cells[2].Value.ToString();
                brand_textbox.Text = dr.Cells[3].Value.ToString();
                importer_textbox.Text = dr.Cells[4].Value.ToString();
                warrenty_textbox.Text = dr.Cells[5].Value.ToString();
                short_description_textbox.Text = dr.Cells[6].Value.ToString();
                long_description_textbox.Text = dr.Cells[7].Value.ToString();
                buy_price_textbox.Text = dr.Cells[9].Value.ToString();
                sell_price_textbox.Text = dr.Cells[10].Value.ToString();

                edit_button.Show();
                update_button.Hide();
                serial_no_textbox.Enabled = false;
                product_no_textbox.Enabled = false;
                model_no_textbox.Enabled = false;
                brand_textbox.Enabled = false;
                importer_textbox.Enabled = false;
                warrenty_textbox.Enabled = false;
                short_description_textbox.Enabled = false;
                long_description_textbox.Enabled = false;
                buy_price_textbox.Enabled = false;
                sell_price_textbox.Enabled = false;
            }
            catch (Exception ex)
            {


            }
        }

        private void grid_product_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DataGridViewRow dr = grid_product.SelectedRows[0];
                serial_no_textbox.Text = dr.Cells[0].Value.ToString();
                product_no_textbox.Text = dr.Cells[1].Value.ToString();
                model_no_textbox.Text = dr.Cells[2].Value.ToString();
                brand_textbox.Text = dr.Cells[3].Value.ToString();
                importer_textbox.Text = dr.Cells[4].Value.ToString();
                warrenty_textbox.Text = dr.Cells[5].Value.ToString();
                short_description_textbox.Text = dr.Cells[6].Value.ToString();
                long_description_textbox.Text = dr.Cells[7].Value.ToString();
                buy_price_textbox.Text = dr.Cells[9].Value.ToString();
                sell_price_textbox.Text = dr.Cells[10].Value.ToString();

                edit_button.Show();
                update_button.Hide();
                serial_no_textbox.Enabled = false;
                product_no_textbox.Enabled = false;
                model_no_textbox.Enabled = false;
                brand_textbox.Enabled = false;
                importer_textbox.Enabled = false;
                warrenty_textbox.Enabled = false;
                short_description_textbox.Enabled = false;
                long_description_textbox.Enabled = false;
                buy_price_textbox.Enabled = false;
                sell_price_textbox.Enabled = false;
            }
            catch (Exception ex)
            {


            }
        }

        private void product_search_box_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
