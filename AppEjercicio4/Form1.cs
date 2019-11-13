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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float cel = float.Parse(this.txtCELCIUS.Text);
            //FORMULA PARA CONVERTIR DE CELCIUS A FAHRENHEIT
            float fah = (cel * 9 / 5) + 32;
            this.txtFAHRENHEIT.Text = fah.ToString();
        }

        private void btnNUEVO_Click(object sender, EventArgs e)
        {
            this.txtCELCIUS.Text = "";
            this.txtFAHRENHEIT.Text = "";

        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
