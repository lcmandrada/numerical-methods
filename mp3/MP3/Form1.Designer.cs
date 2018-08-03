namespace MP3
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnMuller = new System.Windows.Forms.Button();
            this.btnCholesky = new System.Windows.Forms.Button();
            this.btnGaussJacobi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMuller
            // 
            this.btnMuller.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMuller.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnMuller.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnMuller.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMuller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuller.Location = new System.Drawing.Point(177, 229);
            this.btnMuller.Name = "btnMuller";
            this.btnMuller.Size = new System.Drawing.Size(130, 25);
            this.btnMuller.TabIndex = 0;
            this.btnMuller.Text = "MULLER";
            this.btnMuller.UseVisualStyleBackColor = false;
            this.btnMuller.Click += new System.EventHandler(this.btnMuller_Click);
            // 
            // btnCholesky
            // 
            this.btnCholesky.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCholesky.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCholesky.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCholesky.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCholesky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCholesky.Location = new System.Drawing.Point(177, 263);
            this.btnCholesky.Name = "btnCholesky";
            this.btnCholesky.Size = new System.Drawing.Size(130, 25);
            this.btnCholesky.TabIndex = 1;
            this.btnCholesky.Text = "CHOLESKY";
            this.btnCholesky.UseVisualStyleBackColor = false;
            this.btnCholesky.Click += new System.EventHandler(this.btnCholesky_Click);
            // 
            // btnGaussJacobi
            // 
            this.btnGaussJacobi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGaussJacobi.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnGaussJacobi.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnGaussJacobi.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGaussJacobi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGaussJacobi.Location = new System.Drawing.Point(177, 297);
            this.btnGaussJacobi.Name = "btnGaussJacobi";
            this.btnGaussJacobi.Size = new System.Drawing.Size(130, 25);
            this.btnGaussJacobi.TabIndex = 2;
            this.btnGaussJacobi.Text = "GAUSS-JACOBI";
            this.btnGaussJacobi.UseVisualStyleBackColor = false;
            this.btnGaussJacobi.Click += new System.EventHandler(this.btnGaussJacobi_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::MP3.Properties.Resources.MP_3;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnGaussJacobi);
            this.Controls.Add(this.btnCholesky);
            this.Controls.Add(this.btnMuller);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MP3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMuller;
        private System.Windows.Forms.Button btnCholesky;
        private System.Windows.Forms.Button btnGaussJacobi;
    }
}

