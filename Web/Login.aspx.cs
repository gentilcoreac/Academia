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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkRecordarClave_Click(object sender, EventArgs e)
        {
            //Redireccionar a otra pagina que exista y posea el elemento para mostrar el msj
            Response.Redirect("~/Default.aspx?msj=Es ud. un usuario muy descuidado, haga memoria...");
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioLogic ul = new UsuarioLogic();
            try
            {
                //Validar nombre de usuario y contraseña
                string usuario = txtUsuario.Text;
                string contrasenia = txtClave.Text;
                Usuario UsuarioLogueado = new Usuario();
                UsuarioLogueado = ul.GetLoggedUser(usuario, contrasenia);

                if (UsuarioLogueado != null && UsuarioLogueado.NombreUsuario == usuario && UsuarioLogueado.Clave == contrasenia)
                {
                    Response.Redirect("~/");
                }
                else
                {
                    Response.Write("Usuario y/o contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error al ingresar al sistema \n' + ex)</script>");
            }
        }
    }
}