<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="IntroductionWebApp.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:Table ID="Table1" runat="server">
           <

        </asp:Table>

        <asp:Label runat="server" ID="Label1">First Number:</asp:Label>
        <asp:TextBox runat="server" ID="firstNumberTextBox" Width="152px"></asp:TextBox>
        <br/>
        <asp:Label runat="server" ID="Label2">Second Number:</asp:Label>
        <asp:TextBox runat="server" ID="secondNumberTextBox" Width="130px"></asp:TextBox>
        
        <br/>
        
        <asp:Label runat="server" ID="Label3">Result:</asp:Label>
        <asp:TextBox runat="server" ID="resultTextBox"></asp:TextBox>
        <br/>
        <asp:Button runat="server" ID="addButton" Text="Add"  Width="80" OnClick="addButton_OnClick"/>
        
        <asp:Button runat="server" ID="subtractButton" Text="Subtract" Width="80" OnClick="subtractButton_OnClick"/>
        
        <asp:Button runat="server" ID="multiplyButton" Text="Multiply" Width="80" OnClick="multiplyButton_OnClick_" />

        
        <asp:Button runat="server" ID="divisionButton" Text="Division" Width="80" OnClick="divisionButton_OnClick"/>

        
       </div>
    </form>
</body>
</html>
