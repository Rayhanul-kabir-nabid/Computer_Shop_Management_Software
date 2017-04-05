namespace Computer_Management_Software
{
    partial class Profile
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
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 607);
            this.ControlBox = false;
            this.Controls.Add(this.home_button);
            this.Movable = false;
            this.Name = "Profile";
            this.Resizable = false;
            this.Text = "Profile";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton home_button;
    }
}