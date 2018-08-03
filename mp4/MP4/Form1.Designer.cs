namespace MP4
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
            this.btnLinear = new System.Windows.Forms.Button();
            this.btnNewton = new System.Windows.Forms.Button();
            this.btnCentered = new System.Windows.Forms.Button();
            this.btnTrapezoidal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLinear
            // 
            this.btnLinear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLinear.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLinear.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLinear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLinear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinear.Location = new System.Drawing.Point(129, 279);
            this.btnLinear.Name = "btnLinear";
            this.btnLinear.Size = new System.Drawing.Size(110, 25);
            this.btnLinear.TabIndex = 0;
            this.btnLinear.Text = "LINEAR";
            this.btnLinear.UseVisualStyleBackColor = false;
            this.btnLinear.Click += new System.EventHandler(this.btnLinear_Click);
            // 
            // btnNewton
            // 
            this.btnNewton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnNewton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnNewton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewton.Location = new System.Drawing.Point(129, 310);
            this.btnNewton.Name = "btnNewton";
            this.btnNewton.Size = new System.Drawing.Size(110, 25);
            this.btnNewton.TabIndex = 1;
            this.btnNewton.Text = "NEWTON";
            this.btnNewton.UseVisualStyleBackColor = false;
            this.btnNewton.Click += new System.EventHandler(this.btnNewton_Click);
            // 
            // btnCentered
            // 
            this.btnCentered.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCentered.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCentered.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCentered.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCentered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCentered.Location = new System.Drawing.Point(245, 310);
            this.btnCentered.Name = "btnCentered";
            this.btnCentered.Size = new System.Drawing.Size(110, 25);
            this.btnCentered.TabIndex = 3;
            this.btnCentered.Text = "CENTER";
            this.btnCentered.UseVisualStyleBackColor = false;
            this.btnCentered.Click += new System.EventHandler(this.btnCentered_Click);
            // 
            // btnTrapezoidal
            // 
            this.btnTrapezoidal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTrapezoidal.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnTrapezoidal.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTrapezoidal.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTrapezoidal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrapezoidal.Location = new System.Drawing.Point(245, 279);
            this.btnTrapezoidal.Name = "btnTrapezoidal";
            this.btnTrapezoidal.Size = new System.Drawing.Size(110, 25);
            this.btnTrapezoidal.TabIndex = 2;
            this.btnTrapezoidal.Text = "TRAPEZOIDAL";
            this.btnTrapezoidal.UseVisualStyleBackColor = false;
            this.btnTrapezoidal.Click += new System.EventHandler(this.btnTrapezoidal_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::MP4.Properties.Resources.MP_4;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnCentered);
            this.Controls.Add(this.btnTrapezoidal);
            this.Controls.Add(this.btnNewton);
            this.Controls.Add(this.btnLinear);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MP4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLinear;
        private System.Windows.Forms.Button btnNewton;
        private System.Windows.Forms.Button btnCentered;
        private System.Windows.Forms.Button btnTrapezoidal;
    }
}

