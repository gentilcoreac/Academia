<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/BasePaginaMaestra.Master" CodeFile="PersonasEditar.aspx.cs" Inherits="Web.PersonasEditar" %>

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
							<asp:Label ID="lblIdPersona" runat="server" type="number"></asp:Label>
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
							<asp:TextBox ID="txtTelefono" runat="server" type="number"></asp:TextBox></td>
					</tr>
					<tr>
						<td style="width: 225px">
							Fecha de Nacimiento:</td>
						<td class="auto-style2">
							<asp:TextBox ID="txtFechaNac" runat="server" type="date"></asp:TextBox></td>
					</tr>
					<tr>
						<td style="width: 225px">
							Email Personal:</td>
						<td>
							<asp:TextBox ID="txtEmailPersonal" runat="server" type="email"></asp:TextBox></td>
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
							<asp:Label ID="lblIdUsuario" runat="server" type="number"></asp:Label></td>
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
						<td style="width: 225px; height: 50px;">
							Confirmar Clave</td>
						<td style="height: 50px">
							<asp:TextBox ID="txtConfirmaClave" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td style="width: 225px; height: 50px;">
							Habilitado</td>
						<td style="height: 50px">

							<asp:CheckBox ID="cbHabilitado" runat="server" />

						</td>
					</tr>
					<tr>
						<td style="width: 225px; height: 50px;">
							Email Usuario:</td>
						<td style="height: 50px">
							<asp:TextBox ID="txtEmailUsuario" runat="server" type="email"></asp:TextBox></td>
					</tr>
				</table>
			</div>
			<div class="col-sm">
				<table class="table table-stripped" id="tblDatosInstitut">
					<tr>
						<td colspan="2" style="height: 50px">
							<asp:Label ID="lblDatosInstit" runat="server" Text="Datos institucionales"></asp:Label></td>
					</tr>
					<tr>
						<td style="width: 227px; height: 49px;">
							Legajo:</td>
						<td style="height: 49px">
							<asp:TextBox ID="txtLegajo" runat="server" type="number"></asp:TextBox></td>
					</tr>
					<tr>
						<td style="width: 227px; height: 50px;">
							Tipo de Persona:</td>
						<td style="height: 50px">
							<asp:DropDownList ID="ddlTipoPersona" runat="server">
							</asp:DropDownList>
						</td>
					</tr>
					<tr>
						<td style="width: 227px; height: 50px;">
							Plan:</td>
						<td style="height: 50px">
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
