﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Configuration;
using System.Net.Http;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Connector.Authentication;
using Microsoft.Bot.Schema;
using Microsoft.Extensions.Logging;
using Microsoft.Rest;

namespace Microsoft.Bot.Builder.Integration.AspNet.WebApi
{
    /// <summary>
    /// Creates a cloud environment instance from configuration.
    /// </summary>
    public class ConfigurationCloudEnvironment : ICloudEnvironment
    {
        private ICloudEnvironment _inner;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationCloudEnvironment"/> class.
        /// </summary>
        /// <param name="credentialsFactory">An IServiceClientCredentialsFactory instance.</param>
        /// <param name="authConfiguration">An AuthenticationConfiguration instance.</param>
        /// <param name="httpClient">A custom HttpClient to use.</param>
        /// <param name="logger">The ILOgger instance to use.</param>
        public ConfigurationCloudEnvironment(IServiceClientCredentialsFactory credentialsFactory = null, AuthenticationConfiguration authConfiguration = null, HttpClient httpClient = null, ILogger logger = null)
        {
            var channelService = ConfigurationManager.AppSettings["ChannelService"];
            var validateAuthority = ConfigurationManager.AppSettings["ValidateAuthority"];
            var toChannelFromBotLoginUrl = ConfigurationManager.AppSettings["ToChannelFromBotLoginUrl"];
            var toChannelFromBotOAuthScope = ConfigurationManager.AppSettings["ToChannelFromBotOAuthScope"];
            var toBotFromChannelTokenIssuer = ConfigurationManager.AppSettings["ToBotFromChannelTokenIssuer"];
            var oAuthUrl = ConfigurationManager.AppSettings["OAuthUrl"];
            var toBotFromChannelOpenIdMetadataUrl = ConfigurationManager.AppSettings["ToBotFromChannelOpenIdMetadataUrl"];
            var toBotFromEmulatorOpenIdMetadataUrl = ConfigurationManager.AppSettings["ToBotFromEmulatorOpenIdMetadataUrl"];
            var callerId = ConfigurationManager.AppSettings["CallerId"];

            _inner = CloudEnvironment.Create(
                channelService,
                bool.Parse(validateAuthority ?? "true"),
                toChannelFromBotLoginUrl,
                toChannelFromBotOAuthScope,
                toBotFromChannelTokenIssuer,
                oAuthUrl,
                toBotFromChannelOpenIdMetadataUrl,
                toBotFromEmulatorOpenIdMetadataUrl,
                callerId,
                credentialsFactory ?? new ConfigurationServiceClientCredentialFactory(),
                authConfiguration ?? new AuthenticationConfiguration(),
                httpClient,
                logger);
        }

        /// <inheritdoc/>
        public Task<(ClaimsIdentity claimsIdentity, ServiceClientCredentials credentials, string scope, string callerId)> AuthenticateRequestAsync(Activity activity, string authHeader, CancellationToken cancellationToken)
        {
            return _inner.AuthenticateRequestAsync(activity, authHeader, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<ServiceClientCredentials> GetProactiveCredentialsAsync(ClaimsIdentity claimsIdentity, string audience, CancellationToken cancellationToken)
        {
            return _inner.GetProactiveCredentialsAsync(claimsIdentity, audience, cancellationToken);
        }
    }
}
