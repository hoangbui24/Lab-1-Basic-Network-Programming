using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiLab1
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal a, b, c;
            //Rang buoc dieu kien nhap phai la so nguyen, khong duoc la ki tu
            bool aa = decimal.TryParse(textBox1.Text, out a);
            bool bb = decimal.TryParse(textBox2.Text, out b);
            bool cc = decimal.TryParse(textBox3.Text, out c);
            if (!aa || !bb || !cc)
            {
                MessageBox.Show("Có số không hợp lệ. Vui lòng nhập lại!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                decimal mmin, mmax;
                mmax = Math.Max(a, Math.Max(b, c));     //Ham tim so lon nhat
                mmin = Math.Min(a, Math.Min(b, c));     //Ham tim so be nhat
                textBox4.Text = Convert.ToString(mmax);
                textBox5.Text = Convert.ToString(mmin);
            }
        }

        private void button2_Click(object sender, EventArgs e)      //Xoa du lieu neu nhap sai
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)      //Thoat chuong trinh
        {
            Close();
        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }
    }
}
