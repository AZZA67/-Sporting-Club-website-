﻿namespace Sportingclub1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Sportingclub1.Models.context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Sportingclub1.Models.context";
        }

        protected override void Seed(Sportingclub1.Models.context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
