namespace MP4
{
    partial class frmTrapezoidal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrapezoidal));
            this.txtBoxTrapezoidal_eq = new System.Windows.Forms.TextBox();
            this.txtBoxTrapezoidal_n = new System.Windows.Forms.TextBox();
            this.txtBoxTrapezoidal_a = new System.Windows.Forms.TextBox();
            this.txtBoxTrapezoidal_b = new System.Windows.Forms.TextBox();
            this.btnTrapezoidal_solve = new System.Windows.Forms.Button();
            this.btnTrapezoidal_clear = new System.Windows.Forms.Button();
            this.txtBoxTrapezoidal_i = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxTrapezoidal_eq
            // 
            this.txtBoxTrapezoidal_eq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxTrapezoidal_eq.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTrapezoidal_eq.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxTrapezoidal_eq.Location = new System.Drawing.Point(43, 208);
            this.txtBoxTrapezoidal_eq.Name = "txtBoxTrapezoidal_eq";
            this.txtBoxTrapezoidal_eq.Size = new System.Drawing.Size(394, 18);
            this.txtBoxTrapezoidal_eq.TabIndex = 13;
            this.txtBoxTrapezoidal_eq.Text = "EQUATION";
            this.txtBoxTrapezoidal_eq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxTrapezoidal_n
            // 
            this.txtBoxTrapezoidal_n.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxTrapezoidal_n.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTrapezoidal_n.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxTrapezoidal_n.Location = new System.Drawing.Point(83, 278);
            this.txtBoxTrapezoidal_n.Name = "txtBoxTrapezoidal_n";
            this.txtBoxTrapezoidal_n.Size = new System.Drawing.Size(68, 18);
            this.txtBoxTrapezoidal_n.TabIndex = 14;
            this.txtBoxTrapezoidal_n.Text = "n";
            this.txtBoxTrapezoidal_n.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxTrapezoidal_a
            // 
            this.txtBoxTrapezoidal_a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxTrapezoidal_a.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTrapezoidal_a.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxTrapezoidal_a.Location = new System.Drawing.Point(205, 278);
            this.txtBoxTrapezoidal_a.Name = "txtBoxTrapezoidal_a";
            this.txtBoxTrapezoidal_a.Size = new System.Drawing.Size(68, 18);
            this.txtBoxTrapezoidal_a.TabIndex = 15;
            this.txtBoxTrapezoidal_a.Text = "a";
            this.txtBoxTrapezoidal_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxTrapezoidal_b
            // 
            this.txtBoxTrapezoidal_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxTrapezoidal_b.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTrapezoidal_b.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxTrapezoidal_b.Location = new System.Drawing.Point(327, 278);
            this.txtBoxTrapezoidal_b.Name = "txtBoxTrapezoidal_b";
            this.txtBoxTrapezoidal_b.Size = new System.Drawing.Size(68, 18);
            this.txtBoxTrapezoidal_b.TabIndex = 16;
            this.txtBoxTrapezoidal_b.Text = "b";
            this.txtBoxTrapezoidal_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTrapezoidal_solve
            // 
            this.btnTrapezoidal_solve.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTrapezoidal_solve.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnTrapezoidal_solve.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTrapezoidal_solve.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTrapezoidal_solve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrapezoidal_solve.Location = new System.Drawing.Point(140, 309);
            this.btnTrapezoidal_solve.Name = "btnTrapezoidal_solve";
            this.btnTrapezoidal_solve.Size = new System.Drawing.Size(75, 25);
            this.btnTrapezoidal_solve.TabIndex = 17;
            this.btnTrapezoidal_solve.Text = "SOLVE";
            this.btnTrapezoidal_solve.UseVisualStyleBackColor = false;
            this.btnTrapezoidal_solve.Click += new System.EventHandler(this.btnTrapezoidal_solve_Click);
            // 
            // btnTrapezoidal_clear
            // 
            this.btnTrapezoidal_clear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTrapezoidal_clear.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnTrapezoidal_clear.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTrapezoidal_clear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTrapezoidal_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrapezoidal_clear.Location = new System.Drawing.Point(265, 309);
            this.btnTrapezoidal_clear.Name = "btnTrapezoidal_clear";
            this.btnTrapezoidal_clear.Size = new System.Drawing.Size(75, 25);
            this.btnTrapezoidal_clear.TabIndex = 18;
            this.btnTrapezoidal_clear.Text = "CLEAR";
            this.btnTrapezoidal_clear.UseVisualStyleBackColor = false;
            this.btnTrapezoidal_clear.Click += new System.EventHandler(this.btnTrapezoidal_clear_Click);
            // 
            // txtBoxTrapezoidal_i
            // 
            this.txtBoxTrapezoidal_i.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxTrapezoidal_i.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTrapezoidal_i.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxTrapezoidal_i.Location = new System.Drawing.Point(43, 348);
            this.txtBoxTrapezoidal_i.Name = "txtBoxTrapezoidal_i";
            this.txtBoxTrapezoidal_i.ReadOnly = true;
            this.txtBoxTrapezoidal_i.Size = new System.Drawing.Size(394, 18);
            this.txtBoxTrapezoidal_i.TabIndex = 19;
            this.txtBoxTrapezoidal_i.Text = "I";
            this.txtBoxTrapezoidal_i.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmTrapezoidal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::MP4.Properties.Resources.Trapezoidal;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.txtBoxTrapezoidal_i);
            this.Controls.Add(this.btnTrapezoidal_clear);
            this.Controls.Add(this.btnTrapezoidal_solve);
            this.Controls.Add(this.txtBoxTrapezoidal_b);
            this.Controls.Add(this.txtBoxTrapezoidal_a);
            this.Controls.Add(this.txtBoxTrapezoidal_n);
            this.Controls.Add(this.txtBoxTrapezoidal_eq);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTrapezoidal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "TRAPEZOIDAL RULE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxTrapezoidal_eq;
        private System.Windows.Forms.TextBox txtBoxTrapezoidal_n;
        private System.Windows.Forms.TextBox txtBoxTrapezoidal_a;
        private System.Windows.Forms.TextBox txtBoxTrapezoidal_b;
        private System.Windows.Forms.Button btnTrapezoidal_solve;
        private System.Windows.Forms.Button btnTrapezoidal_clear;
        private System.Windows.Forms.TextBox txtBoxTrapezoidal_i;
    }
}