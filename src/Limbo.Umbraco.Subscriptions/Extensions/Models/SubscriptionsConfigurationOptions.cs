using HotChocolate.Execution.Configuration;
using System;

namespace Limbo.Umbraco.Subscriptions.Extensions.Models {
    /// <summary>
    /// Options
    /// </summary>
    public class SubscriptionsConfigurationOptions {

        /// <summary>
        /// 
        /// </summary>
        public string ConnectionStringKey { get; set; } = "umbracoDbDSN";

        /// <summary>
        /// 
        /// </summary>
        public string DataAccessConfigurationSection { get; set; } = "Limbo.DataAccess";

        /// <summary>
        /// 
        /// </summary>
        public string MailConfigurationSection { get; set; } = "Limbo:MailSettings";

        /// <summary>
        /// 
        /// </summary>
        public Func<IRequestExecutorBuilder, IRequestExecutorBuilder>? GraphQLExtensions { get; set; } = null;
    }
}
