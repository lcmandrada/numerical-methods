namespace MP2
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
            this.btnSecant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSecant
            // 
            this.btnSecant.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSecant.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSecant.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSecant.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSecant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecant.Location = new System.Drawing.Point(203, 215);
            this.btnSecant.Name = "btnSecant";
            this.btnSecant.Size = new System.Drawing.Size(75, 30);
            this.btnSecant.TabIndex = 0;
            this.btnSecant.Text = "SECANT";
            this.btnSecant.UseVisualStyleBackColor = false;
            this.btnSecant.Click += new System.EventHandler(this.btnSecant_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::MP2.Properties.Resources.MP_2;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnSecant);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MP2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSecant;
    }
}

