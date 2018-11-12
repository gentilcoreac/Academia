using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Personas : System.Web.UI.Page
    {
        UsuarioLogic ul = new UsuarioLogic();
        PersonaLogic pl = new PersonaLogic();
        Persona PersonaActual = new Persona();

        protected void Page_Load(object sender, EventArgs e)
        {
			if (Session["UsuarioLogueado"] != null)
			{
				if (((Usuario)Session["UsuarioLogueado"]).IDPersona.TiposPersona.ToString() == "Administrador")
				{
					btnNuevo.Visible = true;
				}
				else
				{
					btnNuevo.Visible = false;
				}
			}else
			{
				Response.Redirect("/login.aspx");
			}
        }

        protected void grdPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grdPersonas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
        } 

        private bool PaginaEnEstadoEdicion()
        {
            if (Request.QueryString["id"] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public enum ModoForm { Alta, Baja, Modificacion, Consulta };

        private ModoForm _Modo;
        public ModoForm Modo
        {
            get { return _Modo; }
            set { _Modo = value; }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PersonasEditar.aspx?mode=new");
        }
    }
}