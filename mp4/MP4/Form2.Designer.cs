namespace MP4
{
    partial class frmLinear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLinear));
            this.txtBoxLinear_x = new System.Windows.Forms.TextBox();
            this.txtBoxLinear_fx = new System.Windows.Forms.TextBox();
            this.btnLinear_add = new System.Windows.Forms.Button();
            this.btnLinear_clear = new System.Windows.Forms.Button();
            this.dataLinear_xfx = new System.Windows.Forms.DataGridView();
            this.dataLinear_headi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLinear_headx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLinear_headxfx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLinear_solve = new System.Windows.Forms.Button();
            this.txtBoxLinear_a0 = new System.Windows.Forms.TextBox();
            this.txtBoxLinear_a1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataLinear_xfx)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxLinear_x
            // 
            this.txtBoxLinear_x.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxLinear_x.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLinear_x.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxLinear_x.Location = new System.Drawing.Point(162, 153);
            this.txtBoxLinear_x.Name = "txtBoxLinear_x";
            this.txtBoxLinear_x.Size = new System.Drawing.Size(68, 18);
            this.txtBoxLinear_x.TabIndex = 0;
            this.txtBoxLinear_x.Text = "X";
            this.txtBoxLinear_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxLinear_fx
            // 
            this.txtBoxLinear_fx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxLinear_fx.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLinear_fx.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxLinear_fx.Location = new System.Drawing.Point(247, 153);
            this.txtBoxLinear_fx.Name = "txtBoxLinear_fx";
            this.txtBoxLinear_fx.Size = new System.Drawing.Size(68, 18);
            this.txtBoxLinear_fx.TabIndex = 1;
            this.txtBoxLinear_fx.Text = "f(X)";
            this.txtBoxLinear_fx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLinear_add
            // 
            this.btnLinear_add.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLinear_add.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLinear_add.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLinear_add.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLinear_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinear_add.Location = new System.Drawing.Point(159, 184);
            this.btnLinear_add.Name = "btnLinear_add";
            this.btnLinear_add.Size = new System.Drawing.Size(75, 25);
            this.btnLinear_add.TabIndex = 2;
            this.btnLinear_add.Text = "ADD";
            this.btnLinear_add.UseVisualStyleBackColor = false;
            this.btnLinear_add.Click += new System.EventHandler(this.btnLinear_add_Click);
            // 
            // btnLinear_clear
            // 
            this.btnLinear_clear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLinear_clear.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLinear_clear.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLinear_clear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLinear_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinear_clear.Location = new System.Drawing.Point(244, 184);
            this.btnLinear_clear.Name = "btnLinear_clear";
            this.btnLinear_clear.Size = new System.Drawing.Size(75, 25);
            this.btnLinear_clear.TabIndex = 3;
            this.btnLinear_clear.Text = "CLEAR";
            this.btnLinear_clear.UseVisualStyleBackColor = false;
            this.btnLinear_clear.Click += new System.EventHandler(this.btnLinear_clear_Click);
            // 
            // dataLinear_xfx
            // 
            this.dataLinear_xfx.AllowUserToAddRows = false;
            this.dataLinear_xfx.AllowUserToDeleteRows = false;
            this.dataLinear_xfx.AllowUserToResizeColumns = false;
            this.dataLinear_xfx.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataLinear_xfx.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataLinear_xfx.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataLinear_xfx.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLinear_xfx.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataLinear_xfx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLinear_xfx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataLinear_xfx.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataLinear_xfx.Location = new System.Drawing.Point(144, 224);
            this.dataLinear_xfx.MultiSelect = false;
            this.dataLinear_xfx.Name = "dataLinear_xfx";
            this.dataLinear_xfx.ReadOnly = true;
            this.dataLinear_xfx.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLinear_xfx.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataLinear_xfx.RowHeadersVisible = false;
            this.dataLinear_xfx.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataLinear_xfx.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataLinear_xfx.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataLinear_xfx.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dataLinear_xfx.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLinear_xfx.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataLinear_xfx.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataLinear_xfx.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataLinear_xfx.RowTemplate.ReadOnly = true;
            this.dataLinear_xfx.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataLinear_xfx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataLinear_xfx.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataLinear_xfx.ShowCellErrors = false;
            this.dataLinear_xfx.ShowCellToolTips = false;
            this.dataLinear_xfx.ShowEditingIcon = false;
            this.dataLinear_xfx.ShowRowErrors = false;
            this.dataLinear_xfx.Size = new System.Drawing.Size(193, 120);
            this.dataLinear_xfx.TabIndex = 4;
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
            // btnLinear_solve
            // 
            this.btnLinear_solve.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLinear_solve.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLinear_solve.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLinear_solve.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLinear_solve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinear_solve.Location = new System.Drawing.Point(203, 359);
            this.btnLinear_solve.Name = "btnLinear_solve";
            this.btnLinear_solve.Size = new System.Drawing.Size(75, 25);
            this.btnLinear_solve.TabIndex = 5;
            this.btnLinear_solve.Text = "SOLVE";
            this.btnLinear_solve.UseVisualStyleBackColor = false;
            this.btnLinear_solve.Click += new System.EventHandler(this.btnLinear_solve_Click);
            // 
            // txtBoxLinear_a0
            // 
            this.txtBoxLinear_a0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxLinear_a0.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLinear_a0.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxLinear_a0.Location = new System.Drawing.Point(162, 398);
            this.txtBoxLinear_a0.Name = "txtBoxLinear_a0";
            this.txtBoxLinear_a0.ReadOnly = true;
            this.txtBoxLinear_a0.Size = new System.Drawing.Size(68, 18);
            this.txtBoxLinear_a0.TabIndex = 6;
            this.txtBoxLinear_a0.Text = "a0";
            this.txtBoxLinear_a0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxLinear_a1
            // 
            this.txtBoxLinear_a1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxLinear_a1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLinear_a1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxLinear_a1.Location = new System.Drawing.Point(247, 398);
            this.txtBoxLinear_a1.Name = "txtBoxLinear_a1";
            this.txtBoxLinear_a1.ReadOnly = true;
            this.txtBoxLinear_a1.Size = new System.Drawing.Size(68, 18);
            this.txtBoxLinear_a1.TabIndex = 7;
            this.txtBoxLinear_a1.Text = "a1";
            this.txtBoxLinear_a1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmLinear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::MP4.Properties.Resources.Linear;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.txtBoxLinear_a1);
            this.Controls.Add(this.txtBoxLinear_a0);
            this.Controls.Add(this.btnLinear_solve);
            this.Controls.Add(this.dataLinear_xfx);
            this.Controls.Add(this.btnLinear_clear);
            this.Controls.Add(this.btnLinear_add);
            this.Controls.Add(this.txtBoxLinear_fx);
            this.Controls.Add(this.txtBoxLinear_x);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLinear";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "LINEAR REGRESSION";
            ((System.ComponentModel.ISupportInitialize)(this.dataLinear_xfx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxLinear_x;
        private System.Windows.Forms.TextBox txtBoxLinear_fx;
        private System.Windows.Forms.Button btnLinear_add;
        private System.Windows.Forms.Button btnLinear_clear;
        private System.Windows.Forms.DataGridView dataLinear_xfx;
        private System.Windows.Forms.Button btnLinear_solve;
        private System.Windows.Forms.TextBox txtBoxLinear_a0;
        private System.Windows.Forms.TextBox txtBoxLinear_a1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLinear_headi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLinear_headx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLinear_headxfx;
    }
}