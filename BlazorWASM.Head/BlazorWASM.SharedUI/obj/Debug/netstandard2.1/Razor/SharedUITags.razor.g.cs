#pragma checksum "C:\Users\anton\Documents\A2\GitHub\blazor-wasm-head-components\BlazorWASM.Head\BlazorWASM.SharedUI\SharedUITags.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cbc0d864a5a3917996962b73031a94b748128c0"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWASM.SharedUI
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\anton\Documents\A2\GitHub\blazor-wasm-head-components\BlazorWASM.Head\BlazorWASM.SharedUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\anton\Documents\A2\GitHub\blazor-wasm-head-components\BlazorWASM.Head\BlazorWASM.SharedUI\SharedUITags.razor"
using Microsoft.AspNetCore.Components.Web.Extensions.Head;

#line default
#line hidden
#nullable disable
    public partial class SharedUITags : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Web.Extensions.Head.Title>(0);
            __builder.AddAttribute(1, "value", "Shared UI project");
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Web.Extensions.Head.Meta>(3);
            __builder.AddAttribute(4, "name", "description");
            __builder.AddAttribute(5, "content", "My Blazor Component");
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Web.Extensions.Head.Link>(7);
            __builder.AddAttribute(8, "rel", "icon");
            __builder.AddAttribute(9, "type", "image/x-icon");
            __builder.AddAttribute(10, "href", "/favicon.ico");
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Web.Extensions.Head.Link>(12);
            __builder.AddAttribute(13, "rel", "alternate");
            __builder.AddAttribute(14, "href", "/feed.rss");
            __builder.AddAttribute(15, "type", "application/rss+xml");
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n\r\n");
            __builder.AddMarkupContent(17, "<div class=\"my-component\">\r\n    This Blazor component is defined in the <strong>BlazorWASM.SharedUI</strong> package.\r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
