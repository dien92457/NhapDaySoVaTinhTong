using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhapDaySoVaTinhTong
{
    public partial class FormInput : Form
    {
        public FormInput()
        {
            InitializeComponent();
        }
        public string n;
        public bool check = true;
        private void textInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= '0' && e.KeyChar <='9')||e.KeyChar==(char)8||(e.KeyChar == '-' && textInput.Text.Length==0))
            {
                e.Handled = false;
            } else
            {
                e.Handled = true;
                MessageBox.Show("Nhập sai rồi chế!");
            }
            

        }

        private void BTNInput_Click(object sender, EventArgs e)
        {
            n = textInput.Text;
            textInput.Clear();
            this.Close();
        }

        private void BTNCancel_Click(object sender, EventArgs e)
        {
            check = false;
            this.Close();
        }

        private void textInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
