using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaiordeTres
{
    public partial class frmMaiorValorTres : Form
    {
        public frmMaiorValorTres()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Double A = System.Convert.ToDouble(txbValorA.Text);
            Double B = System.Convert.ToDouble(txbValorB.Text);
            Double C = System.Convert.ToDouble(txbValorC.Text);

            Double valorMaior;
            
            if (A > B && A > C)
            {
             
                valorMaior = A;
                lblResposta.Text = ("Maior Valor é A = " + System.Convert.ToString(valorMaior));
            }
            else if (B > A && B > C)
            {
                valorMaior = B;
                lblResposta.Text = ("Maior Valor é B = " + System.Convert.ToString(valorMaior));
            }
            else if (C > A && C > B)
            {
                valorMaior = C;
                lblResposta.Text = ("Maior Valor é C = " + System.Convert.ToString(valorMaior));
            }
            else if (C == A && C == B)
            {
                valorMaior = C;
                lblResposta.Text = ("Maior Valor é A, B e C = " + System.Convert.ToString(valorMaior));
            }
            else if (C == A && C > B)
            {
                valorMaior = C;
                lblResposta.Text = ("Maior Valor é A e C = " + System.Convert.ToString(valorMaior));
            }
            else if (A == B && C < A)
            {
                valorMaior = A;
                lblResposta.Text = ("Maior Valor é A e B = " + System.Convert.ToString(valorMaior));
            }
            else if (C < A && C == B)
            {
                valorMaior = C;
                lblResposta.Text = ("Maior Valor é B e C = " + System.Convert.ToString(valorMaior));
            }
            

            

        }
    }
}
