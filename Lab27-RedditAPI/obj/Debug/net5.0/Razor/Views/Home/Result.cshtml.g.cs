#pragma checksum "C:\Users\Butch\source\repos\Labs\Lab27-RedditAPI\Lab27-RedditAPI\Lab27-RedditAPI\Views\Home\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ad3721964c2d30735785b60bd8ebfef6fe586b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
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
#line 1 "C:\Users\Butch\source\repos\Labs\Lab27-RedditAPI\Lab27-RedditAPI\Lab27-RedditAPI\Views\_ViewImports.cshtml"
using Lab27_RedditAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Butch\source\repos\Labs\Lab27-RedditAPI\Lab27-RedditAPI\Lab27-RedditAPI\Views\_ViewImports.cshtml"
using Lab27_RedditAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ad3721964c2d30735785b60bd8ebfef6fe586b4", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dad614ba56f41dd016c605d281ce9af960da74f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Child>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>");
#nullable restore
#line 2 "C:\Users\Butch\source\repos\Labs\Lab27-RedditAPI\Lab27-RedditAPI\Lab27-RedditAPI\Views\Home\Result.cshtml"
Write(TempData["error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Butch\source\repos\Labs\Lab27-RedditAPI\Lab27-RedditAPI\Lab27-RedditAPI\Views\Home\Result.cshtml"
 foreach (Child c in Model)
{
    string url = "https://reddit.com" + c.data.permalink;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\"", 148, "\"", 159, 1);
#nullable restore
#line 7 "C:\Users\Butch\source\repos\Labs\Lab27-RedditAPI\Lab27-RedditAPI\Lab27-RedditAPI\Views\Home\Result.cshtml"
WriteAttributeValue("", 155, url, 155, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h2>");
#nullable restore
#line 8 "C:\Users\Butch\source\repos\Labs\Lab27-RedditAPI\Lab27-RedditAPI\Lab27-RedditAPI\Views\Home\Result.cshtml"
       Write(c.data.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 207, "\"", 230, 1);
#nullable restore
#line 9 "C:\Users\Butch\source\repos\Labs\Lab27-RedditAPI\Lab27-RedditAPI\Lab27-RedditAPI\Views\Home\Result.cshtml"
WriteAttributeValue("", 213, c.data.thumbnail, 213, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n    </a>\r\n");
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 14 "C:\Users\Butch\source\repos\Labs\Lab27-RedditAPI\Lab27-RedditAPI\Lab27-RedditAPI\Views\Home\Result.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Child>> Html { get; private set; }
    }
}
#pragma warning restore 1591
