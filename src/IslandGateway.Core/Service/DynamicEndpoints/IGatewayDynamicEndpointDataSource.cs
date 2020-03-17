﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Collections.Generic;
using AspNetCore = Microsoft.AspNetCore;

namespace IslandGateway.Core.Service
{
    /// <summary>
    /// Provides a method to update the list of ASP .NET Core Endpoints
    /// on an instance of <see cref="AspNetCore.Routing.EndpointDataSource"/>.
    /// </summary>
    internal interface IGatewayDynamicEndpointDataSource
    {
        /// <summary>
        /// Applies a new set of ASP .NET Core endpoints. Changes take effect immediately.
        /// </summary>
        /// <param name="endpoints">New endpoints to apply.</param>
        void Update(List<AspNetCore.Http.Endpoint> endpoints);
    }
}
