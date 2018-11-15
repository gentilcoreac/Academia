using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;

namespace Web
{
	public partial class _Default : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			//if (Session["UsuarioLogueado"] != null)
			//{
			//	lbl_TipoUsuario.Text = "Gestion para " + ((Usuario)Session["UsuarioLogueado"]).IDPersona.TiposPersona.ToString();
			//}
			//else
			//{
			//	Response.Redirect("/login.aspx");
			//}
		}
	}
}