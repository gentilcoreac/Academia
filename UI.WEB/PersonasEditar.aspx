<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/PaginaMaestro.Master" CodeFile="PersonasEditar.aspx.cs" Inherits="Web.PersonasEditar" %>

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
							<asp:Label ID="lblIdPersona" runat="server" type="number" ></asp:Label>
					</tr>
					<tr>
						<td style="width: 225px">
							Nombre:</td>
						<td>
							<asp:TextBox ID="txtNombre" CssClass="form-control" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td style="width: 225px">
							Apellido:</td>
						<td>
							<asp:TextBox ID="txtApellido" CssClass="form-control" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td style="width: 225px">
							Dirección:</td>
						<td>
							<asp:TextBox ID="txtDireccion" CssClass="form-control" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td style="width: 225px">
							Teléfono:</td>
						<td>
							<asp:TextBox ID="txtTelefono" CssClass="form-control" runat="server" type="number"></asp:TextBox></td>
					</tr>
					<tr>
						<td style="width: 225px">
							Fecha de Nacimiento:</td>
						<td class="auto-style2">
							<asp:TextBox ID="txtFechaNac" CssClass="form-control" runat="server" type="date"></asp:TextBox></td>
					</tr>
					<tr>
						<td style="width: 225px">
							Email Personal:</td>
						<td>
							<asp:TextBox ID="txtEmailPersonal" CssClass="form-control" runat="server" type="email"></asp:TextBox></td>
					</tr>
				</table>
			</div>
			<div class="col-sm">
				<table class="table table-stripped" id="tblDatosSistema">
					<tr>
						<td colspan="2">
							<asp:Label ID="lblDatosSistema" runat="server" Text="Datos para el sistema"></asp:Label></td>
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
							<asp:TextBox ID="txtNombreUsuario" CssClass="form-control" runat="server" Text="Nombre Usuario: "></asp:TextBox></td>
					</tr>
					<tr>
						<td style="width: 225px">
							Clave:</td>
	                
						<td>
							<asp:TextBox ID="txtClave" CssClass="form-control" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td style="width: 225px; height: 50px;">
							Confirmar Clave</td>
						<td style="height: 50px">
							<asp:TextBox ID="txtConfirmaClave" CssClass="form-control" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td style="width: 225px; height: 50px;">
							Habilitado</td>
						<td style="height: 50px">

							<asp:CheckBox CssClass="form-check-input" ID="cbHabilitado" runat="server" />

						</td>
					</tr>
					<tr>
						<td style="width: 225px; height: 50px;">
							Email Usuario:</td>
						<td style="height: 50px">
							<asp:TextBox ID="txtEmailUsuario" CssClass="form-control" runat="server" type="email"></asp:TextBox></td>
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
							<asp:TextBox ID="txtLegajo" CssClass="form-control" runat="server" type="number"></asp:TextBox></td>
					</tr>
					<tr>
						<td style="width: 227px; height: 50px;">
							Tipo de Persona:</td>
						<td style="height: 50px">
							<asp:DropDownList ID="ddlTipoPersona" CssClass="form-control" runat="server">
							</asp:DropDownList>
						</td>
					</tr>
					<tr>
						<td style="width: 227px; height: 50px;">
							Plan:</td>
						<td style="height: 50px">
							<asp:DropDownList ID="ddlPlan" CssClass="form-control" runat="server" OnSelectedIndexChanged="ddlPlan_SelectedIndexChanged">
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
