<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuscaAuto.aspx.cs" Inherits="Web.BuscaAuto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h4 style="margin-left: 280px">
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Venda</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Atualizar Automoveis</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">Cadastrar Automoveis</asp:LinkButton>
        </h4>
        <h1 style="margin-left: 280px">Busca de Automoveis</h1>
    
    </div>
        <h3>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Marca:&nbsp;
            <asp:DropDownList ID="txtMarca" runat="server" Height="16px" Width="209px">
                <asp:ListItem>Honda</asp:ListItem>
                <asp:ListItem>Ford</asp:ListItem>
                <asp:ListItem>Chevrolet</asp:ListItem>
                <asp:ListItem>Volkswagen</asp:ListItem>
                <asp:ListItem>Fiat</asp:ListItem>
                <asp:ListItem>Toyota</asp:ListItem>
                <asp:ListItem>Hyundai</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Buscar" Width="119px" OnClick="Button1_Click" style="height: 26px" />
        </h3>
        <asp:GridView ID="GridAuto" OnRowCommand="GridAuto_RowCommand" AutoGenerateColumns="false" runat="server" Height="227px" style="margin-left: 52px; margin-top: 26px;" Width="743px">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" />
            </Columns>
            <Columns>
                <asp:BoundField DataField="Marca" HeaderText="Marca" />
            </Columns>

            <Columns>
                <asp:BoundField DataField="Modelo" HeaderText="Modelo" />
            </Columns>

            <Columns>
                <asp:BoundField DataField="Ano" HeaderText="Ano" />
            </Columns>

            <Columns>
                <asp:BoundField DataField="Cor" HeaderText="Cor" />
            </Columns>

            <Columns>
                <asp:BoundField DataField="Chassi" HeaderText="Chassi" />
            </Columns>

            <Columns>
                <asp:BoundField DataField="Preco" HeaderText="Preco" />
            </Columns>
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button Text="Excluir" CommandArgument='<%#Eval("id") %>' CommandName="Apagar" runat="server" />
                        <asp:Button Text="Editar" CommandArgument='<%#Eval("id") %>' CommandName="Editar" runat ="server" />
                    </ItemTemplate>
                </asp:TemplateField>               
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
