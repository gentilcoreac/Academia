<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Personas.aspx.cs" Inherits="Web.Personas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
	<style type="text/css">
		.auto-style1 {
			width: 128px;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="grdPersonas" runat="server" DataSourceID="odsPersonas" OnRowCommand="grdPersonas_RowCommand" ShowFooter="True" OnSelectedIndexChanged="grdPersonas_SelectedIndexChanged" AutoGenerateColumns="False">
			<Columns>
				<asp:CommandField ShowEditButton="True" />
				<asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
				<asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
				<asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
				<asp:BoundField DataField="EmailPersonal" HeaderText="EmailPersonal" SortExpression="EmailPersonal" />
				<asp:BoundField DataField="FechaNacimiento" HeaderText="FechaNacimiento" SortExpression="FechaNacimiento" />
				<asp:BoundField DataField="Legajo" HeaderText="Legajo" SortExpression="Legajo" />
				<asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
				<asp:BoundField DataField="TiposPersona" HeaderText="TiposPersona" SortExpression="TiposPersona" />
				<asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
				<asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
			</Columns>
		</asp:GridView>
		<asp:ObjectDataSource ID="odsPersonas" runat="server" DataObjectTypeName="Business.Entities.Persona" DeleteMethod="Save" SelectMethod="GetAll" TypeName="Business.Logic.PersonaLogic" UpdateMethod="Save" InsertMethod="Save">
		</asp:ObjectDataSource>
        <div>
        </div>
	<table border="1">
		<tr>
			<td align="center" colspan="2">
				<asp:Label ID="lblTablaPersona" runat="server" Text="Datos personales"></asp:Label></td>
		</tr>
		<tr>
			<td style="width: 150px" align="right">
				Id Persona:o" runat="server"></asp:TextBox></td>
		</tr>
		<tr>
			<td style="width: 150px" align="right">
				Fecha de Nacimiento:</td>
			<td class="auto-style1">
				<asp:TextBox ID="txtFechaNac" runat="server"></asp:TextBox></td>
		</tr>
		<tr>
			<td style="width: 150px" align="right">
				Email Personal:</td>
			<td class="auto-style1">
				<asp:TextBox ID="txtEmailPersonal" runat="server"></asp:TextBox></td>
		</tr>
    </table>
	<table border="1">
		<tr>
			<td align="center" colspan="2">
				<asp:Label ID="lblDatosInstit" runat="server" Text="Datos institucionales"></asp:Label></td>
		</tr>
		<tr>
			<td style="width: 150px" align="right">
				Legajo:</td>
			<td class="auto-style1">
				<asp:TextBox ID="txtLegajo" runat="server"></asp:TextBox></td>
		</tr>
		<tr>
			<td style="width: 150px" align="right">
				Tipo de Persona:</td>
			<td class="auto-style1">
				<asp:TextBox ID="txtTipoPersona" runat="server"></asp:TextBox></td>
		</tr>
		<tr>
			<td style="width: 150px" align="right">
				Plan:</td>
			<td class="auto-style1">
				<asp:DropDownList ID="ddlPlan" runat="server">
				</asp:DropDownList>
			</td>
		</tr>
	</table>
	<table border="1">
		<tr>
			<td align="center" colspan="2">
				<asp:Label ID="Label1" runat="server" Text="Datos para el sistema"></asp:Label></td>
		</tr>
		<tr>
			<td style="width: 150px" align="right">
				Id:</td>
			<td>
				<asp:Label ID="lblIdUsuario" runat="server"></asp:Label></td>
		</tr>
		<tr>
			<td style="width: 150px" align="right">
				Usuario:</td>
			<td>
				<asp:TextBox ID="txtNombreUsuario" runat="server"></asp:TextBox></td>
		</tr>
		<tr>
			<td style="width: 150px" align="right">
				Clave:</td>
                
			<td>
				<asp:TextBox ID="txtClave" runat="server"></asp:TextBox></td>
		</tr>
		<tr>
			<td style="width: 150px" align="right">
				Confirmar Clave</td>
			<td>
				<asp:TextBox ID="txtConfirmaClave" runat="server"></asp:TextBox></td>
		</tr>
		<tr>
			<td style="width: 150px" align="right">
				Habilitado</td>
			<td>

				<asp:CheckBox ID="cbHabilitado" runat="server" />

			</td>
		</tr>
		<tr>
			<td style="width: 150px" align="right">
				Email Usuario:</td>
			<td>
				<asp:TextBox ID="txtEmailUsuario" runat="server"></asp:TextBox></td>
		</tr>
        <tr>
            <td style="width: 150px" align="center">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" /></td>
            <td align="center">
	             <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" /></td>
		</tr>
    </table>
    </form>
</body>
</html>