<%@ Page Title="" Language="C#" MasterPageFile="~/MainNested.master" AutoEventWireup="true" CodeBehind="MakaleYonetimi.aspx.cs" Inherits="_20170516_odev.WebUI.MakaleYonetimi" ValidateRequest="false"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


        <div class="container">
            <div class="col-lg-4">
                <%--Column ları otomatik oluşturma için = AutoGenerateColumns = "true"--%>
                <asp:GridView CssClass="table table-hover table-bordered" ID="GridViewListele" AutoGenerateColumns="false" runat="server" OnRowDataBound="GridViewListele_RowDataBound" OnRowCommand="GridViewListele_RowCommand" >
                    <Columns>
                        <asp:BoundField HeaderText="MakaleID" DataField="MakaleID" />
                        

                        <asp:TemplateField HeaderText="Baslık">
                            <ItemTemplate>
                                <asp:TextBox ID="Baslık" Text='<%# Eval("Baslık") %>' runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Icerik">
                            <ItemTemplate>
                                <asp:TextBox ID="Icerik" Text='<%# Eval("Icerik") %>' runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Biçim" runat="server">
                            <ItemTemplate>
                                <asp:DropDownList CssClass="form-control" ID="DropDownListKategori" runat="server">
                                </asp:DropDownList>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Güncelle">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButtonGuncelle" CssClass="btn" Text="Güncelle" CommandName="Guncelle" CommandArgument='<%# ((GridViewRow) Container).RowIndex  %>' runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Sil">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButtonSil" CssClass="btn" Text="Sil" CommandName="Sil" CommandArgument='<%# Eval("MakaleID") %>' runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="IDButton" runat="server"
                                    CommandName="IDButton1" Visible ="false"
                                    CommandArgument='<%# Eval("MakaleID") %>'
                                    Text="" />
                            </ItemTemplate>
                        </asp:TemplateField>

                    </Columns>
                </asp:GridView>


            </div>
        </div>
 

</asp:Content>
