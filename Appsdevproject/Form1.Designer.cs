namespace Appsdevproject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tryBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tryBTN
            // 
            this.tryBTN.BackColor = System.Drawing.Color.Transparent;
            this.tryBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tryBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tryBTN.ForeColor = System.Drawing.Color.DarkOrange;
            this.tryBTN.Location = new System.Drawing.Point(236, 360);
            this.tryBTN.Name = "tryBTN";
            this.tryBTN.Size = new System.Drawing.Size(98, 40);
            this.tryBTN.TabIndex = 0;
            this.tryBTN.Text = "TRY GEN-Z BUBBLE TEA";
            this.tryBTN.UseVisualStyleBackColor = false;
            this.tryBTN.Click += new System.EventHandler(this.tryBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(568, 433);
            this.Controls.Add(this.tryBTN);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Gen-Z Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tryBTN;

    }
}

