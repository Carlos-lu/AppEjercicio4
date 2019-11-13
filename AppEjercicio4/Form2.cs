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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCALCULAR_Click(object sender, EventArgs e)
        {
            int num, resul;
            num = int.Parse(this.txtnumero.Text);

            resul = num * num;
            this.txtresultado.Text = resul.ToString();


        }

        private void btnNUEVO_Click(object sender, EventArgs e)
        {
            this.txtnumero.Text = "";
            this.txtresultado.Text = "";
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
