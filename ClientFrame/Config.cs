using IdentityServer4.Models;
using System.Collections.Generic;

namespace CliCredent
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> GetIdens()
        {
            List<IdentityResource> identityResources = new List<IdentityResource>()
            {
                new IdentityResources.OpenId()
            };

            return identityResources;
        }

        public static IEnumerable<ApiResource> GetApis()
        {
            List<ApiResource> apiResources = new List<ApiResource>()
            {
                new ApiResource("api0Scope", "OAuth")
            };

            return apiResources;
        }

        public static IEnumerable<Client> GetClients()
        {
            List<Client> clients = new List<Client>()
            {
                new Client()
                {
                    ClientId = "client0Id", // client_id
                    ClientSecrets = { new Secret("client0Secret".Sha256()) }, // client_secret
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = { "api0Scope" } // scope
                }
            };

            return clients;
        }
    }
}