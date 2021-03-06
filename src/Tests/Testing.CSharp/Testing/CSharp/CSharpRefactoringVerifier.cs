// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading;
using Roslynator.Testing;

namespace Roslynator.Testing.CSharp
{
    /// <summary>
    /// Represents verifier for a C# refactoring that is provided by <see cref="RefactoringVerifier.RefactoringProvider"/>
    /// </summary>
    public abstract class CSharpRefactoringVerifier : RefactoringVerifier
    {
        private CSharpCodeVerificationOptions _options;

        /// <summary>
        /// Initializes a new instance of <see cref="CSharpRefactoringVerifier"/>.
        /// </summary>
        /// <param name="assert"></param>
        protected CSharpRefactoringVerifier(IAssert assert) : base(CSharpWorkspaceFactory.Instance, assert)
        {
        }

        /// <summary>
        /// Gets a code verification options.
        /// </summary>
        new public CSharpCodeVerificationOptions Options
        {
            get
            {
                if (_options == null)
                    Interlocked.CompareExchange(ref _options, CreateAndUpdateOptions(), null);

                return _options;
            }
        }

        /// <summary>
        /// Gets a common code verification options.
        /// </summary>
        protected override CodeVerificationOptions CommonOptions => Options;

        private CSharpCodeVerificationOptions CreateAndUpdateOptions()
        {
            CSharpCodeVerificationOptions options = CreateOptions();

            return UpdateOptions(options);
        }

        /// <summary>
        /// Creates a new code verification options.
        /// </summary>
        protected virtual CSharpCodeVerificationOptions CreateOptions()
        {
            return CSharpCodeVerificationOptions.Default;
        }

        /// <summary>
        /// Updates a code verification options.
        /// </summary>
        /// <param name="options"></param>
        protected virtual CSharpCodeVerificationOptions UpdateOptions(CSharpCodeVerificationOptions options)
        {
            return options;
        }
    }
}
