<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Venda.aspx.cs" Inherits="Web.Venda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h4>&nbsp; </h4>
        <h1>Compre seu Carro!</h1>
    
    </div>
        <h5><span class="auto-style1">Marca:</span>&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="txtMarca" runat="server" Height="17px" Width="174px" OnSelectedIndexChanged="txtMarca_SelectedIndexChanged">
                <asp:ListItem>Honda</asp:ListItem>
                <asp:ListItem>Ford</asp:ListItem>
                <asp:ListItem>Chevrolet</asp:ListItem>
                <asp:ListItem>Volkswagen</asp:ListItem>
                <asp:ListItem>Fiat</asp:ListItem>
                <asp:ListItem>Toyota</asp:ListItem>
                <asp:ListItem>Hyundai</asp:ListItem>
            </asp:DropDownList>
        &nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Pesquisar" />
        </h5>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;&nbsp;
            <asp:GridView ID="GridCompra" AutoGenerateColumns="false" runat="server" Height="227px" style="margin-left: 52px; margin-top: 26px;" Width="743px" OnSelectedIndexChanged="GridCompra_SelectedIndexChanged">
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
                        <asp:Button Text="Comprar" CommandArgument='<%#Eval("id") %>' CommandName="Comprar" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>               
            </Columns>
        </asp:GridView>
        </p>
    </form>
</body>
</html>
