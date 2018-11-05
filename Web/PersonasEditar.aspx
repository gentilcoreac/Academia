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
						<td style="width: 225px">
							Id Persona: </td>
						<td>
							<asp:Label ID="lblIdPersona" runat="server"></asp:Label>
					</tr>
					<tr>
						<td style="width: 225px">
							Nombre:</td>
						<td>
							<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td style="width: 225px">
							Apellido:</td>
						<td>
							<asp:TextBox ID="txtApellido" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td style="width: 225px">
							Dirección:</td>
						<td>
							<asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td style="width: 225px">
							Teléfono:</td>
						<td>
							<asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td style="width: 225px">
							Fecha de Nacimiento:</td>
						<td class="auto-style2">
							<asp:TextBox ID="txtFechaNac" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td style="width: 225px">
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
						<td style="width: 225px">
							Id:</td>
						<td>
							<asp:Label ID="lblIdUsuario" runat="server"></asp:Label></td>
					</tr>
					<tr>
						<td style="width: 225px">
							Usuario:</td>
						<td>
							<asp:TextBox ID="txtNombreUsuario" runat="server" Text="Nombre Usuario: "></asp:TextBox></td>
					</tr>
					<tr>
						<td style="width: 225px">
							Clave:</td>
	                
						<td>
							<asp:TextBox ID="txtClave" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td style="width: 225px">
							Confirmar Clave</td>
						<td>
							<asp:TextBox ID="txtConfirmaClave" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td style="width: 225px">
							Habilitado</td>
						<td>

							<asp:CheckBox ID="cbHabilitado" runat="server" />

						</td>
					</tr>
					<tr>
						<td style="width: 225px">
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
						<td style="width: 227px">
							Legajo:</td>
						<td>
							<asp:TextBox ID="txtLegajo" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td style="width: 227px">
							Tipo de Persona:</td>
						<td>
							<asp:DropDownList ID="ddlTipoPersona" runat="server">
							</asp:DropDownList>
						</td>
					</tr>
					<tr>
						<td style="width: 227px">
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

	<asp:Button ID="btnGuardar" CssClass="btn btn-success" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
	<asp:Button ID="btnCancelar" CssClass="btn btn-secondary" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
</asp:Content>
