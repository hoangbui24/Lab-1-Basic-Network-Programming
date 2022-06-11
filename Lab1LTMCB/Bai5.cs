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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal a, b;
            bool AisInt = decimal.TryParse(textBox1.Text, out a);
            bool BisInt = decimal.TryParse(textBox2.Text, out b);

            if (!AisInt && !BisInt)                                 //Neu ca hai so khong phai la Int
            {
                MessageBox.Show("Two invalid terms");
                textBox1.Clear();                                //Xoa so hang thu nhat, bat nguoi dung nhap lai
                textBox2.Clear();                                //Xoa so hang thu hai, bat nguoi dung nhap lai
            }
            else if (!AisInt)                                      //Neu chi co so hang thu nhat khong hop le
            {
                MessageBox.Show("Invalid first term");
                textBox1.Clear();                                //Xoa so hang thu nhat, bat nguoi dung nhap lai
            }
            else if (!BisInt)                                      //Neu chi co so hang thu hai khong hop le
            {
                MessageBox.Show("Invalid second term");
                textBox2.Clear();                                 //Xoa so hang thu hai, bat nguoi dung nhap lai
            }
            else
            {
                long AgiaiThua = 1;     //Tinh giai thua cua so A
                for (int i = 1; i <= a; i++)
                {
                    AgiaiThua = AgiaiThua * i;
                }

                long BgiaiThua = 1;     //Tinh giai thua cua so B
                for (int i = 1; i <= b; i++)
                {
                    BgiaiThua = BgiaiThua * i;
                }

                long Tong1 = 0;         //Tinh tong tu 1 toi A
                for (int i = 1; i <= a; i++)
                {
                    Tong1 = Tong1 + i;
                }

                long Tong2 = 0;         //Tinh tong tu 1 toi B
                for (int i = 1; i <= b; i++)
                {
                    Tong2 = Tong2 + i;
                }

                decimal Tong3 = 0;      //Tinh tong cua cac (A^i)
                decimal LuyThua = 1;    //Tinh luy thua A^1 -> A^B
                for (int i = 1; i <= b; i++)
                {
                    LuyThua = LuyThua * a;
                    Tong3 = Tong3 + LuyThua;
                }
                textBox3.Text = AgiaiThua.ToString();
                textBox4.Text = BgiaiThua.ToString();
                textBox5.Text = Tong1.ToString();
                textBox6.Text = Tong2.ToString();
                textBox7.Text = Tong3.ToString();
            }

       
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)      //Xoa du lieu khi nhap sai
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void button3_Click(object sender, EventArgs e)      //Ham thoat chuong trinh
        {
            Close();
        }
    }
}
