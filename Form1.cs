using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_ListBox_Name
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lsKQ.Items.Add(txtName.Text);
            txtName.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lsKQ.Items.RemoveAt(lsKQ.SelectedIndex);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lsKQ.SelectedIndex < 0) return;
            lsKQ.Items[lsKQ.SelectedIndex] = txtName.Text;
        }

        private void lsKQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsKQ.SelectedIndex >= 0)
            txtName.Text = lsKQ.SelectedItem.ToString();
        }
    }
}
