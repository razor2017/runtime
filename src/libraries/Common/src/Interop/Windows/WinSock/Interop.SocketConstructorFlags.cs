// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

internal static partial class Interop
{
    internal static partial class Winsock
    {
        // Used as last parameter to WSASocket call.
        [Flags]
        internal enum SocketConstructorFlags
        {
            WSA_FLAG_OVERLAPPED = 0x01,
            WSA_FLAG_MULTIPOINT_C_ROOT = 0x02,
            WSA_FLAG_MULTIPOINT_C_LEAF = 0x04,
            WSA_FLAG_MULTIPOINT_D_ROOT = 0x08,
            WSA_FLAG_MULTIPOINT_D_LEAF = 0x10,
            WSA_FLAG_NO_HANDLE_INHERIT = 0x80,
        }
    }
}
