<%@ Page Title="" Language="C#" MasterPageFile="~/MainNested.master" AutoEventWireup="true" CodeBehind="MakaleEkle.aspx.cs" Inherits="_20170516_odev.WebUI.MakaleEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="comments">

        <h5 class="uppercase">MAKALE EKLE</h5>

        <input  />
        <asp:TextBox ID="TextBoxBaslik" name="name" type="text" placeholder="Lütfen Makale Başlık Giriniz" runat="server"></asp:TextBox>
        <asp:DropDownList ID="DropDownList1" runat="server" placeholder="Lütfen Kategori Seçiniz"></asp:DropDownList>
        <asp:FileUpload CssClass="btn" ID="FileUpload1" runat="server" text="Lütfen Resim Ekleyiniz Seçiniz " />
        <textarea class="ckeditor" id="editor1" runat="server" TextMode="MultiLine"></textarea>
        <asp:Button ID="Button1" type="submit" runat="server" Text="MAKALEYİ EKLE" />

    </div>


</asp:Content>
