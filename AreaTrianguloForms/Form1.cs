using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaTrianguloForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtResultado_Click(object sender, EventArgs e)
        {
            try
            {
                double baset = double.Parse(txtBase.Text);
                double alturat = double.Parse(txtAltura.Text);

                double resultado = (baset * alturat) / 2;

                txtResultado.Text = resultado.ToString();
            }
            catch 
            {
                MessageBox.Show("Dados inválidos informados! ");

                txtResultado.Clear();
                txtAltura.Clear();  
                txtBase.Clear();
            }

        }

       
       

        
    }
}
