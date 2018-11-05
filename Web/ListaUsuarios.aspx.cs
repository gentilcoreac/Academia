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
    public partial class ListaUsuarios : System.Web.UI.Page
    {

        UsuarioLogic ul = new UsuarioLogic();
        PersonaLogic pl = new PersonaLogic();



        protected void Page_Load(object sender, EventArgs e)
		{
			if (Session["UsuarioLogueado"] == null)
			{

				if (Session["UsuarioLogueado"] != null)
				{
					if (PaginaEnEstadoEdicion())
					{
						int id = Int32.Parse(Request.QueryString["id"]);
						llenaGrilla(id);
					}
				}
				else
				{
					Response.Redirect("/login.aspx");
				}

			}
			else
			{
				Response.Redirect("/login.aspx");
			}
        }

        protected void grdUsuarios_SelectedIndexChanged(object sender, EventArgs e)
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
                //cajaTexto = (TextBox)grdUsuarios.FooterRow.FindControl("txtNombre");
                //textoActual = cajaTexto.Text;
                //usuarioNuevo.NombreUsuario = textoActual;

                //cajaTexto = (TextBox)grdUsuarios.FooterRow.FindControl("txtApellido");
                //textoActual = cajaTexto.Text;
                //usuarioNuevo.Apellido = textoActual;

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
        
        private void llenaGrilla(int id)
        {
            //Obtiene el usuario activo seleccionado
            Business.Logic.UsuarioLogic ul = new Business.Logic.UsuarioLogic();
            Business.Entities.Usuario usuarioActivo = new Business.Entities.Usuario();
            usuarioActivo = ul.GetOne(id);

            //llena la grilla con los datos del usuario traido de la bd
            lblId.Text = usuarioActivo.ID.ToString();
            txtUsuario.Text = usuarioActivo.NombreUsuario;
            cbHabilitado.Checked = usuarioActivo.Habilitado;
            txtEmail.Text = usuarioActivo.Email;
            txtIdPersona.Text = usuarioActivo.IDPersona.ID.ToString();


        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            Persona pers = new Persona();
            pl.GetOne(Int32.Parse(txtIdPersona.Text));

            usuario.State = (Usuario.States)ModoForm.Modificacion;
            usuario.ID = Int32.Parse(lblId.Text);
            usuario.NombreUsuario = txtUsuario.Text;
            usuario.Habilitado = cbHabilitado.Checked;
            usuario.Email = txtEmail.Text;
            usuario.Clave = txtClave.Text;
            usuario.IDPersona = pers;

            ul.Save(usuario);

        }

        private void MapearADatos()
        {
            Usuario usuario = new Usuario();
        }
    }
}