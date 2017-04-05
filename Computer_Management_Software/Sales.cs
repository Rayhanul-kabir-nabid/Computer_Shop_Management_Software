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
using MetroFramework;

namespace Computer_Management_Software
{
    public partial class Sales : MetroForm
    {
        Bo_class bo;
        public Sales(Bo_class bo1)
        {
            InitializeComponent();
            bo = bo1;
            print_button.Visible = false;
            bo.delete_all_temp_cart();
            bo.delete_all_report_table();
        }

        private void Sales_Load(object sender, EventArgs e)
        {

            all_product_button.Select();
        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {

        }

        private void home_button_Click(object sender, EventArgs e)
        {
            if (bo.count_temp_cart()==0)
            {
                this.Close();
            }
            else if (bo.count_temp_cart()>0)
            {
                MetroMessageBox.Show(this, "Finish running task", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            //save_button.Visible = true;
            //print_button.Visible = false;
            Customer customer = new Customer(bo);
            customer.Show();
        }
        string invoice_no, invoice_date;
        private void invoice_button_Click(object sender, EventArgs e)
        {
           // save_button.Visible = true;
           // print_button.Visible = false;
            invoice_no = bo.invoice_no_creator();
            bo.invoice = invoice_no;
            invoice_date = bo.datetime();
            invoice_no_textbox.Text = bo.invoice_no_creator();
            invoice_date_textbox.Text = bo.datetime();
        }
        int cstid; string cstname; string ccontact; string caddress;
        private void customer_id_button_Click(object sender, EventArgs e)
        {
           // save_button.Visible = true;
           // print_button.Visible = false;
            
            if (bo.current_customer_id == 0)
            {
                MetroMessageBox.Show(this, "No customer is selected", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            
            }
            else
            {
                cstid = bo.current_customer_id;
                customer_id_textbox.Text = Convert.ToString(cstid);
                DataSet ds;
                DataTable dt = new DataTable();
                ds = bo.current_customer_name(cstid);
                dt = ds.Tables["customer"];
                cstname = dt.Rows[0]["customer_name"].ToString();
                ccontact = dt.Rows[0]["customer_contactno"].ToString();
                caddress = dt.Rows[0]["customer_address"].ToString();

                customer_name_textbox.Text = cstname;

            }
        }
        DataSet ds;
       

        void display(string m1, string m2, string m3, string m4)
        {



            DataSet dt = new DataSet();
            try
            {
                if (m1 == "" && m2 == "" && m3 == "" && m4 == "" )
                {
                    dt = bo.all_product();

                }
                else
                {
                    dt = bo.advance_search4(m1, m2, m3, m4);
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
            string m1, m2, m3, m4;
            m1 = serial_search_textbox.Text;
            m2 = "";
            m3 = "";
            m4 = "";
            
            display(m1, m2, m3, m4);
        }

        private void short_description_searchbox_TextChanged(object sender, EventArgs e)
        {
            string m1, m2, m3, m4;
            m1 = "";
            m2 = short_description_searchbox.Text;
            m3 = "";
            m4 = "";

            display(m1, m2, m3, m4);
        }

        private void model_no_search_box_TextChanged(object sender, EventArgs e)
        {
            string m1, m2, m3, m4;
            m1 = "";
            m2 = "";
            m3 = model_no_search_box.Text;
            m4 = "";

            display(m1, m2, m3, m4);
        }

        private void brand_search_box_TextChanged(object sender, EventArgs e)
        {
            string m1, m2, m3, m4;
            m1 = "";
            m2 = "";
            m3 = "";
            m4 = brand_search_box.Text;

            display(m1, m2, m3, m4);
        }

       

        private void grid_product_KeyDown_1(object sender, KeyEventArgs e)
        {
            try
            {
                DataGridViewRow dr = grid_product.SelectedRows[0];
                if (dr.Cells[11].Value.ToString() == "0")
                {
                    name_short_des_textbox.Text = dr.Cells[6].Value.ToString();
                    serial_no_textbox.Text = dr.Cells[0].Value.ToString();
                    warrenty_textbox.Text = dr.Cells[5].Value.ToString();

                    //product_no_textbox.Text = dr.Cells[1].Value.ToString();
                    brand_textbox.Text = dr.Cells[3].Value.ToString();
                    sell_price_textbox.Text = dr.Cells[10].Value.ToString();
                }
                else
                {
                    MetroMessageBox.Show(this, "This product is not in stock", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {


            }
        }

        private void grid_product_KeyUp_1(object sender, KeyEventArgs e)
        {
            try
            {
                DataGridViewRow dr = grid_product.SelectedRows[0];
                if (dr.Cells[11].Value.ToString() == "0")
                {
                    name_short_des_textbox.Text = dr.Cells[6].Value.ToString();
                    serial_no_textbox.Text = dr.Cells[0].Value.ToString();
                    warrenty_textbox.Text = dr.Cells[5].Value.ToString();

                   // product_no_textbox.Text = dr.Cells[1].Value.ToString();
                    brand_textbox.Text = dr.Cells[3].Value.ToString();
                    sell_price_textbox.Text = dr.Cells[10].Value.ToString();
                }
                else
                {
                    MetroMessageBox.Show(this, "This product is not in stock", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                }


            }
            catch (Exception ex)
            {


            }
        }

        private void all_product_button_Click(object sender, EventArgs e)
        {
           // save_button.Visible = true;
           // print_button.Visible = false;
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

        private void grid_product_Click(object sender, EventArgs e)
        {

        }

        private void grid_product_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = grid_product.SelectedRows[0];
                if (dr.Cells[11].Value.ToString() == "0")
                {
                    name_short_des_textbox.Text = dr.Cells[1].Value.ToString() + " " + dr.Cells[2].Value.ToString() + " " + dr.Cells[3].Value.ToString() + " " + dr.Cells[6].Value.ToString() + " " + dr.Cells[7].Value.ToString();
                    serial_no_textbox.Text = dr.Cells[0].Value.ToString();
                    warrenty_textbox.Text = dr.Cells[5].Value.ToString();

                    //product_no_textbox.Text = dr.Cells[1].Value.ToString();
                    brand_textbox.Text = dr.Cells[3].Value.ToString();
                    sell_price_textbox.Text = dr.Cells[10].Value.ToString();
                }
                else
                {
                    MetroMessageBox.Show(this, "This product is not in stock", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    name_short_des_textbox.Clear();
                    serial_no_textbox.Clear();
                    warrenty_textbox.Clear();

                   // product_no_textbox.Clear();
                    brand_textbox.Clear();
                    sell_price_textbox.Clear();
            
                }
                



            }
            catch (Exception ex)
            {


            }
        }

        private void grid_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void display_product()
        {
            DataSet ds;
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
        public void display_temp_cart()
        {
            DataSet ds;
            ds = bo.all_temp_cart();

            g_product_serialno.DataPropertyName = "serial_no";
            g_product_description.DataPropertyName = "product_description";

            g_product_warrenty.DataPropertyName = "warrenty";

            g_product_unitprice.DataPropertyName = "unit_price";


            grid_cust_product.DataSource = ds;
            grid_cust_product.DataMember = "temp_cart";
        }
        private void addtocart_button_Click(object sender, EventArgs e)
        {
            //save_button.Visible = true;
            //print_button.Visible = false;
            try
            {
                bo.add_temp_cart(serial_no_textbox.Text, name_short_des_textbox.Text, warrenty_textbox.Text, Convert.ToDouble(sell_price_textbox.Text));
                bo.update_product_for_curt(serial_no_textbox.Text, 1);
                display_product();

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Select product first", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                
            }
            display_temp_cart();

            name_short_des_textbox.Clear();
            serial_no_textbox.Clear();
            warrenty_textbox.Clear();

            //product_no_textbox.Clear();
            brand_textbox.Clear();
            sell_price_textbox.Clear();
            total_amount_textbox.Clear();
            

        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            //save_button.Visible = true;
           // print_button.Visible = false;
            try
            {
                DataGridViewRow dr = grid_cust_product.SelectedRows[0];
                string srlno = dr.Cells[0].Value.ToString();
                bo.delete_temp_cart(srlno);
                bo.update_product_for_curt(srlno, 0);
                display_product();
                display_temp_cart();
            }
            catch (Exception ex)
            {
                
                
            }
            name_short_des_textbox.Clear();
            serial_no_textbox.Clear();
            warrenty_textbox.Clear();

           // product_no_textbox.Clear();
            brand_textbox.Clear();
            sell_price_textbox.Clear();
            total_amount_textbox.Clear();

        }

        private void metroPanel6_Paint(object sender, PaintEventArgs e)
        {

        }
        double ammount_product,ammount_service,ammount_extra,subtotal,grandtotal,total_service_and_extra,discount,ammount_product_for_inc;
        private void calculate_button_Click(object sender, EventArgs e)
        {
            //save_button.Visible = true;
            //print_button.Visible = false;
            ammount_product = bo.calculate_ammount();
            ammount_product_for_inc = bo.calculate_ammount_for_income();
            MessageBox.Show(ammount_product_for_inc.ToString());
            total_amount_textbox.Text = ammount_product.ToString();
           
            
        }

        private void add_to_bill_Click(object sender, EventArgs e)
        {
           // save_button.Visible = true;
           // print_button.Visible = false;
            try
            {
                if (service_textbox.Text == "" && extraproduct_textbox.Text == "")
                {
                    ammount_service = 0;
                    ammount_extra = 0;
                    
                }
                else if (service_textbox.Text == "" && extraproduct_textbox.Text != "")
                {
                    
                    ammount_service = 0;
                    ammount_extra = Convert.ToDouble(extraproduct_textbox.Text);
                }
                else if (service_textbox.Text != "" && extraproduct_textbox.Text == "")
                {
                    ammount_service = Convert.ToDouble(service_textbox.Text);
                    ammount_extra = 0;
                }
                else
                {
                    ammount_extra = Convert.ToDouble(extraproduct_textbox.Text);
                    ammount_service = Convert.ToDouble(service_textbox.Text);
                }
                
                total_service_and_extra = ammount_service + ammount_extra;
                service_and_others_textbox.Text = total_service_and_extra.ToString();
                service_textbox.Clear();
                extraproduct_textbox.Clear();
            }
            catch (Exception ex)
            {
                
                MetroMessageBox.Show(this, "Give numeric value", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                
            }
        }

        private void give_discount_button_Click(object sender, EventArgs e)
        {
           // save_button.Visible = true;
           // print_button.Visible = false;
            subtotal = ammount_product + ammount_service + ammount_extra;
            if (discount_textbox.Text == "")
            {
                discount = 0;
                grandtotal = subtotal - (subtotal * discount / 100);
                after_discount_textbox.Text = grandtotal.ToString();
            }
            else
            {
                try
                {
                    discount = Convert.ToDouble(discount_textbox.Text);
                    grandtotal =subtotal - (subtotal * discount / 100);
                    after_discount_textbox.Text = grandtotal.ToString();
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Give numeric value", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                
                    
                }

            }
        }

        private void new_button_Click(object sender, EventArgs e)
        {
           // save_button.Visible = true;
           // print_button.Visible = false;
            invoice_date_textbox.Clear();
            invoice_no_textbox.Clear();
            customer_id_textbox.Clear();
            customer_name_textbox.Clear();
            total_amount_textbox.Clear();
            service_and_others_textbox.Clear();
            discount_textbox.Clear();
            after_discount_textbox.Clear();
            ammount_product=0;
            ammount_service=0;
            ammount_extra=0;
            subtotal=0;
            grandtotal=0;
            total_service_and_extra=0;
            discount=0;
            cstid = 0;
            cstname = "";
            bo.current_customer_id = 0;
            bo.delete_all_report_table();
            
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string message,message1;
            if (invoice_no != "" && invoice_date != "" && total_amount_textbox.Text != "" && subtotal != 0 && grandtotal != 0 && cstid != 0 && bo.mainname!= "")
            {
                
                message = bo.add_invoice(invoice_no, invoice_date, ammount_product, subtotal, discount, grandtotal, cstid, bo.mainname);
                message1 = bo.add_income(ammount_service, ammount_product_for_inc, ammount_extra, invoice_date, invoice_no);
                
                if (message == "Successfull" && message1 == "Successfull")
                {
                    MetroMessageBox.Show(this, "Saved successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);


                    string m = bo.add_report(cstid, bo.mainname, bo.mainname, cstname, ccontact, caddress, invoice_no, invoice_date, ammount_product,ammount_service,ammount_extra , grandtotal, discount);
                    MessageBox.Show(m);
                    
                    //invoice_date_textbox.Clear();
                    //invoice_no_textbox.Clear();
                    //customer_id_textbox.Clear();
                    //customer_name_textbox.Clear();
                    //total_amount_textbox.Clear();
                    //service_and_others_textbox.Clear();
                    //discount_textbox.Clear();
                    //after_discount_textbox.Clear();
                    //ammount_product = 0;
                    //ammount_service = 0;
                    //ammount_extra = 0;
                    //subtotal = 0;
                    //grandtotal = 0;
                    //total_service_and_extra = 0;
                    //discount = 0;
                    //cstid = 0;
                    //cstname = "";
                    //bo.current_customer_id = 0;
                    
                    display_product();
                    display_temp_cart();

                    print_button.Visible = true;
                    save_button.Visible = false;

                }
                else if (message != "Successfull")
                {
                    MetroMessageBox.Show(this, message, "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                }
                else if (message1 != "Successfull")
                {
                    MetroMessageBox.Show(this, message1, "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                }
            }
            else
            {
                MetroMessageBox.Show(this, "Fill every blank first", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            }
            
        }

        private void model_no_search_box_Click(object sender, EventArgs e)
        {

        }

        private void print_button_Click(object sender, EventArgs e)
        {
            Bill bil = new Bill(bo);
            bil.Show();
            this.Close();
           // save_button.Visible = true;
           // print_button.Visible = false;
        }
//        int rowNum // row number
//string columnName = "DepartureTime";  // database table column name
//dt.Rows[rowNum][columnName].ToString();

//        SqlCeDataAdapter da = new SqlCeDataAdapter();
//DataSet ds = new DataSet();
//DataTable dt = new DataTable();

//da.SelectCommand = new SqlCommand(@"SELECT * FROM FooTable", connString);
//da.Fill(ds, "FooTable");
//dt = ds.Tables["FooTable"];

//foreach (DataRow dr in dt.Rows)
//{
//    MessageBox.Show(dr["Column1"].ToString());






    }
}
