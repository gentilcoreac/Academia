<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Save.aspx.cs" Inherits="Web.Save" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
			<asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
        </div>
    	<asp:HyperLink ID="hlVerTexto" runat="server" NavigateUrl="~/Read.aspx" Target="_self">Ver texto ingresado</asp:HyperLink>
    </form>
</body>
</html>
