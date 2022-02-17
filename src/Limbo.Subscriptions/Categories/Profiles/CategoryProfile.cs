using AutoMapper;
using Limbo.Subscriptions.Persistence.Categories.Models;
using Limbo.Subscriptions.Categories.Models;

namespace Limbo.Subscriptions.Categories.Profiles {
    public class CategoryProfile : Profile {
        public CategoryProfile() {
            CreateMap<Category, CategoryUpdateInput>();
            CreateMap<CategoryUpdateInput, Category>();
        }
    }
}
