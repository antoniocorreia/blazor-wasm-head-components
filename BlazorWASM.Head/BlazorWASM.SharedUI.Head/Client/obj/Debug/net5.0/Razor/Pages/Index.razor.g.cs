#pragma checksum "C:\Users\anton\Documents\A2\GitHub\blazor-wasm-head-components\BlazorWASM.Head\BlazorWASM.SharedUI.Head\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "097d0a95a68cc54ef04717bd3712940e207cfac6"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWASM.SharedUI.Head.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\anton\Documents\A2\GitHub\blazor-wasm-head-components\BlazorWASM.Head\BlazorWASM.SharedUI.Head\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anton\Documents\A2\GitHub\blazor-wasm-head-components\BlazorWASM.Head\BlazorWASM.SharedUI.Head\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\anton\Documents\A2\GitHub\blazor-wasm-head-components\BlazorWASM.Head\BlazorWASM.SharedUI.Head\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\anton\Documents\A2\GitHub\blazor-wasm-head-components\BlazorWASM.Head\BlazorWASM.SharedUI.Head\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\anton\Documents\A2\GitHub\blazor-wasm-head-components\BlazorWASM.Head\BlazorWASM.SharedUI.Head\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\anton\Documents\A2\GitHub\blazor-wasm-head-components\BlazorWASM.Head\BlazorWASM.SharedUI.Head\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\anton\Documents\A2\GitHub\blazor-wasm-head-components\BlazorWASM.Head\BlazorWASM.SharedUI.Head\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\anton\Documents\A2\GitHub\blazor-wasm-head-components\BlazorWASM.Head\BlazorWASM.SharedUI.Head\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\anton\Documents\A2\GitHub\blazor-wasm-head-components\BlazorWASM.Head\BlazorWASM.SharedUI.Head\Client\_Imports.razor"
using BlazorWASM.SharedUI.Head.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\anton\Documents\A2\GitHub\blazor-wasm-head-components\BlazorWASM.Head\BlazorWASM.SharedUI.Head\Client\_Imports.razor"
using BlazorWASM.SharedUI.Head.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\anton\Documents\A2\GitHub\blazor-wasm-head-components\BlazorWASM.Head\BlazorWASM.SharedUI.Head\Client\Pages\Index.razor"
using BlazorWASM.SharedUI;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BlazorWASM.SharedUI.SharedUITags>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.AddMarkupContent(2, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<BlazorWASM.SharedUI.Head.Client.Shared.SurveyPrompt>(3);
            __builder.AddAttribute(4, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
