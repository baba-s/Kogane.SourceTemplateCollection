#if UNITY_EDITOR

using System;
using System.Collections.Generic;
using JetBrains.Annotations;

// ReSharper disable IdentifierTypo
// ReSharper disable InconsistentNaming

namespace Kogane
{
    [PublicAPI]
    [Obsolete( "", true )]
    public static class SourceTemplateCollection
    {
        [SourceTemplate]
        public static void log( this object self )
        {
            /*$ UnityEngine.Debug.Log( self ); */
        }

        [SourceTemplate]
        public static void logwarn( this object self )
        {
            /*$ UnityEngine.Debug.LogWarning( self ); */
        }

        [SourceTemplate]
        public static void logerr( this object self )
        {
            /*$ UnityEngine.Debug.LogError( self ); */
        }

        [SourceTemplate]
        [Macro( Target = "separator" )]
        [Macro( Target = "variable" )]
        public static void join( this IEnumerable<string> self )
        {
            /*$ var $variable$ = string.Join( "$separator$", self ); */
        }
    }
}

#endif