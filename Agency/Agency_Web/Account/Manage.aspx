<%@ Page Title="Upravljanje računom" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="Agency_Web.Account.Manage" %>
<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <br/>
        <hr/>
    </hgroup>
     <section id="loginForm">
            <p class="message-success"><%: SuccessMessage %></p>
        <p>Prijavljeni ste kao <strong><%: User.Identity.Name %></strong>.</p>         
<%--         <h3>Promijenite korisničko ime</h3>
                <fieldset id="changeUsername">
                        <legend>Username change form</legend>
                        <ol>
                            
                            <li>
                                <asp:Label runat="server" ID="Label2" AssociatedControlID="Password">Lozinka</asp:Label>
                                <asp:TextBox runat="server" ID="TextBox2"  TextMode="Password" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Password"
                                    CssClass="field-validation-error" ErrorMessage="Obavezan unos lozinke."
                                     />
                            </li>   
                            
                            <li>
                                <asp:Label runat="server" ID="lblKorisnickoIme" AssociatedControlID="CurrentUserName">Sadašnje korisničko ime</asp:Label>
                                <asp:TextBox runat="server" ID="korisnickoIme"   />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="CurrentUserName"
                                    CssClass="field-validation-error" ErrorMessage="Obavezan unos sadašnjeg korisničkog imena."
                                    ValidationGroup="ChangeUserName" />
                            </li>
                            
                                                   
                           </ol>
                        <asp:Button runat="server" ID="promijeniUserNameSubmit" Text="Promijeni korisničko ime" ValidationGroup="ChangeUserName"  />
                     </fieldset> --%>
<%--       <asp:PlaceHolder runat="server" ID="changePassword" Visible="True">--%>
         
         

            <h3>Promijenite lozinku</h3> <br/> <hr/>
                <fieldset id="changePass">
                        <legend>Password change form</legend>
                        <ol>

                            <asp:Label ID="Validation" runat="server" Text="Pogrešan unos sadašnje lozinke" ForeColor="Red"></asp:Label>
                            <asp:Label ID="SuccPass" runat="server" Text="Uspješno ste promjenili lozinku" ForeColor="Blue" Font-Size="15"></asp:Label>
                            <li>
                                <asp:Label runat="server" ID="CurrentPasswordLabel" AssociatedControlID="CurrentPassword">Sadašnja lozinka</asp:Label>
                                <asp:TextBox runat="server" ID="CurrentPassword"  TextMode="Password" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="CurrentPassword"
                                    CssClass="field-validation-error" ErrorMessage="Obavezan unos sadašnje lozinke."
                                    ValidationGroup="ChangePassword" />
                            </li>
                            <li>
                                <asp:Label runat="server" ID="NewPasswordLabel" AssociatedControlID="NewPassword">Nova lozinka</asp:Label>
                                <asp:TextBox runat="server" ID="NewPassword"  TextMode="Password" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="NewPassword"
                                    CssClass="field-validation-error" ErrorMessage="Obavezan unos nove lozinke."
                                    ValidationGroup="ChangePassword" />
                            </li>
                            <li>
                                <asp:Label runat="server" ID="ConfirmNewPasswordLabel" AssociatedControlID="ConfirmNewPassword">Potvrda nove lozinke</asp:Label>
                                <asp:TextBox runat="server" ID="ConfirmNewPassword"  TextMode="Password" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmNewPassword"
                                    CssClass="field-validation-error" Display="Dynamic" ErrorMessage="Obavezan unos potvrde lozinke."
                                    ValidationGroup="ChangePassword" />
                                <asp:CompareValidator runat="server" ControlToCompare="NewPassword" ControlToValidate="ConfirmNewPassword"
                                    CssClass="field-validation-error" Display="Dynamic" ErrorMessage="Niste unijeli ispravnu potvrdu lozinke"
                                    ValidationGroup="ChangePassword" />
                            </li>
                        </ol>
                        <asp:Button runat="server" ID="promijeniPassSubmit" Text="Promijeni lozinku" ValidationGroup="ChangePassword" OnClick="promijeniPassSubmit_Click" />
                     </fieldset>
    </section>
        <section id="socialLoginForm">
        <img src="/Images/people8.jpg"/>
    </section>
</asp:Content>
