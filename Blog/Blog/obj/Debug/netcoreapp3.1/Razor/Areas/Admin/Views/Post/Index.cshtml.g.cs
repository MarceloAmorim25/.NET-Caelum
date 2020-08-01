#pragma checksum "C:\Users\marce\source\repos\.NET-Caelum\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1193b63c2a2a28b165208388a619abe1c0024fc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Post_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Post/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\marce\source\repos\.NET-Caelum\Blog\Blog\Areas\Admin\Views\_ViewImports.cshtml"
using Blog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1193b63c2a2a28b165208388a619abe1c0024fc9", @"/Areas/Admin/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ba6d000e4da28050915fd9e3327521c39c3164f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h2>Lista de Posts</h2>\r\n\r\n");
#nullable restore
#line 6 "C:\Users\marce\source\repos\.NET-Caelum\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml"
Write(Html.ActionLink("Incluir Post", "Novo", null, null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<table class=""table table-striped table-hover table-bordered"">

    <caption>Lista dos posts cadastrados no blog.</caption>
    <thead>
        <tr>
            <th>Post</th>
            <th>Categoria</th>
            <th>Publicado Em</th>
            <th>Ações</th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 21 "C:\Users\marce\source\repos\.NET-Caelum\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml"
         foreach (var p in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <h4>");
#nullable restore
#line 25 "C:\Users\marce\source\repos\.NET-Caelum\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml"
                   Write(Html.ActionLink(p.Titulo, "Visualiza", new { Id = p.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n                    <p>");
#nullable restore
#line 27 "C:\Users\marce\source\repos\.NET-Caelum\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml"
                  Write(p.Resumo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\marce\source\repos\.NET-Caelum\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml"
               Write(p.Categoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 31 "C:\Users\marce\source\repos\.NET-Caelum\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml"
                     if (p.Publicado)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\marce\source\repos\.NET-Caelum\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml"
                   Write(Html.Raw(string.Format("{0:dd/MM/yyyy}", p.DataPublicacao)));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\marce\source\repos\.NET-Caelum\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml"
                                                                                    
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\marce\source\repos\.NET-Caelum\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml"
                   Write(Html.Raw("Não Publicado"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\marce\source\repos\.NET-Caelum\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml"
                                                  
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\marce\source\repos\.NET-Caelum\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml"
               Write(Html.ActionLink("Remover", "Remove", new { id = p.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 42 "C:\Users\marce\source\repos\.NET-Caelum\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml"
               Write(Html.ActionLink("Publicar", "Publica", new { id = p.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 45 "C:\Users\marce\source\repos\.NET-Caelum\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
