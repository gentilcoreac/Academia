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
    public partial class Materias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			if (Session["UsuarioLogueado"] == null)
			{
				Response.Redirect("/login.aspx");
			}
		}

        protected void grdMaterias_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void grdMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void MapearADatos()
        {

        }
    }
}