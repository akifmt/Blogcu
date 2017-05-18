<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="MakaleYonetimi.aspx.cs" Inherits="_20170516_odev.WebUI.MakaleYonetimi" ValidateRequest="false" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" class="text-left" runat="server">
        <div class="container">
            <div class="col-lg-12">
                <%--Column ları otomatik oluşturma için = AutoGenerateColumns = "true"--%>
                <asp:GridView CssClass="table table-hover table-bordered table-responsive" ID="GridViewListele" AutoGenerateColumns="false" runat="server" OnRowDataBound="GridViewListele_RowDataBound" OnRowCommand="GridViewListele_RowCommand">
                    <Columns>
                        <asp:BoundField HeaderText="MakaleID" DataField="MakaleID" />

                        <asp:TemplateField HeaderText="Baslık">
                            <ItemTemplate>

                                <asp:TextBox ID="Baslık" Text='<%# Eval("Baslik") %>' TextMode="MultiLine" runat="server" />

                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Icerik">
                            <ItemTemplate>
                                <asp:TextBox ID="Icerik" CssClass="ckeditor" Text='<%# Eval("Icerik") %>' TextMode="MultiLine" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Kategori" runat="server">
                            <ItemTemplate>
                                <div style="width:100px;">
                                    <asp:DropDownList CssClass="col-lg-12" ID="DropDownListKategori" runat="server">
                                    </asp:DropDownList>
                                </div>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Güncelle">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButtonGuncelle" CssClass="btn btn-sm" Text="Güncelle" CommandName="Guncelle" CommandArgument='<%# Eval("MakaleID") %>' runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Sil">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButtonSil" Text="Sil"  CssClass="btn btn-sm" CommandName="Sil" CommandArgument='<%# Eval("MakaleID") %>' runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="IDButton" runat="server"
                                    CommandName="IDButton1" Visible="false"
                                    CommandArgument='<%# Eval("MakaleID") %>'
                                    Text="" />
                            </ItemTemplate>
                        </asp:TemplateField>

                    </Columns>
                </asp:GridView>


            </div>
        </div>
    </form>

</asp:Content>
