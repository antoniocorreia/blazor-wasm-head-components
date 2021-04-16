# Blazor WASM - Head tags
Blazor WASM project with razor components to add title, description and meta tags into &lt;head>

The solution contains two folders
+ .NET5
+ .NETSTANDARD2.1

# .NET5
Simple WASM project with server project using https://www.nuget.org/packages/Microsoft.AspNetCore.Components.Web.Extensions 5.0.0-preview.8.20414.8.
1. Just add the reference to `headManager.js` inside the `index.html`
2. Use `Title, Link and Meta` components as present in `Index.razor`

# .NETStandard2.1
Since I'm working in a couple of projects using a razor class library project that is .NETStandard2.1 I had to modify the `HeadManagementJSObjectReference.cs` in order to migrate the Microsoft.AspNetCore.Components.Web.Extensions project to .NETStandard.
This project contains a shared UI project (Razor Class Library) and the source of the Microsoft extensions project (downloaded from https://github.com/aspnet/AspLabs/tree/main/src/Components.Web.Extensions)
1. Reference the Microsoft.AspNetCore.Components.Web.Extensions inside this folder
2. Add the `headManager.js` inside `wwwroot` folder and reference inside the `index.html`
3. Use `Title, Link and Meta` components as present in `SharedUITags.razor`
