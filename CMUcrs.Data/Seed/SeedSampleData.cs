using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMUcrs.Data.Seed
{
    class SeedSampleData : ISeed
    {
        public void Seed(DatabaseContext context)
        {

            context.Database.CreateIfNotExists();
        }

    }
}
