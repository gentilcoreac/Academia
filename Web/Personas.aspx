<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/BasePaginaMaestra.Master" CodeBehind="Personas.aspx.cs" Inherits="Web.Personas" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContentBase" runat="server">
    <asp:GridView ID="grdPersonas" CssClass="table" runat="server" DataSourceID="odsPersonas" OnRowCommand="grdPersonas_RowCommand" ShowFooter="True" OnSelectedIndexChanged="grdPersonas_SelectedIndexChanged" AutoGenerateColumns="False">
		<Columns>
			<asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="PersonasEditar.aspx?id={0}" Text="Editar"/>
			<asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
			<asp:BoundField DataField="TiposPersona" HeaderText="Tipo Persona" SortExpression="TiposPersona" />
			<asp:BoundField DataField="Legajo" HeaderText="Legajo" SortExpression="Legajo" />
			<asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
			<asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
			<asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
			<asp:BoundField DataField="EmailPersonal" HeaderText="Email Personal" SortExpression="EmailPersonal" />
			<asp:BoundField DataField="FechaNacimiento" HeaderText="Fecha Nacimiento" SortExpression="FechaNacimiento" />
			<asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
		</Columns>
	</asp:GridView>
	<asp:ObjectDataSource ID="odsPersonas" runat="server" DataObjectTypeName="Business.Entities.Persona" DeleteMethod="Delete" SelectMethod="GetAll" TypeName="Business.Logic.PersonaLogic" UpdateMethod="Save" InsertMethod="Save">
	</asp:ObjectDataSource>

	<br />
	<asp:Button ID="btnNuevo" CssClass="btn btn-primary" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" />


</asp:Content>