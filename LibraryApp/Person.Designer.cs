namespace LibraryApp
{
    partial class frmPerson
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
            btnSave = new Button();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            btnCancel = new Button();
            chbIsAdmin = new CheckBox();
            lblNationalCode = new Label();
            txtNationalCode = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(43, 271);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 45);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(26, 52);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(76, 20);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "FirstName";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(27, 89);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(75, 20);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "LastName";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(26, 127);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(104, 20);
            lblPhoneNumber.TabIndex = 3;
            lblPhoneNumber.Text = "PhoneNumber";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(142, 120);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(125, 27);
            txtPhoneNumber.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(142, 86);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(142, 52);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(247, 272);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(104, 44);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // chbIsAdmin
            // 
            chbIsAdmin.AutoSize = true;
            chbIsAdmin.Location = new Point(58, 206);
            chbIsAdmin.Name = "chbIsAdmin";
            chbIsAdmin.Size = new Size(85, 24);
            chbIsAdmin.TabIndex = 5;
            chbIsAdmin.Text = "IsAdmin";
            chbIsAdmin.UseVisualStyleBackColor = true;
            // 
            // lblNationalCode
            // 
            lblNationalCode.AutoSize = true;
            lblNationalCode.Location = new Point(27, 19);
            lblNationalCode.Name = "lblNationalCode";
            lblNationalCode.Size = new Size(101, 20);
            lblNationalCode.TabIndex = 12;
            lblNationalCode.Text = "NationalCode";
            // 
            // txtNationalCode
            // 
            txtNationalCode.Location = new Point(142, 16);
            txtNationalCode.Name = "txtNationalCode";
            txtNationalCode.Size = new Size(125, 27);
            txtNationalCode.TabIndex = 1;
            // 
            // frmPerson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(405, 374);
            Controls.Add(txtNationalCode);
            Controls.Add(lblNationalCode);
            Controls.Add(chbIsAdmin);
            Controls.Add(btnCancel);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(btnSave);
            Name = "frmPerson";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Person";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Button btnCancel;
        private CheckBox chbIsAdmin;
        private Label lblNationalCode;
        private TextBox txtNationalCode;
    }
}