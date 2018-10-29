<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/BasePaginaMaestra.Master" CodeBehind="Personas.aspx.cs" Inherits="Web.Personas" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContentBase" runat="server">
        <asp:GridView ID="grdPersonas" CssClass="table" runat="server" DataSourceID="odsPersonas" OnRowCommand="grdPersonas_RowCommand" ShowFooter="True" OnSelectedIndexChanged="grdPersonas_SelectedIndexChanged">
			<Columns>
				<asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="Personas.aspx?id={0}" Text="Editar" />
			</Columns>
		</asp:GridView>
		<asp:ObjectDataSource ID="odsPersonas" runat="server" DataObjectTypeName="Business.Entities.Persona" DeleteMethod="Save" SelectMethod="GetAll" TypeName="Business.Logic.PersonaLogic" UpdateMethod="Save" InsertMethod="Save">
		</asp:ObjectDataSource>
        <div>
        </div>

	<div class="form-group">
		<label for="inputIdPersona">Id Persona</label>
		<input type="text" class="form-control" id="inputIdPersona" />
	</div>
	<div class="form-group">
		<label for="inputNombre">Nombre</label>
		<input type="text" class="form-control" id="inputNombre" />
	</div>
	<div class="form-group">
		<label for="inputApellido">Apellido</label>
		<input type="text" class="form-control" id="inputApellido" />
	</div>
	<div class="form-group">
		<label for="inputDireccion">Direccion</label>
		<input type="text" class="form-control" id="inputDireccion" />
	</div>
	
	
	<table class="table table-stripped" style="float: left">
		<tr>
			<td colspan="2">
				<asp:Label ID="lblTablaPersona" runat="server" Text="Datos personales"></asp:Label></td>
		</tr>
		<tr>
			<td style="width: 353px">
				Id Persona: </td>
			<td>
				<asp:Label ID="lblIdPersona" runat="server"></asp:Label>
		</tr>
		<tr>
			<td style="width: 353px">
				Nombre:</td>
			<td>
				<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></td>
		</tr>
		<tr>
			<td style="width: 353px">
				Apellido:</td>
			<td>
				<asp:TextBox ID="txtApellido" runat="server"></asp:TextBox></td>
		</tr>
		<tr>
			<td style="width: 353px">
				Dirección:</td>
			<td>
				<asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox></td>
		</tr>
		<tr>
			<td style="width: 353px">
				Teléfono:</td>
			<td>
				<asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox></td>
		</tr>
		<tr>
			<td style="width: 353px">
				Fecha de Nacimiento:</td>
			<td class="auto-style2">
				<asp:TextBox ID="txtFechaNac" runat="server"></asp:TextBox></td>
		</tr>
		<tr>
			<td style="width: 353px">
				Email Personal:</td>
			<td>
				<asp:TextBox ID="txtEmailPersonal" runat="server"></asp:TextBox></td>
		</tr>
    </table>
	<table class="table table-stripped" style="float: left">
		<tr>
			<td colspan="2">
				<asp:Label ID="lblDatosInstit" runat="server" Text="Datos institucionales"></asp:Label></td>
		</tr>
		<tr>
			<td style="width: 355px">
				Legajo:</td>
			<td>
				<asp:TextBox ID="txtLegajo" runat="server"></asp:TextBox></td>
		</tr>
		<tr>
			<td style="width: 355px">
				Tipo de Persona:</td>
			<td>
				<asp:DropDownList ID="ddlTipoPersona" runat="server">
				</asp:DropDownList>
			</td>
		</tr>
		<tr>
			<td style="width: 355px">
				Plan:</td>
			<td>
				<asp:DropDownList ID="ddlPlan" runat="server">
				</asp:DropDownList>
			</td>
		</tr>
	</table>
	<table class="table table-stripped" style="float: left">
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
				<asp:TextBox ID="txtNombreUsuario" runat="server"></asp:TextBox></td>
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
        <tr>
            <td>
                <asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardar_Click" /></td>
            <td>
	            <asp:Button ID="btnCancelar" CssClass="btn btn-primary" runat="server" Text="Cancelar" /></td>
		</tr>
    </table>
</asp:Content>