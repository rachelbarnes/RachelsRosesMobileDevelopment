using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RachelBarnesMobileDevelopment {
    public class DatabaseStuff {
        public void RecreateDatabase(RachelsRosesMobileDevelopmentEntities context, string tableName, List<string> tableColumns) {
            var dropTableCommandText = string.Format(@"drop table {0};", tableName);
            var createTableCommandText = string.Format("create table {0} ( ", tableName); 
            foreach (var column in tableColumns) {
                if (column == tableColumns.First())
                    createTableCommandText += string.Format(@"
                                                          {0}", column);
                else if (column == tableColumns.Last())
                    createTableCommandText += string.Format(@"
                                                           , {0});", column); 
                else 
                    createTableCommandText += string.Format(@"
                                                           , {0}", column); 
            }
            context.Database.ExecuteSqlCommand(dropTableCommandText);
            context.Database.ExecuteSqlCommand(createTableCommandText); 
        }
        public void RecreateDatabase(RachelsRosesMobileDevelopmentEntities context) {
            // === To make a new table === 
            // 1. Update these drop/create statements
            // 2. Run tests to drop/create the database
            // 3. Update the model(s) from the .edmx designer view
            // 4. Rerun tests to see where the new model now causes compilation errors
            var dropDb = @" 
                    drop table IngredientDensities; 
                 ";
            var createDb = @"
                    create table IngredientDensities (
                        IngredientDensityId int not null identity(1,1) primary key
                        , IngredientName nvarchar(60)
                        , IngredientDensity decimal(5,2)
                    ); 


                ";
            context.Database.ExecuteSqlCommand(dropDb);
            context.Database.ExecuteSqlCommand(createDb);
        }

    }

}