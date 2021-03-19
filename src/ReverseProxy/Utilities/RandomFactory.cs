// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;

namespace Yarp.ReverseProxy.Utilities
{
    /// <inheritdoc/>
    internal class RandomFactory : IRandomFactory
    {
        /// <inheritdoc/>
        public Random CreateRandomInstance()
        {
            return ThreadStaticRandom.Instance;
        }
    }
}
