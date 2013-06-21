<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioAdendas.aspx.cs" Inherits="Personal.Presentacion.Contrato.FormularioAdendas" 
MasterPageFile="~/Adm.Master" StylesheetTheme="Default"%>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label6" runat="server" Text="Registrar Adendas" ></asp:Label>

  <form id="form1" runat="server">
        <center>
            <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
            </asp:ToolkitScriptManager>
            <table style="width: 400px; border: 1px">
                
                <tr>
                    <td align="left" colspan="4">
                        <asp:Label ID="lbEmpleado" runat="server" Font-Bold="True" Text="Label"></asp:Label>
                        
                    </td>                    
                 </tr>

                 <tr>
                    <td align="right" colspan="2">
                        <asp:Label ID="Label3" runat="server" Text="Contrato"></asp:Label>
                    </td>
                    <td align="left" colspan="2">
                        <asp:TextBox ID="tcontrato" runat="server" Width="100px" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>


                
                <tr>
                    <td align="right" colspan="2">
                        <asp:Label ID="Label1" runat="server" Text="Código" Visible="False"></asp:Label>
                    </td>
                    <td align="left" colspan="2">
                        <asp:TextBox ID="tCod" runat="server" Width="100px" ReadOnly="True" 
                            Visible="False"></asp:TextBox>
                    </td>
                </tr>


                <tr>
                   <%-- <td  align="right">
                             &nbsp;</td>
                    <td class="style1">
                        &nbsp;</td>--%>
                   <td  align="right">
                            <asp:Label ID="Label9" runat="server" Text="Tipo Contrato"></asp:Label>
                    </td>
                    <td>
                    <asp:DropDownList ID="cbTContrato" runat="server" Width="100px">
                            </asp:DropDownList>
                    </td>
                </tr>

                 <tr>
                    <td  align="right">
                             <asp:Label ID="Label10" runat="server" Text="Cronograma"></asp:Label>
                    </td>
                    <td >
                     <asp:DropDownList ID="cbCornograma" runat="server" Width="100px">
                            </asp:DropDownList>
                    </td>
                   <td  align="right">
                            <asp:Label ID="Label11" runat="server" Text="Sucursal"></asp:Label>
                    </td>
                    <td>
                     <asp:DropDownList ID="cbSucusal" runat="server" Width="100px">
                            </asp:DropDownList>
                    </td>
                </tr>

                <tr>
                    <td  align="right" colspan="2">
                        <asp:Label ID="Label2" runat="server" Text="Fecha"></asp:Label>
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
                    <td  align="right" colspan="2">
                        <asp:Label ID="Label7" runat="server" Text="FechaFin"></asp:Label>
                    </td>
                   <td align="left" style="width: 26px">
                        <asp:TextBox ID="tFechaFin" runat="server" Width="100px"></asp:TextBox>
                        <asp:CalendarExtender ID="tFechaFin_CalendarExtender" runat="server" 
                            Format="dd/MM/yyyy" PopupButtonID="ibFF" PopupPosition="Right" 
                            TargetControlID="tFechaFin">
                        </asp:CalendarExtender>
                        <asp:ImageButton ID="ibFF" runat="server" CausesValidation="False" 
                            ImageUrl="~/imgs/calendar1.png" />
                    </td>
                </tr>

                <tr>
                    <td  align="right" colspan="2">
                        <asp:Label ID="Label4" runat="server" Text="Sueldo"></asp:Label>
                    </td>
                    <td  align="left" colspan="2">
                        <asp:TextBox ID="tsaldo" runat="server" Width="100px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="tSaldo" ErrorMessage="Requerido"></asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td  align="right" colspan="2">
                        <asp:Label ID="Label8" runat="server" Text="Estado"></asp:Label>
                    </td>
                    <td  align="left" colspan="2">
                        <asp:CheckBox ID="chActivo" runat="server" Text="Activo" Checked="True" />
                    </td>
                </tr>
<%--                <tr>
                    <td colspan="2">
                        &nbsp;</td>
                </tr>--%>
                
                <tr>
                    <td colspan="4" align="center">
                        &nbsp;<asp:LinkButton ID="lbGuardar" runat="server" Font-Overline="False" 
                            BorderStyle="Outset" Width="100px" onclick="lbGuardar_Click"> <asp:Image ID="Image1" runat="server" ImageUrl="~/imgs/action_add.png" />Guardar </asp:LinkButton>
                        <asp:LinkButton ID="lbVolver" runat="server" Font-Overline="false" 
                            BorderStyle="Outset" Width="100px" CausesValidation="False" 
                            PostBackUrl="Listado.aspx"> <asp:Image ID="Image2" runat="server" ImageUrl="~/imgs/arrow_back.png" />Volver </asp:LinkButton>
                    </td>
                </tr>
                
                  <tr>
                    <td align="center" colspan="4">
                        <asp:Panel ID="pHor2" runat="server" Visible="False">

                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                            
                            <asp:GridView ID="gvAdendas" runat="server" AutoGenerateColumns="False" 
                                BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" 
                                CellPadding="3" EnableModelValidation="True" GridLines="Horizontal" 
                                Width="80%" onrowcommand="gvHorario_RowCommand">
                                <AlternatingRowStyle BackColor="#F7F7F7" />
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lbElimC" runat="server" CommandName="EliminarC" 
                                                CommandArgument='<%# Eval("Id") %>' CausesValidation="False">
                                                <asp:Image ID="Image4" runat="server" ImageUrl="~/imgs/action_delete.png" />
                                            
                                            </asp:LinkButton>
                                        </ItemTemplate>
                                        <ItemStyle Width="25px" />
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="Id" DataField="id" >
                                        <ItemStyle HorizontalAlign="Center" Width="50%" />
                                    </asp:BoundField>
                                    <asp:BoundField HeaderText="FechaFin" DataField="FechaFin" 
                                        DataFormatString="{0:dd/MM/yyyy}">
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="salario" HeaderText="Salario" >
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="fecha" HeaderText="Fecha" 
                                        DataFormatString="{0:dd/MM/yyyy}" >
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="idContrato" HeaderText="Contrato" >
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="TipoContrato" HeaderText="TipoContrato" >
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Cronograma" HeaderText="Cronograma" >
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Sucursal" HeaderText="Sucursal" >
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                   
                                   <asp:TemplateField HeaderText="Activo">
                                   <ItemTemplate>
                                   <asp:Image runat="server" ImageUrl='<%# defImagen((int)Eval("activo")) %>' 
                                        ID="imgAct"></asp:Image>
                                   </ItemTemplate>
                                   <ItemStyle HorizontalAlign="Center" />
                                   </asp:TemplateField>

                                </Columns>
                                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                            </asp:GridView>

                            </ContentTemplate>
                            </asp:UpdatePanel>
                        </asp:Panel>
                    </td>
                </tr>

            </table>
        </center>
    </form>
</asp:Content>