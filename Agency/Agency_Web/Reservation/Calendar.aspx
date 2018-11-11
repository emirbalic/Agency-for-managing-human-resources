<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calendar.aspx.cs" Inherits="Agency_Web.Reservation.Calendar" %>


<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    
    

    <br/>
    <section id="loginForm">
    <h2>
            Dostupnost izabranog radnika:
    </h2>
        
        <asp:GridView ID="radnikGrid" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Prezime" HeaderText="Prezime"/>
            <asp:BoundField HeaderText="  "/>
            <asp:BoundField DataField="Ime" HeaderText="Ime"/>
            <asp:BoundField HeaderText="  "/>
            <asp:BoundField DataField="CijenaPoSatu" HeaderText="Cijena KM/h"/>
            <asp:BoundField HeaderText="  "/>
        </Columns>   
    </asp:GridView>
    <br/>

    <h5>
            Dani u kojima izabrani radnik nije dostupan su obilježeni plavom bojom.
    </h5>
    <asp:Calendar ID="kalendarDostupnosti" runat="server" OnDayRender="kalendarDostupnosti_DayRender"></asp:Calendar>
    
    <h2>
        <p> Kreirajte novu rezervaciju ili ponovite pretragu</p>
    </h2>
        <h5>
            Datum unijeti u formatu dan/mjesec/godina (npr. 7/12/2013)
    </h5>
    
    <table>
        <tr>
            <td>
               <asp:Label ID="Label1" runat="server" Text="Datum početka"></asp:Label> &nbsp;
                
            </td> 
            <td>
                <asp:Label ID="Label2" runat="server" Text="Datum završetka"></asp:Label>
            </td>
        </tr>
                
         <tr>
            <td>
                <asp:TextBox ID="beginDate" runat="server" Width="190px" TextMode="DateTime"></asp:TextBox>&nbsp;
            </td> 
             
            <td>
                <asp:TextBox ID="endDate" runat="server" Width="190px" TextMode="DateTime"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:RequiredFieldValidator ID="rfvBeginDate" runat="server" ErrorMessage="Obavezan unos datuma početka" ControlToValidate="beginDate" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvEndDate" runat="server" ErrorMessage="Obavezan unos datuma završetka" ControlToValidate="endDate" ForeColor="Red"></asp:RequiredFieldValidator>                
            </td>
        </tr>
        <tr>
            <td>
                <asp:RegularExpressionValidator ID="beginDateRegex" runat="server" ErrorMessage="Unesite datum u formatu (dan/mjesec/godina)"
                    ControlToValidate="beginDate"
                    ValidationExpression="^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))
                $|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$" ForeColor="Red"></asp:RegularExpressionValidator>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="endDateRegex" runat="server" ErrorMessage="Unesite datum u formatu (dan/mjesec/godina)"
                    ControlToValidate="endDate"
                    ValidationExpression="^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))
                $|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$" ForeColor="Red"></asp:RegularExpressionValidator>

                
                
            </td>
        </tr>
    </table>

    <br/>

    <br/>
         <asp:Button ID="izaberiSubmit" runat="server" Text="Kreiraj" CommandName="kreirajSubmit" Width="200px" OnClick="izaberiSubmit_Click" />
         <asp:Button ID="ponoviPretragu" runat="server" Text="Ponovi pretragu" Width="200px" OnClick="ponoviPretragu_Click" CausesValidation="False" />
    
    </section>
        <section id="socialLoginForm">
 
            <h2>
                Radnici preporučeni visokim ocjenama usluga
            </h2>
            <br/>
            <br/>
            <asp:DataGrid ID="preporukaGrid" runat="server" DataSource=<%# Preporuka %> 
                AutoGenerateColumns="False" DataKeyField="RadnikId">
            <Columns>
                <asp:BoundColumn DataField="Prezime" HeaderText="Prezime" /> 
                <asp:BoundColumn DataField="Ime" HeaderText="Ime"/>
                <asp:BoundColumn DataField="CijenaPoSatu" HeaderText="Cijena KM/h"  ItemStyle-Wrap="false"  ItemStyle-Width="35"/>
                <asp:BoundColumn DataField="Telefon" HeaderText="Telefon" ItemStyle-Wrap="false"  ItemStyle-Width="35"/>
                <asp:BoundColumn DataField="Email" HeaderText="Email"/>
                </Columns>
          </asp:DataGrid>
            <br/>
            <br/>
                   <img src="/Images/people6.jpg"/>
    </section>
</asp:Content>

