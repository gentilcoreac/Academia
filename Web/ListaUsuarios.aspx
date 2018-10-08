<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListaUsuarios.aspx.cs" Inherits="Web.ListaUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="grdUsuarios" runat="server" AutoGenerateColumns="False" DataSourceID="odsUsuarios" OnRowCommand="grdUsuarios_RowCommand" ShowFooter="True" OnSelectedIndexChanged="grdUsuarios_SelectedIndexChanged">
			<Columns>
				<asp:CommandField ShowDeleteButton="True" ShowEditButton="True"></asp:CommandField>
				<asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
				<asp:BoundField DataField="NombreUsuario" HeaderText="NombreUsuario" SortExpression="NombreUsuario" />
				<asp:BoundField DataField="Clave" HeaderText="Clave" SortExpression="Clave" />
				<asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
				<asp:CheckBoxField DataField="Habilitado" HeaderText="Habilitado" SortExpression="Habilitado" />
			</Columns>
		</asp:GridView>
		<asp:ObjectDataSource ID="odsUsuarios" runat="server" DataObjectTypeName="Business.Entities.Usuario" DeleteMethod="Delete" SelectMethod="GetAll" TypeName="Business.Logic.UsuarioLogic" UpdateMethod="Save" InsertMethod="Save">
			<DeleteParameters>
				<asp:Parameter Name="id" Type="Int32" />
			</DeleteParameters>
		</asp:ObjectDataSource>
        <div>
        </div>
    </form>
</body>
</html>