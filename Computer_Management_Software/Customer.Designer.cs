namespace Computer_Management_Software
{
    partial class Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.home_button = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.save_button = new MetroFramework.Controls.MetroButton();
            this.reset_button = new MetroFramework.Controls.MetroButton();
            this.customer_address_textbox = new MetroFramework.Controls.MetroTextBox();
            this.customer_contact_textbox = new MetroFramework.Controls.MetroTextBox();
            this.customer_name_textbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.billing_label = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.all_customer_button = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.address_search_textbox = new MetroFramework.Controls.MetroTextBox();
            this.contact_no_search_textbox = new MetroFramework.Controls.MetroTextBox();
            this.name_search_textbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.grid_customer = new MetroFramework.Controls.MetroGrid();
            this.g_customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_customer_contactno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_customer_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_employee_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.cancel_button = new MetroFramework.Controls.MetroButton();
            this.edit_button = new MetroFramework.Controls.MetroButton();
            this.e_customer_id_textbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.update_button = new MetroFramework.Controls.MetroButton();
            this.e_customer_address_textbox = new MetroFramework.Controls.MetroTextBox();
            this.e_customer_contact_no_textbox = new MetroFramework.Controls.MetroTextBox();
            this.e_customer_name_textbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.select_for_bill_button = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_customer)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // home_button
            // 
            this.home_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.home_button.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.home_button.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.home_button.Location = new System.Drawing.Point(997, 493);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(180, 73);
            this.home_button.Style = MetroFramework.MetroColorStyle.White;
            this.home_button.TabIndex = 0;
            this.home_button.Text = "HOME";
            this.home_button.UseCustomBackColor = true;
            this.home_button.UseSelectable = true;
            this.home_button.UseStyleColors = true;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(908, 493);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 1;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.save_button);
            this.metroPanel1.Controls.Add(this.reset_button);
            this.metroPanel1.Controls.Add(this.customer_address_textbox);
            this.metroPanel1.Controls.Add(this.customer_contact_textbox);
            this.metroPanel1.Controls.Add(this.customer_name_textbox);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.billing_label);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(37, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(313, 215);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(188, 168);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(97, 23);
            this.save_button.TabIndex = 17;
            this.save_button.Text = "SAVE";
            this.save_button.UseSelectable = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(7, 169);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(97, 23);
            this.reset_button.TabIndex = 16;
            this.reset_button.Text = "RESET";
            this.reset_button.UseSelectable = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // customer_address_textbox
            // 
            // 
            // 
            // 
            this.customer_address_textbox.CustomButton.Image = null;
            this.customer_address_textbox.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.customer_address_textbox.CustomButton.Name = "";
            this.customer_address_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.customer_address_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.customer_address_textbox.CustomButton.TabIndex = 1;
            this.customer_address_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.customer_address_textbox.CustomButton.UseSelectable = true;
            this.customer_address_textbox.CustomButton.Visible = false;
            this.customer_address_textbox.Lines = new string[0];
            this.customer_address_textbox.Location = new System.Drawing.Point(118, 127);
            this.customer_address_textbox.MaxLength = 32767;
            this.customer_address_textbox.Name = "customer_address_textbox";
            this.customer_address_textbox.PasswordChar = '\0';
            this.customer_address_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.customer_address_textbox.SelectedText = "";
            this.customer_address_textbox.SelectionLength = 0;
            this.customer_address_textbox.SelectionStart = 0;
            this.customer_address_textbox.Size = new System.Drawing.Size(167, 23);
            this.customer_address_textbox.TabIndex = 15;
            this.customer_address_textbox.UseSelectable = true;
            this.customer_address_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.customer_address_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.customer_address_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.customer_address_textbox_KeyDown);
            // 
            // customer_contact_textbox
            // 
            // 
            // 
            // 
            this.customer_contact_textbox.CustomButton.Image = null;
            this.customer_contact_textbox.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.customer_contact_textbox.CustomButton.Name = "";
            this.customer_contact_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.customer_contact_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.customer_contact_textbox.CustomButton.TabIndex = 1;
            this.customer_contact_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.customer_contact_textbox.CustomButton.UseSelectable = true;
            this.customer_contact_textbox.CustomButton.Visible = false;
            this.customer_contact_textbox.Lines = new string[0];
            this.customer_contact_textbox.Location = new System.Drawing.Point(118, 85);
            this.customer_contact_textbox.MaxLength = 32767;
            this.customer_contact_textbox.Name = "customer_contact_textbox";
            this.customer_contact_textbox.PasswordChar = '\0';
            this.customer_contact_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.customer_contact_textbox.SelectedText = "";
            this.customer_contact_textbox.SelectionLength = 0;
            this.customer_contact_textbox.SelectionStart = 0;
            this.customer_contact_textbox.Size = new System.Drawing.Size(167, 23);
            this.customer_contact_textbox.TabIndex = 14;
            this.customer_contact_textbox.UseSelectable = true;
            this.customer_contact_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.customer_contact_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // customer_name_textbox
            // 
            // 
            // 
            // 
            this.customer_name_textbox.CustomButton.Image = null;
            this.customer_name_textbox.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.customer_name_textbox.CustomButton.Name = "";
            this.customer_name_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.customer_name_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.customer_name_textbox.CustomButton.TabIndex = 1;
            this.customer_name_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.customer_name_textbox.CustomButton.UseSelectable = true;
            this.customer_name_textbox.CustomButton.Visible = false;
            this.customer_name_textbox.Lines = new string[0];
            this.customer_name_textbox.Location = new System.Drawing.Point(118, 43);
            this.customer_name_textbox.MaxLength = 32767;
            this.customer_name_textbox.Name = "customer_name_textbox";
            this.customer_name_textbox.PasswordChar = '\0';
            this.customer_name_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.customer_name_textbox.SelectedText = "";
            this.customer_name_textbox.SelectionLength = 0;
            this.customer_name_textbox.SelectionStart = 0;
            this.customer_name_textbox.Size = new System.Drawing.Size(167, 23);
            this.customer_name_textbox.TabIndex = 13;
            this.customer_name_textbox.UseSelectable = true;
            this.customer_name_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.customer_name_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(7, 127);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(56, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Address";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(7, 85);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Contact NO";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(7, 43);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = " Name";
            // 
            // billing_label
            // 
            this.billing_label.AutoSize = true;
            this.billing_label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.billing_label.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.billing_label.Location = new System.Drawing.Point(92, 0);
            this.billing_label.Name = "billing_label";
            this.billing_label.Size = new System.Drawing.Size(136, 25);
            this.billing_label.TabIndex = 9;
            this.billing_label.Text = "New Customer";
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel2.Controls.Add(this.all_customer_button);
            this.metroPanel2.Controls.Add(this.metroLabel8);
            this.metroPanel2.Controls.Add(this.address_search_textbox);
            this.metroPanel2.Controls.Add(this.contact_no_search_textbox);
            this.metroPanel2.Controls.Add(this.name_search_textbox);
            this.metroPanel2.Controls.Add(this.metroLabel5);
            this.metroPanel2.Controls.Add(this.metroLabel6);
            this.metroPanel2.Controls.Add(this.metroLabel7);
            this.metroPanel2.Controls.Add(this.grid_customer);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(451, 65);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(676, 422);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // all_customer_button
            // 
            this.all_customer_button.Location = new System.Drawing.Point(490, 73);
            this.all_customer_button.Name = "all_customer_button";
            this.all_customer_button.Size = new System.Drawing.Size(98, 23);
            this.all_customer_button.TabIndex = 33;
            this.all_customer_button.Text = "All Customer";
            this.all_customer_button.UseSelectable = true;
            this.all_customer_button.Click += new System.EventHandler(this.all_customer_button_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(23, 12);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(155, 25);
            this.metroLabel8.TabIndex = 32;
            this.metroLabel8.Text = "Search Customer";
            // 
            // address_search_textbox
            // 
            // 
            // 
            // 
            this.address_search_textbox.CustomButton.Image = null;
            this.address_search_textbox.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.address_search_textbox.CustomButton.Name = "";
            this.address_search_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.address_search_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.address_search_textbox.CustomButton.TabIndex = 1;
            this.address_search_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.address_search_textbox.CustomButton.UseSelectable = true;
            this.address_search_textbox.CustomButton.Visible = false;
            this.address_search_textbox.Lines = new string[0];
            this.address_search_textbox.Location = new System.Drawing.Point(336, 73);
            this.address_search_textbox.MaxLength = 32767;
            this.address_search_textbox.Name = "address_search_textbox";
            this.address_search_textbox.PasswordChar = '\0';
            this.address_search_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.address_search_textbox.SelectedText = "";
            this.address_search_textbox.SelectionLength = 0;
            this.address_search_textbox.SelectionStart = 0;
            this.address_search_textbox.Size = new System.Drawing.Size(118, 23);
            this.address_search_textbox.TabIndex = 31;
            this.address_search_textbox.UseSelectable = true;
            this.address_search_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.address_search_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.address_search_textbox.TextChanged += new System.EventHandler(this.address_search_textbox_TextChanged);
            // 
            // contact_no_search_textbox
            // 
            // 
            // 
            // 
            this.contact_no_search_textbox.CustomButton.Image = null;
            this.contact_no_search_textbox.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.contact_no_search_textbox.CustomButton.Name = "";
            this.contact_no_search_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.contact_no_search_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.contact_no_search_textbox.CustomButton.TabIndex = 1;
            this.contact_no_search_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.contact_no_search_textbox.CustomButton.UseSelectable = true;
            this.contact_no_search_textbox.CustomButton.Visible = false;
            this.contact_no_search_textbox.Lines = new string[0];
            this.contact_no_search_textbox.Location = new System.Drawing.Point(183, 73);
            this.contact_no_search_textbox.MaxLength = 32767;
            this.contact_no_search_textbox.Name = "contact_no_search_textbox";
            this.contact_no_search_textbox.PasswordChar = '\0';
            this.contact_no_search_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.contact_no_search_textbox.SelectedText = "";
            this.contact_no_search_textbox.SelectionLength = 0;
            this.contact_no_search_textbox.SelectionStart = 0;
            this.contact_no_search_textbox.Size = new System.Drawing.Size(118, 23);
            this.contact_no_search_textbox.TabIndex = 30;
            this.contact_no_search_textbox.UseSelectable = true;
            this.contact_no_search_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.contact_no_search_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.contact_no_search_textbox.TextChanged += new System.EventHandler(this.contact_no_search_textbox_TextChanged);
            // 
            // name_search_textbox
            // 
            // 
            // 
            // 
            this.name_search_textbox.CustomButton.Image = null;
            this.name_search_textbox.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.name_search_textbox.CustomButton.Name = "";
            this.name_search_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.name_search_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.name_search_textbox.CustomButton.TabIndex = 1;
            this.name_search_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.name_search_textbox.CustomButton.UseSelectable = true;
            this.name_search_textbox.CustomButton.Visible = false;
            this.name_search_textbox.Lines = new string[0];
            this.name_search_textbox.Location = new System.Drawing.Point(39, 73);
            this.name_search_textbox.MaxLength = 32767;
            this.name_search_textbox.Name = "name_search_textbox";
            this.name_search_textbox.PasswordChar = '\0';
            this.name_search_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.name_search_textbox.SelectedText = "";
            this.name_search_textbox.SelectionLength = 0;
            this.name_search_textbox.SelectionStart = 0;
            this.name_search_textbox.Size = new System.Drawing.Size(118, 23);
            this.name_search_textbox.TabIndex = 29;
            this.name_search_textbox.UseSelectable = true;
            this.name_search_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.name_search_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.name_search_textbox.TextChanged += new System.EventHandler(this.name_search_textbox_TextChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(336, 37);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(56, 19);
            this.metroLabel5.TabIndex = 28;
            this.metroLabel5.Text = "Address";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(183, 37);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(79, 19);
            this.metroLabel6.TabIndex = 27;
            this.metroLabel6.Text = "Contact NO";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(39, 37);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(49, 19);
            this.metroLabel7.TabIndex = 26;
            this.metroLabel7.Text = " Name";
            // 
            // grid_customer
            // 
            this.grid_customer.AllowUserToOrderColumns = true;
            this.grid_customer.AllowUserToResizeRows = false;
            this.grid_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_customer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_customer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_customer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.g_customer_id,
            this.g_customer_name,
            this.g_customer_contactno,
            this.g_customer_address,
            this.g_employee_id});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_customer.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_customer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_customer.EnableHeadersVisualStyles = false;
            this.grid_customer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_customer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_customer.Location = new System.Drawing.Point(39, 102);
            this.grid_customer.Name = "grid_customer";
            this.grid_customer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_customer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_customer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_customer.Size = new System.Drawing.Size(614, 295);
            this.grid_customer.Style = MetroFramework.MetroColorStyle.Silver;
            this.grid_customer.TabIndex = 25;
            this.grid_customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_product_CellContentClick);
            this.grid_customer.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_customer_CellMouseClick);
            this.grid_customer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grid_customer_KeyDown);
            this.grid_customer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.grid_customer_KeyUp);
            this.grid_customer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grid_customer_MouseClick);
            // 
            // g_customer_id
            // 
            this.g_customer_id.HeaderText = "Customer ID";
            this.g_customer_id.Name = "g_customer_id";
            this.g_customer_id.Width = 85;
            // 
            // g_customer_name
            // 
            this.g_customer_name.HeaderText = "Customer Name";
            this.g_customer_name.Name = "g_customer_name";
            this.g_customer_name.Width = 102;
            // 
            // g_customer_contactno
            // 
            this.g_customer_contactno.HeaderText = "Customer Contact NO";
            this.g_customer_contactno.Name = "g_customer_contactno";
            this.g_customer_contactno.Width = 114;
            // 
            // g_customer_address
            // 
            this.g_customer_address.HeaderText = "Customer Address";
            this.g_customer_address.Name = "g_customer_address";
            this.g_customer_address.Width = 112;
            // 
            // g_employee_id
            // 
            this.g_employee_id.HeaderText = "Employee ID";
            this.g_employee_id.Name = "g_employee_id";
            this.g_employee_id.Width = 85;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel3.Controls.Add(this.cancel_button);
            this.metroPanel3.Controls.Add(this.edit_button);
            this.metroPanel3.Controls.Add(this.e_customer_id_textbox);
            this.metroPanel3.Controls.Add(this.metroLabel13);
            this.metroPanel3.Controls.Add(this.update_button);
            this.metroPanel3.Controls.Add(this.e_customer_address_textbox);
            this.metroPanel3.Controls.Add(this.e_customer_contact_no_textbox);
            this.metroPanel3.Controls.Add(this.e_customer_name_textbox);
            this.metroPanel3.Controls.Add(this.metroLabel9);
            this.metroPanel3.Controls.Add(this.metroLabel10);
            this.metroPanel3.Controls.Add(this.metroLabel11);
            this.metroPanel3.Controls.Add(this.metroLabel12);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(46, 317);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(313, 267);
            this.metroPanel3.TabIndex = 4;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(92, 237);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(97, 23);
            this.cancel_button.TabIndex = 21;
            this.cancel_button.Text = "CANCEL";
            this.cancel_button.UseSelectable = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(11, 208);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(97, 23);
            this.edit_button.TabIndex = 20;
            this.edit_button.Text = "EDIT";
            this.edit_button.UseSelectable = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // e_customer_id_textbox
            // 
            // 
            // 
            // 
            this.e_customer_id_textbox.CustomButton.Image = null;
            this.e_customer_id_textbox.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.e_customer_id_textbox.CustomButton.Name = "";
            this.e_customer_id_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.e_customer_id_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.e_customer_id_textbox.CustomButton.TabIndex = 1;
            this.e_customer_id_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.e_customer_id_textbox.CustomButton.UseSelectable = true;
            this.e_customer_id_textbox.CustomButton.Visible = false;
            this.e_customer_id_textbox.Enabled = false;
            this.e_customer_id_textbox.Lines = new string[0];
            this.e_customer_id_textbox.Location = new System.Drawing.Point(122, 35);
            this.e_customer_id_textbox.MaxLength = 32767;
            this.e_customer_id_textbox.Name = "e_customer_id_textbox";
            this.e_customer_id_textbox.PasswordChar = '\0';
            this.e_customer_id_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.e_customer_id_textbox.SelectedText = "";
            this.e_customer_id_textbox.SelectionLength = 0;
            this.e_customer_id_textbox.SelectionStart = 0;
            this.e_customer_id_textbox.Size = new System.Drawing.Size(167, 23);
            this.e_customer_id_textbox.TabIndex = 19;
            this.e_customer_id_textbox.UseSelectable = true;
            this.e_customer_id_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.e_customer_id_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(11, 39);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(82, 19);
            this.metroLabel13.TabIndex = 18;
            this.metroLabel13.Text = "Customer ID";
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(192, 208);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(97, 23);
            this.update_button.TabIndex = 17;
            this.update_button.Text = "UPDATE";
            this.update_button.UseSelectable = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // e_customer_address_textbox
            // 
            // 
            // 
            // 
            this.e_customer_address_textbox.CustomButton.Image = null;
            this.e_customer_address_textbox.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.e_customer_address_textbox.CustomButton.Name = "";
            this.e_customer_address_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.e_customer_address_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.e_customer_address_textbox.CustomButton.TabIndex = 1;
            this.e_customer_address_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.e_customer_address_textbox.CustomButton.UseSelectable = true;
            this.e_customer_address_textbox.CustomButton.Visible = false;
            this.e_customer_address_textbox.Enabled = false;
            this.e_customer_address_textbox.Lines = new string[0];
            this.e_customer_address_textbox.Location = new System.Drawing.Point(122, 164);
            this.e_customer_address_textbox.MaxLength = 32767;
            this.e_customer_address_textbox.Name = "e_customer_address_textbox";
            this.e_customer_address_textbox.PasswordChar = '\0';
            this.e_customer_address_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.e_customer_address_textbox.SelectedText = "";
            this.e_customer_address_textbox.SelectionLength = 0;
            this.e_customer_address_textbox.SelectionStart = 0;
            this.e_customer_address_textbox.Size = new System.Drawing.Size(167, 23);
            this.e_customer_address_textbox.TabIndex = 15;
            this.e_customer_address_textbox.UseSelectable = true;
            this.e_customer_address_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.e_customer_address_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // e_customer_contact_no_textbox
            // 
            // 
            // 
            // 
            this.e_customer_contact_no_textbox.CustomButton.Image = null;
            this.e_customer_contact_no_textbox.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.e_customer_contact_no_textbox.CustomButton.Name = "";
            this.e_customer_contact_no_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.e_customer_contact_no_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.e_customer_contact_no_textbox.CustomButton.TabIndex = 1;
            this.e_customer_contact_no_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.e_customer_contact_no_textbox.CustomButton.UseSelectable = true;
            this.e_customer_contact_no_textbox.CustomButton.Visible = false;
            this.e_customer_contact_no_textbox.Enabled = false;
            this.e_customer_contact_no_textbox.Lines = new string[0];
            this.e_customer_contact_no_textbox.Location = new System.Drawing.Point(122, 122);
            this.e_customer_contact_no_textbox.MaxLength = 32767;
            this.e_customer_contact_no_textbox.Name = "e_customer_contact_no_textbox";
            this.e_customer_contact_no_textbox.PasswordChar = '\0';
            this.e_customer_contact_no_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.e_customer_contact_no_textbox.SelectedText = "";
            this.e_customer_contact_no_textbox.SelectionLength = 0;
            this.e_customer_contact_no_textbox.SelectionStart = 0;
            this.e_customer_contact_no_textbox.Size = new System.Drawing.Size(167, 23);
            this.e_customer_contact_no_textbox.TabIndex = 14;
            this.e_customer_contact_no_textbox.UseSelectable = true;
            this.e_customer_contact_no_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.e_customer_contact_no_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // e_customer_name_textbox
            // 
            // 
            // 
            // 
            this.e_customer_name_textbox.CustomButton.Image = null;
            this.e_customer_name_textbox.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.e_customer_name_textbox.CustomButton.Name = "";
            this.e_customer_name_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.e_customer_name_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.e_customer_name_textbox.CustomButton.TabIndex = 1;
            this.e_customer_name_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.e_customer_name_textbox.CustomButton.UseSelectable = true;
            this.e_customer_name_textbox.CustomButton.Visible = false;
            this.e_customer_name_textbox.Enabled = false;
            this.e_customer_name_textbox.Lines = new string[0];
            this.e_customer_name_textbox.Location = new System.Drawing.Point(122, 80);
            this.e_customer_name_textbox.MaxLength = 32767;
            this.e_customer_name_textbox.Name = "e_customer_name_textbox";
            this.e_customer_name_textbox.PasswordChar = '\0';
            this.e_customer_name_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.e_customer_name_textbox.SelectedText = "";
            this.e_customer_name_textbox.SelectionLength = 0;
            this.e_customer_name_textbox.SelectionStart = 0;
            this.e_customer_name_textbox.Size = new System.Drawing.Size(167, 23);
            this.e_customer_name_textbox.TabIndex = 13;
            this.e_customer_name_textbox.UseSelectable = true;
            this.e_customer_name_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.e_customer_name_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(11, 164);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(56, 19);
            this.metroLabel9.TabIndex = 12;
            this.metroLabel9.Text = "Address";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(11, 122);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(79, 19);
            this.metroLabel10.TabIndex = 11;
            this.metroLabel10.Text = "Contact NO";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(11, 80);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(49, 19);
            this.metroLabel11.TabIndex = 10;
            this.metroLabel11.Text = " Name";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.Location = new System.Drawing.Point(92, 0);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(133, 25);
            this.metroLabel12.TabIndex = 9;
            this.metroLabel12.Text = "Customer Info";
            // 
            // select_for_bill_button
            // 
            this.select_for_bill_button.BackColor = System.Drawing.Color.Black;
            this.select_for_bill_button.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.select_for_bill_button.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.select_for_bill_button.Location = new System.Drawing.Point(535, 511);
            this.select_for_bill_button.Name = "select_for_bill_button";
            this.select_for_bill_button.Size = new System.Drawing.Size(330, 39);
            this.select_for_bill_button.Style = MetroFramework.MetroColorStyle.White;
            this.select_for_bill_button.TabIndex = 5;
            this.select_for_bill_button.Text = "Select For Bill";
            this.select_for_bill_button.UseCustomBackColor = true;
            this.select_for_bill_button.UseSelectable = true;
            this.select_for_bill_button.UseStyleColors = true;
            this.select_for_bill_button.Click += new System.EventHandler(this.select_for_bill_button_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 607);
            this.ControlBox = false;
            this.Controls.Add(this.select_for_bill_button);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.home_button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Customer";
            this.Resizable = false;
            this.Text = "Customer";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.ClientInformation_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_customer)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton home_button;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel billing_label;
        private MetroFramework.Controls.MetroButton save_button;
        private MetroFramework.Controls.MetroButton reset_button;
        private MetroFramework.Controls.MetroTextBox customer_address_textbox;
        private MetroFramework.Controls.MetroTextBox customer_contact_textbox;
        private MetroFramework.Controls.MetroTextBox customer_name_textbox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroGrid grid_customer;
        private MetroFramework.Controls.MetroButton all_customer_button;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox address_search_textbox;
        private MetroFramework.Controls.MetroTextBox contact_no_search_textbox;
        private MetroFramework.Controls.MetroTextBox name_search_textbox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroButton cancel_button;
        private MetroFramework.Controls.MetroButton edit_button;
        private MetroFramework.Controls.MetroTextBox e_customer_id_textbox;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroButton update_button;
        private MetroFramework.Controls.MetroTextBox e_customer_address_textbox;
        private MetroFramework.Controls.MetroTextBox e_customer_contact_no_textbox;
        private MetroFramework.Controls.MetroTextBox e_customer_name_textbox;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroButton select_for_bill_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_customer_contactno;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_customer_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_employee_id;
    }
}