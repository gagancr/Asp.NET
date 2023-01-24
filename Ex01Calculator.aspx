<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ex01Calculator.aspx.cs" Inherits="SampleWebApp.Ex01Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #FFFF99">
    <form id="form1" runat="server">
        <div>
            <h1 style="text-align: center; color: #FF0000">Calculator Program</h1>
            <hr />
            <p style="text-align: center"> 
                Enter The First Value:
                <asp:TextBox runat="server" ID="txtFirstVal" />
            </p>
            <p style="text-align: center"> 
                Select The Option:
                <asp:DropDownList runat="server" ID="dpList">
                    <asp:ListItem Text="Addition" />
                    <asp:ListItem Text="Subtraction" />
                    <asp:ListItem Text="Multiplication" />
                    <asp:ListItem Text="Division" />
                </asp:DropDownList>
            </p>
            <p style="text-align: center">
                Enter the Second Value:
                <asp:TextBox runat="server" ID="txtSecondVal"/>
            </p>
            <p>
                <asp:Button Text="Get Result" runat="server" ID="btnResult" OnClick="btnResult_Click" style="color: #000000; font-weight: 700; margin-left: 641px; background-color: #00CCFF" Width="237px" />

            </p>

            <p>
                <asp:Label Text="The Result" runat="server" ID="lblDisplay" />
            </p>
        </div>
    </form>
</body>
</html>
