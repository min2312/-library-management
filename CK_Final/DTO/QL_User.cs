using System;
using System.Data.Entity;
using System.Linq;

namespace CK_Final.DTO
{
    public class QL_User : DbContext
    {
        // Your context has been configured to use a 'QLSV' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CK_Final.DTO.QLSV' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'QLSV' 
        // connection string in the application configuration file.
        public QL_User()
            : base("name=QL_User")
        {
            Database.SetInitializer<QL_User>(new CreateDB());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}