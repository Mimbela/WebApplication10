using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAscendente_Click(object sender, EventArgs e)
        {
            //primer botón
            List<PartesMotor> datos = PartesMotor.CrearLista();
            //consulta clásica
            var lista = from p in datos
                        orderby p.Numero ascending
                        select p;

            //consulta  LAMBDA
            var listaLambda = datos
                .OrderBy(p => p.Description)
                .Select(p => p);
            foreach (PartesMotor partes in listaLambda)
            {
                Response.Write(string.Format ("{0}{1}", partes.Numero, partes.Description));
                Response.Write("<br>");

               
            }
        }

        protected void btnSeleccionA_Click(object sender, EventArgs e)
        {
            List<PartesMotor> datos = PartesMotor.CrearLista(); //FUENTE DE DATOS
            //consulta clásica
            var partes = from p in datos
                         where p.Description.StartsWith("A")
                         select p;

            //consulta  LAMBDA
            var partesLambda = datos
                .Where(p => p.Description.StartsWith("A"))
                .Select(p => p);

            foreach (PartesMotor part in partes)
            {
                Response.Write(string.Format("{0}{1}", part.Numero, part.Description));
                Response.Write("<br>");
            }

                     

        }

        protected void btnSeleccionNumero_Click(object sender, EventArgs e)
        {
            List<PartesMotor> datos = PartesMotor.CrearLista(); //FUENTE DE DATOS
            var descripcion = (from p in datos
                              where p.Numero.Equals(5)
                              select p.Description).SingleOrDefault(); //singlesordefault: tengo claro que hay una sola respuesta.
            if (descripcion !=null)
            {
                Response.Write (string.Format("Parte del motor {0}", descripcion));
            }
        }
    }
}