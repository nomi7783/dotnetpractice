<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formValidator.aspx.cs" Inherits="DotNetPractice.formValidator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.4.1.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $(document).on("click", "#btnSubmit", function () {

                var bValid = true;

                var txtName = $("#txtName");
                var Label1 = $("#Label1");

                Label1.text("");

                if (txtName.val() == "") {
                    Label1.text("please enter your name");
                    Label1.css("color", "red");
                    bValid = false;
                }

                var txtCNIC = $("#txtCNIC");
                var Label2 = $("#Label2");

                Label2.text("");

                if (txtCNIC.val() == "") {
                    Label2.text("please enter your name");
                    bValid = false;
                }

                return bValid;
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" MaxLength="10"></asp:TextBox>
            <asp:Label ID="Label1" runat="server"></asp:Label>

            <br />
            <br />

            <asp:Label ID="lblCNIC" runat="server" Text="CNIC"></asp:Label>
            <asp:TextBox ID="txtCNIC" runat="server" MaxLength="13"></asp:TextBox>
            <asp:Label ID="Label2" runat="server"></asp:Label>

            <br />
            <br />

            <asp:Button ID="btnSubmit" runat="server" Text="Add" OnClick="btnSubmit_Click1" />


        </div>
    </form>
</body>
</html>
