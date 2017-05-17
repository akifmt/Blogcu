<%@ Page Title="" Language="C#" MasterPageFile="~/MainNested.master" AutoEventWireup="true" CodeBehind="Blog.aspx.cs" Inherits="WebApplication1.Blog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
                            <div class="post-snippet mb64">
                                <a href="#">
                                    <img class="mb24" alt="Post Image" src="img/blog-single-4.jpg" />
                                </a>
                                <div class="post-title">
                                    <span class="label">23 Sep</span>
                                    <a href="#">
                                        <h4 class="inline-block">A simple image post for starters</h4>
                                    </a>
                                </div>
                                <ul class="post-meta">
                                    <li>
                                        <i class="ti-user"></i>
                                        <span>Written by
                                            <a href="#">Craig Garner</a>
                                        </span>
                                    </li>
                                    <li>
                                        <i class="ti-tag"></i>
                                        <span>Tagged as
                                            <a href="#">Lifestyle</a>
                                        </span>
                                    </li>
                                </ul>
                                <hr>
                                <p>
                                    Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.
                                </p>
                                <a class="btn btn-sm" href="#">Read More</a>
                            </div>
                            <!--end of post snippet-->

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
