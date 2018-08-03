namespace MP4
{
    partial class frmNewton
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewton));
            this.btnNewton_solve = new System.Windows.Forms.Button();
            this.dataNewton_xfx = new System.Windows.Forms.DataGridView();
            this.dataLinear_headi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLinear_headx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLinear_headxfx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewton_clear = new System.Windows.Forms.Button();
            this.btnNewton_add = new System.Windows.Forms.Button();
            this.txtBoxNewton_fx = new System.Windows.Forms.TextBox();
            this.txtBoxNewton_x = new System.Windows.Forms.TextBox();
            this.txtBoxNewton_eq = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataNewton_xfx)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewton_solve
            // 
            this.btnNewton_solve.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewton_solve.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnNewton_solve.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnNewton_solve.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewton_solve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewton_solve.Location = new System.Drawing.Point(203, 359);
            this.btnNewton_solve.Name = "btnNewton_solve";
            this.btnNewton_solve.Size = new System.Drawing.Size(75, 25);
            this.btnNewton_solve.TabIndex = 11;
            this.btnNewton_solve.Text = "SOLVE";
            this.btnNewton_solve.UseVisualStyleBackColor = false;
            this.btnNewton_solve.Click += new System.EventHandler(this.btnNewton_solve_Click);
            // 
            // dataNewton_xfx
            // 
            this.dataNewton_xfx.AllowUserToAddRows = false;
            this.dataNewton_xfx.AllowUserToDeleteRows = false;
            this.dataNewton_xfx.AllowUserToResizeColumns = false;
            this.dataNewton_xfx.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataNewton_xfx.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataNewton_xfx.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataNewton_xfx.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataNewton_xfx.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataNewton_xfx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNewton_xfx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataLinear_headi,
            this.dataLinear_headx,
            this.dataLinear_headxfx});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataNewton_xfx.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataNewton_xfx.Location = new System.Drawing.Point(144, 224);
            this.dataNewton_xfx.MultiSelect = false;
            this.dataNewton_xfx.Name = "dataNewton_xfx";
            this.dataNewton_xfx.ReadOnly = true;
            this.dataNewton_xfx.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataNewton_xfx.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataNewton_xfx.RowHeadersVisible = false;
            this.dataNewton_xfx.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataNewton_xfx.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataNewton_xfx.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataNewton_xfx.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dataNewton_xfx.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNewton_xfx.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataNewton_xfx.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataNewton_xfx.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataNewton_xfx.RowTemplate.ReadOnly = true;
            this.dataNewton_xfx.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataNewton_xfx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataNewton_xfx.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataNewton_xfx.ShowCellErrors = false;
            this.dataNewton_xfx.ShowCellToolTips = false;
            this.dataNewton_xfx.ShowEditingIcon = false;
            this.dataNewton_xfx.ShowRowErrors = false;
            this.dataNewton_xfx.Size = new System.Drawing.Size(193, 120);
            this.dataNewton_xfx.TabIndex = 10;
            // 
            // dataLinear_headi
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataLinear_headi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataLinear_headi.HeaderText = "i";
            this.dataLinear_headi.Name = "dataLinear_headi";
            this.dataLinear_headi.ReadOnly = true;
            this.dataLinear_headi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataLinear_headi.Width = 63;
            // 
            // dataLinear_headx
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataLinear_headx.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataLinear_headx.HeaderText = "X";
            this.dataLinear_headx.Name = "dataLinear_headx";
            this.dataLinear_headx.ReadOnly = true;
            this.dataLinear_headx.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataLinear_headx.Width = 63;
            // 
            // dataLinear_headxfx
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataLinear_headxfx.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataLinear_headxfx.HeaderText = "f(X)";
            this.dataLinear_headxfx.Name = "dataLinear_headxfx";
            this.dataLinear_headxfx.ReadOnly = true;
            this.dataLinear_headxfx.Width = 63;
            // 
            // btnNewton_clear
            // 
            this.btnNewton_clear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewton_clear.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnNewton_clear.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnNewton_clear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewton_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewton_clear.Location = new System.Drawing.Point(244, 184);
            this.btnNewton_clear.Name = "btnNewton_clear";
            this.btnNewton_clear.Size = new System.Drawing.Size(75, 25);
            this.btnNewton_clear.TabIndex = 9;
            this.btnNewton_clear.Text = "CLEAR";
            this.btnNewton_clear.UseVisualStyleBackColor = false;
            this.btnNewton_clear.Click += new System.EventHandler(this.btnNewton_clear_Click);
            // 
            // btnNewton_add
            // 
            this.btnNewton_add.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewton_add.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnNewton_add.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnNewton_add.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewton_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewton_add.Location = new System.Drawing.Point(159, 184);
            this.btnNewton_add.Name = "btnNewton_add";
            this.btnNewton_add.Size = new System.Drawing.Size(75, 25);
            this.btnNewton_add.TabIndex = 8;
            this.btnNewton_add.Text = "ADD";
            this.btnNewton_add.UseVisualStyleBackColor = false;
            this.btnNewton_add.Click += new System.EventHandler(this.btnNewton_add_Click);
            // 
            // txtBoxNewton_fx
            // 
            this.txtBoxNewton_fx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxNewton_fx.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNewton_fx.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxNewton_fx.Location = new System.Drawing.Point(247, 153);
            this.txtBoxNewton_fx.Name = "txtBoxNewton_fx";
            this.txtBoxNewton_fx.Size = new System.Drawing.Size(68, 18);
            this.txtBoxNewton_fx.TabIndex = 7;
            this.txtBoxNewton_fx.Text = "f(X)";
            this.txtBoxNewton_fx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxNewton_x
            // 
            this.txtBoxNewton_x.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxNewton_x.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNewton_x.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxNewton_x.Location = new System.Drawing.Point(162, 153);
            this.txtBoxNewton_x.Name = "txtBoxNewton_x";
            this.txtBoxNewton_x.Size = new System.Drawing.Size(68, 18);
            this.txtBoxNewton_x.TabIndex = 6;
            this.txtBoxNewton_x.Text = "X";
            this.txtBoxNewton_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxNewton_eq
            // 
            this.txtBoxNewton_eq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxNewton_eq.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNewton_eq.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxNewton_eq.Location = new System.Drawing.Point(42, 398);
            this.txtBoxNewton_eq.Name = "txtBoxNewton_eq";
            this.txtBoxNewton_eq.ReadOnly = true;
            this.txtBoxNewton_eq.Size = new System.Drawing.Size(394, 18);
            this.txtBoxNewton_eq.TabIndex = 12;
            this.txtBoxNewton_eq.Text = "EQUATION";
            this.txtBoxNewton_eq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmNewton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::MP4.Properties.Resources.Newton;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.txtBoxNewton_eq);
            this.Controls.Add(this.btnNewton_solve);
            this.Controls.Add(this.dataNewton_xfx);
            this.Controls.Add(this.btnNewton_clear);
            this.Controls.Add(this.btnNewton_add);
            this.Controls.Add(this.txtBoxNewton_fx);
            this.Controls.Add(this.txtBoxNewton_x);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "frmNewton";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "NEWTON\'S INTERPOLATION";
            ((System.ComponentModel.ISupportInitialize)(this.dataNewton_xfx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewton_solve;
        private System.Windows.Forms.DataGridView dataNewton_xfx;
        private System.Windows.Forms.Button btnNewton_clear;
        private System.Windows.Forms.Button btnNewton_add;
        private System.Windows.Forms.TextBox txtBoxNewton_fx;
        private System.Windows.Forms.TextBox txtBoxNewton_x;
        private System.Windows.Forms.TextBox txtBoxNewton_eq;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLinear_headi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLinear_headx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLinear_headxfx;
    }
}