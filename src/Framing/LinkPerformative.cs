﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Azure.Amqp.Framing
{
    using Microsoft.Azure.Amqp.Encoding;

    /// <summary>
    /// The base class of link performatives.
    /// </summary>
    public abstract class LinkPerformative : Performative
    {
        /// <summary>
        /// Initializes the object.
        /// </summary>
        /// <param name="name">The descriptor name.</param>
        /// <param name="code">The descriptor code.</param>
        protected LinkPerformative(AmqpSymbol name, ulong code)
            : base(name, code)
        {
        }

        /// <summary>
        /// Gets or sets the "handle" field.
        /// </summary>
        public uint? Handle { get; set; }
    }
}
