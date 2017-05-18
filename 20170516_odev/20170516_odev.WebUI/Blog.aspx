<%@ Page Title="" Language="C#" MasterPageFile="~/MainNested.master" AutoEventWireup="true" CodeBehind="Blog.aspx.cs" Inherits="WebApplication1.Blog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <div class="post-snippet mb64">
                <a href="#">
                    <img class="mb24" alt="Post Image" src="<%#Eval("MakaleFotoPath")%>" />
                </a>
                <div class="post-title">
                    <a href="#">
                        <h4 class="inline-block"><%#Eval("Baslik")%>
                        </h4>
                    </a>
                </div>
                

                <ul class="post-meta">
                    <li>
                        <i class="ti-user"></i>
                        <span>Yazar:
                                            <a href="#"><%#Eval("YazarUserName")%></a>
                        </span>
                    </li>
                    <li>
                        <i class="ti-tag"></i>
                        <span>Kategori: 
                                            <a href="#"><%#Eval("Kategori.KategoriAdi") %></a>
                        </span>
                    </li>
                </ul>
                <hr>
                <p>
                    <%#Eval("Icerik")%>
                </p>
                <a class="btn btn-sm" href='blogsingle.aspx?<%#Eval("MakaleID")%>'>Devamını Oku</a>
            </div>
        </ItemTemplate>
    </asp:Repeater>

    <div class="text-center">
        <ul class="pagination">
            <li>
                <a href="#" aria-label="Previous">
                    <span aria-hidden="true">&laquo;</span>
                </a>
            </li>
            <li class="active">
                <a href="#">1</a>
            </li>
            <li>
                <a href="#">2</a>
            </li>
            <li>
                <a href="#">3</a>
            </li>
            <li>
                <a href="#">4</a>
            </li>
            <li>
                <a href="#">5</a>
            </li>
            <li>
                <a href="#" aria-label="Next">
                    <span aria-hidden="true">&raquo;</span>
                </a>
            </li>
        </ul>
    </div>

</asp:Content>
