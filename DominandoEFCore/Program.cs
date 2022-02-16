using System.Data;
using System;
using System.Data.Common;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace DominandoEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            EnsureCreatedAndDeleted();
        }
           
        static void EnsureCreatedAndDeleted()
        {
            using var db = new DominandoEFCore.Data.ApplicationContext();
            db.Database.EnsureCreated();
            //db.Database.EnsureDeleted();
        }
       /* static void GapDoEnsureCreated()
        {
           using var db1 = new DominandoEFCore.Data.ApplicationContext();
           using var db2 = new DominandoEFCore.Data.ApplicationContextCidade(); 

           db1.Database.EnsureCreated();
           db2.Database.EnsureCreated();

           var databaseCreator = db2.GetService<IRelationalDatabaseCreator>();
           databaseCreator.CreateTables();

        } 
        */
        
    
    }

}
