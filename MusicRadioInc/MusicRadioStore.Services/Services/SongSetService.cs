using MusicRadioStore.Core.Contracts.Repositories;
using MusicRadioStore.Core.Contracts.Services;
using MusicRadioStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRadioStore.Services.Services
{
    public class SongSetService : ISongSetService
    {

        private readonly ISongSetRepository repository;
        public SongSetService(ISongSetRepository _repository)
        {
            this.repository = _repository;
        }

        public void Insert(SongSet songSet)
        {
            repository.Insert(songSet);
        }
    }
}
