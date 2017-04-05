namespace Computer_Management_Software
{
    partial class Income
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
            this.all_income_button = new MetroFramework.Controls.MetroButton();
            this.grid_income = new MetroFramework.Controls.MetroGrid();
            this.g_invoice_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_date_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_income_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_product_sell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_extra_sell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.last_7_days_button = new MetroFramework.Controls.MetroButton();
            this.this_month_button = new MetroFramework.Controls.MetroButton();
            this.service_textbox = new MetroFramework.Controls.MetroTextBox();
            this.product_sell_textbox = new MetroFramework.Controls.MetroTextBox();
            this.extra_textbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_income)).BeginInit();
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
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.extra_textbox);
            this.metroPanel1.Controls.Add(this.product_sell_textbox);
            this.metroPanel1.Controls.Add(this.service_textbox);
            this.metroPanel1.Controls.Add(this.this_month_button);
            this.metroPanel1.Controls.Add(this.last_7_days_button);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.all_income_button);
            this.metroPanel1.Controls.Add(this.grid_income);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(14, 77);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(977, 489);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // all_income_button
            // 
            this.all_income_button.Location = new System.Drawing.Point(746, 24);
            this.all_income_button.Name = "all_income_button";
            this.all_income_button.Size = new System.Drawing.Size(123, 40);
            this.all_income_button.TabIndex = 26;
            this.all_income_button.Text = "All Income";
            this.all_income_button.UseSelectable = true;
            this.all_income_button.Click += new System.EventHandler(this.all_income_button_Click);
            // 
            // grid_income
            // 
            this.grid_income.AllowUserToDeleteRows = false;
            this.grid_income.AllowUserToOrderColumns = true;
            this.grid_income.AllowUserToResizeRows = false;
            this.grid_income.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_income.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid_income.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_income.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_income.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grid_income.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_income.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.g_invoice_no,
            this.g_date_time,
            this.g_income_id,
            this.g_service,
            this.g_product_sell,
            this.g_extra_sell});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_income.DefaultCellStyle = dataGridViewCellStyle8;
            this.grid_income.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_income.EnableHeadersVisualStyles = false;
            this.grid_income.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_income.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_income.Location = new System.Drawing.Point(120, 110);
            this.grid_income.Name = "grid_income";
            this.grid_income.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_income.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grid_income.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_income.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_income.Size = new System.Drawing.Size(645, 366);
            this.grid_income.TabIndex = 25;
            // 
            // g_invoice_no
            // 
            this.g_invoice_no.HeaderText = "Invoice NO";
            this.g_invoice_no.Name = "g_invoice_no";
            // 
            // g_date_time
            // 
            this.g_date_time.HeaderText = "Date and Time";
            this.g_date_time.Name = "g_date_time";
            // 
            // g_income_id
            // 
            this.g_income_id.HeaderText = "Income ID";
            this.g_income_id.Name = "g_income_id";
            // 
            // g_service
            // 
            this.g_service.HeaderText = "Service";
            this.g_service.Name = "g_service";
            // 
            // g_product_sell
            // 
            this.g_product_sell.HeaderText = "Product Sell";
            this.g_product_sell.Name = "g_product_sell";
            // 
            // g_extra_sell
            // 
            this.g_extra_sell.HeaderText = "Extra Sell";
            this.g_extra_sell.Name = "g_extra_sell";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(237, 24);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(123, 40);
            this.metroButton1.TabIndex = 28;
            this.metroButton1.Text = "Today\'s Income list";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // last_7_days_button
            // 
            this.last_7_days_button.Location = new System.Drawing.Point(400, 24);
            this.last_7_days_button.Name = "last_7_days_button";
            this.last_7_days_button.Size = new System.Drawing.Size(127, 40);
            this.last_7_days_button.TabIndex = 29;
            this.last_7_days_button.Text = "Last 7 Days Income list";
            this.last_7_days_button.UseSelectable = true;
            this.last_7_days_button.Click += new System.EventHandler(this.last_7_days_button_Click);
            // 
            // this_month_button
            // 
            this.this_month_button.Location = new System.Drawing.Point(571, 24);
            this.this_month_button.Name = "this_month_button";
            this.this_month_button.Size = new System.Drawing.Size(130, 40);
            this.this_month_button.TabIndex = 30;
            this.this_month_button.Text = "This month Income list";
            this.this_month_button.UseSelectable = true;
            this.this_month_button.Click += new System.EventHandler(this.this_month_button_Click);
            // 
            // service_textbox
            // 
            // 
            // 
            // 
            this.service_textbox.CustomButton.Image = null;
            this.service_textbox.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.service_textbox.CustomButton.Name = "";
            this.service_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.service_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.service_textbox.CustomButton.TabIndex = 1;
            this.service_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.service_textbox.CustomButton.UseSelectable = true;
            this.service_textbox.CustomButton.Visible = false;
            this.service_textbox.Enabled = false;
            this.service_textbox.Lines = new string[0];
            this.service_textbox.Location = new System.Drawing.Point(790, 135);
            this.service_textbox.MaxLength = 32767;
            this.service_textbox.Name = "service_textbox";
            this.service_textbox.PasswordChar = '\0';
            this.service_textbox.PromptText = "Service";
            this.service_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.service_textbox.SelectedText = "";
            this.service_textbox.SelectionLength = 0;
            this.service_textbox.SelectionStart = 0;
            this.service_textbox.Size = new System.Drawing.Size(111, 23);
            this.service_textbox.TabIndex = 31;
            this.service_textbox.UseSelectable = true;
            this.service_textbox.WaterMark = "Service";
            this.service_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.service_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // product_sell_textbox
            // 
            // 
            // 
            // 
            this.product_sell_textbox.CustomButton.Image = null;
            this.product_sell_textbox.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.product_sell_textbox.CustomButton.Name = "";
            this.product_sell_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.product_sell_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.product_sell_textbox.CustomButton.TabIndex = 1;
            this.product_sell_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.product_sell_textbox.CustomButton.UseSelectable = true;
            this.product_sell_textbox.CustomButton.Visible = false;
            this.product_sell_textbox.Enabled = false;
            this.product_sell_textbox.Lines = new string[0];
            this.product_sell_textbox.Location = new System.Drawing.Point(789, 207);
            this.product_sell_textbox.MaxLength = 32767;
            this.product_sell_textbox.Name = "product_sell_textbox";
            this.product_sell_textbox.PasswordChar = '\0';
            this.product_sell_textbox.PromptText = "Product sell";
            this.product_sell_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.product_sell_textbox.SelectedText = "";
            this.product_sell_textbox.SelectionLength = 0;
            this.product_sell_textbox.SelectionStart = 0;
            this.product_sell_textbox.Size = new System.Drawing.Size(111, 23);
            this.product_sell_textbox.TabIndex = 32;
            this.product_sell_textbox.UseSelectable = true;
            this.product_sell_textbox.WaterMark = "Product sell";
            this.product_sell_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.product_sell_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // extra_textbox
            // 
            // 
            // 
            // 
            this.extra_textbox.CustomButton.Image = null;
            this.extra_textbox.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.extra_textbox.CustomButton.Name = "";
            this.extra_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.extra_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.extra_textbox.CustomButton.TabIndex = 1;
            this.extra_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.extra_textbox.CustomButton.UseSelectable = true;
            this.extra_textbox.CustomButton.Visible = false;
            this.extra_textbox.Enabled = false;
            this.extra_textbox.Lines = new string[0];
            this.extra_textbox.Location = new System.Drawing.Point(790, 275);
            this.extra_textbox.MaxLength = 32767;
            this.extra_textbox.Name = "extra_textbox";
            this.extra_textbox.PasswordChar = '\0';
            this.extra_textbox.PromptText = "Extra sell";
            this.extra_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.extra_textbox.SelectedText = "";
            this.extra_textbox.SelectionLength = 0;
            this.extra_textbox.SelectionStart = 0;
            this.extra_textbox.Size = new System.Drawing.Size(111, 23);
            this.extra_textbox.TabIndex = 33;
            this.extra_textbox.UseSelectable = true;
            this.extra_textbox.WaterMark = "Extra sell";
            this.extra_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.extra_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(790, 110);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 34;
            this.metroLabel2.Text = "Service";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(789, 185);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.TabIndex = 35;
            this.metroLabel3.Text = "Product sell";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(790, 253);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(60, 19);
            this.metroLabel4.TabIndex = 36;
            this.metroLabel4.Text = "Extra sell";
            // 
            // Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 607);
            this.ControlBox = false;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.home_button);
            this.Movable = false;
            this.Name = "Income";
            this.Resizable = false;
            this.Text = "Income";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Income_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_income)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton home_button;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton all_income_button;
        private MetroFramework.Controls.MetroGrid grid_income;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_invoice_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_date_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_income_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_product_sell;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_extra_sell;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton last_7_days_button;
        private MetroFramework.Controls.MetroButton this_month_button;
        private MetroFramework.Controls.MetroTextBox extra_textbox;
        private MetroFramework.Controls.MetroTextBox product_sell_textbox;
        private MetroFramework.Controls.MetroTextBox service_textbox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}