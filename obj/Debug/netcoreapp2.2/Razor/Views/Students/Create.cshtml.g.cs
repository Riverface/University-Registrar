#pragma checksum "D:\Projects\Programming\Registrar\registrar\Views\Students\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1ed64aa721a86325522d6cde438d7dc7bdc118f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Create), @"mvc.1.0.view", @"/Views/Students/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Create.cshtml", typeof(AspNetCore.Views_Students_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1ed64aa721a86325522d6cde438d7dc7bdc118f", @"/Views/Students/Create.cshtml")]
    public class Views_Students_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Registrar.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("  \r\n");
            EndContext();
#line 2 "D:\Projects\Programming\Registrar\registrar\Views\Students\Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(69, 29, true);
            WriteLiteral("\r\n<h4>Add a new task</h4>\r\n\r\n");
            EndContext();
#line 10 "D:\Projects\Programming\Registrar\registrar\Views\Students\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(133, 39, false);
#line 12 "D:\Projects\Programming\Registrar\registrar\Views\Students\Create.cshtml"
Write(Html.LabelFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(179, 41, false);
#line 13 "D:\Projects\Programming\Registrar\registrar\Views\Students\Create.cshtml"
Write(Html.TextBoxFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(229, 38, false);
#line 15 "D:\Projects\Programming\Registrar\registrar\Views\Students\Create.cshtml"
Write(Html.LabelFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(274, 40, false);
#line 16 "D:\Projects\Programming\Registrar\registrar\Views\Students\Create.cshtml"
Write(Html.TextBoxFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(327, 27, false);
#line 18 "D:\Projects\Programming\Registrar\registrar\Views\Students\Create.cshtml"
Write(Html.Label("Select course"));

#line default
#line hidden
            EndContext();
            BeginContext(361, 29, false);
#line 19 "D:\Projects\Programming\Registrar\registrar\Views\Students\Create.cshtml"
Write(Html.DropDownList("CourseId"));

#line default
#line hidden
            EndContext();
            BeginContext(394, 74, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add new item\" class=\"btn btn-default\" />\r\n");
            EndContext();
#line 22 "D:\Projects\Programming\Registrar\registrar\Views\Students\Create.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Registrar.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
