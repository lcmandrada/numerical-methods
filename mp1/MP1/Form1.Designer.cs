namespace MP1
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
            this.btnRegula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegula
            // 
            this.btnRegula.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegula.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRegula.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRegula.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegula.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegula.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRegula.Location = new System.Drawing.Point(175, 215);
            this.btnRegula.Name = "btnRegula";
            this.btnRegula.Size = new System.Drawing.Size(130, 30);
            this.btnRegula.TabIndex = 0;
            this.btnRegula.Text = "REGULA-FALSI";
            this.btnRegula.UseVisualStyleBackColor = false;
            this.btnRegula.Click += new System.EventHandler(this.btnRegula_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::MP1.Properties.Resources.MP_1;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnRegula);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MP 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegula;
    }
}

