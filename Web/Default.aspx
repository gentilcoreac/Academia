<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/BasePaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContentBase" runat="server">


        <div class="col-md-4">
            <h2>Academia - Gestión para <%((Business.Entities.Usuario)Session["usuarioLogueado"]).IDPersona.TiposPersona.ToString() ; %> </h2> 
            <p>
                Sistema de gestión del alumno de Universidad Tecnológica Nacional Facultad Regional Rosario
            </p>
        </div>

</asp:Content>
