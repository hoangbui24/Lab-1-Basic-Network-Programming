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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = comboBox1.Text.ToString();
            decimal a;
            bool AisINT = decimal.TryParse(textBox1.Text, out a);   //Kiem tra a co phai so nguyen khong, neu khong bat nhap lai
            if (AisINT)
            {
                if (x == "USD (Đô-la Mỹ)")
                {
                    a = a * 22772;
                }
                if (x == "EUR (Đồng Euro)")
                {
                    a = a * 28132;
                }
                if (x == "GBP (Bảng Anh)")
                {
                    a = a * 31538;
                }
                if (x == "SGD (Đô-la Singapore)")
                {
                    a = a * 17286;
                }
                if (x == "JPY (Yên Nhật)")
                {
                    a = a * 214;
                }
            }
            else
            {
                MessageBox.Show("Invalid input, please enter again");
            }
            textBox2.Text = String.Format("{0:#,##0.##}", a);   //Dinh dang dau ra co dau phay
        }

        private void label6_Click(object sender, EventArgs e)   //Tao nut xem ty gia hoi doai
        {
            string x = comboBox1.Text.ToString();
            if (x == "USD (Đô-la Mỹ)")
            {
                label6.Text = "1 USD = 22,772 VNĐ";
            }
            if (x == "EUR (Đồng Euro)")
            {
                label6.Text = "1 EUR = 28132 VNĐ";
            }
            if (x == "GBP (Bảng Anh)")
            {
                label6.Text = "1 GBP = 31538 VNĐ";
            }
            if (x == "SGD (Đô-la Singapore)")
            {
                label6.Text = "1 SGD = 17286 VNĐ";
            }
            if (x == "JPY (Yên Nhật)")
            {
                label6.Text = "1 JPY = 214 VNĐ";
            }
        }

        private void button2_Click(object sender, EventArgs e)      //Thoat chuong trinh
        {
            Close();
        }
    }
}
