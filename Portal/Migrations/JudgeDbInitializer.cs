using System.Data.Entity;

namespace Portal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Collections.Generic;
    using Portal.Models;
    using System.Linq;

    internal sealed class JudgeDbInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        public JudgeDbInitializer()
        {
        }

        protected override void Seed(ApplicationDbContext context)
        {
            
        }
    }
}
