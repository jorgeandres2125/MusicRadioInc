using MusicRadioStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRadioStore.Core.Contracts.Repositories
{
    public interface ISongSetRepository
    {
        void Insert(SongSet songSet);
    }
}
