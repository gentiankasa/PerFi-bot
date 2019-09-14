using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerFiBot.Bot.Models
{
    public class PerFiBotSettings
    {
        public string TranslatorSpeechSubscriptionKey { get; set; }

        public string TranslatorTextSubscriptionKey { get; set; }

        public string VoiceFontName { get; set; }

        public string VoiceFontLanguage { get; set; }
    }
}
