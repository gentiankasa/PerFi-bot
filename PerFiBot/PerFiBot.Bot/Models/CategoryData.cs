using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerFiBot.Bot.Models
{
    /// <summary>
    /// Class to store conversation data. We need a dictionary structure to pass the conversation state to dialogs.
    /// </summary>
    public class CategoryData : Dictionary<string, object>
    {
        private const string NameKey = "Name";
        private const string TypeKey = "Type";

        public string Name
        {
            get { return this[NameKey].ToString(); }
            set { this[NameKey] = value; }
        }
        public string Type
        {
            get { return this[TypeKey].ToString(); }
            set { this[TypeKey] = value; }
        }

        public CategoryData()
            : this(new Dictionary<string, object>
            {
                [NameKey] = null
            })
        { }
        public CategoryData(IDictionary<string, object> source)
        {
            if (source != null)
            {
                source.ToList().ForEach(item => this.Add(item.Key, item.Value));
            }
        }
    }
}
