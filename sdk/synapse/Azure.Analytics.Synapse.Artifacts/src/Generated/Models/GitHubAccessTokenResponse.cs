// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The GitHubAccessTokenResponse. </summary>
    public partial class GitHubAccessTokenResponse
    {
        /// <summary> Initializes a new instance of <see cref="GitHubAccessTokenResponse"/>. </summary>
        internal GitHubAccessTokenResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GitHubAccessTokenResponse"/>. </summary>
        /// <param name="gitHubAccessToken"></param>
        internal GitHubAccessTokenResponse(string gitHubAccessToken)
        {
            GitHubAccessToken = gitHubAccessToken;
        }

        /// <summary> Gets the git hub access token. </summary>
        public string GitHubAccessToken { get; }
    }
}
