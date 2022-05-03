﻿using Microsoft.Extensions.Configuration;

namespace Limbo.MailSystem.Persistence.Contexts.Extensions.Options {
    /// <summary>
    /// Options for the context
    /// </summary>
    public class ContextOptions {

        /// <summary>
        /// The app configuration
        /// </summary>
        public IConfiguration Configuration { get; set; }

        /// <summary>
        /// The key for the connection string to use for the context
        /// </summary>
        public string ConnectionStringKey { get; set; } = "umbracoDbDSN";

        /// <inheritdoc/>
        public ContextOptions(IConfiguration configuration) {
            Configuration = configuration;
        }
    }
}
