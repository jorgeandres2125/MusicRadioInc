﻿using MusicRadioStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRadioStore.Core.Contracts.Services
{
    public interface ISongSetService
    {
        void Insert(SongSet songSet);
        void Update(SongSet songSet);
        SongSet Find(int albumId, int songId);
        void Delete(int Id);
    }
}
