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
    public partial class FormMain : Form
    {
        //cmt
        public FormMain()
        {
            InitializeComponent();
        }

        private void textArray_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BTNRun_Click(object sender, EventArgs e)
        {
            int s = 0;
            int s1 = 0; int s2 = 0;
            FormInput frm = new FormInput();
            while (frm.check == true)
            {
                textArray.Text = textArray.Text + frm.n + " ";
                s += Convert.ToInt32(frm.n);
                if (Convert.ToInt32(frm.n) % 2 == 0)
                {
                    s1 += Convert.ToInt32(frm.n);
                }
                else
                {
                    s2 += Convert.ToInt32(frm.n);
                }
                frm.ShowDialog();
            }
            textSum.Text = s.ToString();
            textSumChan.Text = s1.ToString();
            textSumLe.Text = s2.ToString();
        }

        private void BTNReset_Click(object sender, EventArgs e)
        {
            textArray.Clear();
            textSum.Clear();
            textSumChan.Clear();
            textSumLe.Clear();
        }

        private void BTNExit_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(kq == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
