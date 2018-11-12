<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListaUsuarios.aspx.cs" Inherits="Web.ListaUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="grdUsuarios" runat="server" DataSourceID="odsUsuarios" OnRowCommand="grdUsuarios_RowCommand" ShowFooter="True" OnSelectedIndexChanged="grdUsuarios_SelectedIndexChanged">
			<Columns>
				<asp:CommandField ShowDeleteButton="True" />
				<asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="ListaUsuarios.aspx?id={0}" Text="Editar" />
			</Columns>
		</asp:GridView>
		<asp:ObjectDataSource ID="odsUsuarios" runat="server" DataObjectTypeName="Business.Entities.Usuario" DeleteMethod="Save" SelectMethod="GetAll" TypeName="Business.Logic.UsuarioLogic" UpdateMethod="Save" InsertMethod="Save">
		</asp:ObjectDataSource>
        <div>
        </div>
	<table border="1">
		<tr>
			<td align="center" colspan="2">
				<asp:Label ID="lblAccion" runat="server" Text="Label"></asp:Label></td>
		</tr>
		<tr>
			<td style="width: 150px" align="right">
				Id:</td>
			<td>
				<asp:Label ID="lblId" runat="server"></asp:Label></td>
		</tr>
		<tr>
			<td style="width: 150px" align="right">
				Usuario:</td>
			<td>
				<asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox></td>
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
				Email:</td>
			<td>
				<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
		</tr>
		<tr>
			<td style="width": 150px align="right">
				Id Persona:</td>
			<td>
				<asp:TextBox ID="txtIdPersona" runat="server"></asp:TextBox>
			</td>
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