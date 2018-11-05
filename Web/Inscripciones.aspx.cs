using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace Web
{
    public partial class Inscripciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            odsInscripciones.SelectParameters.Add("tipoBusqueda", "Todos");
            odsInscripciones.SelectParameters.Add("busqueda", "");

            if (((Usuario)Session["UsuarioLogueado"]).IDPersona.TiposPersona == Persona.TiposPersonas.Administrador)
            {
                odsInscripciones.DataBind();
            } 
            else if (((Usuario)Session["UsuarioLogueado"]).IDPersona.TiposPersona == Persona.TiposPersonas.Alumno)
            {

                odsInscripciones.SelectParameters.Add("id_persona", Session["IDUsuarioLogueado"].ToString());
                //odsInscripciones.SelectParameters["id_persona"].DbType = ;
                odsInscripciones.DataBind();
            }
        }
    }
}