#pragma checksum "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\Pages\EditStudent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85a4901c6f67001b8cfaa6e57ba57bab5d60c920"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/editstudent")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/editstudent/{Id}")]
    public partial class EditStudent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.AddMarkupContent(2, "<h1>Details</h1>\r\n\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\Pages\EditStudent.razor"
                      student

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\Pages\EditStudent.razor"
                                               HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\Pages\EditStudent.razor"
                                                                                    HandleInvalidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.AddMarkupContent(16, "<label>Student ID</label>\r\n            ");
                __Blazor.BlazorSchoolWASM.Pages.EditStudent.TypeInference.CreateInputNumber_0(__builder2, 17, 18, true, 19, "form-control", 20, "ID", 21, 
#nullable restore
#line 12 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\Pages\EditStudent.razor"
                                                                      student.StudentID

#line default
#line hidden
#nullable disable
                , 22, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => student.StudentID = __value, student.StudentID)), 23, () => student.StudentID);
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group");
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.AddMarkupContent(29, "<label>Student Name</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "id", "Name");
                __builder2.AddAttribute(33, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\Pages\EditStudent.razor"
                                                          student.StudentName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => student.StudentName = __value, student.StudentName))));
                __builder2.AddAttribute(35, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => student.StudentName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group");
                __builder2.AddMarkupContent(40, "\r\n            ");
                __builder2.AddMarkupContent(41, "<button type=\"submit\" class=\"btn btn-warning\">Save Item</button>\r\n\r\n");
#nullable restore
#line 21 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\Pages\EditStudent.razor"
             if (!String.IsNullOrEmpty(Id))
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(42, "                ");
                __builder2.OpenElement(43, "a");
                __builder2.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\Pages\EditStudent.razor"
                              DeleteStudent

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "class", "btn btn-danger");
                __builder2.AddContent(46, "Delete");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n");
#nullable restore
#line 24 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\Pages\EditStudent.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(48, "            ");
                __builder2.OpenElement(49, "a");
                __builder2.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\Pages\EditStudent.razor"
                          goback

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "class", "btn");
                __builder2.AddContent(52, "Back");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n\r\n        ");
                __builder2.OpenElement(55, "label");
                __builder2.AddContent(56, 
#nullable restore
#line 28 "C:\Users\AnhNTK13\Downloads\SchoolAPI-main\SchoolAPI-main\BlazorSchool\BlazorSchoolWASM\Pages\EditStudent.razor"
                Message

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(58, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.BlazorSchoolWASM.Pages.EditStudent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "disabled", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "id", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
