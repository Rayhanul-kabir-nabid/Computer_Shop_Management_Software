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
namespace Computer_Management_Software
{
    public partial class Customer : MetroForm
    {
        Bo_class bo;
        public Customer(Bo_class bo1)
        {
            InitializeComponent();
            bo = bo1;
        }

        private void ClientInformation_Load(object sender, EventArgs e)
        {
            metroLabel1.Select();
            
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            //Home home = new Home(bo);
            //home.Show();
            this.Close();
        }
        int custid = 0;
        private void grid_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string cname, ccontact, caddress, username,message;
            username = bo.mainname;
            cname = customer_name_textbox.Text;
            ccontact = customer_contact_textbox.Text;
            caddress = customer_address_textbox.Text;
            if (cname != "" && ccontact != "" && caddress != "" )
            {
                message = bo.add_customer(cname,ccontact,caddress,username);

                if (message == "Successfull")
                {
                    MetroMessageBox.Show(this, "Saved successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                else
                {
                    MetroMessageBox.Show(this, message, "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                }
                customer_name_textbox.Clear();
                customer_contact_textbox.Clear();
                customer_address_textbox.Clear();
                display("", "", "");
                
            }
            else
            {
                MetroMessageBox.Show(this, "Fill every gap", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            }
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            customer_name_textbox.Clear();
            customer_contact_textbox.Clear();
            customer_address_textbox.Clear();
        }
        DataSet ds;
        public void display(string m1,string m2, string m3)
        {
            try
            {
                DataSet dt;
                if (m1 == "" && m2 == "" && m3 == "")
                {
                    dt = bo.all_customer();
                }
                else
                {
                    dt = bo.advance_search3(m1, m2, m3);
                }
                

                g_customer_id.DataPropertyName = "customer_id";
                g_customer_name.DataPropertyName = "customer_name";
                g_customer_contactno.DataPropertyName = "customer_contactno";
                g_customer_address.DataPropertyName = "customer_address";
                g_employee_id.DataPropertyName = "employee_id";

                grid_customer.DataSource = dt;
                grid_customer.DataMember = "customer";
            }
            catch (Exception e)
            {
                
                
            }
        }
        private void all_customer_button_Click(object sender, EventArgs e)
        {

            ds = bo.all_customer();

            g_customer_id.DataPropertyName = "customer_id";
            g_customer_name.DataPropertyName = "customer_name";
            g_customer_contactno.DataPropertyName = "customer_contactno";
            g_customer_address.DataPropertyName = "customer_address";
            g_employee_id.DataPropertyName = "employee_id";

            grid_customer.DataSource = ds;
            grid_customer.DataMember = "customer";
            
        }

        private void name_search_textbox_TextChanged(object sender, EventArgs e)
        {
            string m1, m2, m3;
            m1 = name_search_textbox.Text;
            m2 = "";
            m3 = "";
            display(m1, m2, m3);
        }

        private void contact_no_search_textbox_TextChanged(object sender, EventArgs e)
        {
            string m1, m2, m3;
            m1 = "";
            m2 = contact_no_search_textbox.Text;
            m3 = "";
            display(m1, m2, m3);
        }

        private void address_search_textbox_TextChanged(object sender, EventArgs e)
        {
            string m1, m2, m3;
            m1 = "";
            m2 = "";
            m3 = address_search_textbox.Text;
            display(m1, m2, m3);
        }

        private void grid_customer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void grid_customer_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = grid_customer.SelectedRows[0];
            custid = Convert.ToInt32(dr.Cells[0].Value.ToString());
            e_customer_id_textbox.Text = dr.Cells[0].Value.ToString();
            e_customer_name_textbox.Text = dr.Cells[1].Value.ToString();
            e_customer_contact_no_textbox.Text = dr.Cells[2].Value.ToString();
            e_customer_address_textbox.Text = dr.Cells[3].Value.ToString();

            edit_button.Show();
            update_button.Hide();

            e_customer_id_textbox.Enabled = false;
            e_customer_name_textbox.Enabled = false;
            e_customer_contact_no_textbox.Enabled = false;
            e_customer_address_textbox.Enabled = false;
        }

        private void grid_customer_KeyUp(object sender, KeyEventArgs e)
        {
            DataGridViewRow dr = grid_customer.SelectedRows[0];
            custid = Convert.ToInt32(dr.Cells[0].Value.ToString());
            e_customer_id_textbox.Text = dr.Cells[0].Value.ToString();
            e_customer_name_textbox.Text = dr.Cells[1].Value.ToString();
            e_customer_contact_no_textbox.Text = dr.Cells[2].Value.ToString();
            e_customer_address_textbox.Text = dr.Cells[3].Value.ToString();

            edit_button.Show();
            update_button.Hide();

            e_customer_id_textbox.Enabled = false;
            e_customer_name_textbox.Enabled = false;
            e_customer_contact_no_textbox.Enabled = false;
            e_customer_address_textbox.Enabled = false;
        }

        private void grid_customer_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridViewRow dr = grid_customer.SelectedRows[0];
            custid = Convert.ToInt32(dr.Cells[0].Value.ToString());
            e_customer_id_textbox.Text = dr.Cells[0].Value.ToString();
            e_customer_name_textbox.Text = dr.Cells[1].Value.ToString();
            e_customer_contact_no_textbox.Text = dr.Cells[2].Value.ToString();
            e_customer_address_textbox.Text = dr.Cells[3].Value.ToString();

            edit_button.Show();
            update_button.Hide();

            e_customer_id_textbox.Enabled = false;
            e_customer_name_textbox.Enabled = false;
            e_customer_contact_no_textbox.Enabled = false;
            e_customer_address_textbox.Enabled = false;
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            e_customer_id_textbox.Enabled = false;
            e_customer_name_textbox.Enabled = true;
            e_customer_contact_no_textbox.Enabled = true;
            e_customer_address_textbox.Enabled = true;

            edit_button.Hide();
            update_button.Show();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            e_customer_id_textbox.Enabled = false;
            e_customer_name_textbox.Enabled = false;
            e_customer_contact_no_textbox.Enabled = false;
            e_customer_address_textbox.Enabled = false;

            edit_button.Show();
            update_button.Show();

            e_customer_id_textbox.Clear();
            e_customer_name_textbox.Clear();
            e_customer_contact_no_textbox.Clear();
            e_customer_address_textbox.Clear();
        }

        private void select_for_bill_button_Click(object sender, EventArgs e)
        {
            if (custid == 0)
            {
                MetroMessageBox.Show(this, "No customer is selected", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {


                DialogResult result = MetroMessageBox.Show(this, "Are you sure to choose customer id "+custid+"?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None);
                if (result.ToString()=="Yes")
                {
                    bo.current_customer_id = custid;
                    MetroMessageBox.Show(this, "Selected successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (edit_button.Visible == false)
            {
                
                string message = null;
                try
                {
                    if ( 
                        e_customer_name_textbox.Text != "" && e_customer_contact_no_textbox.Text != "" && e_customer_address_textbox.Text != "" )
                    {
                        message = bo.update_customer(custid,e_customer_name_textbox.Text,e_customer_contact_no_textbox.Text,e_customer_address_textbox.Text);
                        if (message == "Successfull")
                        {
                            MetroMessageBox.Show(this, "Updated successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);

                        }
                        else
                        {
                            MetroMessageBox.Show(this, message, "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Fill every blank", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    }
                    
                }
                catch (Exception ex)
                {

                    string m = ex.ToString();
                    MetroMessageBox.Show(this, m, "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                update_button.Hide();
                edit_button.Show();

            }
            else
            {
                MetroMessageBox.Show(this, "Click edit before update", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            }
            e_customer_id_textbox.Enabled = false;
            e_customer_name_textbox.Enabled = false;
            e_customer_contact_no_textbox.Enabled = false;
            e_customer_address_textbox.Enabled = false;
        }

        private void customer_address_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                save_button_Click((object)sender, (EventArgs)e);
            }
        }
    }
}
