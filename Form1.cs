﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            var userName = "isaac";
            var password = txt_Password.Text.Trim();
            if (txt_UserName.Text.Trim().ToLower() == userName && password == "12345")
            {
                new HomePage().ShowDialog();
                Hide();
            }
             else
            {
                MessageBox.Show("wrong credentials, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
