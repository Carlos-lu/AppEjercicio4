using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEjercicio4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           double p,a, b, c, area;
            
            a = double.Parse(this.txtA.Text);
            b = double.Parse(this.txtB.Text);
            c = double.Parse(this.txtC.Text);
            p = (a + b + c) / 2;
            area = Math.Sqrt(p(p - a)(p - b)(p - c));
            this.txtAREA.Text = p.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtAREA.Text = "0";
            this.txtA.Text = "";
            this.txtB.Text = "";
            this.txtC.Text = "";
            txtAREA.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
