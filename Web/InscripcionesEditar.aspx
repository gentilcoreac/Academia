<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/BasePaginaMaestra.Master" CodeBehind="InscripcionesEditar.aspx.cs" Inherits="Web.InscripcionesEditar" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContentBase">
	<table border="1">
		<tr>
			<td align="center" colspan="2" style="height: 21px">
				<asp:Label ID="lblTablaInscripcion" runat="server" Text="Datos Inscripcion"></asp:Label></td>
		</tr>
		<tr>
			<td style="width: 150px" align="right">
				ID Inscripcion: </td>
			<td class="auto-style2">
				<asp:Label ID="lblIdInscripcion" runat="server"></asp:Label></td>
		</tr>
		<tr>
			<td style="width: 150px" align="right">
				ID Alumno:</td>
			<td class="auto-style2">
				<asp:Label ID="lblIdAlumno" runat="server"></asp:Label></td>
		</tr>   
		<tr>
			<td style="width: 150px; height: 23px;" align="right">
				ID Curso:</td>
			<td class="auto-style1" style="height: 23px">
				<asp:Label ID="lblIdCurso" runat="server"></asp:Label></td>
		</tr>
		<tr>
			<td style="width: 150px" align="right">
				Condicion:</td>
			<td><asp:DropDownList ID="ddlCondicion" runat="server">
				</asp:DropDownList></td>

		</tr>
		<tr>
			<td style="width: 150px" align="right">
				Nota:</td>
			<td><asp:TextBox runat="server" ID="txtNota"></asp:TextBox></td>
		</tr>		
	</table>
	<div></div>
	<asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
	<asp:Button ID="btnCancelar" CssClass="btn btn-primary" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
</asp:Content>