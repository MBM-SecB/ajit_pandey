#pragma checksum "E:\ajit_pandey\EmployeeManagement\Views\Employee\detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "760a3cf1ecad4204dc79845adf3a79b7d1aabae3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_detail), @"mvc.1.0.view", @"/Views/Employee/detail.cshtml")]
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
#line 1 "E:\ajit_pandey\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ajit_pandey\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"760a3cf1ecad4204dc79845adf3a79b7d1aabae3", @"/Views/Employee/detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3af35a328bfe0c906f75d04efeba14f80e1f583b", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Employee Details</h1>\r\n<ul class=\"list-group\">\r\n  <li class=\"list-group-item\">Dapibus ac facilisis in</li>\r\n\r\n  \r\n  <li class=\"list-group-item list-group-item-primary\">First Name: ");
#nullable restore
#line 8 "E:\ajit_pandey\EmployeeManagement\Views\Employee\detail.cshtml"
                                                             Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item list-group-item-secondary\">Last Name: ");
#nullable restore
#line 9 "E:\ajit_pandey\EmployeeManagement\Views\Employee\detail.cshtml"
                                                              Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item list-group-item-success\">Address: ");
#nullable restore
#line 10 "E:\ajit_pandey\EmployeeManagement\Views\Employee\detail.cshtml"
                                                          Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item list-group-item-danger\">Gender: ");
#nullable restore
#line 11 "E:\ajit_pandey\EmployeeManagement\Views\Employee\detail.cshtml"
                                                        Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item list-group-item-warning\">Salary: ");
#nullable restore
#line 12 "E:\ajit_pandey\EmployeeManagement\Views\Employee\detail.cshtml"
                                                         Write(Model.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n  \r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591