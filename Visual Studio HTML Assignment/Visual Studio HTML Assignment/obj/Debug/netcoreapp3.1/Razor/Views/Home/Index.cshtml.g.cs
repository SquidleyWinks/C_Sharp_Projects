#pragma checksum "C:\Users\puebbing\Documents\GitHub\C_Sharp_Projects\Visual Studio HTML Assignment\Visual Studio HTML Assignment\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c146f08e308924920077115963235a932c2f540e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\puebbing\Documents\GitHub\C_Sharp_Projects\Visual Studio HTML Assignment\Visual Studio HTML Assignment\Views\_ViewImports.cshtml"
using Visual_Studio_HTML_Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\puebbing\Documents\GitHub\C_Sharp_Projects\Visual Studio HTML Assignment\Visual Studio HTML Assignment\Views\_ViewImports.cshtml"
using Visual_Studio_HTML_Assignment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c146f08e308924920077115963235a932c2f540e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a51df8588f0a109bf037cda6a60fffe633283711", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\puebbing\Documents\GitHub\C_Sharp_Projects\Visual Studio HTML Assignment\Visual Studio HTML Assignment\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 id=""hello_world"" class=""display-4 green-text"" onmouseover=""newColor()"" onmouseout=""oldColor()"">Hello World!</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
    <p><button id=""myMoveButon"" onclick=""myMove()"">Click Me</button></p>
    <div id=""bigbox"">
        <div id=""smallbox""></div>
    </div>
    <script>
        function myMove() {
            let id = null;
            const elem = document.getElementById(""smallbox"");
            let pos = 0;
            clearInterval(id);
            id = setInterval(frame, 5);
            function frame() {
                if (pos == 350) {
                    clearInterval(id);
                } else {
                    pos++;
                    elem.style.top = pos + ""px"";
                    elem.style.left = pos + ""px"";
                }
            }
        }
    </script>
    <iframe width=""420"" height=""315"" src=""https://www.youtub");
            WriteLiteral("e.com/embed/2dQ2-t_v25g\"</iframe>\r\n\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
