using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAYTINHBOTUI
{
    public partial class Form1 : Form
    {
        private bool ktra;
        private string pheptoan, ketquacuoi;

        public Form1()
        {
            InitializeComponent();
        }
        private void So(int x)
        {
            if (ktra) tbKetQua.Clear();
            tbKetQua.Text += x.ToString();
            ktra = false;
        }
        private void btSo2_Click(object sender, EventArgs e)
        {
            if (ktra) tbKetQua.Clear();
            So(Convert.ToInt32(btSo2.Text));
        }

        private void btSo3_Click(object sender, EventArgs e)
        {
            if (ktra) tbKetQua.Clear();
            So(Convert.ToInt32(btSo3.Text));
        }

        private void btSo4_Click(object sender, EventArgs e)
        {
            if (ktra) tbKetQua.Clear();
            So(Convert.ToInt32(btSo4.Text));
            
        }

        private void btSo5_Click(object sender, EventArgs e)
        {
            if (ktra) tbKetQua.Clear();
            So(Convert.ToInt32(btSo5.Text));
        }

        private void btSo6_Click(object sender, EventArgs e)
        {
            if (ktra) tbKetQua.Clear();
            So(Convert.ToInt32(btSo6.Text));
        }

        private void btSo7_Click(object sender, EventArgs e)
        {
            if (ktra) tbKetQua.Clear();
            So(Convert.ToInt32(btSo7.Text));
        }

        private void btSo8_Click(object sender, EventArgs e)
        {
            if (ktra) tbKetQua.Clear();
            So(Convert.ToInt32(btSo8.Text));
        }

        private void btSo9_Click(object sender, EventArgs e)
        {
            if (ktra) tbKetQua.Clear();
            So(Convert.ToInt32(btSo9.Text));
        }

        private void btSo0_Click(object sender, EventArgs e)
        {
            if (ktra) tbKetQua.Clear();
            So(Convert.ToInt32(btSo0.Text));
        }
        private void btSo1_Click(object sender, EventArgs e)
        {
            if (ktra) tbKetQua.Clear();
            So(Convert.ToInt32(btSo1.Text));
        }
        private void btCONG_Click(object sender, EventArgs e)
        {
            PhepTinh(btCONG.Text);
        }
        private void PhepTinh(string y)
        {
            ketquacuoi = tbKetQua.Text;
            ktra = true;
            pheptoan = y;
        }

        private void btTRU_Click(object sender, EventArgs e)
        {
            PhepTinh(btTRU.Text);
        }

        private void btNHAN_Click(object sender, EventArgs e)
        {
            PhepTinh(btNHAN.Text);
        }

        private void btCHIA_Click(object sender, EventArgs e)
        {
            PhepTinh(btCHIA.Text);
        }

        private void btXOA_Click(object sender, EventArgs e)
        {
            tbKetQua.ResetText();
        }

        private void tbKetQua_TextChanged(object sender, EventArgs e)
        {

        }

        private void btBANG_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(ketquacuoi);
            b = Convert.ToDouble(tbKetQua.Text);
            switch(pheptoan)
            {
                case "+":
                    tbKetQua.Text = Convert.ToString(a + b);
                    break;
                case "-":
                    tbKetQua.Text = Convert.ToString(a - b);
                    break;
                case "*":
                    tbKetQua.Text = Convert.ToString(a * b);
                    break;
                case "/":
                    tbKetQua.Text = Convert.ToString(a / b);
                    break;
            }
        }


    }
}
