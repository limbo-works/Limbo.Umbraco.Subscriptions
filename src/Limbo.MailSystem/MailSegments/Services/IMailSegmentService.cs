﻿using Limbo.EntityFramework.Services.Crud;
using Limbo.MailSystem.Persistence.MailSegments.Models;
using Limbo.MailSystem.Persistence.MailSegments.Repositories;

namespace Limbo.MailSystem.MailSegments.Services {
    /// <summary>
    /// A service for manaing amil segments
    /// </summary>
    public interface IMailSegmentService : ICrudServiceBase<MailSegment, IMailSegmentRepository> {
    }
}