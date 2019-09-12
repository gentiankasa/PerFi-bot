using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerFiBot.Bot.Models
{
    public class ReservationData : Dictionary<string, object>
    {
        private const string AmountPeopleKey = "AmountPeople";
        private const string FullNameKey = "FullName";
        private const string TimeKey = "Time";
        private const string ConfirmedKey = "Confirmed";
        private const string ConversationLanguageKey = "ConversationLanguage";

        public ReservationData()
        {
            this[AmountPeopleKey] = null;
            this[FullNameKey] = null;
            this[TimeKey] = null;
            this[ConfirmedKey] = null;
            this[ConversationLanguageKey] = null;
        }
    }
}
