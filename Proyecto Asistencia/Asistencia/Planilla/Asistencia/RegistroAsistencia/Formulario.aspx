<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="Asistencia.Presentacion.RegistroAsistencia.Formulario"
MasterPageFile="~/Adm.Master" StylesheetTheme="Default"%>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label2" runat="server" Text="Registrar Asistencia"></asp:Label>

    <form id="form1" runat="server">
<center>
            <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
            </asp:ToolkitScriptManager>
            <table style="width: 400px; border: 1px">
             <tr>
                    <td align="right">
                        
                    </td>
                    <td align="left">
                        <asp:TextBox ID="txCod" runat="server" Width="200px" Visible="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        <asp:Label ID="Label1" runat="server" Text="Empleado"></asp:Label>
                    </td>
                    <td align="left">
                        <asp:DropDownList ID="ddEmpleado" runat="server" Width="100%">
                        </asp:DropDownList>
                    </td>
                </tr>
               
                <tr>
                    <td align="right">
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
                    <td align="right">
                        <asp:Label ID="Label4" runat="server" Text="Hora"></asp:Label>
                    </td>
                    <td align="left" style="width: 26px">
                    <table>
                        <tr>
                            <td><asp:TextBox ID="tIH" runat="server" Width="20px"></asp:TextBox>
                            </td>
                            <td>:
                            </td>
                            <td><asp:TextBox ID="tIM" runat="server" Width="20px"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                    </td>
                </tr>
                 
                  <tr>
                    <td align="right" style="width: 26px">
                        <asp:Label ID="Label9" runat="server" Text="Evento"></asp:Label>
                    </td>
                    <td align="left" style="width: 26px">
                        
                        <asp:RadioButton ID="rbEntrada" runat="server" Checked="True" GroupName="gen" 
                            Text="Entrada" />
                        <asp:RadioButton ID="rbsalida" runat="server" GroupName="gen" Text="Salida" />
                    </td>
                </tr>

                <tr>
                    <td align="right">
                        <asp:Label ID="Label6" runat="server" Text="Tipo"></asp:Label>
                    </td>
                    <td align="left" style="width: 26px">
                        <asp:DropDownList ID="ddTipo" runat="server">
                            <asp:ListItem Value="1">Automatico</asp:ListItem>
                            <asp:ListItem Value="2">Manual</asp:ListItem>
                        </asp:DropDownList>
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