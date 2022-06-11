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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            bool aa = Int32.TryParse(textBox1.Text, out a);     //Rang buoc dieu kien nhap la so nguyen
            if (aa)
            {
                switch (a)           //Cau truc re nhanh theo truong hop
                {
                    case 0:
                        textBox2.Text = "Khong";
                        break;
                    case 1:
                        textBox2.Text = "Mot";
                        break;
                    case 2:
                        textBox2.Text = "Hai";
                        break;
                    case 3:
                        textBox2.Text = "Ba";
                        break;
                    case 4:
                        textBox2.Text = "Bon";
                        break;
                    case 5:
                        textBox2.Text = "Nam";
                        break;
                    case 6:
                        textBox2.Text = "Sau";
                        break;
                    case 7:
                        textBox2.Text = "Bay";
                        break;
                    case 8:
                        textBox2.Text = "Tam";
                        break;
                    case 9:
                        textBox2.Text = "Chin";
                        break;
                    default:                            //Neu nhap so qua lon, cu the x != (0 <= x <= 9) thi bat nhap lai
                        MessageBox.Show("Too large number, please enter again");
                        textBox1.Clear();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Invalid input, Please enter again");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)      //Xoa du lieu neu nhap sai
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)      //Thoat chuong trinh
        {
            Close();
        }
    }
}

//Comment in Vietnamese
