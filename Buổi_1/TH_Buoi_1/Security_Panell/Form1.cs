using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Security_Panell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string pass;

        private void Form1_Load(object sender, EventArgs e)
        {
            pass = "";
        }
            string[][] data = new string[100][];
            int i = 0;
            string now = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        private void btn_enter_Click(object sender, EventArgs e)
        {
            switch (pass)
                {
                case "321":
                    MessageBox.Show("Giám đốc đăng nhập thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    pass = "";
                    des_1.Text = pass;
                    data[i] = new string[] { now, "Giám đốc", "Đăng nhập thành công" };
                    ListViewItem listViewItem1 = new ListViewItem(data[i]);
                    listView1.Items.Add(listViewItem1);
                    i++;
                    break;
                case "432":
                    MessageBox.Show("Nhân viên đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pass = "";
                    des_1.Text = pass;
                    data[i] = new string[] { now, "Nhân viên", "Đăng nhập thành công" };
                    ListViewItem listViewItem2 = new ListViewItem(data[i]);
                    listView1.Items.Add(listViewItem2);
                    i++;
                    break;
                default:
                    MessageBox.Show("Không thành công. Vui lòng đăng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pass = "";
                    des_1.Text = pass;
                    data[i] = new string[] { now, "Không có", "Từ chối" };
                    ListViewItem listViewItem3 = new ListViewItem(data[i]);
                    listView1.Items.Add(listViewItem3);
                    i++;
                    break;
                }
            //foreach (var row in data)
            //{
            //    ListViewItem listViewItem = new ListViewItem(row);
            //    listView1.Items.Add(listViewItem);
            //}


        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            pass ="";
            des_1.Text = pass;
        }
        private void btn_ring_Click(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            pass += 1;
            des_1.Text = pass;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            pass += 2;
            des_1.Text = pass;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            pass += 9;
            des_1.Text = pass;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            pass += 4;
            des_1.Text = pass;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            pass += 3;
            des_1.Text = pass;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            pass += 6;
            des_1.Text = pass;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            pass += 7;
            des_1.Text = pass;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            pass += 8;
            des_1.Text = pass;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            pass += 5;
            des_1.Text = pass;
        }

    }
}
