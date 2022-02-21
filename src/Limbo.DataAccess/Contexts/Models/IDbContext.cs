﻿using Microsoft.EntityFrameworkCore;

namespace Limbo.DataAccess.Contexts.Models {
    /// <summary>
    /// A generic interface for interacting with DbContexts
    /// </summary>
    public interface IDbContext {
        /// <summary>
        /// The DbContext
        /// </summary>
        public DbContext Context { get; }
    }
}