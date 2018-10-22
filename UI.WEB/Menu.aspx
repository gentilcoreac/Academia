<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Menu.aspx.cs" Inherits="Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <asp:Label ID="usrLogueado" runat="server" Text="usuarioLogueado"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="Perfil" runat="server">Pefil</asp:HyperLink>
        <br />
        <asp:HyperLink ID="Examenes" runat="server">Examenes</asp:HyperLink>
        <br />
        <asp:HyperLink ID="Cursos" runat="server">Mis cursos</asp:HyperLink>
    </form>

</body>
</html>