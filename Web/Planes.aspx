<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/BasePaginaMaestra.Master" CodeBehind="Planes.aspx.cs" Inherits="Web.Planes" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContentBase" runat="server">
        <asp:GridView ID="grdPlanes"  CssClass="table" runat="server" DataSourceID="odsPlanes" OnRowCommand="grdPlanes_RowCommand" ShowFooter="True" OnSelectedIndexChanged="grdPlanes_SelectedIndexChanged" AutoGenerateColumns="False">
			<Columns>
				<asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
				<asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
				<asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
			</Columns>
		</asp:GridView>
		<asp:ObjectDataSource ID="odsPlanes" runat="server" DataObjectTypeName="Business.Entities.Plan" DeleteMethod="Delete" SelectMethod="GetAll" TypeName="Business.Logic.PlanLogic" UpdateMethod="Save" InsertMethod="Save">
		</asp:ObjectDataSource>
</asp:Content>