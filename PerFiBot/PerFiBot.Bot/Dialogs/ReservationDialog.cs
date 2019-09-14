using Microsoft.Bot.Builder;
using PerFiBot.Bot.Models;
using PerFiBot.Bot.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerFiBot.Bot.Dialogs
{
    public class ReservationDialog
    {
        // Conversation steps
        public const string TimePrompt = "timePrompt";
        public const string AmountPeoplePrompt = "amountPeoplePrompt";
        public const string NamePrompt = "namePrompt";
        public const string ConfirmationPrompt = "confirmationPrompt";

        // Dialog IDs
        private const string ProfileDialog = "profileDialog";

        private readonly TextToSpeechService _ttsService;

        public IStatePropertyAccessor<ReservationData> UserProfileAccessor { get; }

        public ReservationDialog(
            IStatePropertyAccessor<ReservationData> userProfileStateAccessor,
            TextToSpeechService ttsService)
        {
            UserProfileAccessor = userProfileStateAccessor 
                               ?? throw new ArgumentNullException(nameof(userProfileStateAccessor));

            _ttsService = ttsService;

            // Add control flow dialogs

            // Add control flow dialogs
        }
    }
}
