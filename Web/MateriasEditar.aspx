<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MateriasEditar.aspx.cs" MasterPageFile="~/BasePaginaMaestra.Master" Inherits="Web.MateriasEditar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContentBase" runat="server">
	<table border="1">
		<tr>
			<td align="center" colspan="2" style="height: 21px">
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

	</table>
	<div></div>
	<asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
	<asp:Button ID="btnCancelar" CssClass="btn btn-primary" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
</asp:Content>