﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace PSRule.Rules
{
    /// <summary>
    /// Defines a serialized rule object.
    /// </summary>
    public sealed class RuleObject
    {
        public string Kind { get; set; }

        public string Name { get; set; }
    }
}
