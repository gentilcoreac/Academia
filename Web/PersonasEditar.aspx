<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/BasePaginaMaestra.Master" CodeBehind="PersonasEditar.aspx.cs" Inherits="Web.PersonasEditar" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContentBase">
	<div class="container">
		<div class="row">
			<div class="col-sm">
				<table class="table table-stripped" id="tblDatosPersona">
					<tr>
						<td colspan="2">
							<asp:Label ID="lblTablaPersona" runat="server" Text="Datos personales"></asp:Label></td>
					</tr>
					<tr>
						<td>
							Id Persona: </td>
						<td>
							<asp:Label ID="lblIdPersona" runat="server"></asp:Label>
					</tr>
					<tr>
						<td>
							Nombre:</td>
						<td>
							<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td>
							Apellido:</td>
						<td>
							<asp:TextBox ID="txtApellido" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td>
							Dirección:</td>
						<td>
							<asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td>
							Teléfono:</td>
						<td>
							<asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td>
							Fecha de Nacimiento:</td>
						<td class="auto-style2">
							<asp:TextBox ID="txtFechaNac" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td>
							Email Personal:</td>
						<td>
							<asp:TextBox ID="txtEmailPersonal" runat="server"></asp:TextBox></td>
					</tr>
				</table>
			</div>
			<div class="col-sm">
				<table class="table table-stripped" id="tblDatosSistema">
					<tr>
						<td colspan="2">
							<asp:Label ID="Label1" runat="server" Text="Datos para el sistema"></asp:Label></td>
					</tr>
					<tr>
						<td>
							Id:</td>
						<td>
							<asp:Label ID="lblIdUsuario" runat="server"></asp:Label></td>
					</tr>
					<tr>
						<td>
							Usuario:</td>
						<td>
							<asp:TextBox ID="txtNombreUsuario" runat="server" Text="Nombre Usuario: "></asp:TextBox></td>
					</tr>
					<tr>
						<td>
							Clave:</td>
	                
						<td>
							<asp:TextBox ID="txtClave" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td>
							Confirmar Clave</td>
						<td>
							<asp:TextBox ID="txtConfirmaClave" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td>
							Habilitado</td>
						<td>

							<asp:CheckBox ID="cbHabilitado" runat="server" />

						</td>
					</tr>
					<tr>
						<td>
							Email Usuario:</td>
						<td>
							<asp:TextBox ID="txtEmailUsuario" runat="server"></asp:TextBox></td>
					</tr>
				</table>
			</div>
			<div class="col-sm">
				<table class="table table-stripped" id="tblDatosInstitut">
					<tr>
						<td colspan="2">
							<asp:Label ID="lblDatosInstit" runat="server" Text="Datos institucionales"></asp:Label></td>
					</tr>
					<tr>
						<td>
							Legajo:</td>
						<td>
							<asp:TextBox ID="txtLegajo" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td>
							Tipo de Persona:</td>
						<td>
							<asp:DropDownList ID="ddlTipoPersona" runat="server">
							</asp:DropDownList>
						</td>
					</tr>
					<tr>
						<td>
							Plan:</td>
						<td>
							<asp:DropDownList ID="ddlPlan" runat="server">
							</asp:DropDownList>
						</td>
					</tr>
				</table>
			</div>
		</div>
	</div>

	<asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
	<asp:Button ID="btnCancelar" CssClass="btn btn-primary" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
</asp:Content>
