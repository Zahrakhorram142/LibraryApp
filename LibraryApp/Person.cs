using BaseBakend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class frmPerson : Form
    {
        public frmPerson()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string phoneNumber;
            PersonClass person = new();
            try
            {
                person.NationalCode = PersonClass.IsValidCode(txtNationalCode.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                person.FirstName = PersonClass.IsValidInput(txtFirstName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                person.LastName = PersonClass.IsValidInput(txtLastName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                phoneNumber = PersonClass.IsValidPhoneNumber(txtPhoneNumber.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            person.PhoneNumber = PersonClass.ReplacePhone(phoneNumber);
            person.IsAdmin = chbIsAdmin.Checked;
            if (person.IsAdmin)
            {
                person.IsAdmin = true;
                frmAdmin frm = new frmAdmin();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("You are not the manager");
            }
            MessageBox.Show($"NationalCode:{person.NationalCode},FirstName:{person.FirstName},LastName:{person.LastName},PhoneNumber:{person.PhoneNumber}");
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
