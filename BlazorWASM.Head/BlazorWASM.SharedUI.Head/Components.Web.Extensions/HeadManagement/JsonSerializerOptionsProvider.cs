// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Text.Json;

namespace Microsoft.AspNetCore.Components
{
    internal static class JsonSerializerOptionsProvider
    {
        //JsonSerializerDefaults.Web
        public static readonly JsonSerializerOptions Options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true, PropertyNamingPolicy = JsonNamingPolicy.CamelCase};
    }
}