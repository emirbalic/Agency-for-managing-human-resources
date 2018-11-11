<%@ Page Title="Rezervacija" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reservation.aspx.cs" Inherits="Agency_Web.Reservation.Reservation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
        <hgroup class="title">
        <h1><%: Title %>.</h1>
        <hr/>
    </hgroup>
        <section id="loginForm">
    
        
            <asp:Label ID="lblPrikaz" runat="server" Text="Prikaz rezervacije" Font-Size="20" Font-Bold="True"></asp:Label>
 <%--    <h2>
       Prikaz rezervacije
   </h2>--%>
    <br/><br/>
    
       <asp:Label ID="lblProvjera" runat="server" Text="Provjerite podatke o rezervaciji:" Font-Size="15" Font-Bold="True"></asp:Label>      
<%--     <h4>    
        Provjerite podatke o rezervaciji:   
    </h4>--%>
    <br/><br/>
       <asp:Label ID="lblRadnik" runat="server" Text="Radnik/radnica:"  Font-Size="12" Font-Bold="True"></asp:Label>       
<%--        <h5>
        Radnik/radnica:
       </h5>--%>
        <asp:Label ID="NoneChosen" runat="server" Text="Nije odabran nijedan radnik!" Font-Size="20" ForeColor="Red" Visible="False"></asp:Label>

    <asp:GridView ID="radnikGrid" runat="server" AutoGenerateColumns="False">
        <Columns>
             <asp:BoundField DataField="Prezime" HeaderText="Prezime"/>
            <asp:BoundField HeaderText="  "/>
            <asp:BoundField DataField="Ime" HeaderText="Ime"/>
            <asp:BoundField HeaderText="  "/>
        </Columns>   
    </asp:GridView>
    <br/>
    
            
         <asp:Label ID="lblRezervacija" runat="server" Text="Rezervacija:" Font-Size="12" Font-Bold="True"></asp:Label>
           
<%--    <h5>
        Rezervacija:
    </h5>--%>
    <asp:GridView ID="stavkeRezervacijeGrid" runat="server" AutoGenerateColumns="False">
        <Columns>
 
            <asp:BoundField DataField="DatumPocetka" HeaderText="Datum početka" DataFormatString="{0:d}" />
            <asp:BoundField HeaderText="  "/>
            <asp:BoundField DataField="DatumZavrsetka" HeaderText="Datum završetka" DataFormatString="{0:d}"/>
            <asp:BoundField HeaderText="  "/>
            <asp:BoundField DataField="DatumRezervacije" HeaderText="Datum rezervacije" DataFormatString="{0:d}"/>
            <asp:BoundField HeaderText="  "/>
            <asp:BoundField DataField="BrojRadnihSati" HeaderText="Broj radnih sati" DataFormatString="{0:d}"/>            
            <asp:BoundField HeaderText="  "/>
        </Columns>
    </asp:GridView>
    <br/>
    <asp:Label ID="Notification" runat="server" Text="Uspješna rezervacija!" Visible="False" Font-Size="20"  ForeColor="Blue"></asp:Label>            
    <asp:Label ID="Regret" runat="server" Text="Nespješna rezervacija, provjerite podatke vezane za datume!" Font-Size="20" ForeColor="Red" Visible="False"></asp:Label>
    <br/>
    <hr/>  
          <asp:Label ID="lblRezervirati" runat="server" Text="Rezervirati na ime klijenta?" Font-Size="12" Font-Bold="True"></asp:Label>

<%--    <h5>
        <b>Rezervirati na ime klijenta? </b>
    </h5>  --%>
    <br/>
            <asp:DataGrid ID="klijentGrid" runat="server" DataSource=<%# klijenti %> AutoGenerateColumns="False" >
                <Columns>
                    <asp:BoundColumn DataField="Naziv" HeaderText="Naziv klijenta"/> 
                    <asp:BoundColumn DataField="KlijentId" HeaderText="ID na sistemu"/>
                    <asp:BoundColumn DataField="Email" HeaderText="Email adresa"/>                    
                </Columns>
                     </asp:DataGrid>
    <br/>
    <hr/>
    <asp:Label ID="racunLabel" runat="server" Text="Iznos računa: KM " Font-Size="12" Font-Bold="True"></asp:Label>
    &nbsp;<asp:Label ID="iznosLabel" runat="server" Text="Label"></asp:Label>
    <hr/>
    <asp:Button ID="kreirajSubmit" runat="server" Text="Napravi rezervaciju" OnClick="kreirajSubmit_Click"  />    
    <asp:Button ID="otkazziSubmit" runat="server" Text="Odustani" OnClick="otkazziSubmit_Click"  />
    <br/>
    
    
               </section>
        <section id="socialLoginForm">
        <img src="/Images/people2.jpg"/>

    </section>
</asp:Content>


