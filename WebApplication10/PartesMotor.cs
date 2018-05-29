using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication10
{
    public class PartesMotor
    {
        public int Numero { get; set; }
        public string Description { get; set; }
        public static List<PartesMotor> CrearLista() //metodo estatico que va a devolver
        {
            List<PartesMotor> listaPartesMotor = new List<PartesMotor>();
            //creo objetos individuales
            PartesMotor p1 = new PartesMotor();
            p1.Numero = 1;
            p1.Description = "Correa de distribución";
            listaPartesMotor.Add(p1);

            PartesMotor p2 = new PartesMotor();
            p2.Numero = 2;
            p2.Description = "Arbol de levas";
            listaPartesMotor.Add(p2);

            PartesMotor p3 = new PartesMotor();
            p3.Numero = 3;
            p3.Description = "frenos";
            listaPartesMotor.Add(p3);

            PartesMotor p4 = new PartesMotor();
            p4.Numero = 4;
            p4.Description = "volante";
            listaPartesMotor.Add(p4);

            PartesMotor p5 = new PartesMotor();
            p5.Numero = 5;
            p5.Description = "piston";
            listaPartesMotor.Add(p5);

            PartesMotor p6 = new PartesMotor();
            p6.Numero = 6;
            p6.Description = "volante";
            listaPartesMotor.Add(p6);

            return listaPartesMotor;
        }
    }
}