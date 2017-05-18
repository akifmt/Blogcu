<%@ Page Title="" Language="C#" MasterPageFile="~/MainNested.master" AutoEventWireup="true" CodeBehind="BlogSingle.aspx.cs" Inherits="WebApplication1.BlogSingle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="post-snippet mb64">
        <img class="mb24" alt="Post Image" src="img/blog-single.jpg" />
        <div class="post-title">

            <h4 class="inline-block">


                <asp:Label ID="LabelBaslik" runat="server" Text="Label"></asp:Label>
            </h4>
        </div>
        <ul class="post-meta">
            <li>
                <i class="ti-user"></i>
                <span>Yazar:
                                            <a href="#">
                                                <asp:Label ID="LabelYazar" runat="server" Text="Label"></asp:Label></a>
                </span>
            </li>
        </ul>
        <hr>


        <asp:Literal ID="LiteralIcerik" runat="server"></asp:Literal>

    </div>
    <!--end of post snippet-->
    <hr>

    <div class="comments">
        <ul class="comments-list">
            <asp:Repeater ID="RepeaterYorumlar" runat="server">
                <ItemTemplate>
                    <li>
                        <div class="comment">
                            <span class="uppercase author">yazar: <%#Eval("AdiSoyadi")%></span>
                            <p>
                                <%#Eval("YorumIcerik")%>
                            </p>
                        </div>
                    </li>
                </ItemTemplate>
            </asp:Repeater>

        </ul>
        <hr>
        <h5 class="uppercase">Yorum Yaz</h5>

        <asp:TextBox ID="TextBoxAdSoyad" name="name" type="text" placeholder="Ad Soyad" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBoxEmail" name="name" type="text" placeholder="Email" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBoxYorumIcerik" rows="3" name="name2" type="text" placeholder="Yorum" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonYorumKaydet" type="submit" runat="server" Text="YORUM EKLE" OnClick="ButtonYorumKaydet_Click" />

    </div>
    <!--end of comments-->
</asp:Content>
