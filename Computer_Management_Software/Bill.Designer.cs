namespace Computer_Management_Software
{
    partial class Bill
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
            this.home_button = new MetroFramework.Controls.MetroButton();
            this.save_as_pdf_button = new MetroFramework.Controls.MetroButton();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport12 = new Computer_Management_Software.CrystalReport1();
            this.CrystalReport11 = new Computer_Management_Software.CrystalReport1();
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
            this.home_button.TabIndex = 1;
            this.home_button.Text = "HOME";
            this.home_button.UseCustomBackColor = true;
            this.home_button.UseSelectable = true;
            this.home_button.UseStyleColors = true;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // save_as_pdf_button
            // 
            this.save_as_pdf_button.Location = new System.Drawing.Point(997, 339);
            this.save_as_pdf_button.Name = "save_as_pdf_button";
            this.save_as_pdf_button.Size = new System.Drawing.Size(180, 69);
            this.save_as_pdf_button.TabIndex = 3;
            this.save_as_pdf_button.Text = "Save as PDF";
            this.save_as_pdf_button.UseSelectable = true;
            this.save_as_pdf_button.Click += new System.EventHandler(this.save_as_pdf_button_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(22, 56);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReport12;
            this.crystalReportViewer1.Size = new System.Drawing.Size(969, 545);
            this.crystalReportViewer1.TabIndex = 2;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 607);
            this.ControlBox = false;
            this.Controls.Add(this.save_as_pdf_button);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.home_button);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MinimizeBox = false;
            this.Name = "Bill";
            this.Padding = new System.Windows.Forms.Padding(43, 148, 43, 49);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Bill";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Bill_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton home_button;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalReport1 CrystalReport12;
        private CrystalReport1 CrystalReport11;
        private MetroFramework.Controls.MetroButton save_as_pdf_button;
    }
}