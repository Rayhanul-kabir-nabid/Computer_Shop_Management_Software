using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity_Layer;
using BO_Layer;
using MetroFramework.Forms;
using MetroFramework;
namespace Computer_Management_Software
{
    public partial class Home : MetroForm
    {
        private Timer _Timer = new Timer();

        Bo_class bo;
        public Home(Bo_class bo1)
        {
            InitializeComponent();
            bo = bo1;

        }
        Entry_Product entry;
        Search_and_delete_product snd;
        Customer ci ;
        Invoice inv ;
        Income inc ;
        Member mem ;
        
        private void Form1_Load(object sender, EventArgs e)
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
        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void xButton8_Click(object sender, EventArgs e)
        {
            
        }

        private void Calculator_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void notepad_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void wordpad_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Wordpad.exe");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            entry = new Entry_Product(bo);
            MessageBox.Show(bo.mainname);
            entry.Show();
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            snd = new Search_and_delete_product(bo);
            snd.Show();
            //this.Hide();
        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signout_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void clientinformation_button_Click(object sender, EventArgs e)
        {
            ci = new Customer(bo);
            ci.Show();
            //this.Hide();
        }

        private void invoice_button_Click(object sender, EventArgs e)
        {
            inv = new Invoice(bo);
            inv.Show();
            //this.Hide();
            
        }

        private void income_button_Click(object sender, EventArgs e)
        {
            if (bo.is_admin_or_member(bo.mainname)==0)
            {
                MetroMessageBox.Show(this, "You don't have permission", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
           
            }
            else if (bo.is_admin_or_member(bo.mainname)==1)
            {
                inc = new Income(bo);
                inc.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "Something's wrong in system", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
           
            }
            
           // this.Hide();
        }

        private void member_button_Click(object sender, EventArgs e)
        {
            if (bo.is_admin_or_member(bo.mainname) == 0)
            {
                MetroMessageBox.Show(this, "You don't have permission", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            }
            else if (bo.is_admin_or_member(bo.mainname) == 1)
            {
                mem = new Member(bo);
                mem.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "Something's wrong in system", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            }
            
            //this.Hide();
        }

        private void sales_button_Click(object sender, EventArgs e)
        {
            Sales sale = new Sales(bo);
            sale.Show();
            //this.Hide();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void profile_button_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(bo);
            profile.Show();
        }
        
        //746, 544
          
    }
}
