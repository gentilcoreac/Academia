<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/BasePaginaMaestra.Master" CodeBehind="Inscripciones.aspx.cs" Inherits="Web.Inscripciones" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContentBase">

	<asp:GridView ID="grdInscripciones" runat="server" CssClass="table" AutoGenerateColumns="False" DataSourceID="odsInscripciones">
		<Columns>
			<asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
			<asp:BoundField DataField="IDAlumno.ID" HeaderText="ID Alumno" SortExpression="IDAlumno" />
			<asp:BoundField DataField="IDCurso" HeaderText="Curso" SortExpression="IDCurso" />
			<asp:BoundField DataField="Nota" HeaderText="Nota" SortExpression="Nota" />
			<asp:BoundField DataField="Condicion" HeaderText="Condicion" SortExpression="Condicion" />
		</Columns>
	</asp:GridView>
	<asp:ObjectDataSource ID="odsInscripciones" runat="server" DataObjectTypeName="Business.Entities.AlumnoInscripcion" DeleteMethod="Save" InsertMethod="Save" SelectMethod="GetAll" TypeName="Business.Logic.AlumnoInscripcionLogic" UpdateMethod="Save">
		<SelectParameters>
			<asp:Parameter DefaultValue="Todos" Name="tipoBusqueda" Type="String" />
			<asp:Parameter Name="busqueda" Type="String" />
			<asp:SessionParameter Name="ID_Persona" SessionField="UsuarioLogeado.ID" Type="Int32" />
		</SelectParameters>
	</asp:ObjectDataSource>



</asp:Content>