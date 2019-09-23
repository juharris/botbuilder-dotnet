﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json.Linq;

namespace Microsoft.Bot.Builder.Integration.ApplicationInsights.WebApi
{
    /// <summary>
    /// Middleware for storing incoming activity on the HttpContext to make it available to the <see cref="TelemetryBotIdInitializer"/>.
    /// </summary>
    public class TelemetryInitializerMiddleware : IMiddleware
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryInitializerMiddleware"/> class.
        /// </summary>
        public TelemetryInitializerMiddleware()
        {
        }

        /// <summary>
        /// Stores the incoming activity as JSON in the items collection on the HttpContext.
        /// </summary>
        /// <param name="context">The context object for this turn.</param>
        /// <param name="nextTurn">The delegate to call to continue the bot middleware pipeline.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects
        /// or threads to receive notice of cancellation.</param>
        /// <returns>A task that represents the work queued to execute.</returns>
        /// <seealso cref="ITurnContext"/>
        /// <seealso cref="Bot.Schema.IActivity"/>
        public virtual async Task OnTurnAsync(ITurnContext context, NextDelegate nextTurn, CancellationToken cancellationToken)
        {
            BotAssert.ContextNotNull(context);

            if (context.Activity != null)
            {
                var activity = context.Activity;

                var httpContext = HttpContext.Current;
                var items = httpContext?.Items;

                var activityJson = JObject.FromObject(activity);

                items.Add(TelemetryBotIdInitializer.BotActivityKey, activityJson);
            }

            await nextTurn(cancellationToken).ConfigureAwait(false);
        }
    }
}
