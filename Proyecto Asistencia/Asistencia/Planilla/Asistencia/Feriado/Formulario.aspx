<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="Asistencia.Presentacion.Feriado.Formulario"
MasterPageFile="~/Adm.Master" StylesheetTheme="Default"%>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label4" runat="server" Text="Registrar Feriados"></asp:Label>

    <form id="form1" runat="server">
        <center>
            <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
            </asp:ToolkitScriptManager>
            <table style="width: 400px; border: 1px">
                <tr>
                    <td align="right" style="width: 26px">
                        <asp:Label ID="Label1" runat="server" Text="Código"></asp:Label>
                    </td>
                    <td align="left" style="width: 26px">
                        <asp:TextBox ID="tCod" runat="server" Width="100px" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td  align="right">
                        <asp:Label ID="Label2" runat="server" Text="Descripción"></asp:Label>
                    </td>
                    <td  align="left">
                        <asp:TextBox ID="tDesc" runat="server" Width="200px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="tDesc" ErrorMessage="Requerido"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td align="right" style="width: 26px">
                        <asp:Label ID="Label3" runat="server" Text="Fecha"></asp:Label>
                    </td>
                    <td align="left" style="width: 26px">
                        
                        <asp:TextBox ID="tFecha" runat="server" Width="100px" ReadOnly="False"></asp:TextBox>
                        <asp:CalendarExtender ID="tFecha_CalendarExtender" runat="server" 
                            Format="dd/MM/yyyy" PopupButtonID="ibFI" PopupPosition="Right" 
                            TargetControlID="tFecha">
                        </asp:CalendarExtender>
                        <asp:ImageButton ID="ibFI" runat="server" CausesValidation="False" 
                            ImageUrl="~/imgs/calendar1.png" />
                    </td>
                </tr>
              
               
                <tr>
                    <td colspan="2" align="center">
                        <asp:LinkButton ID="lbGuardar" runat="server" Font-Overline="False" 
                            onclick="lbGuardar_Click" BorderStyle="Outset" Width="100px"> <asp:Image ID="Image1" runat="server" ImageUrl="~/imgs/action_add.png" />Guardar </asp:LinkButton>
                        <asp:LinkButton ID="lbVolver" runat="server" Font-Overline="false" 
                            BorderStyle="Outset" Width="100px" CausesValidation="False" 
                            PostBackUrl="Listado.aspx"> <asp:Image ID="Image2" runat="server" ImageUrl="~/imgs/arrow_back.png" />Volver </asp:LinkButton>
                    </td>
                </tr>

            </table>
        </center>
    </form>
</asp:Content>