<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Evaluation.aspx.cs" Inherits="Agency_Web.Evaluation.Evaluation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:Label ID="headText" runat="server" Font-Size="25">Izaberite rezervaciju koju želite da ocijenite  </asp:Label>

    <asp:Label ID="Notification" runat="server" Text="Uspješna ocjena proizvoda. Hvala!" Font-Size="20" Visible="False"  ForeColor="Blue"></asp:Label>
    <asp:Label ID="Evaluated" runat="server" Text="Već ste ocijenili ovu rezervaciju!" Font-Size="20" Visible="False"  ForeColor="Red"></asp:Label>
    <asp:Label ID="UnEnded" runat="server" Text="Ne možete ocijeniti rezervaciju prije kraja aktivnosti!" Font-Size="20" Visible="False"  ForeColor="Red"></asp:Label>

    <br/><br/><br/>       
    <asp:Button ID="Reload" runat="server" Text="Ponovi ocjenu rezervacije" Visible="False" OnClick="Reload_Click"/>
    <br/>
     <asp:DataGrid ID="listaRezervacijaGrid" runat="server" DataSource=<%# listaRezervacija %>  AutoGenerateColumns="False"  AllowCustomPaging="True"
            AllowPaging="True" DataKeyField="RezervacijaId" OnItemCommand="listaRezervacijaGrid_ItemCommand" >
                    <Columns>
                        <asp:BoundColumn DataField="RezervacijaId" HeaderText="ID Rezervacije"/>
                        <asp:BoundColumn DataField="Prezime" HeaderText="Prezime radnika"/>
                        <asp:BoundColumn DataField="Ime" HeaderText="Ime radnika"/>
                        <asp:BoundColumn DataField="DatumRezervacije" HeaderText="Datum rezervacije" DataFormatString="{0:d}"/>
                        <asp:BoundColumn DataField="DatumPocetka" HeaderText="Datum početka" DataFormatString="{0:d}"/>
                        <asp:BoundColumn DataField="DatumZavrsetka" HeaderText="Datum završetka" DataFormatString="{0:d}"/>
                        <asp:BoundColumn DataField="BrojRadnihSati" HeaderText="Broj radnih sati"/>
            <asp:TemplateColumn>
                        <ItemTemplate>

                            <asp:LinkButton ID="izaberiRezervacijuSubmit" runat="server" CommandName="pickReservation" CommandArgument='<%#Bind("RezervacijaId") %>'  
                                >Izaberi rezervaciju</asp:LinkButton>

                        </ItemTemplate>
            </asp:TemplateColumn>
                    </Columns>
       </asp:DataGrid>
    
     <fieldset>
         
                        <legend>Evaluacijski obrazac</legend>
                        <ol>
                            <li>
                                <asp:Label ID="Label3" runat="server" Text="Izaberite ocjenu sa liste" Font-Size="15">Izaberite ocjenu sa liste</asp:Label>
                                <br/>
                                <asp:DropDownList ID="ocjeneList" runat="server" ></asp:DropDownList>              
                            <li>
                                <asp:Label ID="Label4" runat="server" Text="Primjedbe" Font-Size="15">Primjedbe</asp:Label>
                                <br/>
                                <asp:TextBox runat="server" ID="primjedbaInput" Height="30px" Width="700px"/>                               
                            </li>
                            <li>
                                <asp:Label ID="Label5" runat="server" Text="Sugestije" Font-Size="15">Sugestije</asp:Label>
                                <br/>
                                <asp:TextBox runat="server" ID="sugestijeInput" Height="30px" Width="700px" />
                            </li>                           
                        </ol>
                        <asp:Button runat= "server" ID="evaluacijaSubmit" Text="Ocijenite naše usluge " OnClick="evaluacijaSubmit_Click"  />
                    </fieldset>
 </asp:Content>   
    
    
    

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    



