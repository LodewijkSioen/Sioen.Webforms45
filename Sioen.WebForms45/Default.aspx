﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Sioen.WebForms45._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to ASP.NET!
    </h2>
    <table>
        <asp:ListView ID="UserList" runat="server">
            <ItemTemplate>
                <tr><td><%# Eval("Name") %></td></tr>      
            </ItemTemplate>
        </asp:ListView>
    </table>
</asp:Content>
