namespace Appsdevproject
{
    partial class Loginpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginpage));
            this.signinBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signinBTN
            // 
            this.signinBTN.BackColor = System.Drawing.Color.Transparent;
            this.signinBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signinBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinBTN.Location = new System.Drawing.Point(142, 271);
            this.signinBTN.Name = "signinBTN";
            this.signinBTN.Size = new System.Drawing.Size(46, 25);
            this.signinBTN.TabIndex = 2;
            this.signinBTN.Text = "Sign in";
            this.signinBTN.UseVisualStyleBackColor = false;
            this.signinBTN.Click += new System.EventHandler(this.signinBTN_Click);
            // 
            // Loginpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(557, 422);
            this.Controls.Add(this.signinBTN);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Loginpage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Loginpage";
            this.Load += new System.EventHandler(this.Loginpage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button signinBTN;
    }
}