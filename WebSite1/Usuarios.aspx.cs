using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void grdUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.ToLower() == "insertar")
            {
                TextBox cajaTexto;
                CheckBox cbHabil;
                string textoActual;
                Business.Entities.Usuario usuarioNuevo = new Business.Entities.Usuario();

                //Busco el control y lo asigno a la propiedad correspondiente del objeto Usuario
                cajaTexto = (TextBox)grdUsuarios.FooterRow.FindControl("txtNombre");
                textoActual = cajaTexto.Text;
                usuarioNuevo.Nombre = textoActual;

                cajaTexto = (TextBox)grdUsuarios.FooterRow.FindControl("txtApellido");
                textoActual = cajaTexto.Text;
                usuarioNuevo.Apellido = textoActual;

                cajaTexto = (TextBox)grdUsuarios.FooterRow.FindControl("txtEmail");
                textoActual = cajaTexto.Text;
                usuarioNuevo.Email = textoActual;

                cbHabil = (CheckBox)grdUsuarios.FooterRow.FindControl("cbHabilitado");
                usuarioNuevo.Habilitado = cbHabil.Checked;

                Business.Logic.UsuarioLogic usulogic = new Business.Logic.UsuarioLogic();
                usulogic.Save(usuarioNuevo);
                grdUsuarios.DataBind();

            }
        }
    }
}