// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenComponent<Test.MyComponent<string, int>>(0);
            builder.AddAttribute(1, "Item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                                              "hi"

#line default
#line hidden
#nullable disable
            ));
            builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<string>)((context) => (builder2) => {
                builder2.OpenElement(3, "div");
                builder2.AddContent(4, 
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                      context.ToLower()

#line default
#line hidden
#nullable disable
                );
                builder2.CloseElement();
            }
            ));
            builder.AddAttribute(5, "AnotherChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Test.MyComponent<string, int>.Context>)((item) => (builder2) => {
                builder2.AddMarkupContent(6, "\r\n  ");
                builder2.AddContent(7, 
#nullable restore
#line 4 "x:\dir\subdir\Test\TestComponent.cshtml"
   System.Math.Max(0, item.Item)

#line default
#line hidden
#nullable disable
                );
                builder2.AddMarkupContent(8, ";\r\n");
            }
            ));
            builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
