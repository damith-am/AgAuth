using Duende.IdentityServer.Models;

namespace AgAuth.IdentityServer;

public static class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResources.Email(),
        };

    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
        {
            new ApiScope("ecclesia.api", "Ecclesia API"),
        };

    public static IEnumerable<Client> Clients =>
        new Client[]
        {
            // Flutter mobile app — public client, Authorization Code + PKCE
            new Client
            {
                ClientId = "ecclesia_mobile",
                ClientName = "Ecclesia Mobile App",

                AllowedGrantTypes = GrantTypes.Code,
                RequireClientSecret = false,
                RequirePkce = true,

                // Custom URI scheme for deep-linking back into the Flutter app
                RedirectUris =
                {
                    "com.agrando.ecclesia://callback",
                    "https://localhost:4200/signin-callback",
                    "http://localhost:4200/signin-callback",  // for local dev/web preview
                },
                PostLogoutRedirectUris =
                {
                    "com.agrando.ecclesia://logout-callback",
                    "https://localhost:4200/logout-callback",
                    "http://localhost:4200/logout-callback",
                },

                AllowOfflineAccess = true,   // enable refresh tokens
                RequireConsent = false,      // no consent screen for mobile clients

                AllowedScopes =
                {
                    "openid",
                    "profile",
                    "email",
                    "offline_access",
                    "ecclesia.api",
                },

                // Allow the flutter app to receive tokens in a browser-safe way
                AllowedCorsOrigins = { "https://localhost:4200", "http://localhost:4200" },

                AccessTokenLifetime = 3600,           // 1 hour
                AbsoluteRefreshTokenLifetime = 2592000, // 30 days
                SlidingRefreshTokenLifetime = 1296000,  // 15 days
                RefreshTokenUsage = TokenUsage.ReUse,
                RefreshTokenExpiration = TokenExpiration.Sliding,
            },
        };
}
