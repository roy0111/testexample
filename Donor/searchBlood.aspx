<%@ Page Title="Search" Language="C#" MasterPageFile="~/Donor/donorMasterPage.Master" AutoEventWireup="true" CodeBehind="searchBlood.aspx.cs" Inherits="BloodBankWithUnitTesting.Donor.searchBlood" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            text-align: center;
        }
        .auto-style5 {
            color: #1e2123;
            border-color: #c8c9cb;
            background-color: #3A3F44;
        }
        .auto-style6 {
            color: #336633;
            border-color: #d3eed3;
            background-color: #62c462;
        }
        .auto-style7 {
            color: #7c312f;
            border-color: #fad2d1;
            background-color: #ee5f5b;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="form1" runat="server">
        <div class="auto-style4">
            <br />
            <asp:Label ID="Label1" runat="server" EnableTheming="True" Font-Italic="True" Font-Size="X-Large" ForeColor="#99FF66" Text="Search Blood Donor Around You."></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" ToolTip="choose Blood group" CssClass="auto-style6" Font-Size="Large" Height="32px" Width="142px" ForeColor="Black">
                <asp:ListItem>a+</asp:ListItem>
                <asp:ListItem>a-</asp:ListItem>
                <asp:ListItem>b+</asp:ListItem>
                <asp:ListItem>b-</asp:ListItem>
                <asp:ListItem>o+</asp:ListItem>
                <asp:ListItem>o-</asp:ListItem>
                <asp:ListItem>ab+</asp:ListItem>
                <asp:ListItem>ab-</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList2" runat="server" ToolTip="choose area" CssClass="auto-style5" Font-Size="Large" ForeColor="White" Height="32px" Width="182px">
            
                             <asp:ListItem>Asad Gate</asp:ListItem>
                                 <asp:ListItem>Badda</asp:ListItem>
                                 <asp:ListItem>Dhanmondi</asp:ListItem>
                                   <asp:ListItem>Farmget</asp:ListItem>
                                   <asp:ListItem>Gabtoli</asp:ListItem>
                                   <asp:ListItem>Gazipur</asp:ListItem>
                                   <asp:ListItem>Gulshan</asp:ListItem>
                                   <asp:ListItem>Gulisthan</asp:ListItem>
                                   <asp:ListItem>Rampura</asp:ListItem>
                                   <asp:ListItem>Malibagh</asp:ListItem>
                                   <asp:ListItem>Mirpur</asp:ListItem>
                                   <asp:ListItem>Motijheel</asp:ListItem>
                                   <asp:ListItem>Mohammadpur</asp:ListItem>
                                   <asp:ListItem>Mouchak</asp:ListItem>
                                   <asp:ListItem>Nadda</asp:ListItem>
                                   <asp:ListItem>Puran Dhaka</asp:ListItem>
                                   <asp:ListItem>Poltan</asp:ListItem>
                                   <asp:ListItem>Karwan Bazar</asp:ListItem>
                                   <asp:ListItem>Sahbagh</asp:ListItem>
                                   <asp:ListItem>Savar</asp:ListItem>
                                   <asp:ListItem>Shamoli</asp:ListItem>
                                   <asp:ListItem>Uttara</asp:ListItem>
                                   <asp:ListItem>Wari</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" CssClass="auto-style7" Font-Bold="True" Font-Size="Large" ForeColor="White" Height="48px" Text="Search" Width="129px" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="alert-danger" Font-Size="Larger">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
            <asp:Label ID="Label2" runat="server" Font-Italic="False" Font-Size="XX-Large" ForeColor="#FF6600"></asp:Label>
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">

</asp:Content>
