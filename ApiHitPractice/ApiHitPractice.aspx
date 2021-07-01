<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApiHitPractice.aspx.cs" Inherits="DotNetPractice.ApiHitPractice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" CssClass="tableCustomizer" runat="server" AutoGenerateColumns="false">
                 <Columns>  
                        <asp:BoundField DataField="id" HeaderText="S.No." />
                        <asp:BoundField DataField="name" HeaderText="Name" />
                        <asp:BoundField DataField="username" HeaderText="User Name" /> 
                     <asp:BoundField DataField="address.street" HeaderText="Street" /> 
                     <asp:BoundField DataField="address.suite" HeaderText="Suite" /> 
                     <asp:BoundField DataField="address.city" HeaderText="City" /> 
                     <asp:BoundField DataField="address.zipcode" HeaderText="Zipcode" /> 
                     <asp:BoundField DataField="address.geo.lat" HeaderText="lat" /> 
                     <asp:BoundField DataField="address.geo.lng" HeaderText="lng" /> 
                     <asp:BoundField DataField="phone" HeaderText="Phone" /> 
                     <asp:BoundField DataField="website" HeaderText="Website" /> 
                     <asp:BoundField DataField="company.name" HeaderText="Name" /> 
                     <asp:BoundField DataField="company.catchPhrase" HeaderText="catchPhrase" /> 
                     <asp:BoundField DataField="company.bs" HeaderText="BS" /> 
                  </Columns> 
            </asp:GridView>
        </div>
    </form>
</body>
</html>
