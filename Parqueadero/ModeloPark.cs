using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parqueadero
{
    class ModeloPark
    {//Creamos nuestras variables
        private string Modelo;
        private int Cc;
        private string Transmisión;
        private string Dirección;
        private string Placa;
        private string Placa1;
        private string Placa11;
        private int Hi;
        private int Hs;
        private int Mind;
        private string Motor;
        private string Suspension;
        private string Frenos;
        private string Ruedas;
        private string Color;
        private string AudioYEntretenimiento;
        private string Garantía;


        //Constructor vacío, con la información de la ficha técnica de kia
        public ModeloPark()
        {
            this.Modelo = "Picanto";//0
            this.Cc = 998;//1
            this.Transmisión = "Mecánica 5 velocidades";//2
            this.Dirección = "Manual";//3
            this.Placa = "PIC-001";//4
            this.Placa1 = "PIC-002";//5
            this.Placa11 = "PIC-003";//6
            this.Hi = 7;//7
            this.Hs = 10;//8
            this.Mind = (Hs - Hi) * 60;//9
            this.Motor = "998cc | Potencia 5.500 hp / rpm | Torque 3.750 Nm / rpm";//10
            this.Suspension = "Delantera: independiente McPherson con barra|Trasera: Semi-independiente y eje de torsión";//11
            this.Frenos = "Delantero: Disco 9.5|Trasero: Tambor";//12
            this.Ruedas = "Llantas 155/80 Rin 13 o 185/55 Rin 15";//13
            this.Color = "Rojo y acabados negros";//14
            this.AudioYEntretenimiento = "Easy smart con pantalla táctil 9 tipo FES";//15
            this.Garantía = "7 años o 150.000Km, lo primero que ocurra";//16
        }

        //Getters y Setters
        public string GetModelo() { return this.Modelo; }
        public int GetCc() { return this.Cc; }
        public string GetTransmisión() { return this.Transmisión; }
        public string GetDirección() { return this.Dirección; }
        public string GetPlaca() { return this.Placa; }
        public string GetPlaca1() { return this.Placa1; }
        public string GetPlaca11() { return this.Placa11; }
        public int GetHi() { return this.Hi; }
        public int GetHs() { return this.Hs; }
        public int GetMind() { return this.Mind; }
        public string GetMotor() { return this.Motor; }
        public string GetSuspension() { return this.Suspension; }
        public string GetFrenos() { return this.Frenos; }
        public string GetRuedas() { return this.Ruedas; }
        public string GetColor() { return this.Color; }
        public string GetAudioYEntretenimiento() { return this.AudioYEntretenimiento; }
        public string GetGarantía() { return this.Garantía; }


        public void SetModelo(string Model) { this.Modelo = Model; }
        public void SetCc(int Cil) { this.Cc = Cil; }
        public void SetTransmisión(string Transmi) { this.Transmisión = Transmi; }
        public void SetDirección(string Dire) { this.Dirección = Dire; }
        public void SetPlaca(string Plac) { this.Placa = Plac; }
        public void SetPlaca1(string Plac1) { this.Placa1 = Plac1; }
        public void SetPlaca11(string Plac11) { this.Placa11 = Plac11; }
        public void SetHi(int hi) { this.Hi = hi; }
        public void SetHs(int hs) { this.Hs = hs; }
        public void SetMind(int Min) { this.Mind = Min; }
        public void SetMotor(string Mo) { this.Motor = Mo; }
        public void SetSuspension(string Sus) { this.Suspension = Sus; }
        public void SetFrenos(string Fren) { this.Frenos = Fren; }
        public void SetRuedas(string Rue) { this.Ruedas = Rue; }
        public void SetColor(string Col) { this.Color = Col; }
        public void SetAudioYEntretenimiento(string AyE) { this.AudioYEntretenimiento = AyE; }
        public void SetGarantía(string gar) { this.Garantía = gar; }




        //Creamos el constructor sobrecargado
        public ModeloPark(string Model, int Cil, string Transmi, string Dire, string Plac, string Plac1, string Plac11, int hi, int hs, int Min, string Mo, string Sus, string Fren, string Rue, string Col, string AyE, string Gar)
        {
            this.Modelo = Model;
            this.Cc = Cil;
            this.Transmisión = Transmi;
            this.Dirección = Dire;
            this.Placa = Plac;
            this.Placa1 = Plac1;
            this.Placa11 = Plac11;
            this.Hi = hi;
            this.Hs = hs;
            this.Mind = Min;
            this.Motor = Mo;
            this.Suspension = Sus;
            this.Frenos = Fren;
            this.Ruedas = Rue;
            this.Color = Col;
            this.AudioYEntretenimiento = AyE;
            this.Garantía = Gar;
        }

        
    }
   

}