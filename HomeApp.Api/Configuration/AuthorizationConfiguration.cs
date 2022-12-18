using HomeApp.Common;

namespace HomeApp.Api.Configuration;

public static class AuthorizationConfiguration
{
    public static void ConfigureAuthorization(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAuthorization(options =>
        {
            options.AddPolicy(ConfigurationConstants.AuthPolicies.RequirePortalApiScope, policy =>
                {
                    policy.RequireAuthenticatedUser();
                    policy.RequireClaim("scope", Constants.ApiScopes.PortalApi);
                });
        });
    }

}

