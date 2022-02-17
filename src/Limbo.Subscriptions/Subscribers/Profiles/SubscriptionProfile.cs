using AutoMapper;
using Limbo.Subscriptions.Persistence.Subscribers.Models;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Models;
using Limbo.Subscriptions.Subscribers.Models;

namespace Limbo.Subscriptions.Subscribers.Profiles {
    public class SubscriptionProfile : Profile {
        public SubscriptionProfile() {
            CreateMap<Subscriber, SubscriberUpdateInput>()
                .ForMember(dest => dest.SubscriptionSystemId, opt => opt.MapFrom(src => src.SubscriptionSystem.Id));

            CreateMap<SubscriberUpdateInput, Subscriber>()
                .ForMember(dest => dest.SubscriptionSystem, opt => opt.MapFrom(src => new SubscriptionSystem { Id = src.SubscriptionSystemId }));
        }
    }
}
