﻿// <copyright file="DITypeArray.cs" company=".NET Foundation">
// Copyright (c) .NET Foundation. All rights reserved.
// </copyright>

using System.Diagnostics.CodeAnalysis;

namespace Llvm.NET.DebugInfo
{
    /// <summary>Array of <see cref="DILocalVariable"/> nodes for use with see <see cref="DebugInfoBuilder"/> methods</summary>
    [SuppressMessage( "Naming", "CA1710:Identifiers should have correct suffix", Justification = "Name matches underlying LLVM and is descriptive of what it is" )]
    public class DILocalVariableArray
        : TupleTypedArrayWrapper<DILocalVariable>
    {
        internal DILocalVariableArray( MDTuple tuple )
            : base( tuple )
        {
        }
    }
}