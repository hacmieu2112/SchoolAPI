#pragma checksum "C:\Users\Doktoh\source\repos\BlazorSchool\BlazorSchool\Pages\Classroom.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57ac2b9ec51c543138bd6b82cebb676d903bfabf"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorSchool.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Doktoh\source\repos\BlazorSchool\BlazorSchool\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Doktoh\source\repos\BlazorSchool\BlazorSchool\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Doktoh\source\repos\BlazorSchool\BlazorSchool\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Doktoh\source\repos\BlazorSchool\BlazorSchool\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Doktoh\source\repos\BlazorSchool\BlazorSchool\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Doktoh\source\repos\BlazorSchool\BlazorSchool\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Doktoh\source\repos\BlazorSchool\BlazorSchool\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Doktoh\source\repos\BlazorSchool\BlazorSchool\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Doktoh\source\repos\BlazorSchool\BlazorSchool\_Imports.razor"
using BlazorSchool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Doktoh\source\repos\BlazorSchool\BlazorSchool\_Imports.razor"
using BlazorSchool.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Doktoh\source\repos\BlazorSchool\BlazorSchool\Pages\Classroom.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Doktoh\source\repos\BlazorSchool\BlazorSchool\Pages\Classroom.razor"
using BlazorSchool.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Doktoh\source\repos\BlazorSchool\BlazorSchool\Pages\Classroom.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/classroom")]
    public partial class Classroom : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Classroom</h3>");
#nullable restore
#line 11 "C:\Users\Doktoh\source\repos\BlazorSchool\BlazorSchool\Pages\Classroom.razor"
 if (classroom == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 14 "C:\Users\Doktoh\source\repos\BlazorSchool\BlazorSchool\Pages\Classroom.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "border", "1");
            __builder.AddAttribute(4, "style", "text-align:center");
            __builder.AddMarkupContent(5, "<tr><th>Class</th>\r\n            <th>Student</th></tr>");
#nullable restore
#line 22 "C:\Users\Doktoh\source\repos\BlazorSchool\BlazorSchool\Pages\Classroom.razor"
         foreach (var c in classroom)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 25 "C:\Users\Doktoh\source\repos\BlazorSchool\BlazorSchool\Pages\Classroom.razor"
                     c.ClassName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 26 "C:\Users\Doktoh\source\repos\BlazorSchool\BlazorSchool\Pages\Classroom.razor"
                     c.StudentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\Doktoh\source\repos\BlazorSchool\BlazorSchool\Pages\Classroom.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 30 "C:\Users\Doktoh\source\repos\BlazorSchool\BlazorSchool\Pages\Classroom.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\Doktoh\source\repos\BlazorSchool\BlazorSchool\Pages\Classroom.razor"
       
    List<ClassroomModel> classroom;


    protected override async Task OnInitializedAsync()
    {
        string sql = "SELECT class.ClassName, student.StudentName FROM studentinclass,student,class WHERE class.ClassID = studentinclass.ClassID AND studentinclass.StudentID = student.StudentID";

        classroom = await _data.LoadData<ClassroomModel, dynamic>(sql, new { }, _config.GetConnectionString("default"));
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591
