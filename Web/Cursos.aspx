<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/BasePaginaMaestra.Master" CodeFile="Cursos.aspx.cs" Inherits="Web.Cursos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContentBase" runat="server">
	
	<asp:GridView ID="grdCursos" CssClass="table" runat="server" AutoGenerateColumns="False" DataSourceID="odsCursos">
		<Columns>
			<asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="~/CursosEditar.aspx?id={0}" Text="Editar" />
			<asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
			<asp:BoundField DataField="Materia.Descripcion" HeaderText="Materia" SortExpression="Materia" />
			<asp:BoundField DataField="Comision.Descripcion" HeaderText="Comision" SortExpression="Comision" />
			<asp:BoundField DataField="AnioCalendario" HeaderText="Año Calendario" SortExpression="AnioCalendario" />
			<asp:BoundField DataField="Cupo" HeaderText="Cupo" SortExpression="Cupo" />
		</Columns>
	</asp:GridView>
	<asp:ObjectDataSource ID="odsCursos" runat="server" DataObjectTypeName="Business.Entities.Curso" DeleteMethod="Delete" InsertMethod="Save" SelectMethod="GetAll" TypeName="Business.Logic.CursoLogic" UpdateMethod="Save"></asp:ObjectDataSource>
	
</asp:Content>