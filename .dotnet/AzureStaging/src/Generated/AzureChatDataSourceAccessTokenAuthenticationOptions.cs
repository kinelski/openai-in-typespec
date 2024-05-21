// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Chat
{
    /// <summary> The AzureChatDataSourceAccessTokenAuthenticationOptions. </summary>
    public partial class AzureChatDataSourceAccessTokenAuthenticationOptions : AzureChatDataSourceAuthenticationOptions
    {
        /// <summary> Initializes a new instance of <see cref="AzureChatDataSourceAccessTokenAuthenticationOptions"/>. </summary>
        /// <param name="accessToken"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="accessToken"/> is null. </exception>
        internal AzureChatDataSourceAccessTokenAuthenticationOptions(string accessToken)
        {
            Argument.AssertNotNull(accessToken, nameof(accessToken));

            Type = "access_token";
            AccessToken = accessToken;
        }

        /// <summary> Initializes a new instance of <see cref="AzureChatDataSourceAccessTokenAuthenticationOptions"/>. </summary>
        /// <param name="type"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="accessToken"></param>
        internal AzureChatDataSourceAccessTokenAuthenticationOptions(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, string accessToken) : base(type, serializedAdditionalRawData)
        {
            AccessToken = accessToken;
        }

        /// <summary> Initializes a new instance of <see cref="AzureChatDataSourceAccessTokenAuthenticationOptions"/> for deserialization. </summary>
        internal AzureChatDataSourceAccessTokenAuthenticationOptions()
        {
        }

        /// <summary> Gets the access token. </summary>
        public string AccessToken { get; }
    }
}