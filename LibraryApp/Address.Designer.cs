namespace LibraryApp
{
    partial class frmAddress
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
            btnCancel = new Button();
            lblAddressID = new Label();
            lblTitle = new Label();
            lblCity = new Label();
            lblStreet = new Label();
            lblFullAddress = new Label();
            lblPostalCode = new Label();
            txtPostalCode = new TextBox();
            txtFullAddress = new TextBox();
            txtStreet = new TextBox();
            txtCity = new TextBox();
            txtTitle = new TextBox();
            txtAddressID = new TextBox();
            dgvAddress = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAddress).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(81, 249);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 41);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(464, 249);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 41);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += button2_Click;
            // 
            // lblAddressID
            // 
            lblAddressID.AutoSize = true;
            lblAddressID.Location = new Point(28, 15);
            lblAddressID.Name = "lblAddressID";
            lblAddressID.Size = new Size(77, 20);
            lblAddressID.TabIndex = 2;
            lblAddressID.Text = "AddressID";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(28, 46);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 20);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Title";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(28, 82);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(34, 20);
            lblCity.TabIndex = 4;
            lblCity.Text = "City";
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Location = new Point(28, 115);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(48, 20);
            lblStreet.TabIndex = 5;
            lblStreet.Text = "Street";
            // 
            // lblFullAddress
            // 
            lblFullAddress.AutoSize = true;
            lblFullAddress.Location = new Point(28, 145);
            lblFullAddress.Name = "lblFullAddress";
            lblFullAddress.Size = new Size(85, 20);
            lblFullAddress.TabIndex = 6;
            lblFullAddress.Text = "FullAddress";
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Location = new Point(30, 178);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(83, 20);
            lblPostalCode.TabIndex = 7;
            lblPostalCode.Text = "PostalCode";
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(119, 178);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(125, 27);
            txtPostalCode.TabIndex = 6;
            // 
            // txtFullAddress
            // 
            txtFullAddress.Location = new Point(119, 145);
            txtFullAddress.Name = "txtFullAddress";
            txtFullAddress.Size = new Size(125, 27);
            txtFullAddress.TabIndex = 5;
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(119, 112);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(125, 27);
            txtStreet.TabIndex = 4;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(119, 79);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(125, 27);
            txtCity.TabIndex = 3;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(119, 46);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 2;
            // 
            // txtAddressID
            // 
            txtAddressID.Location = new Point(119, 12);
            txtAddressID.Name = "txtAddressID";
            txtAddressID.Size = new Size(125, 27);
            txtAddressID.TabIndex = 1;
            // 
            // dgvAddress
            // 
            dgvAddress.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddress.Location = new Point(0, 296);
            dgvAddress.Name = "dgvAddress";
            dgvAddress.RowHeadersWidth = 51;
            dgvAddress.RowTemplate.Height = 29;
            dgvAddress.Size = new Size(622, 221);
            dgvAddress.TabIndex = 14;
            // 
            // frmAddress
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(626, 521);
            Controls.Add(dgvAddress);
            Controls.Add(txtAddressID);
            Controls.Add(txtTitle);
            Controls.Add(txtCity);
            Controls.Add(txtStreet);
            Controls.Add(txtFullAddress);
            Controls.Add(txtPostalCode);
            Controls.Add(lblPostalCode);
            Controls.Add(lblFullAddress);
            Controls.Add(lblStreet);
            Controls.Add(lblCity);
            Controls.Add(lblTitle);
            Controls.Add(lblAddressID);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "frmAddress";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Address";
            ((System.ComponentModel.ISupportInitialize)dgvAddress).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private Label lblAddressID;
        private Label lblTitle;
        private Label lblCity;
        private Label lblStreet;
        private Label lblFullAddress;
        private Label lblPostalCode;
        private TextBox txtPostalCode;
        private TextBox txtFullAddress;
        private TextBox txtStreet;
        private TextBox txtCity;
        private TextBox txtTitle;
        private TextBox txtAddressID;
        private DataGridView dgvAddress;
    }
}