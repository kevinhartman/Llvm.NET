﻿// <copyright file="AssemblyInitialize.cs" company=".NET Foundation">
// Copyright (c) .NET Foundation. All rights reserved.
// </copyright>

using System;
using System.Diagnostics.CodeAnalysis;
using Llvm.NET;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[assembly: SuppressMessage( "StyleCop.CSharp.DocumentationRules", "SA1652:Enable XML documentation output", Justification = "Unit Tests" )]

namespace Llvm.NETTests
{
    // Provides common location for one time initialization for all tests in this assembly
    [TestClass]
    public static class AssemblyInitialize
    {
        [AssemblyInitialize]
        [SuppressMessage( "Redundancies in Symbol Declarations", "RECS0154:Parameter is never used", Justification = "Not needed and signature is defined by test framework" )]
        public static void InitializeAssembly(TestContext ctx)
        {
            LlvmInit = StaticState.InitializeLLVM( );
            StaticState.RegisterAll( );
        }

        [AssemblyCleanup]
        public static void UninitializeAssembly( ) => LlvmInit.Dispose( );

        private static IDisposable LlvmInit;
    }
}