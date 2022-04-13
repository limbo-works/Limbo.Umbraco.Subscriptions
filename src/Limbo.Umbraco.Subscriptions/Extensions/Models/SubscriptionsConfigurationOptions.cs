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
        public virtual string ConnectionStringKey { get; set; } = "umbracoDbDSN";

        /// <summary>
        /// 
        /// </summary>
        public virtual string DataAccessConfigurationSection { get; set; } = "Limbo.DataAccess";

        /// <summary>
        /// 
        /// </summary>
        public virtual string MailConfigurationSection { get; set; } = "Limbo:MailSettings";

        /// <summary>
        /// 
        /// </summary>
        public virtual Func<IRequestExecutorBuilder, IRequestExecutorBuilder>? GraphQLExtensions { get; set; } = null;
    }
}
