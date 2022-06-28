// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The expression. </summary>
    public partial class Expression
    {
        /// <summary> Initializes a new instance of Expression. </summary>
        internal Expression()
        {
            Subexpressions = new ChangeTrackingList<Expression>();
        }

        /// <summary> Initializes a new instance of Expression. </summary>
        /// <param name="text"> The text. </param>
        /// <param name="value"> Anything. </param>
        /// <param name="subexpressions"> The sub expressions. </param>
        /// <param name="error"> The azure resource error info. </param>
        internal Expression(string text, BinaryData value, IReadOnlyList<Expression> subexpressions, AzureResourceErrorInfo error)
        {
            Text = text;
            Value = value;
            Subexpressions = subexpressions;
            Error = error;
        }

        /// <summary> The text. </summary>
        public string Text { get; }
        /// <summary> Anything. </summary>
        public BinaryData Value { get; }
        /// <summary> The sub expressions. </summary>
        public IReadOnlyList<Expression> Subexpressions { get; }
        /// <summary> The azure resource error info. </summary>
        public AzureResourceErrorInfo Error { get; }
    }
}
