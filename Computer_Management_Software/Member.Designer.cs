namespace Computer_Management_Software
{
    partial class Member
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
            this.grid_member = new MetroFramework.Controls.MetroGrid();
            this.new_member_panel = new MetroFramework.Controls.MetroPanel();
            this.cancel_button = new MetroFramework.Controls.MetroButton();
            this.delete_button = new MetroFramework.Controls.MetroButton();
            this.update_button = new MetroFramework.Controls.MetroButton();
            this.edit_button = new MetroFramework.Controls.MetroButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.gender_combobox = new MetroFramework.Controls.MetroComboBox();
            this.address_textbox = new MetroFramework.Controls.MetroTextBox();
            this.type_combobox = new MetroFramework.Controls.MetroComboBox();
            this.email_textbox = new MetroFramework.Controls.MetroTextBox();
            this.contact_no_textbox = new MetroFramework.Controls.MetroTextBox();
            this.user_name_textbox = new MetroFramework.Controls.MetroTextBox();
            this.full_name_textbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.all_member_button = new MetroFramework.Controls.MetroButton();
            this.g_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_contactno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_member)).BeginInit();
            this.new_member_panel.SuspendLayout();
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
            this.metroLabel1.Location = new System.Drawing.Point(773, 452);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 1;
            // 
            // grid_member
            // 
            this.grid_member.AllowUserToResizeRows = false;
            this.grid_member.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_member.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_member.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_member.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_member.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_member.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.g_id,
            this.g_username,
            this.g_fullname,
            this.g_contactno,
            this.g_type,
            this.g_gender,
            this.g_email,
            this.g_address});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_member.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_member.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_member.EnableHeadersVisualStyles = false;
            this.grid_member.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_member.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_member.Location = new System.Drawing.Point(358, 62);
            this.grid_member.Name = "grid_member";
            this.grid_member.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_member.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_member.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_member.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_member.ShowEditingIcon = false;
            this.grid_member.Size = new System.Drawing.Size(828, 387);
            this.grid_member.TabIndex = 2;
            this.grid_member.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_member_CellContentClick);
            this.grid_member.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grid_member_KeyDown);
            this.grid_member.KeyUp += new System.Windows.Forms.KeyEventHandler(this.grid_member_KeyUp);
            this.grid_member.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grid_member_MouseClick);
            // 
            // new_member_panel
            // 
            this.new_member_panel.Controls.Add(this.cancel_button);
            this.new_member_panel.Controls.Add(this.delete_button);
            this.new_member_panel.Controls.Add(this.update_button);
            this.new_member_panel.Controls.Add(this.edit_button);
            this.new_member_panel.Controls.Add(this.metroLabel9);
            this.new_member_panel.Controls.Add(this.gender_combobox);
            this.new_member_panel.Controls.Add(this.address_textbox);
            this.new_member_panel.Controls.Add(this.type_combobox);
            this.new_member_panel.Controls.Add(this.email_textbox);
            this.new_member_panel.Controls.Add(this.contact_no_textbox);
            this.new_member_panel.Controls.Add(this.user_name_textbox);
            this.new_member_panel.Controls.Add(this.full_name_textbox);
            this.new_member_panel.Controls.Add(this.metroLabel5);
            this.new_member_panel.Controls.Add(this.metroLabel6);
            this.new_member_panel.Controls.Add(this.metroLabel8);
            this.new_member_panel.Controls.Add(this.metroLabel7);
            this.new_member_panel.Controls.Add(this.metroLabel4);
            this.new_member_panel.Controls.Add(this.metroLabel2);
            this.new_member_panel.Controls.Add(this.metroLabel12);
            this.new_member_panel.HorizontalScrollbarBarColor = true;
            this.new_member_panel.HorizontalScrollbarHighlightOnWheel = false;
            this.new_member_panel.HorizontalScrollbarSize = 10;
            this.new_member_panel.Location = new System.Drawing.Point(4, 40);
            this.new_member_panel.Name = "new_member_panel";
            this.new_member_panel.Size = new System.Drawing.Size(338, 486);
            this.new_member_panel.Style = MetroFramework.MetroColorStyle.Lime;
            this.new_member_panel.TabIndex = 10;
            this.new_member_panel.VerticalScrollbarBarColor = true;
            this.new_member_panel.VerticalScrollbarHighlightOnWheel = false;
            this.new_member_panel.VerticalScrollbarSize = 10;
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(17, 453);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 28;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseSelectable = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(178, 453);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(77, 23);
            this.delete_button.TabIndex = 27;
            this.delete_button.Text = "Delete";
            this.delete_button.UseSelectable = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(178, 412);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(77, 23);
            this.update_button.TabIndex = 26;
            this.update_button.Text = "Update";
            this.update_button.UseSelectable = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(17, 412);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(77, 23);
            this.edit_button.TabIndex = 25;
            this.edit_button.Text = "Edit";
            this.edit_button.UseSelectable = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.Location = new System.Drawing.Point(85, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(119, 25);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel9.TabIndex = 22;
            this.metroLabel9.Text = "EDIT MEMBER";
            this.metroLabel9.UseStyleColors = true;
            // 
            // gender_combobox
            // 
            this.gender_combobox.Enabled = false;
            this.gender_combobox.FormattingEnabled = true;
            this.gender_combobox.ItemHeight = 23;
            this.gender_combobox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender_combobox.Location = new System.Drawing.Point(143, 362);
            this.gender_combobox.Name = "gender_combobox";
            this.gender_combobox.Size = new System.Drawing.Size(176, 29);
            this.gender_combobox.TabIndex = 19;
            this.gender_combobox.UseSelectable = true;
            // 
            // address_textbox
            // 
            // 
            // 
            // 
            this.address_textbox.CustomButton.Image = null;
            this.address_textbox.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.address_textbox.CustomButton.Name = "";
            this.address_textbox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.address_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.address_textbox.CustomButton.TabIndex = 1;
            this.address_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.address_textbox.CustomButton.UseSelectable = true;
            this.address_textbox.CustomButton.Visible = false;
            this.address_textbox.Enabled = false;
            this.address_textbox.Lines = new string[0];
            this.address_textbox.Location = new System.Drawing.Point(143, 254);
            this.address_textbox.MaxLength = 32767;
            this.address_textbox.Name = "address_textbox";
            this.address_textbox.PasswordChar = '\0';
            this.address_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.address_textbox.SelectedText = "";
            this.address_textbox.SelectionLength = 0;
            this.address_textbox.SelectionStart = 0;
            this.address_textbox.Size = new System.Drawing.Size(176, 29);
            this.address_textbox.TabIndex = 17;
            this.address_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.address_textbox.UseSelectable = true;
            this.address_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.address_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // type_combobox
            // 
            this.type_combobox.Enabled = false;
            this.type_combobox.FormattingEnabled = true;
            this.type_combobox.ItemHeight = 23;
            this.type_combobox.Items.AddRange(new object[] {
            "Admin",
            "Member"});
            this.type_combobox.Location = new System.Drawing.Point(143, 308);
            this.type_combobox.Name = "type_combobox";
            this.type_combobox.Size = new System.Drawing.Size(176, 29);
            this.type_combobox.TabIndex = 18;
            this.type_combobox.UseSelectable = true;
            // 
            // email_textbox
            // 
            // 
            // 
            // 
            this.email_textbox.CustomButton.Image = null;
            this.email_textbox.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.email_textbox.CustomButton.Name = "";
            this.email_textbox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.email_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.email_textbox.CustomButton.TabIndex = 1;
            this.email_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.email_textbox.CustomButton.UseSelectable = true;
            this.email_textbox.CustomButton.Visible = false;
            this.email_textbox.Enabled = false;
            this.email_textbox.Lines = new string[0];
            this.email_textbox.Location = new System.Drawing.Point(143, 200);
            this.email_textbox.MaxLength = 32767;
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.PasswordChar = '\0';
            this.email_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.email_textbox.SelectedText = "";
            this.email_textbox.SelectionLength = 0;
            this.email_textbox.SelectionStart = 0;
            this.email_textbox.Size = new System.Drawing.Size(176, 29);
            this.email_textbox.TabIndex = 16;
            this.email_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.email_textbox.UseSelectable = true;
            this.email_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.email_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // contact_no_textbox
            // 
            // 
            // 
            // 
            this.contact_no_textbox.CustomButton.Image = null;
            this.contact_no_textbox.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.contact_no_textbox.CustomButton.Name = "";
            this.contact_no_textbox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.contact_no_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.contact_no_textbox.CustomButton.TabIndex = 1;
            this.contact_no_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.contact_no_textbox.CustomButton.UseSelectable = true;
            this.contact_no_textbox.CustomButton.Visible = false;
            this.contact_no_textbox.Enabled = false;
            this.contact_no_textbox.Lines = new string[0];
            this.contact_no_textbox.Location = new System.Drawing.Point(143, 146);
            this.contact_no_textbox.MaxLength = 32767;
            this.contact_no_textbox.Name = "contact_no_textbox";
            this.contact_no_textbox.PasswordChar = '\0';
            this.contact_no_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.contact_no_textbox.SelectedText = "";
            this.contact_no_textbox.SelectionLength = 0;
            this.contact_no_textbox.SelectionStart = 0;
            this.contact_no_textbox.Size = new System.Drawing.Size(176, 29);
            this.contact_no_textbox.TabIndex = 13;
            this.contact_no_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contact_no_textbox.UseSelectable = true;
            this.contact_no_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.contact_no_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // user_name_textbox
            // 
            // 
            // 
            // 
            this.user_name_textbox.CustomButton.Image = null;
            this.user_name_textbox.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.user_name_textbox.CustomButton.Name = "";
            this.user_name_textbox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.user_name_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.user_name_textbox.CustomButton.TabIndex = 1;
            this.user_name_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.user_name_textbox.CustomButton.UseSelectable = true;
            this.user_name_textbox.CustomButton.Visible = false;
            this.user_name_textbox.Enabled = false;
            this.user_name_textbox.Lines = new string[0];
            this.user_name_textbox.Location = new System.Drawing.Point(143, 92);
            this.user_name_textbox.MaxLength = 32767;
            this.user_name_textbox.Name = "user_name_textbox";
            this.user_name_textbox.PasswordChar = '\0';
            this.user_name_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.user_name_textbox.SelectedText = "";
            this.user_name_textbox.SelectionLength = 0;
            this.user_name_textbox.SelectionStart = 0;
            this.user_name_textbox.Size = new System.Drawing.Size(176, 29);
            this.user_name_textbox.TabIndex = 11;
            this.user_name_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.user_name_textbox.UseSelectable = true;
            this.user_name_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.user_name_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // full_name_textbox
            // 
            // 
            // 
            // 
            this.full_name_textbox.CustomButton.Image = null;
            this.full_name_textbox.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.full_name_textbox.CustomButton.Name = "";
            this.full_name_textbox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.full_name_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.full_name_textbox.CustomButton.TabIndex = 1;
            this.full_name_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.full_name_textbox.CustomButton.UseSelectable = true;
            this.full_name_textbox.CustomButton.Visible = false;
            this.full_name_textbox.Enabled = false;
            this.full_name_textbox.Lines = new string[0];
            this.full_name_textbox.Location = new System.Drawing.Point(143, 38);
            this.full_name_textbox.MaxLength = 32767;
            this.full_name_textbox.Name = "full_name_textbox";
            this.full_name_textbox.PasswordChar = '\0';
            this.full_name_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.full_name_textbox.SelectedText = "";
            this.full_name_textbox.SelectionLength = 0;
            this.full_name_textbox.SelectionStart = 0;
            this.full_name_textbox.Size = new System.Drawing.Size(176, 29);
            this.full_name_textbox.TabIndex = 10;
            this.full_name_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.full_name_textbox.UseSelectable = true;
            this.full_name_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.full_name_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(5, 308);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(46, 25);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Type";
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(5, 362);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(68, 25);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Gender";
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(5, 254);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(72, 25);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel8.TabIndex = 9;
            this.metroLabel8.Text = "Address";
            this.metroLabel8.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(5, 200);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(58, 25);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Email ";
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(8, 146);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(98, 25);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Contact No";
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(5, 92);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(97, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "User Name";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.Location = new System.Drawing.Point(5, 38);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(89, 25);
            this.metroLabel12.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel12.TabIndex = 2;
            this.metroLabel12.Text = "Full Name";
            this.metroLabel12.UseStyleColors = true;
            // 
            // all_member_button
            // 
            this.all_member_button.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.all_member_button.Location = new System.Drawing.Point(585, 470);
            this.all_member_button.Name = "all_member_button";
            this.all_member_button.Size = new System.Drawing.Size(223, 56);
            this.all_member_button.TabIndex = 11;
            this.all_member_button.Text = "All Member";
            this.all_member_button.UseSelectable = true;
            this.all_member_button.Click += new System.EventHandler(this.all_member_button_Click);
            // 
            // g_id
            // 
            this.g_id.HeaderText = "ID";
            this.g_id.Name = "g_id";
            // 
            // g_username
            // 
            this.g_username.HeaderText = "User Name";
            this.g_username.Name = "g_username";
            // 
            // g_fullname
            // 
            this.g_fullname.HeaderText = "Full Name";
            this.g_fullname.Name = "g_fullname";
            // 
            // g_contactno
            // 
            this.g_contactno.HeaderText = "Contact No";
            this.g_contactno.Name = "g_contactno";
            // 
            // g_type
            // 
            this.g_type.HeaderText = "Type";
            this.g_type.Name = "g_type";
            // 
            // g_gender
            // 
            this.g_gender.HeaderText = "Gender";
            this.g_gender.Name = "g_gender";
            // 
            // g_email
            // 
            this.g_email.HeaderText = "Email";
            this.g_email.Name = "g_email";
            // 
            // g_address
            // 
            this.g_address.HeaderText = "Address";
            this.g_address.Name = "g_address";
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 607);
            this.ControlBox = false;
            this.Controls.Add(this.all_member_button);
            this.Controls.Add(this.new_member_panel);
            this.Controls.Add(this.grid_member);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.home_button);
            this.Movable = false;
            this.Name = "Member";
            this.Resizable = false;
            this.Text = "Member";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_member)).EndInit();
            this.new_member_panel.ResumeLayout(false);
            this.new_member_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton home_button;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid grid_member;
        private MetroFramework.Controls.MetroPanel new_member_panel;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroComboBox gender_combobox;
        private MetroFramework.Controls.MetroTextBox address_textbox;
        private MetroFramework.Controls.MetroComboBox type_combobox;
        private MetroFramework.Controls.MetroTextBox email_textbox;
        private MetroFramework.Controls.MetroTextBox contact_no_textbox;
        private MetroFramework.Controls.MetroTextBox user_name_textbox;
        private MetroFramework.Controls.MetroTextBox full_name_textbox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroButton delete_button;
        private MetroFramework.Controls.MetroButton update_button;
        private MetroFramework.Controls.MetroButton edit_button;
        private MetroFramework.Controls.MetroButton all_member_button;
        private MetroFramework.Controls.MetroButton cancel_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_contactno;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_address;
    }
}