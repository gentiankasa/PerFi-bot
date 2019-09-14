using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerFiBot.Bot.Models
{
    public class BudgetData : Dictionary<string, object>
    {
        private const string CategoryNameKey = "CategoryName";
        private const string MonthKey = "Month";
        private const string YearKey = "Year";
        private const string AmountKey = "Amount";

        public string CategoryName
        {
            get { return this[CategoryNameKey].ToString(); }
            set { this[CategoryNameKey] = value; }
        }
        public string Month
        {
            get { return this[MonthKey].ToString(); }
            set { this[MonthKey] = value; }
        }
        public string Year
        {
            get { return this[YearKey].ToString(); }
            set { this[YearKey] = value; }
        }
        public string Amount
        {
            get { return this[AmountKey].ToString(); }
            set { this[AmountKey] = value; }
        }

        public BudgetData()
            : this(new Dictionary<string, object>
            {
                [CategoryNameKey] = null,
                [MonthKey] = null,
                [YearKey] = null,
                [AmountKey] = null
            })
        { }
        public BudgetData(IDictionary<string, object> source)
        {
            if (source != null)
            {
                source.ToList().ForEach(item => this.Add(item.Key, item.Value));
            }
        }
    }
}
