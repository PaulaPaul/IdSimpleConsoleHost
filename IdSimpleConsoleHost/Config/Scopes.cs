using System;
using System.Collections.Generic;
using IdentityServer3.Core.Models;

static class Scopes
{
    public static List<Scope> Get()
    {
        return new List<Scope>
        {
            new Scope
            {
                Name = "ALapi"
            }
        };
    }
}
