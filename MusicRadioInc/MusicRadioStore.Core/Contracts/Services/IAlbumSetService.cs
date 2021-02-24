using MusicRadioStore.Core.Models;
using MusicRadioStore.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRadioStore.Core.Contracts.Services
{
    public interface IAlbumSetService
    {
        List<AlbumSetViewModel> ListViewModel();
        AlbumSet Find(int Id);
        void Insert(AlbumSet albumSet);
        void Update(AlbumSet albumSet);
    }
}
