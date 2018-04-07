<%@ Page Title="Change password" Language="C#" MasterPageFile="~/Donor/donorMasterPage.Master" AutoEventWireup="true" CodeBehind="passwordChange.aspx.cs" Inherits="BloodBankWithUnitTesting.Donor.passwordChange" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            width: 100%;
            max-width: 1140px;
            min-width: 992px;
            text-align: center;
            margin-left: auto;
            margin-right: auto;
            padding-left: 15px;
            padding-right: 15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

                <div class="auto-style3" style="padding-left:20em"  runat="server">
                
                    <div class="row vertical-offset-100">
    	<div class="col-md-4 col-md-offset-4">
    		<div class="panel panel-default">
			  	<div class="panel-heading">
			 	</div>
			  	<div class="auto-style2">
			    	<form id="form2" runat="server">
                    <fieldset>
                        <br />
                        <asp:Label ID="Label4" runat="server" ForeColor="#FF6600" Font-Size="XX-Large" Width="500px"></asp:Label>
			    	    <br /><br /><br /><br />
			    		<div class="form-group">
                                <asp:TextBox ID="TextBox1"  required="require" class="form-control" placeholder="old Password" runat="server" TextMode="Password" Height="61px" Width="500px" Font-Size="Large" MaxLength="32"></asp:TextBox>
			    		 <asp:Label ID="Label1" runat="server" Width="500px" ForeColor="Red" Font-Size="Larger">password Length (8-31)</asp:Label>
                        </div>
                       <br />
                        <div class="form-group">
                                <asp:TextBox ID="TextBox2"  required="require" class="form-control" placeholder="New Password" runat="server" TextMode="Password" Height="61px" Width="500px" Font-Size="Large"></asp:TextBox>
			    		<asp:Label ID="Label2" runat="server" Width="500px" ForeColor="Red" Font-Size="Larger">password Length (8-31)</asp:Label>
                        </div><br />
                        <div class="form-group">
                                <asp:TextBox ID="TextBox3"  required="require" class="form-control" placeholder="Confirm Password" runat="server" TextMode="Password" Height="61px" Width="500px" Font-Size="Large" MaxLength="32"></asp:TextBox>
			    		<br /><asp:Label ID="Label3" runat="server" Width="500px" ForeColor="Red" Font-Size="Larger">password Length (8-31)</asp:Label>
                        </div><br />
			    	

                         <asp:Button ID="Button2" class="btn btn-lg btn-success btn-block"  runat="server" Text="Submit Change" Width="500px" OnClick="Button1_Click" />
			    	    <br />
                        <br />
                        <br />
                        <br />
			    	</fieldset>
			      	</form>
			    </div>
			</div>
		</div>
	</div>

   </div>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>


