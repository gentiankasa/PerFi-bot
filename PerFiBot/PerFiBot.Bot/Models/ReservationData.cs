using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerFiBot.Bot.Models
{
    /// <summary>
    /// Class to store conversation data. We need a dictionary structure to pass the conversation state to dialogs.
    /// </summary>
    public class ReservationData : Dictionary<string, object>
    {
        private const string AmountPeopleKey = "AmountPeople";
        private const string FullNameKey = "FullName";
        private const string TimeKey = "Time";
        private const string ConfirmedKey = "Confirmed";
        private const string ConversationLanguageKey = "ConversationLanguage";

        public string AmountPeople
        {
            get { return this[AmountPeopleKey].ToString(); }
            set { this[AmountPeopleKey] = value; }
        }

        public string FullName
        {
            get { return this[FullNameKey].ToString(); }
            set { this[FullNameKey] = value; }
        }
        public string FirstName => FullName?.ToString().Split(" ").First();

        public string Time
        {
            get { return this[TimeKey].ToString(); }
            set { this[TimeKey] = value; }
        }

        public string Confirmed
        {
            get { return this[ConfirmedKey].ToString(); }
            set { this[ConfirmedKey] = value; }
        }

        public string ConversationLanguage
        {
            get { return this[ConversationLanguageKey].ToString(); }
            set { this[ConversationLanguageKey] = value; }
        }

        public ReservationData()
            : this(new Dictionary<string, object>
            {
                [AmountPeopleKey] = null,
                [FullNameKey] = null,
                [TimeKey] = null,
                [ConfirmedKey] = null,
                [ConversationLanguageKey] = null
            })
        { }
        public ReservationData(IDictionary<string, object> source)
        {
            if (source != null)
            {
                source.ToList().ForEach(item => this.Add(item.Key, item.Value));
            }
        }
    }
}
