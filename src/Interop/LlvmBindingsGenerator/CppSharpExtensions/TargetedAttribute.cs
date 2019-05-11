﻿// -----------------------------------------------------------------------
// <copyright file="TargetedAttribute.cs" company=".NET Foundation">
// Copyright (c) .NET Foundation. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LlvmBindingsGenerator.CppSharpExtensions
{
    internal enum AttributeTarget
    {
        Default,
        Assembly,
        Module,
        Field,
        Event,
        Method,
        Param,
        Property,
        Return,
        Type
    }

    internal class TargetedAttribute
        : CppSharp.AST.Attribute
    {
        public TargetedAttribute( Type type, params string[ ] args )
            : this( AttributeTarget.Default, type, ( IEnumerable<string> )args )
        {
        }

        public TargetedAttribute( AttributeTarget target, Type type, params string[ ] args )
            : this( target, type, ( IEnumerable<string> )args )
        {
        }

        public TargetedAttribute( AttributeTarget target, Type type, IEnumerable<string> args )
        {
            if( !typeof( Attribute ).IsAssignableFrom( type ) )
            {
                throw new ArgumentException( "Attribute type required", nameof( type ) );
            }

            Type = type;
            Target = target;
            Value = string.Join( ", ", args );
        }

        public TargetedAttribute( AttributeTarget target, CppSharp.AST.Attribute other )
        {
            Type = other.Type;
            Value = other.Value;
            Target = target;
        }

        public void AddParameter( string param )
        {
            Value = $"{Value}, {param}";
        }

        public AttributeTarget Target { get; }
    }
}