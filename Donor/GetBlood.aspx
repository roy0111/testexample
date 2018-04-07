<%@ Page Title="Get Blood" Language="C#" MasterPageFile="~/Donor/donorMasterPage.Master" AutoEventWireup="true" CodeBehind="GetBlood.aspx.cs" Inherits="BloodBankWithUnitTesting.Donor.GetBlood" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
                    <div class="auto-style3" style="padding-left:10em"  runat="server">
                
                    <div class="row vertical-offset-100">
    	<div class="col-md-4 col-md-offset-4">
    		<div class="panel panel-default">
			  	<div class="panel-heading">
			 	</div>
			  	<div class="auto-style2">
			    	<form id="form2" runat="server">
                    <fieldset>
                        <br /><br />
			    		<div class="form-group">
                                <asp:TextBox ID="TextBox1"  required="require" class="form-control" placeholder="Confirmation Id Of Donor" runat="server" Height="61px" Width="500px" Font-Size="Large" MaxLength="32"></asp:TextBox>
			    		</div><br />
                        <div class="form-group">
                                <asp:TextBox ID="TextBox2"  required="require" class="form-control" placeholder="Donor Date Of Birth" runat="server" TextMode="Date" Height="61px" Width="500px" Font-Size="Large"></asp:TextBox>
			    		</div><br />
                      
			    	

                         <asp:Button ID="Button2" class="btn btn-lg btn-danger btn-block"  runat="server" Text="Approve Donor" Width="500px" OnClick="Button1_Click" />
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


