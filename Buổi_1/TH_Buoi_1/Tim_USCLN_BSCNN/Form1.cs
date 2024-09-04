using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tim_USCLN_BSCNN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtA.Text.Trim());
            int b = Convert.ToInt32(txtB.Text.Trim());

            if (timUSCLN.Checked)
            {
                while (b != 0)
                {
                    int tmp = b;
                    b = a % b;
                    a = tmp;
                }
                txtKetQua.Text = ""+a;
            }
            else
            {
                int max = Math.Max(a, b);  // Bắt đầu từ số lớn hơn trong hai số
                int bscnn = max;

                // Tăng dần cho đến khi tìm được số chia hết cho cả a và b
                while (bscnn % a != 0 || bscnn % b != 0)
                {
                    bscnn += max;
                }

                txtKetQua.Text = "" + bscnn;
            }


        }
    }
}
