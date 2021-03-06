// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

// <auto-generated>

using System;
using Microsoft.CodeAnalysis;

namespace Roslynator.Formatting.CSharp
{
    public static partial class AnalyzerOptions
    {
        /// <summary>RCS0011i</summary>
        public static readonly DiagnosticDescriptor RemoveEmptyLineBetweenSingleLineAccessors = DiagnosticDescriptorFactory.Default.Create(
            id:                 AnalyzerOptionIdentifiers.RemoveEmptyLineBetweenSingleLineAccessors, 
            title:              "Remove empty line between single-line accessors.", 
            messageFormat:      "Remove empty line between single-line accessors.", 
            category:           DiagnosticCategories.AnalyzerOption, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        AnalyzerOptionIdentifiers.RemoveEmptyLineBetweenSingleLineAccessors, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0015i</summary>
        public static readonly DiagnosticDescriptor RemoveEmptyLineBetweenUsingDirectivesWithDifferentRootNamespace = DiagnosticDescriptorFactory.Default.Create(
            id:                 AnalyzerOptionIdentifiers.RemoveEmptyLineBetweenUsingDirectivesWithDifferentRootNamespace, 
            title:              "Remove empty line between using directives with different root namespace.", 
            messageFormat:      "Remove empty line between using directives with different root namespace.", 
            category:           DiagnosticCategories.AnalyzerOption, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        AnalyzerOptionIdentifiers.RemoveEmptyLineBetweenUsingDirectivesWithDifferentRootNamespace, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0027i</summary>
        public static readonly DiagnosticDescriptor AddNewLineAfterBinaryOperatorInsteadOfBeforeIt = DiagnosticDescriptorFactory.Default.Create(
            id:                 AnalyzerOptionIdentifiers.AddNewLineAfterBinaryOperatorInsteadOfBeforeIt, 
            title:              "Add newline after binary operator instead of before it.", 
            messageFormat:      "Add newline after binary operator instead of before it.", 
            category:           DiagnosticCategories.AnalyzerOption, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        AnalyzerOptionIdentifiers.AddNewLineAfterBinaryOperatorInsteadOfBeforeIt, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0028i</summary>
        public static readonly DiagnosticDescriptor AddNewLineAfterConditionalOperatorInsteadOfBeforeIt = DiagnosticDescriptorFactory.Default.Create(
            id:                 AnalyzerOptionIdentifiers.AddNewLineAfterConditionalOperatorInsteadOfBeforeIt, 
            title:              "Add newline after conditional operator instead of before it.", 
            messageFormat:      "Add newline after conditional operator instead of before it.", 
            category:           DiagnosticCategories.AnalyzerOption, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        AnalyzerOptionIdentifiers.AddNewLineAfterConditionalOperatorInsteadOfBeforeIt, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0032i</summary>
        public static readonly DiagnosticDescriptor AddNewLineAfterExpressionBodyArrowInsteadOfBeforeIt = DiagnosticDescriptorFactory.Default.Create(
            id:                 AnalyzerOptionIdentifiers.AddNewLineAfterExpressionBodyArrowInsteadOfBeforeIt, 
            title:              "Add newline after expression-body arrow instead of before it.", 
            messageFormat:      "Add newline after expression-body arrow instead of before it.", 
            category:           DiagnosticCategories.AnalyzerOption, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        AnalyzerOptionIdentifiers.AddNewLineAfterExpressionBodyArrowInsteadOfBeforeIt, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0051i</summary>
        public static readonly DiagnosticDescriptor RemoveNewLineBetweenClosingBraceAndWhileKeyword = DiagnosticDescriptorFactory.Default.Create(
            id:                 AnalyzerOptionIdentifiers.RemoveNewLineBetweenClosingBraceAndWhileKeyword, 
            title:              "Remove newline between closing brace and 'while' keyword.", 
            messageFormat:      "Remove newline between closing brace and 'while' keyword.", 
            category:           DiagnosticCategories.AnalyzerOption, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        AnalyzerOptionIdentifiers.RemoveNewLineBetweenClosingBraceAndWhileKeyword, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0052i</summary>
        public static readonly DiagnosticDescriptor AddNewLineAfterEqualsSignInsteadOfBeforeIt = DiagnosticDescriptorFactory.Default.Create(
            id:                 AnalyzerOptionIdentifiers.AddNewLineAfterEqualsSignInsteadOfBeforeIt, 
            title:              "Add newline after equals sign instead of before it.", 
            messageFormat:      "Add newline after equals sign instead of before it.", 
            category:           DiagnosticCategories.AnalyzerOption, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        AnalyzerOptionIdentifiers.AddNewLineAfterEqualsSignInsteadOfBeforeIt, 
            customTags:         Array.Empty<string>());

        public static bool IsEnabled(CompilationOptions compilationOptions, DiagnosticDescriptor analyzerOption)
        {
            switch (analyzerOption.Id)
            {
                case AnalyzerOptionIdentifiers.RemoveEmptyLineBetweenSingleLineAccessors:
                {
                    return !compilationOptions.IsAnalyzerSuppressed(DiagnosticDescriptors.AddEmptyLineBetweenSingleLineAccessorsOrViceVersa) && !compilationOptions.IsAnalyzerSuppressed(AnalyzerOptions.RemoveEmptyLineBetweenSingleLineAccessors);
                }

                case AnalyzerOptionIdentifiers.RemoveEmptyLineBetweenUsingDirectivesWithDifferentRootNamespace:
                {
                    return !compilationOptions.IsAnalyzerSuppressed(DiagnosticDescriptors.AddEmptyLineBetweenUsingDirectivesWithDifferentRootNamespaceOrViceVersa) && !compilationOptions.IsAnalyzerSuppressed(AnalyzerOptions.RemoveEmptyLineBetweenUsingDirectivesWithDifferentRootNamespace);
                }

                case AnalyzerOptionIdentifiers.AddNewLineAfterBinaryOperatorInsteadOfBeforeIt:
                {
                    return !compilationOptions.IsAnalyzerSuppressed(DiagnosticDescriptors.AddNewLineBeforeBinaryOperatorInsteadOfAfterItOrViceVersa) && !compilationOptions.IsAnalyzerSuppressed(AnalyzerOptions.AddNewLineAfterBinaryOperatorInsteadOfBeforeIt);
                }

                case AnalyzerOptionIdentifiers.AddNewLineAfterConditionalOperatorInsteadOfBeforeIt:
                {
                    return !compilationOptions.IsAnalyzerSuppressed(DiagnosticDescriptors.AddNewLineBeforeConditionalOperatorInsteadOfAfterItOrViceVersa) && !compilationOptions.IsAnalyzerSuppressed(AnalyzerOptions.AddNewLineAfterConditionalOperatorInsteadOfBeforeIt);
                }

                case AnalyzerOptionIdentifiers.AddNewLineAfterExpressionBodyArrowInsteadOfBeforeIt:
                {
                    return !compilationOptions.IsAnalyzerSuppressed(DiagnosticDescriptors.AddNewLineBeforeExpressionBodyArrowInsteadOfAfterItOrViceVersa) && !compilationOptions.IsAnalyzerSuppressed(AnalyzerOptions.AddNewLineAfterExpressionBodyArrowInsteadOfBeforeIt);
                }

                case AnalyzerOptionIdentifiers.RemoveNewLineBetweenClosingBraceAndWhileKeyword:
                {
                    return !compilationOptions.IsAnalyzerSuppressed(DiagnosticDescriptors.AddNewLineBetweenClosingBraceAndWhileKeywordOrViceVersa) && !compilationOptions.IsAnalyzerSuppressed(AnalyzerOptions.RemoveNewLineBetweenClosingBraceAndWhileKeyword);
                }

                case AnalyzerOptionIdentifiers.AddNewLineAfterEqualsSignInsteadOfBeforeIt:
                {
                    return !compilationOptions.IsAnalyzerSuppressed(DiagnosticDescriptors.AddNewLineBeforeEqualsSignInsteadOfAfterItOrViceVersa) && !compilationOptions.IsAnalyzerSuppressed(AnalyzerOptions.AddNewLineAfterEqualsSignInsteadOfBeforeIt);
                }

                default:
                {
                    throw new ArgumentException("", nameof(analyzerOption));
                }
            }
        }
    }
}