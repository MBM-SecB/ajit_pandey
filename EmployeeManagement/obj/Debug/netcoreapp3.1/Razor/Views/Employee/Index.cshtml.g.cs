#pragma checksum "E:\ajit_pandey\EmployeeManagement\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8185ab68dd99fac325f696f7ef8aae96a94313a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8185ab68dd99fac325f696f7ef8aae96a94313a1", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3af35a328bfe0c906f75d04efeba14f80e1f583b", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\ajit_pandey\EmployeeManagement\Views\Employee\Index.cshtml"
  
  ViewData["Title"] = "Employee Home";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  

<h1>Displaying all employees .. </h1>

<table class=""table"">
  <thead class=""thead-dark"">
    <tr>
      
      <th scope=""col"">First</th>
      <th scope=""col"">Last</th>
      <th scope=""col"">Address</th>
      <th scope=""col"">Gender</th>
      <th scope=""col"">Salary</th>
    </tr>
  </thead>
  <tbody>
    
");
#nullable restore
#line 23 "E:\ajit_pandey\EmployeeManagement\Views\Employee\Index.cshtml"
     foreach (var employee in Model)
    {
    

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n        \r\n          <td>");
#nullable restore
#line 28 "E:\ajit_pandey\EmployeeManagement\Views\Employee\Index.cshtml"
         Write(employee.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 29 "E:\ajit_pandey\EmployeeManagement\Views\Employee\Index.cshtml"
         Write(employee.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 30 "E:\ajit_pandey\EmployeeManagement\Views\Employee\Index.cshtml"
         Write(employee.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 31 "E:\ajit_pandey\EmployeeManagement\Views\Employee\Index.cshtml"
         Write(employee.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 32 "E:\ajit_pandey\EmployeeManagement\Views\Employee\Index.cshtml"
         Write(employee.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 35 "E:\ajit_pandey\EmployeeManagement\Views\Employee\Index.cshtml"
        
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
