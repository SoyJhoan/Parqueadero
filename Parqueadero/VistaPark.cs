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

            else if (txtPp.Text== "GTL-001")
            {
                txtM.Text = "PICANTO GT-LINE";
                txtC.Text = "1.248 cc";
                txtT.Text = "Mecánica 5 velocidades";
                txtD.Text = "Asistida Eléctricamente";
                txtP.Text ="GTL-001" ;
                txtHi.Text ="10" ;
                txtHs.Text ="3" ;
                txtMin.Text = "300";
                textMo.Text = "1.25L DOHC CVVT Dual 16 Válvulas";
                textSus.Text = "Delantera Independiente tipo McPherson con barra estabilizadora,Trasera Semi-independiente y eje de torsión";
                textFren.Text = "Delanteros Disco 10, Traseros Tambor";
                textRue.Text = "Rin  15' de Lujo, Llantas 185 / 55 R15";
                textCol.Text ="Blanco, Negro, Gris o Plata " ;
                textAu.Text = "Easy Smart con pantalla táctil 9'' tipo FES";
                textGar.Text = "7 años ó 150.000 kilómetros, lo primero que ocurra";
            }

            else if (txtPp.Text=="GTL-002")
            {
                txtM.Text = "PICANTO GT-LINE";
                txtC.Text = "1.248 cc";
                txtT.Text = "Mecánica 5 velocidades";
                txtD.Text = "Asistida Eléctricamente";
                txtP.Text = "GTL-002";
                txtHi.Text = "5";
                txtHs.Text = "8";
                txtMin.Text = "180";
                textMo.Text = "1.25L DOHC CVVT Dual 16 Válvulas";
                textSus.Text = "Delantera Independiente tipo McPherson con barra estabilizadora,Trasera Semi-independiente y eje de torsión";
                textFren.Text = "Delanteros Disco 10, Traseros Tambor";
                textRue.Text = "Rin  15' de Lujo, Llantas 185 / 55 R15";
                textCol.Text = "Blanco, Negro, Gris o Plata ";
                textAu.Text = "Easy Smart con pantalla táctil 9'' tipo FES";
                textGar.Text = "7 años ó 150.000 kilómetros, lo primero que ocurra";
            }
            else if (txtPp.Text == "GTL-003")
            {
                txtM.Text = "PICANTO GT-LINE";
                txtC.Text = "1.248 cc";
                txtT.Text = "Mecánica 5 velocidades";
                txtD.Text = "Asistida Eléctricamente";
                txtP.Text = "GTL-003";
                txtHi.Text = "1";
                txtHs.Text = "10";
                txtMin.Text = "540";
                textMo.Text = "1.25L DOHC CVVT Dual 16 Válvulas";
                textSus.Text = "Delantera Independiente tipo McPherson con barra estabilizadora,Trasera Semi-independiente y eje de torsión";
                textFren.Text = "Delanteros Disco 10, Traseros Tambor";
                textRue.Text = "Rin  15' de Lujo, Llantas 185 / 55 R15";
                textCol.Text = "Blanco, Negro, Gris o Plata ";
                textAu.Text = "Easy Smart con pantalla táctil 9'' tipo FES";
                textGar.Text = "7 años ó 150.000 kilómetros, lo primero que ocurra";
            }
            else if (txtPp.Text == "SOL-001")
            {
                txtM.Text = "SOLUTO";
                txtC.Text = "1.368 cc";
                txtT.Text = "Mecánica 5 velocidades";
                txtD.Text = "Asistida Eléctricamente (MDPS)";
                txtP.Text = "SOL-001";
                txtHi.Text = "10";
                txtHs.Text = "12";
                txtMin.Text = "120";
                textMo.Text = "1.4L DOHC CVVT Dual de 16 Válvulas";
                textSus.Text = "Delantera Independiente tipo McPherson con barra estabilizadora,Trasera Semi-independiente y eje de torsión";
                textFren.Text = "Delanteros Disco Ventilado,Traseros Tambor";
                textRue.Text = "Rin 14 con copa, Llantas 175 / 70 R14, Llanta de repuesto Temporal del acero";
                textCol.Text = "Rojo, Blanco, Negro, Gris, Azul ";
                textAu.Text = "Be Connected con pantalla táctil de 9";
                textGar.Text = "7 años ó 150.000 kilómetros, lo primero que ocurra";
            }
            else if (txtPp.Text == "SOL-002")
            {
                txtM.Text = "SOLUTO";
                txtC.Text = "1.368 cc";
                txtT.Text = "Mecánica 5 velocidades";
                txtD.Text = "Asistida Eléctricamente (MDPS)";
                txtP.Text = "SOL-002";
                txtHi.Text = "2";
                txtHs.Text = "4:30";
                txtMin.Text = "150";
                textMo.Text = "1.4L DOHC CVVT Dual de 16 Válvulas";
                textSus.Text = "Delantera Independiente tipo McPherson con barra estabilizadora,Trasera Semi-independiente y eje de torsión";
                textFren.Text = "Delanteros Disco Ventilado,Traseros Tambor";
                textRue.Text = "Rin 14 con copa, Llantas 175 / 70 R14, Llanta de repuesto Temporal del acero";
                textCol.Text = "Rojo, Blanco, Negro, Gris, Azul ";
                textAu.Text = "Be Connected con pantalla táctil de 9";
                textGar.Text = "7 años ó 150.000 kilómetros, lo primero que ocurra";
            }
            else if (txtPp.Text == "SOL-003" || txtPp.Text== "SOL-001")
            {
                txtM.Text = "SOLUTO";
                txtC.Text = "1.368 cc";
                txtT.Text = "Mecánica 5 velocidades";
                txtD.Text = "Asistida Eléctricamente (MDPS)";
                txtP.Text = "SOL-003";
                txtHi.Text = "6";
                txtHs.Text = "9";
                txtMin.Text = "180";
                textMo.Text = "1.4L DOHC CVVT Dual de 16 Válvulas";
                textSus.Text = "Delantera Independiente tipo McPherson con barra estabilizadora,Trasera Semi-independiente y eje de torsión";
                textFren.Text = "Delanteros Disco Ventilado,Traseros Tambor";
                textRue.Text = "Rin 14 con copa , Llantas 175 / 70 R14, Llanta de repuesto Temporal del acero";
                textCol.Text = "Rojo, Blanco, Negro, Gris, Azul ";
                textAu.Text = "Be Connected con pantalla táctil de 9";
                textGar.Text = "7 años ó 150.000 kilómetros, lo primero que ocurra";
            }
            else if (txtPp.Text == "RHB-001")
            {
                txtM.Text = "Rio HatchBack";
                txtC.Text = "1.368 cc";
                txtT.Text = "Mecánica 6 velocidades";
                txtD.Text = "Asistida Eléctricamente";
                txtP.Text = "RHB-001";
                txtHi.Text = "3";
                txtHs.Text = "5:45";
                txtMin.Text = "165";
                textMo.Text = "1.4L DOHC CVVT Dual de 16 Válvulas";
                textSus.Text = "Delantera Independiente tipo McPherson con barra estabilizadora,Trasera Semi-independiente y eje de torsión";
                textFren.Text = "Delanteros Disco Ventilado 10'',Traseros Tambor 8'";
                textRue.Text = "Rin de lujo 15, Llantas 185 / 65 R15";
                textCol.Text = "Rojo, Blanco, Negro, Gris, Plata, Azul ";
                textAu.Text = "Centro de Entretenimiento Easy Smart con pantalla táctil de 8'";
                textGar.Text = "7 años ó 150.000 kilómetros, lo primero que ocurra";
            }
            else if (txtPp.Text == "RHB-002")
            {
                txtM.Text = "Rio HatchBack";
                txtC.Text = "1.368 cc";
                txtT.Text = "Mecánica 6 velocidades";
                txtD.Text = "Asistida Eléctricamente";
                txtP.Text = "RHB-002";
                txtHi.Text = "8";
                txtHs.Text = "10:30";
                txtMin.Text = "150";
                textMo.Text = "1.4L DOHC CVVT Dual de 16 Válvulas";
                textSus.Text = "Delantera Independiente tipo McPherson con barra estabilizadora,Trasera Semi-independiente y eje de torsión";
                textFren.Text = "Delanteros Disco Ventilado 10'',Traseros Tambor 8'";
                textRue.Text = "Rin de lujo 15, Llantas 185 / 65 R15";
                textCol.Text = "Rojo, Blanco, Negro, Gris, Plata, Azul ";
                textAu.Text = "Centro de Entretenimiento Easy Smart con pantalla táctil de 8'";
                textGar.Text = "7 años ó 150.000 kilómetros, lo primero que ocurra";
            }
            else if (txtPp.Text == "RHB-003")
            {
                txtM.Text = "Rio HatchBack";
                txtC.Text = "1.368 cc";
                txtT.Text = "Mecánica 6 velocidades";
                txtD.Text = "Asistida Eléctricamente";
                txtP.Text = "RHB-003";
                txtHi.Text = "7";
                txtHs.Text = "9:30";
                txtMin.Text = "150";
                textMo.Text = "1.4L DOHC CVVT Dual de 16 Válvulas";
                textSus.Text = "Delantera Independiente tipo McPherson con barra estabilizadora,Trasera Semi-independiente y eje de torsión";
                textFren.Text = "Delanteros Disco Ventilado 10'',Traseros Tambor 8'";
                textRue.Text = "Rin de lujo 15, Llantas 185 / 65 R15";
                textCol.Text = "Rojo, Blanco, Negro, Gris, Plata, Azul ";
                textAu.Text = "Centro de Entretenimiento Easy Smart con pantalla táctil de 8'";
                textGar.Text = "7 años ó 150.000 kilómetros, lo primero que ocurra";
            }
            else if (txtPp.Text == "RSD-001")
            {
                txtM.Text = "Rio Sedán";
                txtC.Text = "1.368 cc";
                txtT.Text = "Mecánica 6 velocidades";
                txtD.Text = "Asistida Eléctricamente";
                txtP.Text = "RSD-001";
                txtHi.Text = "9";
                txtHs.Text = "11:30 ";
                txtMin.Text = "150";
                textMo.Text = "1.4L DOHC CVVT Dual de 16 Válvulas";
                textSus.Text = "Delantera Independiente tipo McPherson con barra estabilizadora,Trasera Semi-independiente y eje de torsión";
                textFren.Text = "Delanteros Disco Ventilado 10'',Traseros Tambor 8'";
                textRue.Text = "Rin de lujo 15, Llantas 185 / 65 R15";
                textCol.Text = "Rojo,Negro,Blanco,Gris Claro,Azul,Gris";
                textAu.Text = "Centro de Entretenimiento Easy Smart con pantalla táctil de 8'";
                textGar.Text = "7 años ó 150.000 kilómetros, lo primero que ocurra";
            }
            else if (txtPp.Text == "RSD-002")
            {
                txtM.Text = "Rio Sedán";
                txtC.Text = "1.368 cc";
                txtT.Text = "Mecánica 6 velocidades";
                txtD.Text = "Asistida Eléctricamente";
                txtP.Text = "RSD-002";
                txtHi.Text = "4";
                txtHs.Text = "6:45";
                txtMin.Text = "165";
                textMo.Text = "1.4L DOHC CVVT Dual de 16 Válvulas";
                textSus.Text = "Delantera Independiente tipo McPherson con barra estabilizadora,Trasera Semi-independiente y eje de torsión";
                textFren.Text = "Delanteros Disco Ventilado 10'',Traseros Tambor 8'";
                textRue.Text = "Rin de lujo 15, Llantas 185 / 65 R15";
                textCol.Text = "Rojo,Negro,Blanco,Gris Claro,Azul,Gris";
                textAu.Text = "Centro de Entretenimiento Easy Smart con pantalla táctil de 8'";
                textGar.Text = "7 años ó 150.000 kilómetros, lo primero que ocurra";
            }
            else if (txtPp.Text == "RSD-003")
            {
                txtM.Text = "Rio Sedán";
                txtC.Text = "1.368 cc";
                txtT.Text = "Mecánica 6 velocidades";
                txtD.Text = "Asistida Eléctricamente";
                txtP.Text = "RSD-003";
                txtHi.Text = "7:30";
                txtHs.Text = "10";
                txtMin.Text = "150";
                textMo.Text = "1.4L DOHC CVVT Dual de 16 Válvulas";
                textSus.Text = "Delantera Independiente tipo McPherson con barra estabilizadora,Trasera Semi-independiente y eje de torsión";
                textFren.Text = "Delanteros Disco Ventilado 10'',Traseros Tambor 8'";
                textRue.Text = "Rin de lujo 15, Llantas 185 / 65 R15";
                textCol.Text = "Rojo,Negro,Blanco,Gris Claro,Azul,Gris";
                textAu.Text = "Centro de Entretenimiento Easy Smart con pantalla táctil de 8'";
                textGar.Text = "7 años ó 150.000 kilómetros, lo primero que ocurra";
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
            if (MessageBox.Show("¿Deseas salir?", "Confirma salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
