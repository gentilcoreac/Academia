using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Cursos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			if (Session["UsuarioLogueado"] != null)
			{
				if (((Usuario)Session["UsuarioLogueado"]).IDPersona.TiposPersona.Equals(Persona.TiposPersonas.Administrador))
				{
					btnNuevo.Visible = true;
				}
				else
				{
					btnNuevo.Visible = false;
				}
			}
			else
			{
				Response.Redirect("/login.aspx");
			}


		}

		protected void btnNuevo_Click(object sender, EventArgs e)
		{
			Response.Redirect("~/CursosEditar.aspx?mode=new");
		}
	}
}