﻿using MusicRadioStore.Core.Contracts.Repositories;
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
    public class SongSetRepository : ISongSetRepository
    {
        internal DataContext context;
        internal DbSet<SongSet> dbSongSet;
        internal Database database;

        public SongSetRepository(DataContext _context)
        {
            this.context = _context;
            this.dbSongSet = context.Set<SongSet>();
            this.database = this.context.Database;
        }

        public void Insert(SongSet songSet)
        {
            var sqlCommand = "SP_INSERT_SONGSET @Name, @AlbumSetId";
            object[] parameters = new object[2];
            parameters[0] = new SqlParameter("@Name", songSet.Name);
            parameters[1] = new SqlParameter("@AlbumSetId", songSet.AlbumSetId);
            database.ExecuteSqlCommand(sqlCommand, parameters);
        }
    }
}