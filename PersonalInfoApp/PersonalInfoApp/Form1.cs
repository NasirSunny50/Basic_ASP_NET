using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInfoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String name;
        String address;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            BtnSave.Enabled = false;

            name = txtName.Text;
            address = txtAddress.Text;

            txtName.Text = "";
            txtAddress.Text = "";
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            txtName.Text = name;
            txtAddress.Text = address;
        }

    }
}
