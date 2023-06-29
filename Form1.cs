using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNota01_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNota02_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNota03_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, media;

            n1 = Convert.ToDouble(txtNota01.Text);
            n2 = Convert.ToDouble(txtNota02.Text);  
            n3 = Convert.ToDouble(txtNota03.Text);

            media = (n1 + n2 + n3) / 3;

            lblMedia.Text = Convert.ToString(media);
            if (media>=60)
            {
                lblSituacao.Text = "Aprovado";
            }
            else
            {
                lblSituacao.Text = "Reprovado";
            }


        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
