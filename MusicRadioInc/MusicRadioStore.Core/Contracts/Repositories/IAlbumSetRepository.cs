using MusicRadioStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRadioStore.Core.Contracts.Repositories
{
    public interface IAlbumSetRepository
    {
        IQueryable<AlbumSet> Collection();
        AlbumSet Find(int Id);
        void Insert(AlbumSet albumSet);
        void Update(AlbumSet albumSet);
        void Delete(int Id);
    }
}
