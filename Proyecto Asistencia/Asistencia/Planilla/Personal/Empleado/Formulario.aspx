<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="Personal.Presentacion.Empleado.Formulario"
MasterPageFile="~/Adm.Master" StylesheetTheme="Default"%>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label17" runat="server" Text="Registrar Empleado" ></asp:Label>


<body>
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
                        <asp:Label ID="Label2" runat="server" Text="CI"></asp:Label>
                    </td>
                    <td  align="left">
                        <asp:TextBox ID="tci" runat="server" Width="100px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="tci" ErrorMessage="Requerido"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td align="right" style="width: 26px">
                        <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>
                    </td>
                    <td align="left" style="width: 26px">
                        
                        <asp:TextBox ID="tnombre" runat="server" Width="100px"></asp:TextBox>
                    </td>
                </tr>
                
                 <tr>
                    <td align="right" style="width: 26px">
                        <asp:Label ID="Label6" runat="server" Text="APaterno"></asp:Label>
                    </td>
                    <td align="left" style="width: 26px">
                        
                        <asp:TextBox ID="tAPaterno" runat="server" Width="100px"></asp:TextBox>
                    </td>
                </tr>

                 <tr>
                    <td align="right" style="width: 26px">
                        <asp:Label ID="Label7" runat="server" Text="AMaterno"></asp:Label>
                    </td>
                    <td align="left" style="width: 26px">
                        
                        <asp:TextBox ID="tAMaterno" runat="server" Width="100px"></asp:TextBox>
                    </td>
                </tr>

                 <tr>
                    <td align="right" style="width: 26px">
                        <asp:Label ID="Label8" runat="server" Text="FechaNac"></asp:Label>
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
                    <td align="right" style="width: 26px">
                        <asp:Label ID="Label10" runat="server" Text="EstadoCivil"></asp:Label>
                    </td>
                    <td align="left" style="width: 26px">
                        
                        <asp:DropDownList ID="ddEstado" runat="server">
                            <asp:ListItem>Soltero</asp:ListItem>
                            <asp:ListItem>Casado</asp:ListItem>
                            <asp:ListItem>Divorciado</asp:ListItem>
                            <asp:ListItem>Viudo</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>

                 <tr>
                    <td align="right" style="width: 26px">
                        <asp:Label ID="Label11" runat="server" Text="Profesion"></asp:Label>
                    </td>
                    <td align="left" style="width: 26px">
                        
                        <asp:TextBox ID="tProfesion" runat="server" Width="100px"></asp:TextBox>
                    </td>
                </tr>

                 <tr>
                    <td align="right" style="width: 26px">
                        <asp:Label ID="Label12" runat="server" Text="Nacionalidad"></asp:Label>
                    </td>
                    <td align="left" style="width: 26px">
                        
                        <asp:TextBox ID="tNacionalidad" runat="server" Width="100px"></asp:TextBox>
                    </td>
                </tr>

                 <tr>
                    <td align="right" style="width: 26px">
                        <asp:Label ID="Label13" runat="server" Text="Tefono1"></asp:Label>
                    </td>
                    <td align="left" style="width: 26px">
                        
                        <asp:TextBox ID="tTelf1" runat="server" Width="100px"></asp:TextBox>
                    </td>
                </tr>

                 <tr>
                    <td align="right" style="width: 26px">
                        <asp:Label ID="Label14" runat="server" Text="telfInteno"></asp:Label>
                    </td>
                    <td align="left" style="width: 26px">
                        
                        <asp:TextBox ID="tTelfInterno" runat="server" Width="100px"></asp:TextBox>
                    </td>
                </tr>


                 <tr>
                    <td align="right" style="width: 26px">
                        <asp:Label ID="Label15" runat="server" Text="Direccion"></asp:Label>
                    </td>
                    <td align="left" style="width: 26px">
                        
                        <asp:TextBox ID="tdireccion" runat="server" Width="100px"></asp:TextBox>
                    </td>
                </tr>

                 <tr>
                    <td align="right" style="width: 26px">
                        <asp:Label ID="Label16" runat="server" Text="NroAsegurado"></asp:Label>
                    </td>
                    <td align="left" style="width: 26px">
                        
                        <asp:TextBox ID="tNroAsegurado" runat="server" Width="100px"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td align="right" style="width: 26px">
                        <asp:Label ID="Label4" runat="server" Text="NUA"></asp:Label>
                    </td>
                    <td align="left" style="width: 26px">
                        <asp:TextBox ID="tNUA" runat="server" Width="100px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" style="width: 26px">
                        <asp:Label ID="Label9" runat="server" Text="Genero"></asp:Label>
                    </td>
                    <td align="left" style="width: 26px">
                        
                        <asp:RadioButton ID="rbGenF" runat="server" Checked="True" GroupName="gen" 
                            Text="Femenino" />
                        <asp:RadioButton ID="rbGenM" runat="server" GroupName="gen" Text="Masculino" />
                    </td>
                </tr>
                 <tr>
                    <td  align="right">
                        <asp:Label ID="Label5" runat="server" Text="Estado"></asp:Label>
                    </td>
                    <td  align="left">
                        <asp:CheckBox ID="chActivo" runat="server" Text="Activo" Checked="True" />
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
