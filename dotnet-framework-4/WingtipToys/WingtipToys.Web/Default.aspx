<%@ Page
Title="Welcome"
Language="C#"
MasterPageFile="~/Site.Master"
AutoEventWireup="true"
CodeBehind="Default.aspx.cs"
Inherits="WingtipToys._Default"
%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  <h1><%: Title %></h1>
  <h2>Wingtip Toys can help you find teh perfect gift.</h2>
  <em>But for spelling, you're on your own.</em>
  
  <p class="lead">
    They told me there would be toys here.
  </p>
</asp:Content>
