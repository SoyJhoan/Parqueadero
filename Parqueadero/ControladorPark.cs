using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parqueadero
{
    class ControladorPark
    {
        ModeloPark mode = new ModeloPark();

        //Creamos metodo para mostrar en vista
        public ArrayList Mostrar()
        {
            ArrayList Consulta = new ArrayList();
            Consulta.Add(mode.GetModelo());
            Consulta.Add(mode.GetCc().ToString());
            Consulta.Add(mode.GetTransmisión());
            Consulta.Add(mode.GetDirección());
            Consulta.Add(mode.GetPlaca());
            Consulta.Add(mode.GetPlaca1());
            Consulta.Add(mode.GetPlaca11());
            Consulta.Add(mode.GetHi().ToString());
            Consulta.Add(mode.GetHs().ToString());
            Consulta.Add(mode.GetMind().ToString());
            Consulta.Add(mode.GetMotor().ToString());
            Consulta.Add(mode.GetSuspension().ToString());  
            Consulta.Add(mode.GetFrenos().ToString());
            Consulta.Add(mode.GetRuedas().ToString());
            Consulta.Add(mode.GetColor().ToString   ());
            Consulta.Add(mode.GetAudioYEntretenimiento());
            Consulta.Add(mode.GetGarantía());
            



            return Consulta;
        }
    }
}


