using Keycloak.AuthServices.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Common.Identity.DependencyInjection
{
    public static class KeycloakDI
    {
        public static WebApplicationBuilder AddAuth(this WebApplicationBuilder builder)
        {
            builder.Services.AddKeycloakWebApiAuthentication(builder.Configuration);
            builder.Services.AddAuthorization();

            return builder;
        }

        public static WebApplication UseAuth(this WebApplication app)
        {
            app.UseAuthentication();
            app.UseAuthorization();

            return app;
        }
    }
}
