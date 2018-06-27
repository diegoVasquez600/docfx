// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;

namespace Microsoft.Docs.Build
{
    internal static class BuildSchemaDocument
    {
        public static Task<DependencyMap> Build()
        {
            return Task.FromResult(DependencyMap.Empty);
        }
    }
}