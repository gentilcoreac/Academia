<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/BasePaginaMaestra.Master" CodeFile="InscripcionesEditar.aspx.cs" Inherits="Web.InscripcionesEditar" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContentBase">
       <div class="container">
		<div class="row">
			<div class="col-sm">
				<table class="table table-stripped" id="tblDatosPersona" style="height: 187px">
					<tr>
						<td colspan="2" style="height: 41px">
							<asp:Label ID="lblTablaPersona" runat="server" Text="Datos personales"></asp:Label></td>
					</tr>
					<tr>
						<td style="width: 225px; height: 47px;">
							Id inscripcion: </td>
						<td style="height: 47px">
							<asp:Label ID="lblIdInscripcion" runat="server"></asp:Label>
					</tr>
					<tr>
						<td style="width: 225px">
							ID Alumno:</td>
						<td>
							<asp:TextBox ID="txtAlumno" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td style="width: 225px">
							ID Curso:</td>
						<td>
							<asp:TextBox ID="txtCurso" runat="server"></asp:TextBox></td>
					</tr>
                    <tr>
						<td style="width: 225px">
							Nota:</td>
						<td>
							<asp:TextBox ID="txtNota" runat="server" type="number"></asp:TextBox></td>
					</tr>
                    <tr>
						<td style="width: 225px">
							Condicion:</td>
						<td>
							<asp:TextBox ID="txtCondicion" runat="server"></asp:TextBox></td>
					</tr>
				</table>
			</div>

	<asp:Button ID="btnGuardar" CssClass="btn btn-success" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
	<asp:Button ID="btnCancelar" CssClass="btn btn-secondary" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
       </div>
</asp:Content>