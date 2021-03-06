﻿
// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage(
    "Performance",
    "RCS1080:Use 'Count/Length' property instead of 'Any' method.",
    Justification = "This project prefers the clarity of Any().")]

[assembly: SuppressMessage(
    "Language Usage Opportunities",
    "RECS0002:Convert anonymous method to method group",
    Justification = "Specifying parameter names helps with code clarity",
    Scope = "type",
    Target = "Microsoft.Azure.Batch.SoftwareEntitlement.ServerOptionBuilder")]

[assembly: SuppressMessage(
    "Language Usage Opportunities",
    "RECS0002:Convert anonymous method to method group",
    Justification = "Specifying parameter names helps with code clarity",
    Scope = "type",
    Target = "Microsoft.Azure.Batch.SoftwareEntitlement.NodeEntitlementsBuilder")]
