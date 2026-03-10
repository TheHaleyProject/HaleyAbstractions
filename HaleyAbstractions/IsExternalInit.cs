// Required for 'init' property accessors on .NET Standard 2.x.
// .NET 5+ has this type built-in; polyfill it here for .NET Standard targets.
namespace System.Runtime.CompilerServices {
    internal static class IsExternalInit { }
}