using Data.Mapping;
using Data.Seeds;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context;

public class MyContext : DbContext
{
    public MyContext(DbContextOptions<MyContext> options) : base(options)
    {   
        // Every time that had a new migration in the project,
        // this command will be updated your database
        Database.Migrate();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Add your entities below
        modelBuilder.Entity<User>(new UserMap().Configure);
        modelBuilder.Entity<WalletType>(new WalletTypeMap().Configure);
        modelBuilder.Entity<Wallet>(new WalletMap().Configure);
        modelBuilder.Entity<Category>(new CategoryMap().Configure);
        modelBuilder.Entity<Entrance>(new EntranceMap().Configure);
        modelBuilder.Entity<Log>(new LogMap().Configure);

        // Add your seeders below
        UserSeeder.Users(modelBuilder);
        WalletTypeSeeder.WalletTypes(modelBuilder);
        WalletSeeder.Wallet(modelBuilder);
        CategorySeeder.Categories(modelBuilder);

        // If you want to add some data remove this comment
        //EntraceSeeder.Entrance(modelBuilder);
    }
}
