﻿<%@ Page Title="Prijava" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Agency_Web.Account.Login" %>
<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <hr/>
    </hgroup>
    <section id="loginForm">
        <h2>Logirajte se sa svojim podacima.</h2>
        <asp:Login ID="loginBox" runat="server" ViewStateMode="Disabled" RenderOuterTable="false" OnAuthenticate="loginBox_Authenticate">
            <LayoutTemplate>
                <p class="validation-summary-errors">
                    <asp:Literal runat="server" ID="FailureText" />
                </p>
                <fieldset>
                    <legend>Log in Form</legend>
                    <ol>
                        <li>
                            <asp:Label runat="server" AssociatedControlID="UserName">Korisničko ime</asp:Label>
                            <asp:TextBox runat="server" ID="UserName" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName" CssClass="field-validation-error" ErrorMessage="Korisničko ime je obavezno." />
                        </li>
                        <li>
                            <asp:Label runat="server" AssociatedControlID="Password">Lozinka</asp:Label>
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="field-validation-error" ErrorMessage="Lozinka je obavezna." />
                        </li>

                    </ol>
                    <asp:Button runat="server" CommandName="Login" Text="Log in" />
                </fieldset>
            </LayoutTemplate>
        </asp:Login>
        <p>
            <asp:HyperLink runat="server" ID="RegisterHyperLink" ViewStateMode="Disabled">Registrirajte se</asp:HyperLink>
            ako nemate otvoren korisnički nalog.
        </p>
    </section>

    <section id="socialLoginForm">
        <img src="/Images/people.jpg"/>

    </section>
</asp:Content>
