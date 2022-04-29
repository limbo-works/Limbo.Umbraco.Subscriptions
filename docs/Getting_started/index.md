# Getting started

## Install
```
dotnet add Limbo.Umbraco.Subscriptions
```

## Startup.cs setup

To get started we need to add the extensions like below:
```csharp
public void ConfigureServices(IServiceCollection services) {
    services.AddUmbraco(_env, _config)
        .AddBackOffice()
        .AddWebsite()
        .AddComposers()
        .AddSubscriptions(_config, options => { })
        .Build();
        
    services.AddRazorTemplating();
}

public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApiAuthenticationSettings apiAuthenticationSettings) {
    
    app.UseSubscriptionsGraphQLEndpoint(new SubscriptionGraphQlEndpointOptions {
        UseSecurity = true
    });

    app.UseUmbraco()
        .WithMiddleware(u => {
            u.UseBackOffice();
            u.UseWebsite();
        })
        .WithEndpoints(u => {
            u.UseInstallerEndpoints();
            u.UseBackOfficeEndpoints();
            u.UseWebsiteEndpoints();
        });
}
```

```csharp
public void ConfigureServices(IServiceCollection services) {
    services.AddLimboApiAuthentication(_config, settings: new ApiAuthenticationConfigurationSettings() { ConnectionStringKey = "umbracoDbDSN" });
}
```

AddSubscriptions adds most of the services needed for running the subscriptions package
```csharp
.AddSubscriptions(_config, options => { })
```

AddRazorTemplating adds the services needed for using Razor templates for the emails
```csharp
services.AddRazorTemplating();
```

We also need to use the GraphQL endpoint to get access to query the subscription data from `/graphql`
```csharp
app.UseSubscriptionsGraphQLEndpoint(new SubscriptionGraphQlEndpointOptions {
    UseSecurity = true
});
```

The `UseSecurity` property adds the use extensions below. This needs to be in your request pipeline to use the GraphQL endpoint but can be added manually instead.
```csharp
app
    .UseAuthentication()
    .UseAuthorization();
```

## Authentication

To use the GraphQL endpoint you need to be able to authenticate with your Asp Net Core application. This can be setup in multiple ways.
An easy to setup solution is [Limbo.ApiAuthentication](https://github.com/limbo-works/Limbo.ApiAuthentication) to setup authentication with this package see the [docs](https://github.com/limbo-works/Limbo.ApiAuthentication/blob/main/docs/index.md)

## Mail templates

To send out mails you need to setup a Razor template for the mail. The default location for this is: `YOUR_ASPNET_PROJECT_FOLDER/Views/Mails/Default.cshtml`

An example configuration for this file is:

```cshtml
@using Limbo.Subscriptions.Subscribers.Models
@using Umbraco.Cms.Core.Services
@inject IContentService _contentService;

@model SubscriberTemplateModel

<div>
    <p>Hej @Model.Name</p>
    <br />

    <p>Du har opdateringer på følgende sider:</p>
    <ul>
        @foreach(var item in Model.SubscriptionItems) {
            var contentNode = _contentService.GetById(item.NodeId);
            <li>@contentNode.Name - opdateret @contentNode.UpdateDate</li>
        }
    </ul>
</div>
```