﻿using Limbo.MailSystem.Distribution.Extensions;
using Limbo.MailSystem.Extensions.Options;
using Limbo.MailSystem.MailSegments.Extensions;
using Limbo.MailSystem.MailTemplates.Extensions;
using Limbo.MailSystem.Persistence.Extensions;
using Limbo.MailSystem.Queue.Extensions;
using Limbo.MailSystem.SegmentTypes.Extensions;
using Limbo.MailSystem.Settings.Extensions;
using Limbo.MailSystem.Templates.RazorTemplates.Extensions;
using Limbo.MailSystem.Templates.SimpleText.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class MailSystemExtensions {
        /// <summary>
        /// Adds the mail system
        /// </summary>
        /// <param name="services"></param>
        /// <param name="mailSystemOptions"></param>
        /// <returns></returns>
        public static IServiceCollection AddMailSystem(this IServiceCollection services, MailSystemOptions mailSystemOptions) {
            services
                .AddPersistence(mailSystemOptions.MailSystemPersistenceOptions)
                .AddSettings(mailSystemOptions.MailSystemSettingsOptions)
                .AddDistributions()
                .AddQueues()
                .AddMailSegments()
                .AddMailTemplates()
                .AddSegmentTypes()
                .AddSimpleTextTemplates()
                .AddRazorTemplates();

            return services;
        }
    }
}
