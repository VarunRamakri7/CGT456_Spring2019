<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calc1.aspx.cs" Inherits="Assignment3.calc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Container{
            width:700px;
            height:700px;
            border-radius:50px;
            background-color:lightblue;
        }
        #LabelBackground{
            width:700px;
            height:90px;
            position:relative;
            top:0px;
            left:0px;
            background-color:gray;
            border-top-left-radius:50px;
            border-top-right-radius:50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="Container">
            <div id="LabelBackground">

                <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 109px; top: 10px; position: absolute; width: 464px; margin-bottom: 0px;" Text="Single Digit Calculator" Font-Size="15pt" Font-Strikeout="False"></asp:Label>

            </div>
            <asp:TextBox ID="display" runat="server" Height="50px" style="z-index: 1; left: 71px; top: 146px; position: absolute" Width="300px"></asp:TextBox>
            
            <asp:Button ID="BtnClear" runat="server" Height="100px" style="z-index: 1; left: 443px; top: 122px; position: absolute" Text="C" Width="100px" OnClick="BtnClear_Click" />
            <asp:Button ID="Btn1" runat="server" Height="100px" style="z-index: 1; left: 52px; top: 482px; position: absolute" Text="1" Width="100px" OnClick="Btn1_Click" />
            <asp:Button ID="Btn2" runat="server" Height="100px" style="z-index: 1; left: 193px; top: 476px; position: absolute" Text="2" Width="100px" OnClick="Btn2_Click" />
            <asp:Button ID="Btn3" runat="server" Height="100px" style="z-index: 1; left: 327px; top: 473px; position: absolute" Text="3" Width="100px" OnClick="Btn3_Click" />
            <asp:Button ID="Btn4" runat="server" Height="100px" style="z-index: 1; left: 57px; top: 360px; position: absolute" Text="4" Width="100px" OnClick="Btn4_Click" />
            <asp:Button ID="Btn5" runat="server" Height="100px" style="z-index: 1; left: 195px; top: 359px; position: absolute; right: 812px;" Text="5" Width="100px" OnClick="Btn5_Click" />
            <asp:Button ID="Btn6" runat="server" Height="100px" style="z-index: 1; left: 328px; top: 359px; position: absolute" Text="6" Width="100px" OnClick="Btn6_Click" />
            <asp:Button ID="Btn7" runat="server" Height="100px" style="z-index: 1; left: 64px; top: 241px; position: absolute" Text="7" Width="100px" OnClick="Btn7_Click" />
            <asp:Button ID="Btn8" runat="server" Height="100px" style="z-index: 1; left: 191px; top: 238px; position: absolute" Text="8" Width="100px" OnClick="Btn8_Click" />
            <asp:Button ID="Btn9" runat="server" Height="100px" style="z-index: 1; left: 320px; top: 237px; position: absolute" Text="9" Width="100px" OnClick="Btn9_Click" />
            <asp:Button ID="Btn0" runat="server" Height="100px" style="z-index: 1; left: 54px; top: 595px; position: absolute" Text="0" Width="100px" OnClick="Btn0_Click" />
            <asp:Button ID="BtnDiv" runat="server" Height="100px" style="z-index: 1; left: 471px; top: 240px; position: absolute" Text="/" Width="100px" OnClick="BtnDiv_Click" />
            <asp:Button ID="BtnMult" runat="server" Height="100px" style="z-index: 1; left: 469px; top: 359px; position: absolute" Text="*" Width="100px" OnClick="BtnMult_Click" />
            <asp:Button ID="BtnAdd" runat="server" Height="100px" style="z-index: 1; left: 331px; top: 588px; position: absolute" Text="+" Width="100px" OnClick="BtnAdd_Click" />
            <asp:Button ID="BtnSubtract" runat="server" Height="100px" style="z-index: 1; left: 465px; top: 473px; position: absolute" Text="-" Width="100px" OnClick="BtnSubtract_Click" />
            <asp:Button ID="BtnEqual" runat="server" Height="100px" style="z-index: 1; left: 200px; top: 589px; position: absolute" Text="=" Width="100px" OnClick="BtnEqual_Click" />
               
        
        </div>
    </form>
</body>
</html>
