<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Usuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="grdUsuarios" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="odsUsuarios" OnRowCommand="grdUsuarios_RowCommand" ShowFooter="True">
			<Columns>
				<asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
				<asp:TemplateField ConvertEmptyStringToNull="False" HeaderText="ID" SortExpression="ID">
					<EditItemTemplate>
						<asp:DynamicControl ID="DynamicControl1" runat="server" DataField="ID" Mode="Edit" />
					</EditItemTemplate>
					<FooterTemplate>
						<asp:Button ID="btnInsertar" runat="server" CommandName="Insertar" Text="Insertar" />
					</FooterTemplate>
					<ItemTemplate>
						<asp:DynamicControl ID="DynamicControl1" runat="server" DataField="ID" Mode="ReadOnly" />
					</ItemTemplate>
				</asp:TemplateField>
				<asp:TemplateField HeaderText="Nombre" SortExpression="Nombre">
					<EditItemTemplate>
						<asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Nombre") %>'></asp:TextBox>
					</EditItemTemplate>
					<FooterTemplate>
						<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
					</FooterTemplate>
					<ItemTemplate>
						<asp:Label ID="Label3" runat="server" Text='<%# Bind("Nombre") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>
				<asp:TemplateField HeaderText="Apellido" SortExpression="Apellido">
					<EditItemTemplate>
						<asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Apellido") %>'></asp:TextBox>
					</EditItemTemplate>
					<FooterTemplate>
						<asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
					</FooterTemplate>
					<ItemTemplate>
						<asp:Label ID="Label4" runat="server" Text='<%# Bind("Apellido") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>
				<asp:TemplateField HeaderText="Email" SortExpression="Email">
					<EditItemTemplate>
						<asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("Email") %>'></asp:TextBox>
					</EditItemTemplate>
					<FooterTemplate>
						<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
					</FooterTemplate>
					<ItemTemplate>
						<asp:Label ID="Label5" runat="server" Text='<%# Bind("Email") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>
				<asp:TemplateField HeaderText="Habilitado" SortExpression="Habilitado">
					<EditItemTemplate>
						<asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("Habilitado") %>' />
					</EditItemTemplate>
					<FooterTemplate>
						<asp:CheckBox ID="cbHabilitado" runat="server" />
					</FooterTemplate>
					<ItemTemplate>
						<asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("Habilitado") %>' Enabled="false" />
					</ItemTemplate>
				</asp:TemplateField>
			</Columns>
		</asp:GridView>
		<asp:ObjectDataSource ID="odsUsuarios" runat="server" DataObjectTypeName="Business.Entities.Usuario" DeleteMethod="Delete" SelectMethod="GetAll" TypeName="Business.Logic.UsuarioLogic" UpdateMethod="Save">
			<DeleteParameters>
				<asp:Parameter Name="id" Type="Int32" />
			</DeleteParameters>
		</asp:ObjectDataSource>
        <div>
        </div>
    </form>
</body>
</html>
