using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tính_chiều_cao
{
    public partial class Form1 : Form
    {
        public static string s, t, l = "vnm";//s là string, t là title, l là language
        private void vnmItem_Click(object sender, EventArgs e)
        {
            l = "vnm";
            this.txtMain.Text = "Nhập chiều cao của bạn";
            this.Text = "Phần mềm tính chiều cao";
        }

        private void enlItem_Click(object sender, EventArgs e)
        {
            l = "enl";
            this.txtMain.Text = "Press your height: ";
            this.Text = "Height calculator app";
        }
        private void btn_Click(object sender, EventArgs e)
        {
            int temp;
            if (l == "vnm")
            {
                if (int.TryParse(this.inputMain.Text, out temp) == false)
                {
                    s = "Giá trị nhập sai, thử lại!";
                    t = "Lỗi";
                }
                else if (int.Parse(this.inputMain.Text) <= 30 || int.Parse(this.inputMain.Text) >= 260)
                {
                    s = "Có gì đó sai sai. Nhập lại đê!";
                    t = "Hư cấu time";
                }
                else
                {
                    s = "Chiều cao của bạn là: " + this.inputMain.Text + "cm";
                    t = "Kết quả";
                }
                MessageBox.Show(this, s, t, MessageBoxButtons.OK);
            }
            else
            {
                if (int.TryParse(this.inputMain.Text, out temp) == false)
                {
                    s = "Wrong value, try again!";
                    t = "Error";
                }
                else if (int.Parse(this.inputMain.Text) <= 30 || int.Parse(this.inputMain.Text) >= 260)
                {
                    s = "Somethings went wrong with that value, try again!";
                    t = "Error";
                }
                else
                {
                    s = "Your height is: " + this.inputMain.Text + "cm";
                    t = "Result";
                }
                MessageBox.Show(this, s, t, MessageBoxButtons.OK);
            }
        }
        public Form1()
        {
            InitializeComponent();
            float size = (float)Math.Round((this.Width / 35.37) * 10) / 10;
            this.txtMain.Font = new Font("arial", size);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }
    }
}
