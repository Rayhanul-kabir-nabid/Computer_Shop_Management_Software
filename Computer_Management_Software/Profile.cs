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
    public partial class Profile : MetroForm
    {
        Bo_class bo;
        public Profile(Bo_class bo1)
        {
            InitializeComponent();
            bo = bo1;
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void home_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
