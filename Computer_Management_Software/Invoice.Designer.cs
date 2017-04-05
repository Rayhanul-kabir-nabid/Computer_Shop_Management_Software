namespace Computer_Management_Software
{
    partial class Invoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.home_button = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.all_invoice_button = new MetroFramework.Controls.MetroButton();
            this.grid_invoice = new MetroFramework.Controls.MetroGrid();
            this.g_invoice_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_date_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_ammount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_sub_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_grand_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_employee_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_invoice_button = new MetroFramework.Controls.MetroTextBox();
            this.search_customer_name_button = new MetroFramework.Controls.MetroTextBox();
            this.search_customer_id_button = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_invoice)).BeginInit();
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
            this.metroPanel1.Controls.Add(this.search_customer_id_button);
            this.metroPanel1.Controls.Add(this.search_customer_name_button);
            this.metroPanel1.Controls.Add(this.search_invoice_button);
            this.metroPanel1.Controls.Add(this.all_invoice_button);
            this.metroPanel1.Controls.Add(this.grid_invoice);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 77);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(977, 489);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // all_invoice_button
            // 
            this.all_invoice_button.Location = new System.Drawing.Point(746, 24);
            this.all_invoice_button.Name = "all_invoice_button";
            this.all_invoice_button.Size = new System.Drawing.Size(123, 40);
            this.all_invoice_button.TabIndex = 26;
            this.all_invoice_button.Text = "All Invoice";
            this.all_invoice_button.UseSelectable = true;
            this.all_invoice_button.Click += new System.EventHandler(this.all_invoice_button_Click);
            // 
            // grid_invoice
            // 
            this.grid_invoice.AllowUserToDeleteRows = false;
            this.grid_invoice.AllowUserToOrderColumns = true;
            this.grid_invoice.AllowUserToResizeRows = false;
            this.grid_invoice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_invoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid_invoice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_invoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_invoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grid_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_invoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.g_invoice_no,
            this.g_customer_name,
            this.g_customer_id,
            this.g_date_time,
            this.g_ammount,
            this.g_sub_total,
            this.g_discount,
            this.g_grand_total,
            this.g_employee_id});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_invoice.DefaultCellStyle = dataGridViewCellStyle8;
            this.grid_invoice.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_invoice.EnableHeadersVisualStyles = false;
            this.grid_invoice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_invoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_invoice.Location = new System.Drawing.Point(17, 82);
            this.grid_invoice.Name = "grid_invoice";
            this.grid_invoice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_invoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grid_invoice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_invoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_invoice.Size = new System.Drawing.Size(939, 366);
            this.grid_invoice.TabIndex = 25;
            this.grid_invoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_invoice_CellContentClick);
            // 
            // g_invoice_no
            // 
            this.g_invoice_no.HeaderText = "Invoice NO";
            this.g_invoice_no.Name = "g_invoice_no";
            // 
            // g_customer_name
            // 
            this.g_customer_name.HeaderText = "Customer Name";
            this.g_customer_name.Name = "g_customer_name";
            // 
            // g_customer_id
            // 
            this.g_customer_id.HeaderText = "Customer ID";
            this.g_customer_id.Name = "g_customer_id";
            // 
            // g_date_time
            // 
            this.g_date_time.HeaderText = "Date and Time";
            this.g_date_time.Name = "g_date_time";
            // 
            // g_ammount
            // 
            this.g_ammount.HeaderText = "Ammount";
            this.g_ammount.Name = "g_ammount";
            // 
            // g_sub_total
            // 
            this.g_sub_total.HeaderText = "Sub Total";
            this.g_sub_total.Name = "g_sub_total";
            // 
            // g_discount
            // 
            this.g_discount.HeaderText = "Discount";
            this.g_discount.Name = "g_discount";
            // 
            // g_grand_total
            // 
            this.g_grand_total.HeaderText = "Grand Total";
            this.g_grand_total.Name = "g_grand_total";
            // 
            // g_employee_id
            // 
            this.g_employee_id.HeaderText = "Entry Member ID";
            this.g_employee_id.Name = "g_employee_id";
            // 
            // search_invoice_button
            // 
            // 
            // 
            // 
            this.search_invoice_button.CustomButton.Image = null;
            this.search_invoice_button.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.search_invoice_button.CustomButton.Name = "";
            this.search_invoice_button.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.search_invoice_button.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.search_invoice_button.CustomButton.TabIndex = 1;
            this.search_invoice_button.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.search_invoice_button.CustomButton.UseSelectable = true;
            this.search_invoice_button.CustomButton.Visible = false;
            this.search_invoice_button.Lines = new string[0];
            this.search_invoice_button.Location = new System.Drawing.Point(59, 36);
            this.search_invoice_button.MaxLength = 32767;
            this.search_invoice_button.Name = "search_invoice_button";
            this.search_invoice_button.PasswordChar = '\0';
            this.search_invoice_button.PromptText = "Invoice no";
            this.search_invoice_button.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.search_invoice_button.SelectedText = "";
            this.search_invoice_button.SelectionLength = 0;
            this.search_invoice_button.SelectionStart = 0;
            this.search_invoice_button.Size = new System.Drawing.Size(174, 23);
            this.search_invoice_button.TabIndex = 27;
            this.search_invoice_button.UseSelectable = true;
            this.search_invoice_button.WaterMark = "Invoice no";
            this.search_invoice_button.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.search_invoice_button.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.search_invoice_button.TextChanged += new System.EventHandler(this.search_invoice_button_TextChanged);
            // 
            // search_customer_name_button
            // 
            // 
            // 
            // 
            this.search_customer_name_button.CustomButton.Image = null;
            this.search_customer_name_button.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.search_customer_name_button.CustomButton.Name = "";
            this.search_customer_name_button.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.search_customer_name_button.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.search_customer_name_button.CustomButton.TabIndex = 1;
            this.search_customer_name_button.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.search_customer_name_button.CustomButton.UseSelectable = true;
            this.search_customer_name_button.CustomButton.Visible = false;
            this.search_customer_name_button.Lines = new string[0];
            this.search_customer_name_button.Location = new System.Drawing.Point(251, 36);
            this.search_customer_name_button.MaxLength = 32767;
            this.search_customer_name_button.Name = "search_customer_name_button";
            this.search_customer_name_button.PasswordChar = '\0';
            this.search_customer_name_button.PromptText = "Customer name";
            this.search_customer_name_button.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.search_customer_name_button.SelectedText = "";
            this.search_customer_name_button.SelectionLength = 0;
            this.search_customer_name_button.SelectionStart = 0;
            this.search_customer_name_button.Size = new System.Drawing.Size(174, 23);
            this.search_customer_name_button.TabIndex = 28;
            this.search_customer_name_button.UseSelectable = true;
            this.search_customer_name_button.WaterMark = "Customer name";
            this.search_customer_name_button.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.search_customer_name_button.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.search_customer_name_button.TextChanged += new System.EventHandler(this.search_customer_name_button_TextChanged);
            // 
            // search_customer_id_button
            // 
            // 
            // 
            // 
            this.search_customer_id_button.CustomButton.Image = null;
            this.search_customer_id_button.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.search_customer_id_button.CustomButton.Name = "";
            this.search_customer_id_button.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.search_customer_id_button.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.search_customer_id_button.CustomButton.TabIndex = 1;
            this.search_customer_id_button.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.search_customer_id_button.CustomButton.UseSelectable = true;
            this.search_customer_id_button.CustomButton.Visible = false;
            this.search_customer_id_button.Lines = new string[0];
            this.search_customer_id_button.Location = new System.Drawing.Point(443, 36);
            this.search_customer_id_button.MaxLength = 32767;
            this.search_customer_id_button.Name = "search_customer_id_button";
            this.search_customer_id_button.PasswordChar = '\0';
            this.search_customer_id_button.PromptText = "Customer id";
            this.search_customer_id_button.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.search_customer_id_button.SelectedText = "";
            this.search_customer_id_button.SelectionLength = 0;
            this.search_customer_id_button.SelectionStart = 0;
            this.search_customer_id_button.Size = new System.Drawing.Size(174, 23);
            this.search_customer_id_button.TabIndex = 29;
            this.search_customer_id_button.UseSelectable = true;
            this.search_customer_id_button.WaterMark = "Customer id";
            this.search_customer_id_button.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.search_customer_id_button.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.search_customer_id_button.TextChanged += new System.EventHandler(this.search_customer_id_button_TextChanged);
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 607);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.home_button);
            this.Movable = false;
            this.Name = "Invoice";
            this.Resizable = false;
            this.Text = "Invoice";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_invoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton home_button;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton all_invoice_button;
        private MetroFramework.Controls.MetroGrid grid_invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_invoice_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_date_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_ammount;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_sub_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_grand_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_employee_id;
        private MetroFramework.Controls.MetroTextBox search_customer_id_button;
        private MetroFramework.Controls.MetroTextBox search_customer_name_button;
        private MetroFramework.Controls.MetroTextBox search_invoice_button;
    }
}