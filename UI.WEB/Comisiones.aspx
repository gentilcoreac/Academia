<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/PaginaMaestro.Master" CodeFile="Comisiones.aspx.cs" Inherits="Web.Comisiones" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContentBase" runat="server">
	
	<asp:GridView ID="grdComisiones" CssClass="table" runat="server" AutoGenerateColumns="False" DataSourceID="odsComisiones">
		<Columns>
			<asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
			<asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
			<asp:BoundField DataField="AnioEspecialidad" HeaderText="Año Especialidad" SortExpression="AnioEspecialidad" />
			<asp:BoundField DataField="IDPlan" HeaderText="IDPlan" SortExpression="IDPlan" />
		</Columns>
	</asp:GridView>
	<asp:ObjectDataSource ID="odsComisiones" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.ComisionLogic"></asp:ObjectDataSource>
	
</asp:Content>