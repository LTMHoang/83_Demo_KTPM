using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _83_Hoang_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cong_83_Click(object sender, EventArgs e)
        {
            int a_83, b_83, kq_83;
            a_83 = int.Parse(txt_1_83.Text);
            b_83 = int.Parse(txt_2_83.Text);
            Calculation_83 c_83 = new Calculation_83(a_83, b_83);
            kq_83 = c_83.Execute_83("+");
            txt_kq_83.Text = kq_83.ToString();

        }

        private void btn_Tru_83_Click(object sender, EventArgs e)
        {
            int a_83, b_83, kq_83;
            a_83 = int.Parse(txt_1_83.Text);
            b_83 = int.Parse(txt_2_83.Text);
            Calculation_83 c_83 = new Calculation_83(a_83, b_83);
            kq_83 = c_83.Execute_83("-");
            txt_kq_83.Text = kq_83.ToString();
        }

        private void btn_Nhan_83_Click(object sender, EventArgs e)
        {
            int a_83, b_83, kq_83;
            a_83 = int.Parse(txt_1_83.Text);
            b_83 = int.Parse(txt_2_83.Text);
            Calculation_83 c_83 = new Calculation_83(a_83, b_83);
            kq_83 = c_83.Execute_83("*");
            txt_kq_83.Text = kq_83.ToString();
        }

        private void btn_Chia_83_Click(object sender, EventArgs e)
        {
            int a_83, b_83, kq_83;
            a_83 = int.Parse(txt_1_83.Text);
            b_83 = int.Parse(txt_2_83.Text);
            Calculation_83 c_83 = new Calculation_83(a_83, b_83);
            kq_83 = c_83.Execute_83("/");
            txt_kq_83.Text = kq_83.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
