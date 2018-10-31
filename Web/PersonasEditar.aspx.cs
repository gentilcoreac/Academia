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
    public partial class UsuariosEditar : System.Web.UI.Page
    {

        UsuarioLogic ul = new UsuarioLogic();
        PersonaLogic pl = new PersonaLogic();
        Persona PersonaActual = new Persona();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (PaginaEnEstadoEdicion())
            {
                int id = Int32.Parse(Request.QueryString["id"]);
                llenaGrilla(id);
            }

            if (IsPostBack)
            {

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

        private void llenaGrilla(int id)
        {
            //Obtiene el usuario activo seleccionado
            Usuario usuarioActivo = new Usuario();
            Persona personaActiva = new Persona();

            personaActiva = pl.GetOne(id);
            usuarioActivo = personaActiva.UsuarioPersona;

            //llena la grilla con los datos del usuario traido de la bd

            //Tabla de datos de persona
            lblIdPersona.Text = personaActiva.ID.ToString();
            txtNombre.Text = personaActiva.Nombre.ToString();
            txtApellido.Text = personaActiva.Apellido.ToString();
            txtDireccion.Text = personaActiva.Direccion.ToString();
            txtTelefono.Text = personaActiva.Telefono.ToString();
            txtFechaNac.Text = personaActiva.FechaNacimiento.ToString();
            txtEmailPersonal.Text = personaActiva.EmailPersonal.ToString();

            //Tabla de datos institucionales
            txtLegajo.Text = personaActiva.Legajo.ToString();
            //Llena los dropdownlists
            PlanLogic planLogic = new PlanLogic();
            ddlPlan.DataSource = planLogic.GetAll();
            ddlPlan.DataValueField = "ID";
            ddlPlan.DataBind();

            ddlTipoPersona.DataSource = Enum.GetValues(typeof(Persona.TiposPersonas));
            ddlTipoPersona.DataBind();

            //Tabla de datos de usuario
            lblIdUsuario.Text = usuarioActivo.ID.ToString();
            txtNombreUsuario.Text = usuarioActivo.NombreUsuario;
            cbHabilitado.Checked = usuarioActivo.Habilitado;
            txtEmailUsuario.Text = usuarioActivo.Email;

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            //pl.Save();

        }

        private void MapearADatos()
        {
            Usuario usuario = new Usuario();
            Persona pers = new Persona();

            usuario.State = (Usuario.States)ModoForm.Modificacion;
            usuario.ID = Int32.Parse(lblIdUsuario.Text);
            usuario.NombreUsuario = txtNombreUsuario.Text;
            usuario.Habilitado = cbHabilitado.Checked;
            usuario.Email = txtEmailUsuario.Text;
            usuario.Clave = txtClave.Text;

            pers.ID = Int32.Parse(lblIdPersona.Text);
            pers.State = (Persona.States)ModoForm.Modificacion;
            pers.Nombre = txtNombre.Text;
            pers.Apellido = txtApellido.Text;
            pers.Direccion = txtDireccion.Text;
            pers.Telefono = txtTelefono.Text;
            pers.FechaNacimiento = DateTime.Parse(txtFechaNac.Text);
            pers.EmailPersonal = txtEmailPersonal.Text;

            pers.UsuarioPersona = usuario;
        }

        public enum ModoForm { Alta, Baja, Modificacion, Consulta };

        private ModoForm _Modo;
        public ModoForm Modo
        {
            get { return _Modo; }
            set { _Modo = value; }
        }
    }
}
