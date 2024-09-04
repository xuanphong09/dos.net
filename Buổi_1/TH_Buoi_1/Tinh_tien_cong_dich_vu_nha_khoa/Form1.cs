using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tinh_tien_cong_dich_vu_nha_khoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(dialog == DialogResult.Yes)
            {
                Close();
            }
           
        }

        private void txt_name_Validating(object sender, CancelEventArgs e)
        {
            string name = txt_name.Text;
            if (string.IsNullOrEmpty(name))
            {
                e.Cancel = true;
                err.SetError(txt_name, "Vui lòng nhập tên");
            }
            else
            {
                e.Cancel = false;
                err.Clear();
            }
        }

        private void btn_tt_Click(object sender, EventArgs e)
        {
            double tien = 0;
            if(chkLayCaoRang.Checked)
            {
                tien += 50000;
            }
            if (chkTayTrangRang.Checked)
            {
                tien += 100000;
            }
            if (chkHanRang.Checked)
            {
                tien += 100000 * (int)numHanRang.Value;
            }
            if (chkBeRang.Checked)
            {
                tien += 10000 * (int)numBeRang.Value;
            }
            if (chkBocRang.Checked)
            {
                tien += 1000000 * (int)numBocRang.Value;
            }

            txt_tt.Text = tien.ToString();

        }
    }
}
