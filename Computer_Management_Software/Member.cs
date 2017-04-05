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
    public partial class Member : MetroForm
    {
        Bo_class bo;
        public Member(Bo_class bo1)
        {
            InitializeComponent();
            bo = bo1;
        }

        private void Member_Load(object sender, EventArgs e)
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
        public int uid=0;
        private void all_member_button_Click(object sender, EventArgs e)
        {
            ds = bo.all_member();
            g_id.DataPropertyName = "id";
            g_username.DataPropertyName = "user_name";
            g_fullname.DataPropertyName = "full_name";
            g_address.DataPropertyName = "address";
            g_contactno.DataPropertyName = "contact_no";
            g_email.DataPropertyName = "email";
            g_gender.DataPropertyName = "gender";
            g_type.DataPropertyName = "type";

            grid_member.DataSource = ds;
            grid_member.DataMember = "employee";
            edit_button.Show();
            update_button.Show();
            
        }

        private void grid_member_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = grid_member.SelectedRows[0];
                uid = Convert.ToInt32(dr.Cells[0].Value.ToString());
                full_name_textbox.Text = dr.Cells[2].Value.ToString();
                user_name_textbox.Text = dr.Cells[1].Value.ToString();
                contact_no_textbox.Text = dr.Cells[3].Value.ToString();
                email_textbox.Text = dr.Cells[6].Value.ToString();
                address_textbox.Text = dr.Cells[7].Value.ToString();
                type_combobox.Text = dr.Cells[4].Value.ToString();
                gender_combobox.Text = dr.Cells[5].Value.ToString();

                edit_button.Show();
                update_button.Hide();
                full_name_textbox.Enabled = false;
                contact_no_textbox.Enabled = false;
                email_textbox.Enabled = false;
                address_textbox.Enabled = false;
                type_combobox.Enabled = false;
                gender_combobox.Enabled = false;

                
            }
            catch (Exception ex)
            {

                type_combobox.Text = null;
                gender_combobox.Text = null;
            }

        }

        private void grid_member_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                DataGridViewRow dr = grid_member.SelectedRows[0];
                uid = Convert.ToInt32(dr.Cells[0].Value.ToString());
                full_name_textbox.Text = dr.Cells[2].Value.ToString();
                user_name_textbox.Text = dr.Cells[1].Value.ToString();
                contact_no_textbox.Text = dr.Cells[3].Value.ToString();
                email_textbox.Text = dr.Cells[6].Value.ToString();
                address_textbox.Text = dr.Cells[7].Value.ToString();
                type_combobox.Text = dr.Cells[4].Value.ToString();
                gender_combobox.Text = dr.Cells[5].Value.ToString();

                edit_button.Show();
                update_button.Hide();
                full_name_textbox.Enabled = false;
                contact_no_textbox.Enabled = false;
                email_textbox.Enabled = false;
                address_textbox.Enabled = false;
                type_combobox.Enabled = false;
                gender_combobox.Enabled = false;
            }
            catch (Exception ex)
            {

                type_combobox.Text = null;
                gender_combobox.Text = null;
            }
        }
        
        private void grid_member_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DataGridViewRow dr = grid_member.SelectedRows[0];
                uid = Convert.ToInt32( dr.Cells[0].Value.ToString());
                full_name_textbox.Text = dr.Cells[2].Value.ToString();
                user_name_textbox.Text = dr.Cells[1].Value.ToString();
                contact_no_textbox.Text = dr.Cells[3].Value.ToString();
                email_textbox.Text = dr.Cells[6].Value.ToString();
                address_textbox.Text = dr.Cells[7].Value.ToString();
                type_combobox.Text = dr.Cells[4].Value.ToString();
                gender_combobox.Text = dr.Cells[5].Value.ToString();

                edit_button.Show();
                update_button.Hide();
                full_name_textbox.Enabled = false;
                contact_no_textbox.Enabled = false;
                email_textbox.Enabled = false;
                address_textbox.Enabled = false;
                type_combobox.Enabled = false;
                gender_combobox.Enabled = false;
            }
            catch (Exception ex)
            {
                type_combobox.Text = null;
                gender_combobox.Text = null;

            }
        }
        
        private void cancel_button_Click(object sender, EventArgs e)
        {
            full_name_textbox.Clear();
            user_name_textbox.Clear();
            contact_no_textbox.Clear();
            email_textbox.Clear();
            address_textbox.Clear();
            type_combobox.Text = null;
            gender_combobox.Text = null;
            edit_button.Show();
            update_button.Show();

            full_name_textbox.Enabled = false;
            contact_no_textbox.Enabled = false;
            email_textbox.Enabled = false;
            address_textbox.Enabled = false;
            type_combobox.Enabled = false;
            gender_combobox.Enabled = false;

            
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            full_name_textbox.Enabled = true;
            contact_no_textbox.Enabled = true;
            email_textbox.Enabled = true;
            address_textbox.Enabled = true;
            type_combobox.Enabled = true;
            gender_combobox.Enabled = true;

            edit_button.Hide();
            update_button.Show();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            
            edit_button.Show();
            update_button.Show();

            string message = null;

            DialogResult result = MetroMessageBox.Show(this, "Are you sure to delete this?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None);
            if (result.ToString() == "Yes")
            {
                message = bo.delete_employee(user_name_textbox.Text);
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

            full_name_textbox.Enabled = false;
            contact_no_textbox.Enabled = false;
            email_textbox.Enabled = false;
            address_textbox.Enabled = false;
            type_combobox.Enabled = false;
            gender_combobox.Enabled = false;
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            
            if (edit_button.Visible == false)
            {
                
                string message = null;
                try
                {
                    if (full_name_textbox.Text != "" && contact_no_textbox.Text != "" && address_textbox.Text != "" && type_combobox.Text != "" && gender_combobox.Text!= "")
                    {
                        message = bo.update_employee(full_name_textbox.Text, contact_no_textbox.Text, email_textbox.Text, address_textbox.Text, type_combobox.Text, gender_combobox.Text, uid);
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
            full_name_textbox.Enabled = false;
            contact_no_textbox.Enabled = false;
            email_textbox.Enabled = false;
            address_textbox.Enabled = false;
            type_combobox.Enabled = false;   
            gender_combobox.Enabled = false;

        }

        private void grid_member_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
