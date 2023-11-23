namespace LibraryApp
{
    partial class frmEmployee
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
            lblNationalCode = new Label();
            lblEmployeeCode = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblPhoneNumber = new Label();
            lblEmployeementDate = new Label();
            txtPhoneNumber = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtEmployeeID = new TextBox();
            txtNationalCode = new TextBox();
            btnSave = new Button();
            dgvEmployee = new DataGridView();
            btnCancel = new Button();
            dtpEmployeementDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // lblNationalCode
            // 
            lblNationalCode.AutoSize = true;
            lblNationalCode.Location = new Point(32, 60);
            lblNationalCode.Name = "lblNationalCode";
            lblNationalCode.Size = new Size(105, 20);
            lblNationalCode.TabIndex = 0;
            lblNationalCode.Text = "National Code";
            // 
            // lblEmployeeCode
            // 
            lblEmployeeCode.AutoSize = true;
            lblEmployeeCode.Location = new Point(32, 27);
            lblEmployeeCode.Name = "lblEmployeeCode";
            lblEmployeeCode.Size = new Size(90, 20);
            lblEmployeeCode.TabIndex = 1;
            lblEmployeeCode.Text = "EmployeeID";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(33, 93);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(76, 20);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "FirstName";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(34, 126);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(75, 20);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "LastName";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(32, 159);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(104, 20);
            lblPhoneNumber.TabIndex = 4;
            lblPhoneNumber.Text = "PhoneNumber";
            // 
            // lblEmployeementDate
            // 
            lblEmployeementDate.AutoSize = true;
            lblEmployeementDate.Location = new Point(32, 193);
            lblEmployeementDate.Name = "lblEmployeementDate";
            lblEmployeementDate.Size = new Size(145, 20);
            lblEmployeementDate.TabIndex = 6;
            lblEmployeementDate.Text = "Employeement Date";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(190, 159);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(125, 27);
            txtPhoneNumber.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(190, 126);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(190, 93);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 3;
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(190, 27);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(125, 27);
            txtEmployeeID.TabIndex = 1;
            // 
            // txtNationalCode
            // 
            txtNationalCode.Location = new Point(190, 60);
            txtNationalCode.Name = "txtNationalCode";
            txtNationalCode.Size = new Size(125, 27);
            txtNationalCode.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(69, 273);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 47);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(12, 338);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.RowTemplate.Height = 29;
            dgvEmployee.Size = new Size(671, 215);
            dgvEmployee.TabIndex = 15;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(529, 273);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 47);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dtpEmployeementDate
            // 
            dtpEmployeementDate.Location = new Point(190, 193);
            dtpEmployeementDate.Name = "dtpEmployeementDate";
            dtpEmployeementDate.Size = new Size(250, 27);
            dtpEmployeementDate.TabIndex = 6;
            // 
            // frmEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(695, 565);
            Controls.Add(dtpEmployeementDate);
            Controls.Add(btnCancel);
            Controls.Add(dgvEmployee);
            Controls.Add(btnSave);
            Controls.Add(txtNationalCode);
            Controls.Add(txtEmployeeID);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblEmployeementDate);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblEmployeeCode);
            Controls.Add(lblNationalCode);
            Name = "frmEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNationalCode;
        private Label lblEmployeeCode;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPhoneNumber;
        private Label lblEmployeementDate;
        private TextBox txtPhoneNumber;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtEmployeeID;
        private TextBox txtNationalCode;
        private Button btnSave;
        private DataGridView dgvEmployee;
        private Button btnCancel;
        private DateTimePicker dtpEmployeementDate;
    }
}