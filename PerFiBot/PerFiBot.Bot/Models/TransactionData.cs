using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerFiBot.Bot.Models
{
    public class TransactionData : Dictionary<string, object>
    {
        private const string CategoryNameKey = "CategoryName";
        private const string TransactionDateKey = "TransactionDate";
        private const string ValueDateKey = "ValueDate";
        private const string AmountKey = "Amount";
        private const string TransactionTypeKey = "TransactionType";
        private const string DescriptionKey = "Description";

        public string CategoryName
        {
            get { return this[CategoryNameKey].ToString(); }
            set { this[CategoryNameKey] = value; }
        }
        public string TransactionDate
        {
            get { return this[TransactionDateKey].ToString(); }
            set { this[TransactionDateKey] = value; }
        }
        public string ValueDate
        {
            get { return this[ValueDateKey].ToString(); }
            set { this[ValueDateKey] = value; }
        }
        public string Amount
        {
            get { return this[AmountKey].ToString(); }
            set { this[AmountKey] = value; }
        }
        public string TransactionType
        {
            get { return this[TransactionTypeKey].ToString(); }
            set { this[TransactionTypeKey] = value; }
        }
        public string Description
        {
            get { return this[DescriptionKey].ToString(); }
            set { this[DescriptionKey] = value; }
        }

        public TransactionData()
            : this(new Dictionary<string, object>
            {
                [CategoryNameKey] = null,
                [TransactionDateKey] = null,
                [ValueDateKey] = null,
                [AmountKey] = null,
                [TransactionTypeKey] = null,
                [DescriptionKey] = null
            })
        { }
        public TransactionData(IDictionary<string, object> source)
        {
            if (source != null)
            {
                source.ToList().ForEach(item => this.Add(item.Key, item.Value));
            }
        }
    }
}
