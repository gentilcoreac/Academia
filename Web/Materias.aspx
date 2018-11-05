<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/BasePaginaMaestra.Master" CodeBehind="Materias.aspx.cs" Inherits="Web.Materias" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContentBase" runat="server">
        <asp:GridView ID="grdMaterias"  CssClass="table"  runat="server" DataSourceID="odsMaterias" OnRowCommand="grdMaterias_RowCommand" ShowFooter="True" AutoGenerateColumns="False">
			<Columns>
				<asp:CommandField ShowEditButton="True" />
				<asp:CommandField ShowDeleteButton="True" />
				<asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
				<asp:BoundField DataField="HSSemanales" HeaderText="HSSemanales" SortExpression="HSSemanales" />
				<asp:BoundField DataField="HSTotales" HeaderText="HSTotales" SortExpression="HSTotales" />
				<asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
				<asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
			</Columns>
		</asp:GridView>
		<asp:ObjectDataSource ID="odsMaterias" runat="server" DataObjectTypeName="Business.Entities.Materia" DeleteMethod="Delete" SelectMethod="GetAll" TypeName="Business.Logic.MateriaLogic" UpdateMethod="Save" InsertMethod="Save">
		</asp:ObjectDataSource>
        <div>
        </div>
	<table border="1">
		<tr>
			<td align="center" colspan="2">
				<asp:Label ID="lblTablaMateria" runat="server" Text="Datos materia"></asp:Label></td>
		</tr>
		<tr>
			<td style="width: 150px" align="right">
				Id Materia: </td>
			<td class="auto-style2">
				<asp:Label ID="lblIdMateria" runat="server"></asp:Label>
		</tr>
		<tr>
			<td style="width: 150px" align="right">
				Descripción:</td>
			<td class="auto-style2">
				<asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox></td>
		</tr>
		<tr>
			<td style="width: 150px" align="right">
				Horas semanales:</td>
			<td class="auto-style2">
				<asp:TextBox ID="txtHsSemanales" runat="server"></asp:TextBox></td>
		</tr>
		<tr>
			<td style="width: 150px" align="right">
				Horas totales:</td>
			<td class="auto-style2">
				<asp:TextBox ID="txtHorasTotales" runat="server"></asp:TextBox></td>
		</tr>
		<tr>
			<td style="width: 150px" align="right">
				Plan:</td>
			<td class="auto-style1">
				<asp:DropDownList ID="ddlPlan" runat="server">
				</asp:DropDownList>
			</td>
		</tr>
	</table>
</asp:Content>