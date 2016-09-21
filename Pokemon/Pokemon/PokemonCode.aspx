<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PokemonCode.aspx.cs" Inherits="Pokemon.PokemonCode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <table style="align-self: center">
           <tr><td>Pikachu</td><td><asp:TextBox runat="server" ID="PikachuQuantity" TextMode="Number"></asp:TextBox></td></tr>
           <tr><td>Squirtle</td><td><asp:TextBox runat="server" ID="SquirtleQuanity" TextMode="Number"></asp:TextBox></td></tr>
           <tr><td>Charmander</td><td><asp:TextBox runat="server" ID="CharmanderQuantity" TextMode="Number"></asp:TextBox></td></tr>
       </table>
        <asp:Button runat="server" ID="CalculateDiscount" Text="CalculateDiscount" OnClick="CalculateDiscount_Click" ></asp:Button>


    </div>
        <asp:Label ID="TotalPrice" runat="server"></asp:Label>
    </form>
</body>
</html>
