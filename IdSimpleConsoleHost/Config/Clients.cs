﻿using System;
using System.Collections.Generic;
using IdentityServer3.Core.Models;

static class Clients
{
    public static List<Client> Get()
    {
        return new List<Client>
        {
           // no human involved
            new Client
            {
                ClientName = "AmLINK Sample Client",
                ClientId = "ALclient",
                Enabled = true,
                AccessTokenType = AccessTokenType.Reference,

                Flow = Flows.ClientCredentials,

                ClientSecrets = new List<Secret>
                {
                    new Secret("F621F470-9731-4A25-80EF-67A6F7C5F4B8".Sha256())
                },

                AllowedScopes = new List<string>
                {
                    "ALapi"
                }
            }
        };
    }
}
