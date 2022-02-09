﻿using System.Threading.Tasks;
using AutoMapper;
using HotChocolate;
using HotChocolate.Types;
using Limbo.Umbraco.Subscription.Persistence.Categories.Models;
using Limbo.Umbraco.Subscriptions.Bases.GraphQL.Mutations;
using Limbo.Umbraco.Subscriptions.Bases.GraphQL.Responses;
using Limbo.Umbraco.Subscriptions.Categories.Models;
using Limbo.Umbraco.Subscriptions.Categories.Services;

namespace Limbo.Umbraco.Subscriptions.Categories.Mutations {
    [ExtendObjectType(typeof(Mutation))]
    public class CategoryMutations {
        public async Task<Category> CreateCategory([Service] ICategoryService categoryService, string categoryName) {
            var response = await categoryService.Add(new Category { Name = categoryName });
            return Response.CreateResponse(response);
        }

        public async Task<Category> DeleteCategoryById([Service] ICategoryService categoryService, int categoryId) {
            var response = await categoryService.DeleteById(categoryId);
            return Response.CreateResponse(response);
        }

        public async Task<Category> UpdateCategory([Service] ICategoryService categoryService, [Service] IMapper mapper, CategoryUpdateInput category) {
            var response = await categoryService.Update(mapper.Map<Category>(category));
            return Response.CreateResponse(response);
        }

        public async Task<Category> AddSubscribersToCategory([Service] ICategoryService categoryService, int id, int[] subscriberIds) {
            var response = await categoryService.AddSubscribers(id, subscriberIds);
            return Response.CreateResponse(response);
        }

        public async Task<Category> RemoveSubscribersFromCategory([Service] ICategoryService categoryService, int id, int[] subscriberIds) {
            var response = await categoryService.RemoveSubscribers(id, subscriberIds);
            return Response.CreateResponse(response);
        }

        public async Task<Category> AddSubscriptionItemsToCategory([Service] ICategoryService categoryService, int id, int[] subscriptionItemIds) {
            var response = await categoryService.AddSubscriptionItems(id, subscriptionItemIds);
            return Response.CreateResponse(response);
        }

        public async Task<Category> RemoveSubcriptionItemsFromCategory([Service] ICategoryService categoryService, int id, int[] subscriptionItemIds) {
            var response = await categoryService.RemoveSubscriptionItems(id, subscriptionItemIds);
            return Response.CreateResponse(response);
        }
    }
}
