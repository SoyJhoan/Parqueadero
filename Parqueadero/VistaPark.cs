using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parqueadero
{
    public partial class VistaPark : Form
    {
        public VistaPark()
        {
            InitializeComponent();
        }
        //Llamo al controlador
        ControladorPark control = new ControladorPark();
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ArrayList vista = new ArrayList();
            vista = control.Mostrar();
            if (txtPp.Text == "PIC-001")
            {
                //Designamos cada cuadro de texto con la información
                txtM.Text = (string)vista[0];
                txtC.Text = (string)vista[1];
                txtT.Text = (string)vista[2];
                txtD.Text = (string)vista[3];
                txtP.Text = (string)vista[4];               
                txtHi.Text = (string)vista[7];
                txtHs.Text = (string)vista[8];
                txtMin.Text = (string)vista[9];
                textMo.Text = (string)vista[10];
                textSus.Text = (string)vista[11];
                textFren.Text = (string)vista[12];
                textRue.Text = (string)vista[13];
                textCol.Text = (string)vista[14];
                textAu.Text = (string)vista[15];
                textGar.Text = (string)vista[16];
             

            }
            else if (txtPp.Text == "PIC-002")
            {
                txtM.Text = (string)vista[0];
                txtC.Text = (string)vista[1];
                txtT.Text = (string)vista[2];
                txtD.Text = (string)vista[3];
                txtP.Text = (string)vista[5];         
                txtHi.Text = (string)vista[7];
                txtHs.Text = (string)vista[8];
                txtMin.Text = (string)vista[9];
                textMo.Text = (string)vista[10];
                textSus.Text = (string)vista[11];
                textFren.Text = (string)vista[12];
                textRue.Text = (string)vista[13];
                textCol.Text = (string)vista[14];
                textAu.Text = (string)vista[15];
                textGar.Text = (string)vista[16];
            
                
            }
            else if (txtPp.Text == "PIC-003")
                { 
                txtM.Text = (string)vista[0];
                txtC.Text = (string)vista[1];
                txtT.Text = (string)vista[2];
                txtD.Text = (string)vista[3];
                txtP.Text = (string)vista[6];
                txtHi.Text = (string)vista[7];
                txtHs.Text = (string)vista[8];
                txtMin.Text = (string)vista[9];
                textMo.Text = (string)vista[10];
                textSus.Text = (string)vista[11];
                textFren.Text = (string)vista[12];
                textRue.Text = (string)vista[13];
                textCol.Text = (string)vista[14];
                textAu.Text = (string)vista[15];
                textGar.Text = (string)vista[16];
                

            }

         
            else
            {
                
                MessageBox.Show("Digite una placa correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void VistaPark_Load(object sender, EventArgs e)
        {

        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Confirma salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control datos in this.gbDatos.Controls)
            {
                if (datos is TextBox)
                {
                    datos.Text = String.Empty;
                }
            }
            foreach (Control resultado in this.gbResultado.Controls)
            {
                if (resultado is TextBox)
                {
                    resultado.Text = String.Empty;
                }
            }
            txtPp.Focus();
        }

        private void txtPp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
