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
    public partial class InscripcionesEditar : System.Web.UI.Page
    {

        #region Variables
        private AlumnoInscripcionLogic ail = new AlumnoInscripcionLogic();
        private PersonaLogic pl = new PersonaLogic();
        private CursoLogic cl = new CursoLogic();
        private AlumnoInscripcion _InscripcionActual = new AlumnoInscripcion();
        private Persona _PersonaActual = new Persona();
        private Curso _CursoActual = new Curso();


        public enum ModoForm { Alta, Baja, Modificacion, Consulta };
        private ModoForm _Modo;

        public enum ValoresEstadoRegularidad { Regular, Libre, Promovido, Inscripto };
        private ValoresEstadoRegularidad _EstadoRegularidad;
        #endregion

        #region Propiedades
        public AlumnoInscripcion InscripcionActual { get => _InscripcionActual; set => _InscripcionActual = value; }
        public Persona PersonaActual { get => _PersonaActual; set => _PersonaActual = value; }
        public Curso CursoActual { get => _CursoActual; set => _CursoActual = value; }
        public ModoForm Modo { get => _Modo; set => _Modo = value; }
        public ValoresEstadoRegularidad EstadoRegularidad { get => _EstadoRegularidad; set => _EstadoRegularidad = value; }
        #endregion

        #region Disparadores
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UsuarioLogueado"] != null)
            {
                if (PaginaEnEstadoEdicion() && !IsPostBack)
                {
                    int id = Int32.Parse(Request.QueryString["id"]);
                    InscripcionActual = ail.GetOne(id);
                    PersonaActual = pl.GetOne(InscripcionActual.IDAlumno.ID);
                    CursoActual = cl.GetOne(InscripcionActual.IDCurso.ID);
                    LlenaCampos();
                }

                if (PaginaEnEstadoAlta() && !IsPostBack)
                {
                    LlenaDropDownList();
                }

            }
            else
            {
                Response.Redirect("/Inscripciones.aspx");
            }

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            MapearADatos();
            ail.Save(InscripcionActual);
            Response.Redirect("~/Inscripciones");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Inscripciones");
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
        private void LlenaCampos()
        {
            lblIdInscripcion.Text = InscripcionActual.ID.ToString();
            lblIdAlumno.Text = PersonaActual.ID.ToString();
            lblIdCurso.Text = CursoActual.ID.ToString();
            txtNota.Text = InscripcionActual.Nota.ToString();

            //Llenar los dropdownlists
            LlenaDropDownList();
            ddlCondicion.SelectedValue = InscripcionActual.Condicion.ToString();
        }

        /// <summary>
        /// Mapea los datos de los controles actuales del formulario en las propiedades PersonaActual y UsuarioActual
        /// </summary>
        private void MapearADatos()
        {
            if (PaginaEnEstadoEdicion())
            {
                InscripcionActual.State = (AlumnoInscripcion.States)ModoForm.Modificacion;
                PersonaActual.State = (Persona.States)ModoForm.Modificacion;
                CursoActual.State = (Curso.States)ModoForm.Modificacion;
                PersonaActual.ID = Int32.Parse(lblIdAlumno.Text);
                CursoActual.ID = Int32.Parse(lblIdCurso.Text);
            }
            else if (PaginaEnEstadoAlta())
            {
                InscripcionActual.State = (AlumnoInscripcion.States)ModoForm.Alta;
                PersonaActual.State = (Persona.States)ModoForm.Alta;
                CursoActual.State = (Curso.States)ModoForm.Alta;
            }

            InscripcionActual.ID = Int32.Parse(lblIdInscripcion.Text);
            InscripcionActual.IDAlumno = PersonaActual;
            InscripcionActual.IDCurso = CursoActual;
            InscripcionActual.Nota = Int32.Parse(txtNota.Text);
            InscripcionActual.Condicion = ddlCondicion.Text;
        }

        private void LlenaDropDownList()
        {
            ddlCondicion.DataSource = Enum.GetNames(typeof(ValoresEstadoRegularidad));
            ddlCondicion.DataBind();
        }

        #endregion
    }
}