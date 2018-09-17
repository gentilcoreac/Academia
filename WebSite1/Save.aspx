<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Save.aspx.cs" Inherits="Save" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="txt_Busqueda" runat="server"></asp:TextBox>
        <asp:Button ID="btn_Guardar" runat="server" OnClick="Button1_Click" Text="Guardar" />
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Read.aspx" Target="_self">Ver texto ingresado</asp:HyperLink>
        </div>
    </form>
</body>
</html>
