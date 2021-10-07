using System.Collections.Generic;
using IdentityServer4.Models;

namespace IdentityServer
{
    public class Config
    {

        public static List<Client> Clients = new List<Client>
        {
            new Client
            {
                ClientId = "box-admin-web",
                AllowedGrantTypes = new List<string>{GrantType.AuthorizationCode},
                RequireConsent = false,
                RequireClientSecret = false,
                RedirectUris = new List<string>
                {
                    "http://localhost:3006/signin-callback.html"
                },
                PostLogoutRedirectUris = new List<string>
                {
                    "http://localhost:3006"
                },
                AllowedScopes =
                {
                    "box-admin-api",
                    "write",
                    "read",
                    "openid",
                    "profile",
                    "email"
                },
                AllowedCorsOrigins = new List<string>
                {
                    "http://localhost:3006"
                },
                AccessTokenLifetime = 86400
            }
        };
        
        public static List<ApiResource> ApiResources = new List<ApiResource>
        {
            new ApiResource
            {
                Name = "box-admin-api",
                DisplayName = "Identity Server Demo API",
                Scopes = new List<string>
                {
                    "write",
                    "read"
                }
            }
        };

        public static IEnumerable<ApiScope> ApiScopes = new List<ApiScope>
        {
            new ApiScope("openid"),
            new ApiScope("profile"),
            new ApiScope("email"),
            new ApiScope("read"),
            new ApiScope("write"),
            new ApiScope("box-admin-api")
        };
    }
}