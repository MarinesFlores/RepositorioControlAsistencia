<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listado.aspx.cs" Inherits="Personal.Presentacion.Empleado.Listado" 
MasterPageFile="~/Adm.Master" StylesheetTheme="Default"%>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label2" runat="server" Text="Listado de empleados" ></asp:Label>

    <form id="form1" runat="server">
    <asp:HyperLink ID="hlNuevo" runat="server" 
        NavigateUrl="~/Personal/Empleado/Formulario.aspx" Font-Overline="False">
        <asp:Image ID="Image3" runat="server" ImageUrl="~/imgs/action_add.png" />Nuevo
      </asp:HyperLink>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    <asp:GridView ID="gvListado" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" EnableModelValidation="True" GridLines="Horizontal" 
        onrowcommand="gvListado_RowCommand" AllowSorting="True">
        <AlternatingRowStyle BackColor="#F7F7F7" />
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:HyperLink ID="hlMod" runat="server" 
                        NavigateUrl='<%# Eval("Id", "Formulario.aspx?id={0}") %>'>
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/imgs/reply.png" />
                    </asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Eliminar" CommandArgument='<%# Eval("Id") %>'>
                        <asp:Image ID="Image2" runat="server" ImageUrl="~/imgs/action_delete.png" />
                    </asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="id" HeaderText="Código" SortExpression="id">
            <ItemStyle HorizontalAlign="Center" Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="ci" HeaderText="ci">
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="nombre" HeaderText="Nombre" >
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="APaterno" HeaderText="APaterno" >
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="AMaterno" HeaderText="AMaterno" >
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="fechaNac" HeaderText="FechaNac" 
                DataFormatString="{0:dd/MM/yyyy}" >
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="Genero" HeaderText="Genero">
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="estadoCivil" HeaderText="estadoCivil" >
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="profesion" HeaderText="profesion" >
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="nacionalidad" HeaderText="nacionalidad" >
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="telefono1" HeaderText="telefono1" >
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="telefenoInterno" HeaderText="telefenoInterno" >
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="direccion" HeaderText="direccion" >
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="nroAsegurado" HeaderText="nroAsegurado" >
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="NUA" HeaderText="NUA" >
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>

            <asp:TemplateField HeaderText="Activo">
                <ItemTemplate>
<%--                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("activo") %>'></asp:Label>--%>
                    <asp:Image runat="server" ImageUrl='<%# defImagen((int)Eval("activo")) %>' 
                        ID="imgAct"></asp:Image>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>


        </Columns>
        <EmptyDataTemplate>
            <asp:Label ID="Label1" runat="server" Text="No hay datos"></asp:Label>
        </EmptyDataTemplate>
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
    </asp:GridView>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</asp:Content>
