#pragma checksum "/Users/Brooke/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "892f666903cf77d212f5a05cf25fb4cb95d77b3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Show), @"mvc.1.0.view", @"/Views/Clients/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Show.cshtml", typeof(AspNetCore.Views_Clients_Show))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"892f666903cf77d212f5a05cf25fb4cb95d77b3b", @"/Views/Clients/Show.cshtml")]
    public class Views_Clients_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Brooke/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Show.cshtml"
  
Layout = "_Layout";

#line default
#line hidden
            BeginContext(25, 3, true);
            WriteLiteral("\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 28, "\"", 65, 2);
            WriteAttributeValue("", 35, "/stylists/", 35, 10, true);
#line 5 "/Users/Brooke/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Show.cshtml"
WriteAttributeValue("", 45, Model["stylist"].Id, 45, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(66, 297, true);
            WriteLiteral(@" class=""btn btn-dark"">Back to Stylist</a>
<a href=""/stylists"" class=""btn btn-dark"">Return to list of Stylists</a>
<a href=""/"" class=""btn btn-dark"">Return to homepage</a><br><br>

<div class=""row"">
    <div class=""card col-md-12"">
        <div class=""card-body"">
            <h1 class=""card-title"">");
            EndContext();
            BeginContext(364, 21, false);
#line 12 "/Users/Brooke/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Show.cshtml"
                              Write(Model["stylist"].Name);

#line default
#line hidden
            EndContext();
            BeginContext(385, 116, true);
            WriteLiteral("</h1><br>\n            <div class=\"card-text\">\n                <h2>Years of experience:</h2><br>\n                <h3>");
            EndContext();
            BeginContext(502, 32, false);
#line 15 "/Users/Brooke/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Show.cshtml"
               Write(Model["stylist"].YearsExperience);

#line default
#line hidden
            EndContext();
            BeginContext(534, 83, true);
            WriteLiteral("</h3><br>\n                <h2>Days available to work:</h2><br>\n                <h3>");
            EndContext();
            BeginContext(618, 25, false);
#line 17 "/Users/Brooke/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Show.cshtml"
               Write(Model["stylist"].WorkDays);

#line default
#line hidden
            EndContext();
            BeginContext(643, 59, true);
            WriteLiteral("</h3><br><br>\n            </div>\n        </div>\n    </div>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
