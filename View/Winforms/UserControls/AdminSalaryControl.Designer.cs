
namespace SIGEN.View.Winforms.UserControls
{
    partial class AdminSalaryControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TabCtrl = new System.Windows.Forms.TabControl();
            this.InfoTab = new System.Windows.Forms.TabPage();
            this.SalaryTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmployeeList = new System.Windows.Forms.ListBox();
            this.FullNameBox = new System.Windows.Forms.RichTextBox();
            this.CIBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PositionBox = new System.Windows.Forms.RichTextBox();
            this.ShiftBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TabCtrl.SuspendLayout();
            this.InfoTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(221)))));
            this.label1.Location = new System.Drawing.Point(222, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control de Sueldos";
            // 
            // TabCtrl
            // 
            this.TabCtrl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.TabCtrl.Controls.Add(this.InfoTab);
            this.TabCtrl.Controls.Add(this.SalaryTab);
            this.TabCtrl.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabCtrl.Location = new System.Drawing.Point(15, 48);
            this.TabCtrl.Name = "TabCtrl";
            this.TabCtrl.SelectedIndex = 0;
            this.TabCtrl.Size = new System.Drawing.Size(711, 370);
            this.TabCtrl.TabIndex = 1;
            // 
            // InfoTab
            // 
            this.InfoTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(4)))));
            this.InfoTab.Controls.Add(this.ShiftBox);
            this.InfoTab.Controls.Add(this.label6);
            this.InfoTab.Controls.Add(this.PositionBox);
            this.InfoTab.Controls.Add(this.label5);
            this.InfoTab.Controls.Add(this.CIBox);
            this.InfoTab.Controls.Add(this.FullNameBox);
            this.InfoTab.Controls.Add(this.label4);
            this.InfoTab.Controls.Add(this.label3);
            this.InfoTab.Controls.Add(this.label2);
            this.InfoTab.Controls.Add(this.EmployeeList);
            this.InfoTab.Location = new System.Drawing.Point(4, 34);
            this.InfoTab.Name = "InfoTab";
            this.InfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.InfoTab.Size = new System.Drawing.Size(703, 332);
            this.InfoTab.TabIndex = 0;
            this.InfoTab.Text = "Información";
            this.InfoTab.ToolTipText = "Información y selección de un empleado";
            // 
            // SalaryTab
            // 
            this.SalaryTab.Location = new System.Drawing.Point(4, 34);
            this.SalaryTab.Name = "SalaryTab";
            this.SalaryTab.Padding = new System.Windows.Forms.Padding(3);
            this.SalaryTab.Size = new System.Drawing.Size(703, 332);
            this.SalaryTab.TabIndex = 1;
            this.SalaryTab.Text = "Sueldos";
            this.SalaryTab.ToolTipText = "Información y modificación de Sueldos";
            this.SalaryTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(221)))));
            this.label4.Location = new System.Drawing.Point(590, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "C.I.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(221)))));
            this.label3.Location = new System.Drawing.Point(278, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(221)))));
            this.label2.Location = new System.Drawing.Point(50, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Empleados";
            // 
            // EmployeeList
            // 
            this.EmployeeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.EmployeeList.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(221)))));
            this.EmployeeList.FormattingEnabled = true;
            this.EmployeeList.ItemHeight = 18;
            this.EmployeeList.Items.AddRange(new object[] {
            "Juan Manuel Correa",
            "Facundo Gerardo Rodriguez",
            "Alexander Dominguez",
            "Jairo Iván Severo",
            "Facundo Geremías Charquero",
            "Pablo Suarez"});
            this.EmployeeList.Location = new System.Drawing.Point(6, 28);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.Size = new System.Drawing.Size(193, 292);
            this.EmployeeList.TabIndex = 5;
            // 
            // FullNameBox
            // 
            this.FullNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(231)))), ((int)(((byte)(136)))));
            this.FullNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FullNameBox.DetectUrls = false;
            this.FullNameBox.Font = new System.Drawing.Font("Montserrat Medium", 8.95F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameBox.Location = new System.Drawing.Point(232, 52);
            this.FullNameBox.Multiline = false;
            this.FullNameBox.Name = "FullNameBox";
            this.FullNameBox.ReadOnly = true;
            this.FullNameBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.FullNameBox.Size = new System.Drawing.Size(258, 21);
            this.FullNameBox.TabIndex = 9;
            this.FullNameBox.TabStop = false;
            this.FullNameBox.Text = "Facundo Geremías Charquero Martinez";
            this.FullNameBox.WordWrap = false;
            // 
            // CIBox
            // 
            this.CIBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(231)))), ((int)(((byte)(136)))));
            this.CIBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CIBox.DetectUrls = false;
            this.CIBox.Font = new System.Drawing.Font("Montserrat Medium", 8.95F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CIBox.Location = new System.Drawing.Point(561, 52);
            this.CIBox.Multiline = false;
            this.CIBox.Name = "CIBox";
            this.CIBox.ReadOnly = true;
            this.CIBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.CIBox.Size = new System.Drawing.Size(94, 21);
            this.CIBox.TabIndex = 10;
            this.CIBox.TabStop = false;
            this.CIBox.Text = "18662345";
            this.CIBox.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(221)))));
            this.label5.Location = new System.Drawing.Point(260, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cargo";
            // 
            // PositionBox
            // 
            this.PositionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(231)))), ((int)(((byte)(136)))));
            this.PositionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PositionBox.DetectUrls = false;
            this.PositionBox.Font = new System.Drawing.Font("Montserrat Medium", 8.95F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionBox.Location = new System.Drawing.Point(232, 146);
            this.PositionBox.Multiline = false;
            this.PositionBox.Name = "PositionBox";
            this.PositionBox.ReadOnly = true;
            this.PositionBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.PositionBox.Size = new System.Drawing.Size(116, 21);
            this.PositionBox.TabIndex = 12;
            this.PositionBox.TabStop = false;
            this.PositionBox.Text = "Fisioterapeuta";
            this.PositionBox.WordWrap = false;
            // 
            // ShiftBox
            // 
            this.ShiftBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(231)))), ((int)(((byte)(136)))));
            this.ShiftBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShiftBox.DetectUrls = false;
            this.ShiftBox.Font = new System.Drawing.Font("Montserrat Medium", 8.95F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftBox.Location = new System.Drawing.Point(406, 146);
            this.ShiftBox.Multiline = false;
            this.ShiftBox.Name = "ShiftBox";
            this.ShiftBox.ReadOnly = true;
            this.ShiftBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ShiftBox.Size = new System.Drawing.Size(116, 21);
            this.ShiftBox.TabIndex = 14;
            this.ShiftBox.TabStop = false;
            this.ShiftBox.Text = "7:00 - 16:00";
            this.ShiftBox.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(221)))));
            this.label6.Location = new System.Drawing.Point(434, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Turno";
            // 
            // AdminSalaryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TabCtrl);
            this.Controls.Add(this.label1);
            this.Name = "AdminSalaryControl";
            this.Size = new System.Drawing.Size(750, 434);
            this.TabCtrl.ResumeLayout(false);
            this.InfoTab.ResumeLayout(false);
            this.InfoTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl TabCtrl;
        private System.Windows.Forms.TabPage InfoTab;
        private System.Windows.Forms.RichTextBox FullNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox EmployeeList;
        private System.Windows.Forms.TabPage SalaryTab;
        private System.Windows.Forms.RichTextBox CIBox;
        private System.Windows.Forms.RichTextBox ShiftBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox PositionBox;
        private System.Windows.Forms.Label label5;
    }
}
