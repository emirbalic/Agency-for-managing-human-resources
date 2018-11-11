<%@ Page Title="Početna strana" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" 
    Inherits="Agency_Web._Default" %>
<%@ Import Namespace="Agency_Servis.Data" %>



<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="startPage">
       <div class="content-wrapper"> 
            <hgroup class="title">   
                <h1><%: Title %>.</h1>
                <br/>
                <hr/>
                <h2>Agencija za upravljanje ljudskim resursima</h2>
            </hgroup>

        </div>
    </section>
</asp:Content>
 
<%--ID="BodyContent"--%>



<asp:Content runat="server"  ContentPlaceHolderID="MainContent">
                    <section id="loginForm">
    <h3>Naši kandidati:</h3>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Struka"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Ime i prezime"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="strukaList"  runat="server" DataSource=<%# struke %> DataTextField="Naziv" 
                    DataValueField="StrukaId"></asp:DropDownList>
            </td>
        <td>
            <asp:TextBox ID="imeIPrezimeInput" runat="server" Width="275px"></asp:TextBox>
        </td>
         <td>  
             <asp:Button ID="traziSubmit" runat="server" Text="Pretraga" OnClick="traziSubmit_Click" />
         </td>
        </tr>
        
    </table>
    <br/>
        <asp:DataGrid ID="radniciGrid" runat="server" DataSource=<%# radnici %> AllowPaging="True" 
            AllowCustomPaging="True" PageSize="3" AutoGenerateColumns="False" OnPageIndexChanged="radniciGrid_PageIndexChanged"
            DataKeyField="RadnikId"  OnItemCommand="radniciGrid_ItemCommand1">
        <PagerStyle Mode="NumericPages"></PagerStyle>
                    <Columns>
            <asp:BoundColumn DataField="Prezime_i_ime" HeaderText="Prezime i ime"/>
            <asp:BoundColumn DataField="Strucna_sprema" HeaderText="Stručna sprema"/>
            <asp:BoundColumn DataField="CijenaPoSatu" HeaderText="Cijena po satu angažmana"/>
            <asp:TemplateColumn>
                        <ItemTemplate>

                            <asp:LinkButton ID="provjeriRezervacijeSubmit" runat="server" CommandName="checkReserved" CommandArgument='<%#Bind("RadnikId") %>'>Provjeri dostupnost</asp:LinkButton>

                        </ItemTemplate>
            </asp:TemplateColumn>
                    </Columns>
       </asp:DataGrid>
        </section>
        <section id="socialLoginForm">

<asp:Label ID="headText" runat="server" Font-Size="15" Visible="False">Kandidati preporučeni visokim ocjenama drugih klijenata:  </asp:Label>
<asp:Label ID="hTxtProff" runat="server" Font-Size="15" Visible="False">Kandidati iz tražene struke preporučeni visokim ocjenama drugih klijenata:  </asp:Label>            

            <asp:Image ID="people" runat="server"  ImageUrl="Images/people4.jpg"/>
            <hr/>

            
            <asp:DataGrid ID="poStruciGrid" runat="server" DataSource=<%# PreporukaPoStruci %> 
                AutoGenerateColumns="False" DataKeyField="Prezime_i_ime">
            <Columns>
                <asp:BoundColumn DataField="Prezime_i_ime" HeaderText="Prezime i ime"/> 
                <asp:BoundColumn DataField="Strucna_sprema" HeaderText="Stručna sprema"/>
                <asp:BoundColumn DataField="Struka" HeaderText="Struka"/>
                </Columns>
          </asp:DataGrid>
            
            
            

    </section>  
</asp:Content>
