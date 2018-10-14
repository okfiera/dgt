using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.MainBoundedContext.Migrations
{
    public static class CustomIndexes
    {
        public static void CreateCustomIndexes(UnitOfWork.MainBCUnitOfWork context)
        {
            //Drivers identification
            context.Database.ExecuteSqlCommand("IF EXISTS (SELECT 'X' FROM sysindexes WHERE id = (SELECT OBJECT_ID('Drivers')) AND name = 'IX_Identifier') DROP INDEX Drivers.IX_Identifier");
            context.Database.ExecuteSqlCommand("CREATE INDEX IX_Identifier ON Drivers(Identifier)");

            //Vehicle license
            context.Database.ExecuteSqlCommand("IF EXISTS (SELECT 'X' FROM sysindexes WHERE id = (SELECT OBJECT_ID('Vehicles')) AND name = 'IX_License') DROP INDEX Vehicles.IX_License");
            context.Database.ExecuteSqlCommand("CREATE INDEX IX_License ON Vehicles(License)");

            //Infractions date
            context.Database.ExecuteSqlCommand("IF EXISTS (SELECT 'X' FROM sysindexes WHERE id = (SELECT OBJECT_ID('Infractions')) AND name = 'IX_Date') DROP INDEX Infractions.IX_Date");
            context.Database.ExecuteSqlCommand("CREATE INDEX IX_Date ON Infractions(Date)");
        }
    }
}
