namespace MP1
{
    partial class frmRegula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegula));
            this.txtBoxRegula_int1 = new System.Windows.Forms.TextBox();
            this.txtBoxRegula_int2 = new System.Windows.Forms.TextBox();
            this.btnRegula_solve = new System.Windows.Forms.Button();
            this.btnRegula_clear = new System.Windows.Forms.Button();
            this.lBoxRegula_x0 = new System.Windows.Forms.ListBox();
            this.lBoxRegula_x2 = new System.Windows.Forms.ListBox();
            this.lBoxRegula_x1 = new System.Windows.Forms.ListBox();
            this.lBoxRegula_fx0 = new System.Windows.Forms.ListBox();
            this.lBoxRegula_fx2 = new System.Windows.Forms.ListBox();
            this.lBoxRegula_fx1 = new System.Windows.Forms.ListBox();
            this.txtBoxRegula_eq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxRegula_int1
            // 
            this.txtBoxRegula_int1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxRegula_int1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRegula_int1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxRegula_int1.Location = new System.Drawing.Point(156, 237);
            this.txtBoxRegula_int1.Name = "txtBoxRegula_int1";
            this.txtBoxRegula_int1.Size = new System.Drawing.Size(68, 18);
            this.txtBoxRegula_int1.TabIndex = 1;
            this.txtBoxRegula_int1.Text = "X0";
            this.txtBoxRegula_int1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxRegula_int2
            // 
            this.txtBoxRegula_int2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxRegula_int2.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRegula_int2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxRegula_int2.Location = new System.Drawing.Point(256, 237);
            this.txtBoxRegula_int2.Name = "txtBoxRegula_int2";
            this.txtBoxRegula_int2.Size = new System.Drawing.Size(68, 18);
            this.txtBoxRegula_int2.TabIndex = 2;
            this.txtBoxRegula_int2.Text = "X1";
            this.txtBoxRegula_int2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRegula_solve
            // 
            this.btnRegula_solve.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegula_solve.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRegula_solve.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRegula_solve.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegula_solve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegula_solve.Location = new System.Drawing.Point(201, 267);
            this.btnRegula_solve.Name = "btnRegula_solve";
            this.btnRegula_solve.Size = new System.Drawing.Size(75, 25);
            this.btnRegula_solve.TabIndex = 3;
            this.btnRegula_solve.Text = "SOLVE";
            this.btnRegula_solve.UseVisualStyleBackColor = false;
            this.btnRegula_solve.Click += new System.EventHandler(this.btnRegula_solve_Click);
            // 
            // btnRegula_clear
            // 
            this.btnRegula_clear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegula_clear.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRegula_clear.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRegula_clear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegula_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegula_clear.Location = new System.Drawing.Point(201, 373);
            this.btnRegula_clear.Name = "btnRegula_clear";
            this.btnRegula_clear.Size = new System.Drawing.Size(75, 25);
            this.btnRegula_clear.TabIndex = 4;
            this.btnRegula_clear.Text = "CLEAR";
            this.btnRegula_clear.UseVisualStyleBackColor = false;
            this.btnRegula_clear.Click += new System.EventHandler(this.btnRegula_clear_Click);
            // 
            // lBoxRegula_x0
            // 
            this.lBoxRegula_x0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBoxRegula_x0.Font = new System.Drawing.Font("Verdana", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxRegula_x0.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lBoxRegula_x0.FormattingEnabled = true;
            this.lBoxRegula_x0.ItemHeight = 8;
            this.lBoxRegula_x0.Location = new System.Drawing.Point(24, 319);
            this.lBoxRegula_x0.Name = "lBoxRegula_x0";
            this.lBoxRegula_x0.Size = new System.Drawing.Size(55, 40);
            this.lBoxRegula_x0.TabIndex = 8;
            this.lBoxRegula_x0.TabStop = false;
            // 
            // lBoxRegula_x2
            // 
            this.lBoxRegula_x2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBoxRegula_x2.Font = new System.Drawing.Font("Verdana", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxRegula_x2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lBoxRegula_x2.FormattingEnabled = true;
            this.lBoxRegula_x2.ItemHeight = 8;
            this.lBoxRegula_x2.Location = new System.Drawing.Point(99, 319);
            this.lBoxRegula_x2.Name = "lBoxRegula_x2";
            this.lBoxRegula_x2.Size = new System.Drawing.Size(55, 40);
            this.lBoxRegula_x2.TabIndex = 9;
            this.lBoxRegula_x2.TabStop = false;
            // 
            // lBoxRegula_x1
            // 
            this.lBoxRegula_x1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBoxRegula_x1.Font = new System.Drawing.Font("Verdana", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxRegula_x1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lBoxRegula_x1.FormattingEnabled = true;
            this.lBoxRegula_x1.ItemHeight = 8;
            this.lBoxRegula_x1.Location = new System.Drawing.Point(174, 319);
            this.lBoxRegula_x1.Name = "lBoxRegula_x1";
            this.lBoxRegula_x1.Size = new System.Drawing.Size(55, 40);
            this.lBoxRegula_x1.TabIndex = 10;
            this.lBoxRegula_x1.TabStop = false;
            // 
            // lBoxRegula_fx0
            // 
            this.lBoxRegula_fx0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBoxRegula_fx0.Font = new System.Drawing.Font("Verdana", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxRegula_fx0.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lBoxRegula_fx0.FormattingEnabled = true;
            this.lBoxRegula_fx0.ItemHeight = 8;
            this.lBoxRegula_fx0.Location = new System.Drawing.Point(249, 319);
            this.lBoxRegula_fx0.Name = "lBoxRegula_fx0";
            this.lBoxRegula_fx0.Size = new System.Drawing.Size(55, 40);
            this.lBoxRegula_fx0.TabIndex = 11;
            this.lBoxRegula_fx0.TabStop = false;
            // 
            // lBoxRegula_fx2
            // 
            this.lBoxRegula_fx2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBoxRegula_fx2.Font = new System.Drawing.Font("Verdana", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxRegula_fx2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lBoxRegula_fx2.FormattingEnabled = true;
            this.lBoxRegula_fx2.ItemHeight = 8;
            this.lBoxRegula_fx2.Location = new System.Drawing.Point(324, 319);
            this.lBoxRegula_fx2.Name = "lBoxRegula_fx2";
            this.lBoxRegula_fx2.Size = new System.Drawing.Size(55, 40);
            this.lBoxRegula_fx2.TabIndex = 12;
            this.lBoxRegula_fx2.TabStop = false;
            // 
            // lBoxRegula_fx1
            // 
            this.lBoxRegula_fx1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBoxRegula_fx1.Font = new System.Drawing.Font("Verdana", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxRegula_fx1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lBoxRegula_fx1.FormattingEnabled = true;
            this.lBoxRegula_fx1.ItemHeight = 8;
            this.lBoxRegula_fx1.Location = new System.Drawing.Point(399, 319);
            this.lBoxRegula_fx1.Name = "lBoxRegula_fx1";
            this.lBoxRegula_fx1.Size = new System.Drawing.Size(55, 40);
            this.lBoxRegula_fx1.TabIndex = 13;
            this.lBoxRegula_fx1.TabStop = false;
            // 
            // txtBoxRegula_eq
            // 
            this.txtBoxRegula_eq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxRegula_eq.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRegula_eq.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxRegula_eq.Location = new System.Drawing.Point(43, 177);
            this.txtBoxRegula_eq.Name = "txtBoxRegula_eq";
            this.txtBoxRegula_eq.Size = new System.Drawing.Size(394, 18);
            this.txtBoxRegula_eq.TabIndex = 0;
            this.txtBoxRegula_eq.Text = "EQUATION";
            this.txtBoxRegula_eq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmRegula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::MP1.Properties.Resources.Regula;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.txtBoxRegula_eq);
            this.Controls.Add(this.lBoxRegula_fx1);
            this.Controls.Add(this.lBoxRegula_fx2);
            this.Controls.Add(this.lBoxRegula_fx0);
            this.Controls.Add(this.lBoxRegula_x1);
            this.Controls.Add(this.lBoxRegula_x2);
            this.Controls.Add(this.lBoxRegula_x0);
            this.Controls.Add(this.btnRegula_clear);
            this.Controls.Add(this.btnRegula_solve);
            this.Controls.Add(this.txtBoxRegula_int2);
            this.Controls.Add(this.txtBoxRegula_int1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "frmRegula";
            this.Text = "REGULA-FALSI METHOD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxRegula_int1;
        private System.Windows.Forms.TextBox txtBoxRegula_int2;
        private System.Windows.Forms.Button btnRegula_solve;
        private System.Windows.Forms.Button btnRegula_clear;
        private System.Windows.Forms.ListBox lBoxRegula_x0;
        private System.Windows.Forms.ListBox lBoxRegula_x2;
        private System.Windows.Forms.ListBox lBoxRegula_x1;
        private System.Windows.Forms.ListBox lBoxRegula_fx0;
        private System.Windows.Forms.ListBox lBoxRegula_fx2;
        private System.Windows.Forms.ListBox lBoxRegula_fx1;
        private System.Windows.Forms.TextBox txtBoxRegula_eq;
    }
}