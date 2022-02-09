using AutoMapper;
using Limbo.Umbraco.Subscription.Persistence.Subscribers.Models;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionSystems.Models;
using Limbo.Umbraco.Subscriptions.Subscribers.Models;

namespace Limbo.Umbraco.Subscriptions.Subscribers.Profiles {
    public class SubscriptionProfile : Profile {
        public SubscriptionProfile() {
            CreateMap<Subscriber, SubscriberUpdateInput>()
                .ForMember(dest => dest.SubscriptionSystemId, opt => opt.MapFrom(src => src.SubscriptionSystem.Id));

            CreateMap<SubscriberUpdateInput, Subscriber>()
                .ForMember(dest => dest.SubscriptionSystem, opt => opt.MapFrom(src => new SubscriptionSystem { Id = src.SubscriptionSystemId }));
        }
    }
}
