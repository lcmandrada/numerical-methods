namespace MP2
{
    partial class frmSecant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecant));
            this.btnSecant_solve = new System.Windows.Forms.Button();
            this.btnSecant_clear = new System.Windows.Forms.Button();
            this.lBoxSecant_x0 = new System.Windows.Forms.ListBox();
            this.lBoxSecant_x2 = new System.Windows.Forms.ListBox();
            this.lBoxSecant_x1 = new System.Windows.Forms.ListBox();
            this.lBoxSecant_fx0 = new System.Windows.Forms.ListBox();
            this.lBoxSecant_fx2 = new System.Windows.Forms.ListBox();
            this.lBoxSecant_fx1 = new System.Windows.Forms.ListBox();
            this.txtBoxSecant_eq = new System.Windows.Forms.TextBox();
            this.txtBoxSecant_int2 = new System.Windows.Forms.TextBox();
            this.txtBoxSecant_int1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSecant_solve
            // 
            this.btnSecant_solve.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSecant_solve.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSecant_solve.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSecant_solve.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSecant_solve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecant_solve.Location = new System.Drawing.Point(201, 267);
            this.btnSecant_solve.Name = "btnSecant_solve";
            this.btnSecant_solve.Size = new System.Drawing.Size(75, 25);
            this.btnSecant_solve.TabIndex = 3;
            this.btnSecant_solve.Text = "SOLVE";
            this.btnSecant_solve.UseVisualStyleBackColor = false;
            this.btnSecant_solve.Click += new System.EventHandler(this.btnSecant_solve_Click);
            // 
            // btnSecant_clear
            // 
            this.btnSecant_clear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSecant_clear.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSecant_clear.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSecant_clear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSecant_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecant_clear.Location = new System.Drawing.Point(201, 373);
            this.btnSecant_clear.Name = "btnSecant_clear";
            this.btnSecant_clear.Size = new System.Drawing.Size(75, 25);
            this.btnSecant_clear.TabIndex = 4;
            this.btnSecant_clear.Text = "CLEAR";
            this.btnSecant_clear.UseVisualStyleBackColor = false;
            this.btnSecant_clear.Click += new System.EventHandler(this.btnSecant_clear_Click);
            // 
            // lBoxSecant_x0
            // 
            this.lBoxSecant_x0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBoxSecant_x0.Font = new System.Drawing.Font("Verdana", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxSecant_x0.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lBoxSecant_x0.FormattingEnabled = true;
            this.lBoxSecant_x0.ItemHeight = 8;
            this.lBoxSecant_x0.Location = new System.Drawing.Point(24, 319);
            this.lBoxSecant_x0.Name = "lBoxSecant_x0";
            this.lBoxSecant_x0.Size = new System.Drawing.Size(55, 40);
            this.lBoxSecant_x0.TabIndex = 8;
            this.lBoxSecant_x0.TabStop = false;
            // 
            // lBoxSecant_x2
            // 
            this.lBoxSecant_x2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBoxSecant_x2.Font = new System.Drawing.Font("Verdana", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxSecant_x2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lBoxSecant_x2.FormattingEnabled = true;
            this.lBoxSecant_x2.ItemHeight = 8;
            this.lBoxSecant_x2.Location = new System.Drawing.Point(99, 319);
            this.lBoxSecant_x2.Name = "lBoxSecant_x2";
            this.lBoxSecant_x2.Size = new System.Drawing.Size(55, 40);
            this.lBoxSecant_x2.TabIndex = 9;
            this.lBoxSecant_x2.TabStop = false;
            // 
            // lBoxSecant_x1
            // 
            this.lBoxSecant_x1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBoxSecant_x1.Font = new System.Drawing.Font("Verdana", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxSecant_x1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lBoxSecant_x1.FormattingEnabled = true;
            this.lBoxSecant_x1.ItemHeight = 8;
            this.lBoxSecant_x1.Location = new System.Drawing.Point(174, 319);
            this.lBoxSecant_x1.Name = "lBoxSecant_x1";
            this.lBoxSecant_x1.Size = new System.Drawing.Size(55, 40);
            this.lBoxSecant_x1.TabIndex = 10;
            this.lBoxSecant_x1.TabStop = false;
            // 
            // lBoxSecant_fx0
            // 
            this.lBoxSecant_fx0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBoxSecant_fx0.Font = new System.Drawing.Font("Verdana", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxSecant_fx0.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lBoxSecant_fx0.FormattingEnabled = true;
            this.lBoxSecant_fx0.ItemHeight = 8;
            this.lBoxSecant_fx0.Location = new System.Drawing.Point(249, 319);
            this.lBoxSecant_fx0.Name = "lBoxSecant_fx0";
            this.lBoxSecant_fx0.Size = new System.Drawing.Size(55, 40);
            this.lBoxSecant_fx0.TabIndex = 11;
            this.lBoxSecant_fx0.TabStop = false;
            // 
            // lBoxSecant_fx2
            // 
            this.lBoxSecant_fx2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBoxSecant_fx2.Font = new System.Drawing.Font("Verdana", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxSecant_fx2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lBoxSecant_fx2.FormattingEnabled = true;
            this.lBoxSecant_fx2.ItemHeight = 8;
            this.lBoxSecant_fx2.Location = new System.Drawing.Point(324, 319);
            this.lBoxSecant_fx2.Name = "lBoxSecant_fx2";
            this.lBoxSecant_fx2.Size = new System.Drawing.Size(55, 40);
            this.lBoxSecant_fx2.TabIndex = 12;
            this.lBoxSecant_fx2.TabStop = false;
            // 
            // lBoxSecant_fx1
            // 
            this.lBoxSecant_fx1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBoxSecant_fx1.Font = new System.Drawing.Font("Verdana", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxSecant_fx1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lBoxSecant_fx1.FormattingEnabled = true;
            this.lBoxSecant_fx1.ItemHeight = 8;
            this.lBoxSecant_fx1.Location = new System.Drawing.Point(399, 319);
            this.lBoxSecant_fx1.Name = "lBoxSecant_fx1";
            this.lBoxSecant_fx1.Size = new System.Drawing.Size(55, 40);
            this.lBoxSecant_fx1.TabIndex = 13;
            this.lBoxSecant_fx1.TabStop = false;
            // 
            // txtBoxSecant_eq
            // 
            this.txtBoxSecant_eq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSecant_eq.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSecant_eq.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxSecant_eq.Location = new System.Drawing.Point(43, 177);
            this.txtBoxSecant_eq.Name = "txtBoxSecant_eq";
            this.txtBoxSecant_eq.Size = new System.Drawing.Size(394, 18);
            this.txtBoxSecant_eq.TabIndex = 0;
            this.txtBoxSecant_eq.Text = "EQUATION";
            this.txtBoxSecant_eq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxSecant_int2
            // 
            this.txtBoxSecant_int2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSecant_int2.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSecant_int2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxSecant_int2.Location = new System.Drawing.Point(256, 238);
            this.txtBoxSecant_int2.Name = "txtBoxSecant_int2";
            this.txtBoxSecant_int2.Size = new System.Drawing.Size(68, 18);
            this.txtBoxSecant_int2.TabIndex = 2;
            this.txtBoxSecant_int2.Text = "X1";
            this.txtBoxSecant_int2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxSecant_int1
            // 
            this.txtBoxSecant_int1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSecant_int1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSecant_int1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxSecant_int1.Location = new System.Drawing.Point(156, 238);
            this.txtBoxSecant_int1.Name = "txtBoxSecant_int1";
            this.txtBoxSecant_int1.Size = new System.Drawing.Size(68, 18);
            this.txtBoxSecant_int1.TabIndex = 1;
            this.txtBoxSecant_int1.Text = "X0";
            this.txtBoxSecant_int1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmSecant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::MP2.Properties.Resources.Secant;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.txtBoxSecant_int2);
            this.Controls.Add(this.txtBoxSecant_int1);
            this.Controls.Add(this.txtBoxSecant_eq);
            this.Controls.Add(this.lBoxSecant_fx1);
            this.Controls.Add(this.lBoxSecant_fx2);
            this.Controls.Add(this.lBoxSecant_fx0);
            this.Controls.Add(this.lBoxSecant_x1);
            this.Controls.Add(this.lBoxSecant_x2);
            this.Controls.Add(this.lBoxSecant_x0);
            this.Controls.Add(this.btnSecant_clear);
            this.Controls.Add(this.btnSecant_solve);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "frmSecant";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SECANT METHOD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSecant_solve;
        private System.Windows.Forms.Button btnSecant_clear;
        private System.Windows.Forms.ListBox lBoxSecant_x0;
        private System.Windows.Forms.ListBox lBoxSecant_x2;
        private System.Windows.Forms.ListBox lBoxSecant_x1;
        private System.Windows.Forms.ListBox lBoxSecant_fx0;
        private System.Windows.Forms.ListBox lBoxSecant_fx2;
        private System.Windows.Forms.ListBox lBoxSecant_fx1;
        private System.Windows.Forms.TextBox txtBoxSecant_eq;
        private System.Windows.Forms.TextBox txtBoxSecant_int2;
        private System.Windows.Forms.TextBox txtBoxSecant_int1;
    }
}