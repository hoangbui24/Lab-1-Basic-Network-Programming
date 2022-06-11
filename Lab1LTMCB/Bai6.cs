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
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void Bai6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp = 0;
            double sum = 0;
            int countpass = 0;
            int countfail = 0;
            string testInput = textBox1.Text;

            label3.Text = string.Empty;


            //Hàm kiểm tra điều kiện nhập vào 

            testInput = testInput.Replace(", ", String.Empty);
            if ((testInput.Contains(',')) || (testInput.Contains(' ')))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] Diem = textBox1.Text.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            

            // Hàm tính xem có bao nhiêu điểm đậu và không đậu 
            for (int j = 0; j < Diem.Length; j++)
            {
                sum += double.Parse(Diem[j]);
                if (double.Parse(Diem[j]) >= 5)
                    countpass++;
                else countfail++;
            }

            // Hàm tìm điểm cao nhất 
            double max = 0;
            for (int k = 0; k < Diem.Length; k++)
            {
                if (max < double.Parse(Diem[k]))
                    max = double.Parse(Diem[k]);
            }

            // Hàm tìm điểm thấp nhất 
            double min = max;
            for (int l = 0; l < Diem.Length; l++)
            {
                if (min > double.Parse(Diem[l]))
                    min = double.Parse(Diem[l]);
            }

            // Ham xếp loại 
            int Gioi = 0;
            int Kha = 0;
            int TB = 0;
            int Yeu = 0;
            for (int x = 0; x < Diem.Length; x++)
            {
                if ((double.Parse(Diem[x])) < 6.5)
                    Gioi++;
                else if ((double.Parse(Diem[x])) < 5)
                    Kha++;
                else if ((double.Parse(Diem[x])) < 3.5)
                    TB++;
                else if ((double.Parse(Diem[x])) < 2)
                    Yeu++;
            }



            // Xuất dữ liệu 
            double dtb = Math.Round(sum / Diem.Length, 1);

            for (int i = 0; i < Diem.Length; i++)
            {
                temp = i + 1;
                label3.Text += "Môn " + temp + ": " + Diem[i] + "\r\n";
            }

            if ((dtb >= 8) && (Gioi == 0))
                textBox7.Text = "Giỏi";
            else if ((dtb >= 6.5) && (Kha == 0))
                textBox7.Text = "Khá";
            else if ((dtb >= 5) && (TB == 0))
                textBox7.Text = "TB";
            else if ((dtb >= 3.5) && (Yeu == 0))
                textBox7.Text = "Yếu";
            else textBox7.Text = "Kém";


            textBox2.Text = dtb.ToString();
            textBox3.Text = max.ToString();
            textBox4.Text = min.ToString();
            textBox5.Text = countpass.ToString();
            textBox6.Text = countfail.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }
    }
}
