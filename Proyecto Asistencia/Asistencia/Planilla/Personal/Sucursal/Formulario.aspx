<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="Personal.Presentacion.Sucursal.Formulario" 
MasterPageFile="~/Adm.Master" StylesheetTheme="Default"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label4" runat="server" Text="Registrar Sucursal" ></asp:Label>

    <form id="form1" runat="server">
        <center>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
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
                    <td  align="right">
                        <asp:Label ID="Label6" runat="server" Text="Estado"></asp:Label>
                    </td>
                    <td  align="left">
                        <asp:CheckBox ID="chActivo" runat="server" Text="Activo" Checked="True" />
                    </td>
                </tr>


                <%--<asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>--%>
                <tr>
                    <td colspan="2">
                        <asp:Panel ID="pHor1" runat="server" Visible="False">
                            <asp:Label ID="Label3" runat="server" Text="Feriado:" Font-Size="9pt"></asp:Label>
                            <asp:DropDownList ID="cbFeriado" runat="server">
                            </asp:DropDownList>
                            <asp:LinkButton ID="lbAddH" runat="server" ValidationGroup="gHor" 
                                onclick="lbAddH_Click">
                                <asp:Image ID="Image3" runat="server" ImageUrl="~/imgs/action_add.png" />
                            </asp:LinkButton>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Panel ID="pHor2" runat="server" Visible="False">

                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                            
                            
                            <asp:GridView ID="gvFeriado" runat="server" AutoGenerateColumns="False" 
                                BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" 
                                CellPadding="3" EnableModelValidation="True" GridLines="Horizontal" 
                                Width="80%" onrowcommand="gvHorario_RowCommand">
                                <AlternatingRowStyle BackColor="#F7F7F7" />
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lbElimC" runat="server" CommandName="EliminarC" CommandArgument='<%# Eval("Id") %>'>
                                                <asp:Image ID="Image4" runat="server" ImageUrl="~/imgs/action_delete.png" />
                                            
                                            </asp:LinkButton>
                                        </ItemTemplate>
                                        <ItemStyle Width="25px" />
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="Feriado" DataField="feriado" />
                                    <asp:BoundField HeaderText="Fecha" DataField="fecha" 
                                        DataFormatString="{0:dd/MMMM}">
                                    <ItemStyle Width="75px" />
                                    </asp:BoundField>
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
                <%--</ContentTemplate>
                </asp:UpdatePanel>--%>


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