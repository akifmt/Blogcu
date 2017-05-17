<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication1.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="main-container">
            <section class="cover fullscreen image-bg overlay">
                <div class="background-image-holder">
                    <img alt="image" class="background-image" src="img/home2.jpg" />
                </div>
                <div class="container v-align-transform">
                    <div class="row">
                        <div class="col-sm-6 col-sm-offset-3">
                            <div class="feature bordered text-center">
                                <h4 class="uppercase">Üyelik</h4>
                                <form id="form1" class="text-left" runat="server">
                                    <asp:Literal runat="server" ID="StatusMessage" />
                                    <asp:TextBox runat="server" ID="UserName" type="text" name="name" placeholder="Üyeadı" />   
                                    <asp:TextBox runat="server" ID="EMail" type="text" name="email" placeholder="Email Adresi" />  
                                    <asp:TextBox runat="server" ID="Password" TextMode="Password" type="password" placeholder="Şifre" />
                                    <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" type="password" placeholder="Şifre Doğrula" />   

                                    <asp:Button runat="server" type="submit" value="Register" Text="Kayıt" OnClick="CreateUser_Click" />
                                </form>
                                <p class="mb0">Üye olarak sözleşmeyi kabul etmiş olursunuz.
                                    <a href="#">Kullanım Hakları</a>
                                </p>
                            </div>
                        </div>
                    </div>
                    <!--end of row-->
                </div>
                <!--end of container-->
            </section>
           
        </div>
</asp:Content>
