<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MateriasEditar.aspx.cs" MasterPageFile="~/PaginaMaestro.Master" Inherits="Web.MateriasEditar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContentBase" runat="server">
 <table class="table table-stripped" id="tblDatosPersona">
		<tr>
			<td align="center" colspan="2" style="height: 21px">
				<asp:Label ID="lblTablaMateria" runat="server" Text="Datos materia"></asp:Label></td>
		</tr>
		<tr>
			<td style="width: 150px; height: 47px;" align="right">
				Id Materia: </td>
			<td class="auto-style2" style="height: 47px">
				<asp:Label ID="lblIdMateria" runat="server"></asp:Label>
		</tr>
		<tr>
			<td style="width: 150px; height: 48px;" align="right">
				Descripción:</td>
			<td class="auto-style2" style="height: 48px">
				<asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox></td>
		</tr>
		<tr>
			<td style="width: 150px; height: 48px;" align="right">
				Horas semanales:</td>
			<td class="auto-style2" style="height: 48px">
				<asp:TextBox ID="txtHsSemanales" runat="server" type="number"></asp:TextBox></td>
		</tr>
		<tr>
			<td style="width: 150px; height: 49px;" align="right">
				Horas totales:</td>
			<td class="auto-style2" style="height: 49px">
				<asp:TextBox ID="txtHorasTotales" runat="server" type="number"></asp:TextBox></td>
		</tr>
		<tr>
			<td style="width: 150px; height: 49px;" align="right">
				Plan:</td>
			<td class="auto-style1" style="height: 49px">
				<asp:DropDownList ID="ddlPlan" runat="server">
				</asp:DropDownList>
			</td>

	</table>
	<div></div>
	<asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
	<asp:Button ID="btnCancelar" CssClass="btn btn-primary" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
</asp:Content>