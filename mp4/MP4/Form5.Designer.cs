namespace MP4
{
    partial class frmCenter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCenter));
            this.txtBoxCenter_eq = new System.Windows.Forms.TextBox();
            this.txtBoxCenter_xi = new System.Windows.Forms.TextBox();
            this.txtBoxCenter_h = new System.Windows.Forms.TextBox();
            this.btnCenter_solve = new System.Windows.Forms.Button();
            this.btnCenter_clear = new System.Windows.Forms.Button();
            this.txtBoxCenter_d = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxCenter_eq
            // 
            this.txtBoxCenter_eq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxCenter_eq.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCenter_eq.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxCenter_eq.Location = new System.Drawing.Point(43, 206);
            this.txtBoxCenter_eq.Name = "txtBoxCenter_eq";
            this.txtBoxCenter_eq.Size = new System.Drawing.Size(394, 18);
            this.txtBoxCenter_eq.TabIndex = 14;
            this.txtBoxCenter_eq.Text = "EQUATION";
            this.txtBoxCenter_eq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxCenter_xi
            // 
            this.txtBoxCenter_xi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxCenter_xi.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCenter_xi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxCenter_xi.Location = new System.Drawing.Point(144, 276);
            this.txtBoxCenter_xi.Name = "txtBoxCenter_xi";
            this.txtBoxCenter_xi.Size = new System.Drawing.Size(68, 18);
            this.txtBoxCenter_xi.TabIndex = 15;
            this.txtBoxCenter_xi.Text = "Xi";
            this.txtBoxCenter_xi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxCenter_h
            // 
            this.txtBoxCenter_h.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxCenter_h.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCenter_h.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxCenter_h.Location = new System.Drawing.Point(266, 276);
            this.txtBoxCenter_h.Name = "txtBoxCenter_h";
            this.txtBoxCenter_h.Size = new System.Drawing.Size(68, 18);
            this.txtBoxCenter_h.TabIndex = 16;
            this.txtBoxCenter_h.Text = "h";
            this.txtBoxCenter_h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCenter_solve
            // 
            this.btnCenter_solve.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCenter_solve.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCenter_solve.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCenter_solve.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCenter_solve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCenter_solve.Location = new System.Drawing.Point(141, 307);
            this.btnCenter_solve.Name = "btnCenter_solve";
            this.btnCenter_solve.Size = new System.Drawing.Size(75, 25);
            this.btnCenter_solve.TabIndex = 18;
            this.btnCenter_solve.Text = "SOLVE";
            this.btnCenter_solve.UseVisualStyleBackColor = false;
            this.btnCenter_solve.Click += new System.EventHandler(this.btnCenter_solve_Click);
            // 
            // btnCenter_clear
            // 
            this.btnCenter_clear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCenter_clear.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCenter_clear.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCenter_clear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCenter_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCenter_clear.Location = new System.Drawing.Point(263, 307);
            this.btnCenter_clear.Name = "btnCenter_clear";
            this.btnCenter_clear.Size = new System.Drawing.Size(75, 25);
            this.btnCenter_clear.TabIndex = 19;
            this.btnCenter_clear.Text = "CLEAR";
            this.btnCenter_clear.UseVisualStyleBackColor = false;
            this.btnCenter_clear.Click += new System.EventHandler(this.btnCenter_clear_Click);
            // 
            // txtBoxCenter_d
            // 
            this.txtBoxCenter_d.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxCenter_d.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCenter_d.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxCenter_d.Location = new System.Drawing.Point(43, 346);
            this.txtBoxCenter_d.Name = "txtBoxCenter_d";
            this.txtBoxCenter_d.ReadOnly = true;
            this.txtBoxCenter_d.Size = new System.Drawing.Size(394, 18);
            this.txtBoxCenter_d.TabIndex = 20;
            this.txtBoxCenter_d.Text = "D";
            this.txtBoxCenter_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::MP4.Properties.Resources.Center;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.txtBoxCenter_d);
            this.Controls.Add(this.btnCenter_clear);
            this.Controls.Add(this.btnCenter_solve);
            this.Controls.Add(this.txtBoxCenter_h);
            this.Controls.Add(this.txtBoxCenter_xi);
            this.Controls.Add(this.txtBoxCenter_eq);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCenter";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CENTERED FINITE DIVIDED DIFFERENCE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxCenter_eq;
        private System.Windows.Forms.TextBox txtBoxCenter_xi;
        private System.Windows.Forms.TextBox txtBoxCenter_h;
        private System.Windows.Forms.Button btnCenter_solve;
        private System.Windows.Forms.Button btnCenter_clear;
        private System.Windows.Forms.TextBox txtBoxCenter_d;
    }
}