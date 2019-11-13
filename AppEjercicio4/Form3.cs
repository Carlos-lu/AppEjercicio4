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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double altura, area, radio, radio2, volumen;
            if (txtaltura.Text == "")
            {
                MessageBox.Show("Ingrese una altura");
                txtaltura.Focus();
            }
            else
            {
                if (txtradio.Text == "")
                {
                    MessageBox.Show("Ingrese el radio");
                    txtradio.Focus();
                }
                else
                {
                    altura = Convert.ToDouble(txtaltura.Text);
                    radio = Convert.ToDouble(txtradio.Text);
                    area = (2 * Math.PI * radio * (altura + radio));
                    radio2 = Math.Pow(radio, 2);
                    volumen = (Math.PI * radio2 * altura);
                    txtarea.Text = area.ToString();
                    txtvolumen.Text = volumen.ToString();

                }
            }

        }

        private void btnNUEVO_Click(object sender, EventArgs e)
        {
            txtaltura.Text = "";
            txtradio.Text = "";
            txtarea.Text = "0";
            txtvolumen.Text = "0";
            txtarea.Focus();
        }
    }
}
