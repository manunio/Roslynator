// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Roslynator.CSharp.Analyzers.Tests
{
    internal static class RemoveEmptyElseClause
    {
        private static void Foo()
        {
            bool condition = false;

            if (condition)
            {
                Foo();
            }
            else
            {
            }
        }
    }
}
