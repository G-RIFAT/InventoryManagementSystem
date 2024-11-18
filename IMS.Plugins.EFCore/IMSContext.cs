using IMS.CoreBusiness;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IMS.Plugins.EFCore
{
    public class IMSContext : DbContext
    {

        public IMSContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Inventory> Inventories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //populating demo data
            modelBuilder.Entity<Inventory>().HasData(new Inventory
            {
                InventoryId = 1,
                InventoryName = "Engine",
                Quantity = 1,
                Price = 1000

            },
            new Inventory
            {
                InventoryId = 2,
                InventoryName = "Body",
                Quantity = 1,
                Price = 400
            },
            new Inventory
            {

               InventoryId = 3,
               InventoryName = "Wheels",
               Quantity = 4,
               Price = 100
            },
            new Inventory
            {
             InventoryId = 4,
             InventoryName = "Seat",
             Quantity = 5,
             Price = 50
            }
            );

        }
    }
}
