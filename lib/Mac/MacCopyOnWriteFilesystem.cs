﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.CopyOnWrite.Mac;

internal sealed class MacCopyOnWriteFilesystem : ICopyOnWriteFilesystem
{
    public int MaxClonesPerFile => int.MaxValue;

    public bool CopyOnWriteLinkSupportedBetweenPaths(string source, string destination)
    {
        // AppleFS always supports CoW.
        // return true;
        throw new NotImplementedException();
    }

    public bool CopyOnWriteLinkSupportedInDirectoryTree(string rootDirectory)
    {
        // AppleFS always supports CoW.
        // return true;
        throw new NotImplementedException();
    }

    public void CloneFile(string source, string destination) => CloneFile(source, destination, CloneFlags.None);

    public void CloneFile(string source, string destination, CloneFlags cloneFlags)
    {
        // TODO: Use clonefile().
        throw new NotImplementedException();
    }

    public
#if NET6_0 || NETSTANDARD2_1
    ValueTask
#elif NETSTANDARD2_0
    Task
#else
#error Target Framework not supported
#endif
    CloneFileAsync(string source, string destination, CloneFlags cloneFlags, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public void ClearFilesystemCache()
    {
        throw new NotImplementedException();
    }
}
