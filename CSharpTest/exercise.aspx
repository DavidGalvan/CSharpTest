<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="exercise.aspx.cs" Inherits="CSharpTest.exercise" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:TextBox ID="TextBoxText" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonChangeText" runat="server" Text="Change Text" />
        <asp:Button ID="ButtonSendData" runat="server" Text="Send Data" />
    
    </div>
    </form>
</body>
</html>
