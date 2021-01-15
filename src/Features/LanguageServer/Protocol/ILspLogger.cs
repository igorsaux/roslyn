﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis.LanguageServer
{
    internal interface ILspLogger
    {
        void TraceInformation(string message);
        void TraceException(Exception exception);
    }

    internal class NoOpLspLogger : ILspLogger
    {
        public static readonly ILspLogger Instance = new NoOpLspLogger();

        private NoOpLspLogger()
        {
        }

        public void TraceException(Exception exception)
        {
        }

        public void TraceInformation(string message)
        {
        }
    }
}
