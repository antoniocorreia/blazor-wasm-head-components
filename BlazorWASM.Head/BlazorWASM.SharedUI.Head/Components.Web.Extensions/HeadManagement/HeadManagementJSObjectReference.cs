// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace Microsoft.AspNetCore.Components.Web.Extensions.Head
{
    internal class HeadManagementJSObjectReference
    {
        private readonly IJSRuntime _jsRuntime;

        public HeadManagementJSObjectReference(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async ValueTask SetTitleAsync(string title)
        {
            await _jsRuntime.InvokeVoidAsync("setTitle", title);
        }

        public async ValueTask AddOrUpdateHeadTagAsync(TagElement tag, string id)
        {
            await _jsRuntime.InvokeVoidAsync("addOrUpdateHeadTag", tag, id);
        }

        public async ValueTask RemoveHeadTagAsync(string id)
        {
            await _jsRuntime.InvokeVoidAsync("removeHeadTag", id);
        }
    }
}
