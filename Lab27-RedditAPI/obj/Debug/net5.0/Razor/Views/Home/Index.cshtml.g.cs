#pragma checksum "C:\Users\Butch\source\repos\Labs\Lab27-RedditAPI\Lab27-RedditAPI\Lab27-RedditAPI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "684ade81edc50cf33cd54c2db3041cfc8b862cd8"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"684ade81edc50cf33cd54c2db3041cfc8b862cd8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dad614ba56f41dd016c605d281ce9af960da74f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data1>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 3 "C:\Users\Butch\source\repos\Labs\Lab27-RedditAPI\Lab27-RedditAPI\Lab27-RedditAPI\Views\Home\Index.cshtml"
Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<img");
            BeginWriteAttribute("src", " src=\"", 43, "\"", 65, 1);
#nullable restore
#line 4 "C:\Users\Butch\source\repos\Labs\Lab27-RedditAPI\Lab27-RedditAPI\Lab27-RedditAPI\Views\Home\Index.cshtml"
WriteAttributeValue("", 49, Model.thumbnail, 49, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n<a href=\"reddit.com\" + ");
#nullable restore
#line 5 "C:\Users\Butch\source\repos\Labs\Lab27-RedditAPI\Lab27-RedditAPI\Lab27-RedditAPI\Views\Home\Index.cshtml"
                  Write(Model.permalink);

#line default
#line hidden
#nullable disable
            WriteLiteral(";>Link</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data1> Html { get; private set; }
    }
}
#pragma warning restore 1591
