using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RUSIA2018;

namespace RUSIA2018.Models
{
    public class Registro
    {
        private string Nombre;

        public string Nick
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        private string  Mail;

        public string  Correo
        {
            get { return Mail; }
            set { Mail = value; }
        }
       
        public string Contraseña { get; set; }

        public void MostrarNombre(string v, string v2)
        {
            //Nick = "Bienvenido : " + v;
            //Mail = "Suscripción correcta! hemos enviado un correo electronico a :" + v2 +"  para mantenerte informado con los resultados del Mundial.. Ya puedes participar por la entrada a la final del mundial!!";
           Nick=v;
           Correo=v2;
        }
    }
}
