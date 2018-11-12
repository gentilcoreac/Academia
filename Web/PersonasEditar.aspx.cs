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
    public partial class PersonasEditar : System.Web.UI.Page
    {
        #region Variables
        private UsuarioLogic ul = new UsuarioLogic();
        private PersonaLogic pl = new PersonaLogic();
        private Persona _PersonaActual = new Persona();
        private Usuario _UsuarioActual = new Usuario();
        public enum ModoForm { Baja, Alta, Modificacion, Consulta };
        private ModoForm _Modo;
        #endregion

        #region Propiedades
        public ModoForm Modo
        {
            get { return _Modo; }
            set { _Modo = value; }
        }

        public Persona PersonaActual { get => _PersonaActual; set => _PersonaActual = value; }
        public Usuario UsuarioActual { get => _UsuarioActual; set => _UsuarioActual = value; }
        #endregion

        #region Disparadores
        protected void Page_Load(object sender, EventArgs e)
        {
			if ( Session["UsuarioLogueado"] != null)
			{
				if (PaginaEnEstadoEdicion() && !IsPostBack)
				{
					int id = Int32.Parse(Request.QueryString["id"]);
					PersonaActual = pl.GetOne(id);
					UsuarioActual = PersonaActual.UsuarioPersona;
					llenaCampos();
				}
				if (PaginaEnEstadoAlta() && !IsPostBack)
				{
					llenaDropDownLists();
				}
			}
			else
			{
				Response.Redirect("/login.aspx");
			}
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            MapearADatos();
            pl.Save(PersonaActual);
            Response.Redirect("~/Personas");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Personas");
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Verifica si la página está en estado de edición 
        /// </summary>
        /// <returns></returns>
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

        private bool PaginaEnEstadoAlta()
        {
            if (Request.QueryString["mode"] == "new")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Llena los campos con los datos de la Persona y Usuario previamente traidos de la BD
        /// </summary>
        private void llenaCampos()
        {
            //Tabla de datos de persona
            lblIdPersona.Text = PersonaActual.ID.ToString();
            txtNombre.Text = PersonaActual.Nombre.ToString();
            txtApellido.Text = PersonaActual.Apellido.ToString();
            txtDireccion.Text = PersonaActual.Direccion.ToString();
            txtTelefono.Text = PersonaActual.Telefono.ToString();
            txtFechaNac.Text = PersonaActual.FechaNacimiento.ToString();
            txtEmailPersonal.Text = PersonaActual.EmailPersonal.ToString();

            //Tabla de datos institucionales
            txtLegajo.Text = PersonaActual.Legajo.ToString();
            //Llenar los dropdownlists
            llenaDropDownLists();
            ddlPlan.SelectedValue = PersonaActual.Plan_persona.ID.ToString();
            ddlTipoPersona.SelectedValue = PersonaActual.TiposPersona.ToString();

            //Tabla de datos de usuario
            lblIdUsuario.Text = PersonaActual.ID.ToString();
            txtNombreUsuario.Text = UsuarioActual.NombreUsuario;
            cbHabilitado.Checked = UsuarioActual.Habilitado;
            txtEmailUsuario.Text = UsuarioActual.Email;
        }

        private void llenaDropDownLists()
        {
            PlanLogic planLogic = new PlanLogic();
            ddlPlan.DataSource = planLogic.GetAll();
            ddlPlan.DataValueField = "ID";
            ddlPlan.DataBind();

            ddlTipoPersona.DataSource = Enum.GetValues(typeof(Persona.TiposPersonas));
            ddlTipoPersona.DataBind();
        }

        /// <summary>
        /// Mapea los datos de los controles actuales del formulario en las propiedades PersonaActual y UsuarioActual
        /// </summary>
        private void MapearADatos()
        {
            if (PaginaEnEstadoEdicion())
            {
                UsuarioActual.State = (Usuario.States)ModoForm.Modificacion;
                PersonaActual.State = (Persona.States)ModoForm.Modificacion;
                UsuarioActual.ID = Int32.Parse(lblIdUsuario.Text);
                PersonaActual.ID = Int32.Parse(lblIdPersona.Text);
            }
            else if (PaginaEnEstadoAlta())
            {
                UsuarioActual.State = (Usuario.States)ModoForm.Alta;
                PersonaActual.State = (Persona.States)ModoForm.Alta;
            }

            UsuarioActual.NombreUsuario = txtNombreUsuario.Text;
            UsuarioActual.Habilitado = cbHabilitado.Checked;
            UsuarioActual.Email = txtEmailUsuario.Text;
            UsuarioActual.Clave = txtClave.Text;

            PersonaActual.Nombre = txtNombre.Text;
            PersonaActual.Apellido = txtApellido.Text;
            PersonaActual.Direccion = txtDireccion.Text;
            PersonaActual.Telefono = txtTelefono.Text;
            PersonaActual.FechaNacimiento = DateTime.Parse(txtFechaNac.Text);
            PersonaActual.EmailPersonal = txtEmailPersonal.Text;
            PersonaActual.Legajo = Int32.Parse(txtLegajo.Text);
            PersonaActual.Plan_persona = new Plan();
            PersonaActual.Plan_persona.ID = (ddlPlan.SelectedIndex + 1);    //Suma 1 porque el índice seleccionado comienza por 0
            PersonaActual.TiposPersona = ((Persona.TiposPersonas)ddlTipoPersona.SelectedIndex + 1); //Suma 1 porque el índice seleccionado comienza por 0
            PersonaActual.UsuarioPersona = UsuarioActual;
        }
        #endregion 
    }
}
