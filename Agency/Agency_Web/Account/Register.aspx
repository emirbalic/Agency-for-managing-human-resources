<%@ Page Title="Registracija" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Agency_Web.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <br/>
        <hr/>
        <h2>Upotrebite formu da kreirate svoj račun</h2>
    </hgroup>

    
<%--                    <p class="message-info">
                        Passwords are required to be a minimum of <%: Membership.MinRequiredPasswordLength %> characters in length.
                    </p>--%>
        <section id="loginForm">
                    <p class="validation-summary-errors">
                        <asp:Literal runat="server" ID="ErrorMessage" />
                    </p>

                    <fieldset>
                        <legend>Registration Form</legend>
                        <ol>
                            <li>
                                <asp:Label ID="Label1" runat="server" AssociatedControlID="nazivInput">Ime</asp:Label>
                                <asp:TextBox runat="server" ID="nazivInput" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nazivInput"
                                    CssClass="field-validation-error" ErrorMessage="Obavezan unos naziva klijenta." />

                            <li>
                                <asp:Label runat="server" AssociatedControlID="korisnickoImeInput">Korisničko ime</asp:Label>
                                <asp:TextBox runat="server" ID="korisnickoImeInput" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="korisnickoImeInput"
                                    CssClass="field-validation-error" ErrorMessage="Unos korisničkog imena je obavezan." />
                            </li>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="emailInput">Email adresa</asp:Label>
                                <asp:TextBox runat="server" ID="emailInput" TextMode="Email" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="emailInput"
                                    CssClass="field-validation-error" ErrorMessage="Unos e-mail adrese je obavezan." />
                            </li>
                            
                            <li>
                                <asp:Label ID="Label2" runat="server" AssociatedControlID="adresaInput">Ulica i broj</asp:Label>
                                <asp:TextBox runat="server" ID="adresaInput"  />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="adresaInput"
                                    CssClass="field-validation-error" ErrorMessage="Unos adrese firme je obavezan." />
                            </li>
                            <li>
                                <asp:Label ID="Label3" runat="server" AssociatedControlID="mjestoList" >Grad</asp:Label>                
                                <asp:DropDownList ID="mjestoList" runat="server" Height="30px" Width="311px" DataTextField="Naziv" DataValueField="MjestoId"></asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="mjestoList" CssClass="field-validation-error"
                                ErrorMessage="Unos grada u kojem se firma nalazi je obavezan."></asp:RequiredFieldValidator>

                            </li>
                            <li>
                                <asp:Label ID="Label4" runat="server" AssociatedControlID="tipAktivnostiList" >Tip aktivnosti</asp:Label>                
                                <asp:DropDownList ID="tipAktivnostiList" runat="server" Height="30px" Width="311px" DataTextField="Naziv" DataValueField="tipAktivnostiId"></asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="tipAktivnostiList" CssClass="field-validation-error"
                                ErrorMessage="Unos primarne aktivnosti firme nalazi je obavezan."></asp:RequiredFieldValidator>

                            </li>
                       
                            

                            <li>
                                <asp:Label runat="server" AssociatedControlID="lozinkaInput">Lozinka</asp:Label>
                                <asp:TextBox runat="server" ID="lozinkaInput" TextMode="Password" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="lozinkaInput"
                                    CssClass="field-validation-error" ErrorMessage="Unos lozinke je obavezan." />
                            </li>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="potvrdaLozinkeInput">Potvrda lozinke</asp:Label>
                                <asp:TextBox runat="server" ID="potvrdaLozinkeInput" TextMode="Password" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="potvrdaLozinkeInput"
                                     CssClass="field-validation-error" Display="Dynamic" ErrorMessage="Unos potvrde lozinke je obavezan." />

                                <asp:CompareValidator runat="server" ControlToCompare="lozinkaInput" ControlToValidate="potvrdaLozinkeInput"
                                     CssClass="field-validation-error" Display="Dynamic" ErrorMessage="Neispravna potvrda lozinke." />
                            </li>
                        </ol>
                        <asp:Button runat= "server" ID="registracijaSubmit" Text="Registrirajte se " OnClick="registracijaSubmit_Click"  />
                    </fieldset>
            
                </section>

    <section id="socialLoginForm">
        <img src="/Images/people3.jpg"/>

    </section>
                
</asp:Content>