#pragma checksum "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\Pages\School.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a76d23aa15efbcb40f995e88353b5b247f8b7fbb"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorSchoolWASM.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\_Imports.razor"
using BlazorSchoolWASM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\_Imports.razor"
using BlazorSchoolWASM.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/School")]
    public partial class School : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Student</h1>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\Pages\School.razor"
 if (students == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p>Loading ...</p>\r\n");
#nullable restore
#line 8 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\Pages\School.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <td>Student ID</td>\r\n                <td>Student Name</td>\r\n                <td></td>\r\n                <td></td>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 21 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\Pages\School.razor"
             foreach (var item in students)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 24 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\Pages\School.razor"
                         item.StudentID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 25 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\Pages\School.razor"
                         item.StudentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "href", 
#nullable restore
#line 27 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\Pages\School.razor"
                                   $"editstudent/{item.StudentID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(23, "class", "btn btn-warning");
            __builder.AddContent(24, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 30 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\Pages\School.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "href", 
#nullable restore
#line 33 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\Pages\School.razor"
               $"/editstudent"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(33, "class", "btn btn-success");
            __builder.AddContent(34, "Add New Student");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 34 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\Pages\School.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
