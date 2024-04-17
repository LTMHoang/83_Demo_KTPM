using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_83_Hoang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Cong_83_Hoang_Click(object sender, EventArgs e)
        {
            int a_83_Hoang, b_83_Hoang, kq_83_Hoang;
            a_83_Hoang = int.Parse(txt_1_83_Hoang.Text);
            b_83_Hoang = int.Parse(txt_2_83_Hoang.Text);
            Calculation_83_Hoang c_83 = new Calculation_83_Hoang(a_83_Hoang, b_83_Hoang);
            kq_83_Hoang = c_83.Execute_83_Hoang("+");
            txt_kq_83_Hoang.Text = kq_83_Hoang.ToString();
        }

        private void btn_Tru_83_Hoang_Click(object sender, EventArgs e)
        {
            int a_83_Hoang, b_83_Hoang, kq_83_Hoang;
            a_83_Hoang = int.Parse(txt_1_83_Hoang.Text);
            b_83_Hoang = int.Parse(txt_2_83_Hoang.Text);
            Calculation_83_Hoang c_83 = new Calculation_83_Hoang(a_83_Hoang, b_83_Hoang);
            kq_83_Hoang = c_83.Execute_83_Hoang("-");
            txt_kq_83_Hoang.Text = kq_83_Hoang.ToString();
        }

        private void btn_Nhan_83_Hoang_Click(object sender, EventArgs e)
        {
            int a_83_Hoang, b_83_Hoang, kq_83_Hoang;
            a_83_Hoang = int.Parse(txt_1_83_Hoang.Text);
            b_83_Hoang = int.Parse(txt_2_83_Hoang.Text);
            Calculation_83_Hoang c_83 = new Calculation_83_Hoang(a_83_Hoang, b_83_Hoang);
            kq_83_Hoang = c_83.Execute_83_Hoang("*");
            txt_kq_83_Hoang.Text = kq_83_Hoang.ToString();
        }

        private void btn_Chia_83_Hoang_Click(object sender, EventArgs e)
        {
            int a_83_Hoang, b_83_Hoang, kq_83_Hoang;
            a_83_Hoang = int.Parse(txt_1_83_Hoang.Text);
            b_83_Hoang = int.Parse(txt_2_83_Hoang.Text);
            Calculation_83_Hoang c_83 = new Calculation_83_Hoang(a_83_Hoang, b_83_Hoang);
            kq_83_Hoang = c_83.Execute_83_Hoang("/");
            txt_kq_83_Hoang.Text = kq_83_Hoang.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
