#pragma checksum "C:\Users\Shanice\Desktop\Fall 2020 Coursework\C# III\Completed Projects\GuildManager\GuildManager\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c388e428107c76016d42afc3f2343a316215fed"
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
#line 1 "C:\Users\Shanice\Desktop\Fall 2020 Coursework\C# III\Completed Projects\GuildManager\GuildManager\Views\_ViewImports.cshtml"
using GuildManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shanice\Desktop\Fall 2020 Coursework\C# III\Completed Projects\GuildManager\GuildManager\Views\_ViewImports.cshtml"
using GuildManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c388e428107c76016d42afc3f2343a316215fed", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a025e93ba0ce765122330f40f96e9c2f171aef6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Announcement>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Shanice\Desktop\Fall 2020 Coursework\C# III\Completed Projects\GuildManager\GuildManager\Views\Home\Index.cshtml"
 foreach (Announcement a in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>");
#nullable restore
#line 5 "C:\Users\Shanice\Desktop\Fall 2020 Coursework\C# III\Completed Projects\GuildManager\GuildManager\Views\Home\Index.cshtml"
   Write(a.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p>");
#nullable restore
#line 6 "C:\Users\Shanice\Desktop\Fall 2020 Coursework\C# III\Completed Projects\GuildManager\GuildManager\Views\Home\Index.cshtml"
  Write(a.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 7 "C:\Users\Shanice\Desktop\Fall 2020 Coursework\C# III\Completed Projects\GuildManager\GuildManager\Views\Home\Index.cshtml"
  Write(a.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n");
#nullable restore
#line 8 "C:\Users\Shanice\Desktop\Fall 2020 Coursework\C# III\Completed Projects\GuildManager\GuildManager\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Announcement>> Html { get; private set; }
    }
}
#pragma warning restore 1591
