using MusicRadioStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRadioStore.DataAccess.SQL
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<AlbumSet> AlbumSets { get; set; }
        public DbSet<SongSet> SongSets { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseDatail> PurchaseDatails { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
    }
}
