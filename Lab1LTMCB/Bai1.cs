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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int SoThuNhat, SoThuHai;
            bool AisINT = Int32.TryParse(textBox1.Text, out SoThuNhat);   //Kiem tra so hang thu nhat co phai la Int ?
            bool BisINT = Int32.TryParse(textBox2.Text, out SoThuHai);   //Kiem tra so hang thu hai co phai la Int ?

            if (!AisINT && !BisINT)                                 //Neu ca hai so khong phai la Int
            {
                MessageBox.Show("Two invalid terms");

                textBox1.Clear();                                //Xoa so hang thu nhat, bat nguoi dung nhap lai
                textBox2.Clear();                                //Xoa so hang thu hai, bat nguoi dung nhap lai
            }
            else if (!AisINT)                                      //Neu chi co so hang thu nhat khong hop le
            {
                MessageBox.Show("Invalid first term");
                textBox1.Clear();                                //Xoa so hang thu nhat, bat nguoi dung nhap lai
            }
            else if (!BisINT)                                      //Neu chi co so hang thu hai khong hop le
            {
                MessageBox.Show("Invalid second term");
                textBox2.Clear();                                 //Xoa so hang thu hai, bat nguoi dung nhap lai
            }
            else
            {
                try
                {
                    long sum = checked((long)SoThuNhat + (long)SoThuHai);
                    textBox3.Text = sum.ToString();
                }
                catch (OverflowException)                          //Kiem tra xem tong co tran so khong ?
                {
                    MessageBox.Show("Overflow");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
