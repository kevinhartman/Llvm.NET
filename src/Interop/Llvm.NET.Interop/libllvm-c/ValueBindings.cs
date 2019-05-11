// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 2.17941.31104.49410
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.CodeDom.Compiler;
using System.Runtime.InteropServices;
using System.Security;

namespace Llvm.NET.Interop
{
    /// <include file="ValueBindings.xml" path='LibLLVMAPI/Delegate[@name="LibLLVMValueCacheItemDeletedCallback"]/*' />
    [UnmanagedFunctionPointer( global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
    public delegate void LibLLVMValueCacheItemDeletedCallback( LLVMValueRef @ref, System.IntPtr handle );

    /// <include file="ValueBindings.xml" path='LibLLVMAPI/Delegate[@name="LibLLVMValueCacheItemReplacedCallback"]/*' />
    [UnmanagedFunctionPointer( global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
    public delegate System.IntPtr LibLLVMValueCacheItemReplacedCallback( LLVMValueRef oldValue, System.IntPtr handle, LLVMValueRef newValue );

    public static partial class NativeMethods
    {
        /// <include file="ValueBindings.xml" path='LibLLVMAPI/Function[@name="LibLLVMIsConstantZeroValue"]/*' />
        [return: MarshalAs( UnmanagedType.Bool )]
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern bool LibLLVMIsConstantZeroValue( LLVMValueRef valueRef );

        /// <include file="ValueBindings.xml" path='LibLLVMAPI/Function[@name="LibLLVMRemoveGlobalFromParent"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LibLLVMRemoveGlobalFromParent( LLVMValueRef valueRef );

        /// <include file="ValueBindings.xml" path='LibLLVMAPI/Function[@name="LibLLVMGetValueID"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern int LibLLVMGetValueID( LLVMValueRef valueRef );

        /// <include file="ValueBindings.xml" path='LibLLVMAPI/Function[@name="LibLLVMGetAliasee"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMValueRef LibLLVMGetAliasee( LLVMValueRef Val );

        /// <include file="ValueBindings.xml" path='LibLLVMAPI/Function[@name="LibLLVMGetArgumentIndex"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern System.UInt32 LibLLVMGetArgumentIndex( LLVMValueRef Val );

        /// <include file="ValueBindings.xml" path='LibLLVMAPI/Function[@name="LibLLVMGlobalObjectGetComdat"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMComdatRef LibLLVMGlobalObjectGetComdat( LLVMValueRef Val );

        /// <include file="ValueBindings.xml" path='LibLLVMAPI/Function[@name="LibLLVMGlobalObjectSetComdat"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LibLLVMGlobalObjectSetComdat( LLVMValueRef Val, LLVMComdatRef comdatRef );

        /// <include file="ValueBindings.xml" path='LibLLVMAPI/Function[@name="LibLLVMGlobalVariableAddDebugExpression"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LibLLVMGlobalVariableAddDebugExpression( LLVMValueRef globalVar, LLVMMetadataRef exp );

        /// <include file="ValueBindings.xml" path='LibLLVMAPI/Function[@name="LibLLVMFunctionAppendBasicBlock"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LibLLVMFunctionAppendBasicBlock( LLVMValueRef function, LLVMBasicBlockRef block );

        /// <include file="ValueBindings.xml" path='LibLLVMAPI/Function[@name="LibLLVMValueAsMetadataGetValue"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMValueRef LibLLVMValueAsMetadataGetValue( LLVMMetadataRef vmd );

        /// <include file="ValueBindings.xml" path='LibLLVMAPI/Function[@name="LibLLVMCreateValueCache"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LibLLVMValueCacheRef LibLLVMCreateValueCache( LibLLVMValueCacheItemDeletedCallback deletedCallback, LibLLVMValueCacheItemReplacedCallback replacedCallback );

        /// <include file="ValueBindings.xml" path='LibLLVMAPI/Function[@name="LibLLVMValueCacheAdd"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LibLLVMValueCacheAdd( LibLLVMValueCacheRef cacheRef, LLVMValueRef value, System.IntPtr handle );

        /// <include file="ValueBindings.xml" path='LibLLVMAPI/Function[@name="LibLLVMValueCacheLookup"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern System.IntPtr LibLLVMValueCacheLookup( LibLLVMValueCacheRef cacheRef, LLVMValueRef valueRef );

    }
}