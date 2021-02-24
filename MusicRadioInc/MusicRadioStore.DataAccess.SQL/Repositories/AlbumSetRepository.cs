using MusicRadioStore.Core.Contracts.Repositories;
using MusicRadioStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRadioStore.DataAccess.SQL.Repositories
{
    public class AlbumSetRepository : IAlbumSetRepository
    {
        internal DataContext context;
        internal DbSet<AlbumSet> dbAlbumSet;
        internal Database database;

        public AlbumSetRepository(DataContext _context)
        {
            this.context = _context;
            this.dbAlbumSet = context.Set<AlbumSet>();
            this.database = this.context.Database;
        }

        public IQueryable<AlbumSet> Collection()
        {
            return dbAlbumSet.Include(r => r.SongSets);
        }

        public AlbumSet Find(int Id)
        {
            return dbAlbumSet.Find(Id);
        }

        public void Insert(AlbumSet albumSet)
        {
            var sqlCommand = "SP_INSERT_ALBUMSET @Name, @Image, @Price";
            object[] parameters = new object[3];
            parameters[0] = new SqlParameter("@Name", albumSet.Name);
            parameters[1] = new SqlParameter("@Image", albumSet.Image);
            parameters[2] = new SqlParameter("@Price", albumSet.Price);
            database.ExecuteSqlCommand(sqlCommand, parameters);
        }

        public void Update(AlbumSet albumSet)
        {
            var sqlCommand = "SP_UPDATE_ALBUMSET @Id, @Name, @Image, @Price";
            object[] parameters = new object[4];
            parameters[0] = new SqlParameter("@Id", albumSet.Id);
            parameters[1] = new SqlParameter("@Name", albumSet.Name);
            parameters[2] = new SqlParameter("@Image", albumSet.Image);
            parameters[3] = new SqlParameter("@Price", albumSet.Price);
            database.ExecuteSqlCommand(sqlCommand, parameters);
        }
    }
}
