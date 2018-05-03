// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type MailFolderMessageRulesCollectionRequestBuilder.
    /// </summary>
    public partial class MailFolderMessageRulesCollectionRequestBuilder : BaseRequestBuilder, IMailFolderMessageRulesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new MailFolderMessageRulesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public MailFolderMessageRulesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IMailFolderMessageRulesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IMailFolderMessageRulesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new MailFolderMessageRulesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IMessageRuleRequestBuilder"/> for the specified MailFolderMessageRule.
        /// </summary>
        /// <param name="id">The ID for the MailFolderMessageRule.</param>
        /// <returns>The <see cref="IMessageRuleRequestBuilder"/>.</returns>
        public IMessageRuleRequestBuilder this[string id]
        {
            get
            {
                return new MessageRuleRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
