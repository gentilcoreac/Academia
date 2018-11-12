<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/BasePaginaMaestra.Master" CodeFile="Materias.aspx.cs" Inherits="Web.Materias" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContentBase" runat="server">
		<asp:GridView ID="grdMaterias" CssClass="table" runat="server" DataSourceID="odsMaterias" OnRowCommand="grdMaterias_RowCommand" OnSelectedIndexChanged="grdMaterias_SelectedIndexChanged" AutoGenerateColumns="False">
			<Columns>
				<asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="~/MateriasEditar.aspx?id={0}" Text="Editar" />
				<asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
				<asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
				<asp:BoundField DataField="HSSemanales" HeaderText="Horas Semanales" SortExpression="HSSemanales" />
				<asp:BoundField DataField="HSTotales" HeaderText="Horas Totales" SortExpression="HSTotales" />
				<asp:BoundField DataField="Plan" HeaderText="Plan" SortExpression="Plan" />
			</Columns>
		</asp:GridView>
        <div>
        	<asp:ObjectDataSource ID="odsMaterias" runat="server" DataObjectTypeName="Business.Entities.Materia" DeleteMethod="Delete" InsertMethod="Save" SelectMethod="GetAll" TypeName="Business.Logic.MateriaLogic" UpdateMethod="Save"></asp:ObjectDataSource>
        </div>

	<asp:Button ID="btnNuevo" CssClass="btn btn-primary" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" />
</asp:Content>