﻿// <copyright file="Select.cs" company=".NET Foundation">
// Copyright (c) .NET Foundation. All rights reserved.
// </copyright>

using Llvm.NET.Interop;

namespace Llvm.NET.Instructions
{
    /// <summary>Select instruction</summary>
    public class SelectInstruction
        : Instruction
    {
        internal SelectInstruction( LLVMValueRef valueRef )
            : base( valueRef )
        {
        }
    }
}