// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//
// Generated with Bot Builder V4 SDK Template for Visual Studio EchoBot v4.5.0

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using Microsoft.Bot.Builder.AI.Luis;
using PerFiBot.Bot.Accessors;
using Microsoft.Extensions.Options;
using PerFiBot.Bot.Models;
using System;
using System.Linq;

namespace PerFiBot.Bot.Bots
{
    public class PerFiVirtualAssistant : IBot
    {
        private readonly PerFiBotAccessors _accessors;
        protected LuisRecognizer _luis;

        public PerFiVirtualAssistant(PerFiBotAccessors accessors, IOptions<PerFiBotSettings> config, LuisRecognizer luisRecognizer)
        {
            _accessors = accessors ?? throw new ArgumentNullException($"{nameof(accessors)}");
            _luis = luisRecognizer ?? throw new ArgumentNullException($"{nameof(luisRecognizer)}");
        }

        /// <summary>
        /// Every conversation turn for our Echo Bot will call this method.
        /// There are no dialogs used, since it's "single turn" processing, meaning a single
        /// request and response.
        /// </summary>
        /// <param name="turnContext">A <see cref="ITurnContext"/> containing all the data needed
        /// for processing this conversation turn. </param>
        /// <param name="cancellationToken">(Optional) A <see cref="CancellationToken"/> that can be used by other objects
        /// or threads to receive notice of cancellation.</param>
        /// <returns>A <see cref="Task"/> that represents the work queued to execute.</returns>
        /// <seealso cref="BotStateSet"/>
        /// <seealso cref="ConversationState"/>
        /// <seealso cref="IMiddleware"/>
        public async Task OnTurnAsync(ITurnContext turnContext, CancellationToken cancellationToken = default)
        {
            if (turnContext.Activity.Type == ActivityTypes.Message)
            {
                if (turnContext.Responded == false)
                {
                    // Manage LUIS intents recognition
                    // Perform a call to LUIS to retrieve results for the current activity message.
                    var luisResults = await _luis.RecognizeAsync(turnContext, cancellationToken).ConfigureAwait(false);
                    var topScoringIntent = luisResults?.GetTopScoringIntent();
                    var topIntent = topScoringIntent.Value.score > 0.5
                                  ? topScoringIntent.Value.intent
                                  : string.Empty;

                    switch (topIntent)
                    {
                        case "TodaysSpecialty":
                            await turnContext.SendActivityAsync($"For today we have the following options: {string.Join(", ", BotConstants.Specialties)}");
                            break;
                        default:
                            await turnContext.SendActivityAsync("Sorry, I didn't understand that.");
                            break;
                    }
                }

                // Save states in the accessor

            }
            else if (turnContext.Activity.Type == ActivityTypes.ConversationUpdate
                     && turnContext.Activity.MembersAdded.FirstOrDefault()?.Id == turnContext.Activity.Recipient.Id)
            {
                var message = "Hi! I'm PerFi, a virtual assistant that helps you with your finances.";
                await turnContext.SendActivityAsync(message);
            }
        }
    }
}
