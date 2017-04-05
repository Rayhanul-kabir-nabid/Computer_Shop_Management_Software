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
using MetroFramework;
using BO_Layer;
namespace Computer_Management_Software
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }
        private Timer _Timer = new Timer();
        Bo_class bo = new Bo_class();
        private void Login_Load(object sender, EventArgs e)
        {
            _Timer.Interval = 1000;
            _Timer.Tick += new EventHandler(_Timer_Tick);
            _Timer.Start();
            this.CancelButton = exit_button;
            Clock_button.Select();
        }
        void _Timer_Tick(object sender, EventArgs e)
        {
            this.Clock_button.Text = DateTime.Now.ToString();
        }
        private void clock_button_Click(object sender, EventArgs e)
        {

        }

        private void metroButton7_Click(object sender, EventArgs e)
        {

        }

        private void Clock_button_Click_1(object sender, EventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void password_lebel_Click(object sender, EventArgs e)
        {

        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(bo.invoice_no_creator().ToString());
            username_textbox.Clear();
            password_textbox.Clear();
        }

        private void signin_button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(bo.datetime());
            string username, password;
            username = username_textbox.Text;
            password = password_textbox.Text;
            int t = bo.sign_in(username,password);
            if (t==0)
            {
                
                MetroMessageBox.Show(this, "Wrong Combination", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (t==1)
            {
                //MessageBox.Show(t.ToString());
                bo.mainname = username;
                Home home = new Home(bo);
                home.Show();
                this.Hide();
            }
            else if(t==2)
            {
                Home home = new Home(bo);
                bo.mainname = username;
               // MessageBox.Show(bo.mainname);
                home.Show();
                this.Hide();
            }
            
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextBox7_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void clear_button2_Click(object sender, EventArgs e)
        {
            user_name_textbox.Clear();
            pass_textbox.Clear();
            full_name_textbox.Clear();
            contact_no_textbox.Clear();
            type_combobox.Text = null;
            gender_combobox.Text = null;
            email_textbox.Clear();
            address_textbox.Clear();
        }

        private void save_button_Click(object sender, EventArgs e)
        {

            
             string fullname = full_name_textbox.Text;
             string username = user_name_textbox.Text;
             string password = pass_textbox.Text;
             string contactno = contact_no_textbox.Text;
             string type = type_combobox.Text;
             string gender = gender_combobox.Text;
             string email = email_textbox.Text;
             string address = address_textbox.Text;
             string admin_name = admin_name_textbox.Text;
             string admin_pass = admin_password_textbox.Text;
             string message;
            if ( fullname == "" || username == "" || password == "" || contactno  == "" || type == "" || gender== "" || email == "" || address == "" || admin_name == "" || admin_pass == "")
            {
                MetroMessageBox.Show(this, "Fill up every blank.", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
           
            }
            else
            {
                message = bo.add_member(fullname, username, password, contactno, type, gender, email, address, admin_name, admin_pass);
                if (message == "Successfull")
                {
                    MetroMessageBox.Show(this, "Saved successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MetroMessageBox.Show(this, message, "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                }
             }
           //  MessageBox.Show(b.ToString());
             

            user_name_textbox.Clear();
            pass_textbox.Clear();
            full_name_textbox.Clear();
            contact_no_textbox.Clear();
            type_combobox.Text = null;
            gender_combobox.Text = null;
            email_textbox.Clear();
            address_textbox.Clear();
            admin_name_textbox.Clear();
            admin_password_textbox.Clear();
        }

        private void password_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signin_button_Click((object) sender, (EventArgs) e);
            }
        }

        private void admin_password_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                save_button_Click((object)sender, (EventArgs)e);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            /*
              private void Form1_Load(object sender, EventArgs e)
    {
        notifyIcon1.BalloonTipText = "Application Minimized.";
        notifyIcon1.BalloonTipTitle = "test";
    }

    private void Form1_Resize(object sender, EventArgs e)
    {
        if (WindowState == FormWindowState.Minimized)
        {
            ShowInTaskbar = false;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(1000);
        }
    }

    private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        ShowInTaskbar = true;
        notifyIcon1.Visible = false;
        WindowState = FormWindowState.Normal;
    }
            */
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void password_textbox_Click(object sender, EventArgs e)
        {

        }

        private void change_button_Click(object sender, EventArgs e)
        {
            string m;
            if (c_p_new_password_textbox.Text == "")
            {
                 MetroMessageBox.Show(this, "Give new password.", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            }
            else
            {
                 m = bo.change_password(c_p_user_name_button.Text, c_p_current_password_textbox.Text, c_p_new_password_textbox.Text);
                 if (m == "Successfull")
                {

                     MetroMessageBox.Show(this, "Changed successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                     c_p_user_name_button.Clear();
                     c_p_new_password_textbox.Clear();
                     c_p_current_password_textbox.Clear();
                 }
                 else
                 {
                     MetroMessageBox.Show(this, m, "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                 }
            }
            
        }
    }
}
