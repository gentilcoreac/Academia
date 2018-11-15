<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/PaginaMaestro.Master" CodeFile="CursosEditar.aspx.cs" Inherits="Web.CursosEditar" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContentBase">
	<div class="col-sm">
				<table class="table" id="tblDatosCursos">
		<tr>
			<td align="center" colspan="2" style="height: 21px">
				<asp:Label ID="lblTablaMateria" runat="server" Text="Datos Curso"></asp:Label></td>
		</tr>
		<tr>
			<td style="width: 150px; height: 34px;" align="right">
				ID Curso: </td>
			<td class="auto-style2" style="height: 34px">
				<asp:Label ID="lblIdCurso" runat="server"></asp:Label>
		</tr>
		<tr>
			<td style="width: 150px; height: 33px;" align="right">
				Año Calendario:</td>
			<td class="auto-style2" style="height: 23px">
				<asp:TextBox ID="txtAnioCalendario" runat="server" type="number"></asp:TextBox>
            </td>
		</tr>   
		<tr>
			<td style="width: 150px; height: 33px;" align="right">
				Cupo:</td>
			<td class="auto-style1" style="height: 23px" >
				<asp:TextBox ID="txtCupo" runat="server" type="number"></asp:TextBox>
			</td>
		</tr>
		<tr>
			<td style="width: 150px; height: 33px;" align="right">
				ComComision:</td>
			<td style="height: 33px"><asp:DropDownList ID="ddlComision" runat="server">
				</asp:DropDownList></td>

		</tr>
		<tr>
			<td style="width: 150px; height: 33px;" align="right">
				Materia:>
			<td style="height: 34px"><asp:DropDownList ID="ddlMateria" runat="server">
				</asp:DropDownList></td>
		</tr>		
	</table>
        </div>
	<div></div>
	<asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
	<asp:Button ID="btnCancelar" CssClass="btn btn-primary" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
</asp:Content>