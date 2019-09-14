using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using PerFiBot.Bot.Bots;
using PerFiBot.Bot.Models;

namespace PerFiBot.Bot.Accessors
{
    /// <summary>
    /// This class is created as a Singleton and passed into the IBot-derived constructor.
    ///  - See <see cref="PerFiVirtualAssistant"/> constructor for how that is injected.
    ///  - See the Startup.cs file for more details on creating the Singleton that gets
    ///    injected into the constructor.
    /// </summary>
    public class PerFiBotAccessors
    {
        /// <summary>
        /// Gets the <see cref="ConversationState"/> object for the conversation.
        /// </summary>
        /// <value>The <see cref="ConversationState"/> object.</value>
        public ConversationState ConversationState { get; }

        /// <summary>
        /// Gets the <see cref="UserState"/> object for the conversation.
        /// </summary>
        /// <value>The <see cref="UserState"/> object.</value>
        public UserState UserState { get; }

        public string ReservationStateName { get; } = $"{nameof(PerFiBotAccessors)}.ReservationState";
        public string TransactionManagementStateName { get; } = $"{nameof(PerFiBotAccessors)}.TransactionManagement";
        public string BudgetManagementStateName { get; } = $"{nameof(PerFiBotAccessors)}.BudgetManagementState";
        public string CategoryManagementStateName { get; } = $"{nameof(PerFiBotAccessors)}.CategoryManagementState";

        public IStatePropertyAccessor<ReservationData> ReservationState { get; set; }
        public IStatePropertyAccessor<TransactionData> TransactionManagemenState { get; set; }
        public IStatePropertyAccessor<BudgetData> BudgetManagementState { get; set; }
        public IStatePropertyAccessor<CategoryData> CategoryManagementState { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerFiBotAccessors"/> class.
        /// Contains the <see cref="ConversationState"/> and associated <see cref="IStatePropertyAccessor{T}"/>.
        /// </summary>
        /// <param name="conversationState">The state object that stores the conversation data.</param>
        /// <param name="userState">The state object that stores the user state.</param>
        public PerFiBotAccessors(ConversationState conversationState, UserState userState)
        {
            ConversationState = conversationState 
                             ?? throw new ArgumentNullException(nameof(conversationState));
            UserState = userState 
                     ?? throw new ArgumentNullException(nameof(userState));
        }
    }
}
