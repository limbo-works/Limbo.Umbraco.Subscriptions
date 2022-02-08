using AutoMapper;
using Limbo.Umbraco.Subscription.Persistence.Categories.Models;
using Limbo.Umbraco.Subscriptions.Categories.Models;

namespace Limbo.Umbraco.Subscriptions.Categories.Profiles {
    public class CategoryProfile : Profile {
        public CategoryProfile() {
            CreateMap<Category, CategoryUpdateInput>();
            CreateMap<CategoryUpdateInput, Category>();
        }
    }
}
