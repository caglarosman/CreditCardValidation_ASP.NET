<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreditCardValidation.aspx.cs" Inherits="CreditCardValidation.CreditCardValidation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="float:left;"><asp:Panel ID="PanelCreditCardValidation" runat="server" BackColor="WhiteSmoke" Height="330px" Width="250px" Font-Bold="False" BorderStyle="Solid" BorderWidth="2px">
            <div style="margin: 20px 0 0 0; padding-left: 20px; padding-top: 10px">
                <asp:Label ID="LabelPaymentDetails" runat="server" Text="Payment details" ForeColor="#C2BABA"></asp:Label>
            </div>
            <div style="margin: 0 0 0 20px">
                <img alt="" src="img/visa.png" style="height: 40px;" />
                <img alt="" src="img/visa-electron.png" style="height: 40px;" />
                <img alt="" src="img/mastercard.png" style="height: 22px; padding-bottom: 9px" />
                <img alt="" src="img/maestro.png" style="height: 40px;" />
                <img alt="" src="img/discover.png" style="height: 27px; padding-bottom: 5px" />
            </div>
            <div style="margin: 0 0 5px 0; padding-left: 20px; padding-top: 5px">
                <asp:Label ID="LabelCardNumber" runat="server" Text="Card number" ForeColor="#C2BABA"></asp:Label>
                <div style="margin: 0 0 5px 0; padding-top: 5px">
                    <div style="float:left;"><asp:TextBox ID="TextBoxCardNumber" runat="server" Width="170px" MaxLength="19" OnTextChanged="TextBoxCardNumber_TextChanged" AutoPostBack="True" BorderStyle="Solid"></asp:TextBox></div>
                   <div style="margin: 1px 0 0 0; float:left;"><img ID="ImageBoxCardType" runat="server" alt="" src="" style="height: 25px; width: 30px; margin: 0px 0 0 10px; border-style:none;" visible="false"/></div>
                </div>
            </div>
            <div style="margin: 0 0 5px 0; padding-left: 20px; padding-top: 5px; float:left">
                <asp:Label ID="LabelExpiryDate" runat="server" Text="Expiry date " ForeColor="#C2BABA"></asp:Label>
                <asp:Label ID="LabelMMYY" runat="server" Text="MM/YY" ForeColor="#C2BABA" Font-Size="XX-Small"></asp:Label>
                <div style="margin: 0 0 5px 0; padding-top: 5px">
                    <asp:TextBox ID="TextBoxExpiryDate" runat="server" Width="135px" MaxLength="50" ToolTip="MM/YY" TextMode="Month" BorderStyle="Solid" OnTextChanged="TextBoxExpiryDate_TextChanged"  AutoPostBack="True"></asp:TextBox>
                </div>
            </div>
            <div style="margin: 0 0 5px 5px; padding-left: 20px; padding-top: 5px; float:left">
                <div style="text-align:right"><asp:Label ID="LabelCVV" runat="server" Text="CVV" ForeColor="#C2BABA"></asp:Label></div>
                <div style="margin: 0 0 5px -20px; padding-top: 5px; text-align:right">
                    <asp:TextBox ID="TextBoxCVV" runat="server" Width="55px" TextMode="SingleLine" MaxLength="3" BorderStyle="Solid" AutoPostBack="True" OnTextChanged="TextBoxCVV_TextChanged"></asp:TextBox>
                </div>
            </div>

            <div style="margin: 0px 0 5px 0; padding-left: 20px; padding-top: 5px; float:left">
                <asp:Label ID="LabelNameOnCard" runat="server" Text="Name on card" ForeColor="#C2BABA"></asp:Label>
                <div style="margin: 0 0 5px 0; padding-top: 5px">
                    <asp:TextBox ID="TextBoxNameOnCard" runat="server" Width="200px" BorderStyle="Solid" AutoPostBack="True" OnTextChanged="TextBoxNameOnCard_TextChanged"></asp:TextBox>
                    <div style="margin:20px 0 0 40px"><asp:Button ID="ButtonSubmit" runat="server" Height="25px" Text="Submit" Width="130px" OnClick="ButtonSubmit_Click" /></div>
                </div>
            </div>


        </asp:Panel></div>
        <div ID="PaymentResult" runat="server" style="width:550px; height:250px; float:left; margin:70px 0 0 50px; visibility:hidden">
            <img src="img/checked.png" width="100px" style="float:left"/>
            <span style="float: left; padding: 50px 0 50px 50px; font:bold 20px arial; width: 400px;">Ödeme işlemi başarıyla gerçekleştirildi!</span>
        </div>
    </form>
</body>
</html>
