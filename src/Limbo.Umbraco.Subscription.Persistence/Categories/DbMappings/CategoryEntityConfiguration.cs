﻿using Limbo.Umbraco.Subscription.Persistence.Categories.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Limbo.Umbraco.Subscription.Persistence.Categories.DbMappings {
    internal class CategoryEntityConfiguration : IEntityTypeConfiguration<Category> {
        public void Configure(EntityTypeBuilder<Category> builder) {
        }
    }
}
