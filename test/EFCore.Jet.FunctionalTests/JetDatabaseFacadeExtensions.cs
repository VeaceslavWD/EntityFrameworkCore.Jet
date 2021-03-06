﻿// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EntityFramework.Jet.FunctionalTests
{
    public static class JetDatabaseFacadeExtensions
    {
        public static void EnsureClean(this DatabaseFacade databaseFacade)
            => new JetDatabaseCleaner().Clean(databaseFacade);
    }
}

