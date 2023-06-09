using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;
using UserControl = System.Windows.Controls.UserControl;

namespace WPF_StudentManagement.View
{
    /// <summary>
    /// Interaction logic for StudentManegement.xaml
    /// </summary>
    public partial class StudentManegement : UserControl
    {
        public StudentManegement()
        {
            InitializeComponent();
        }
        //public bool Validation()
        //{
        //    if (String.IsNullOrWhiteSpace(txtFristname.Text) || !(txtFristname.Text.Length < 50))
        //    {
        //        MessageBox.Show("Please input Frist Name (Max 50 character) ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtFristname.Focus();
        //        return false;
        //    }

        //    if (String.IsNullOrWhiteSpace(txtLastname.Text) || !(txtLastname.Text.Length < 50))
        //    {
        //        MessageBox.Show("Please input Last Name (Max 50 character) ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtFristname.Focus();
        //        return false;
        //    }

        //    if (String.IsNullOrWhiteSpace(txtPhone.Text) || txtPhone.Text.Length != 10)
        //    {
        //        MessageBox.Show("Please input your phone number (Length 10)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtPhone.Focus();
        //        return false;
        //    }

        //    if (String.IsNullOrWhiteSpace(txtEmail.Text))
        //    {
        //        MessageBox.Show("Please input your email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtEmail.Focus();
        //        return false;
        //    }

        //    if (!txtEmail.Text.Contains("@"))
        //    {
        //        MessageBox.Show(txtEmail.Text + " is not email type!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtEmail.Focus();
        //        return false;
        //    }
        //    return true;

        //}


    }
}
