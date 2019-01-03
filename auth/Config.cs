using IdentityServer4.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace auth
{
    public class Config
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
                new IdentityResource("dataeventrecordsscope",new []{ "role", "admin", "user", "dataEventRecords", "dataEventRecords.admin" , "dataEventRecords.user" } ),
                new IdentityResource("securedfilesscope",new []{ "role", "admin", "user", "securedFiles", "securedFiles.admin", "securedFiles.user"} )
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("dataEventRecords")
                {
                    ApiSecrets =
                    {
                        new Secret("thisisMysecret".Sha256())
                    },
                    Scopes =
                    {
                        new Scope
                        {
                            Name = "dataeventrecords",
                            DisplayName = "Scope for the dataEventRecords ApiResource"
                        }
                    },
                    UserClaims = { "role", "admin", "user", "dataEventRecords", "dataEventRecords.admin", "dataEventRecords.user" }
                }
                //,
                //new ApiResource("securedFiles")
                //{
                //    ApiSecrets =
                //    {
                //        new Secret("securedFilesSecret".Sha256())
                //    },
                //    Scopes =
                //    {
                //        new Scope
                //        {
                //            Name = "securedfiles",
                //            DisplayName = "Scope for the securedFiles ApiResource"
                //        }
                //    },
                //    UserClaims = { "role", "admin", "user", "securedFiles", "securedFiles.admin", "securedFiles.user" }
                //}
            };
        }

        // clients want to access resources (aka scopes)
        public static IEnumerable<Client> GetClients(IConfigurationSection config)
        {
            // client credentials client
            return new List<Client>
            {
                new Client
                {
                    ClientName = "angularclient",
                    ClientId = "angularclient",
                    AccessTokenType = AccessTokenType.Reference,
                    // RequireConsent = false,
                    AccessTokenLifetime = 330,// 330 seconds, default 60 minutes
                    IdentityTokenLifetime = 30,
                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowAccessTokensViaBrowser = true,
                    AlwaysIncludeUserClaimsInIdToken = true,
                    RedirectUris = new List<string>
                    {
                        "https://localhost:4200",
                        "https://localhost:4200/assets/silent-renew.html"

                    },
                    PostLogoutRedirectUris = new List<string>
                    {
                        "https://localhost:4200/unauthorized",
                        "https://localhost:4200"
                    },
                    AllowedCorsOrigins = new List<string>
                    {
                        "https://localhost:4200",
                        "http://localhost:4200"
                    },
                    AllowedScopes = new List<string>
                    {
                        "openid",
                        "dataEventRecords",
                        "dataeventrecords",
                        "dataeventrecordsscope",
                        "securedFiles",
                        "securedfilesscope",
                        "role",
                        "profile",
                        "email"
                    }
                },
//                new Client
//                {
//                    ClientName = "angularclientidtokenonly",
//                    ClientId = "angularclientidtokenonly",
//                    AccessTokenType = AccessTokenType.Reference,
//                    AccessTokenLifetime = 360,// 120 seconds, default 60 minutes
//                    IdentityTokenLifetime = 30,
//                    AllowedGrantTypes = GrantTypes.Implicit,
//                    AlwaysIncludeUserClaimsInIdToken = true,
//                    AllowAccessTokensViaBrowser = true,
//                    RedirectUris = new List<string>
//                    {
//                        "https://localhost:44372",
//                        "https://localhost:44372/silent-renew.html"

//                    },
//                    PostLogoutRedirectUris = new List<string>
//                    {
//                        "https://localhost:44372/Unauthorized"
//                    },
//                    AllowedCorsOrigins = new List<string>
//                    {
//                        "https://localhost:44372",
//                        "http://localhost:44372"
//                    },
//                    AllowedScopes = new List<string>
//                    {
//                        "openid",
//                        "dataEventRecords",
//                        "dataeventrecordsscope",
//                        "securedFiles",
//                        "securedfilesscope",
//                        "role",
//                        "profile",
//                        "email"
//                    }
//},
//                new Client
//                {
//                    ClientName = "angularjsclient",
//                    ClientId = "angularjsclient",
//                    AllowedGrantTypes = GrantTypes.Implicit,
//                    AllowAccessTokensViaBrowser = true,
//                    RedirectUris = new List<string>
//                    {
//                        "https://localhost:44376/authorized"
//                    },
//                    PostLogoutRedirectUris = new List<string>
//                    {
//                        "https://localhost:44346/unauthorized.html"
//                    },
//                    AllowedCorsOrigins = new List<string>
//                    {
//                        "https://localhost:44346"
//                    },
//                    AllowedScopes = new List<string>
//                    {
//                        "openid",
//                        "email",
//                        "profile",
//                        "dataEventRecords",
//                        "dataeventrecordsscope",
//                        "securedFiles",
//                        "securedfilesscope",
//                    }
//                },
            };
        }
    }
}