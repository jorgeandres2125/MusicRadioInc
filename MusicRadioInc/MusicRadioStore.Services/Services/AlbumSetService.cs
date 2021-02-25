using MusicRadioStore.Core.Contracts.Repositories;
using MusicRadioStore.Core.Contracts.Services;
using MusicRadioStore.Core.Models;
using MusicRadioStore.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRadioStore.Services.Services
{
    public class AlbumSetService : IAlbumSetService
    {
        private readonly IAlbumSetRepository repository;
        public AlbumSetService(IAlbumSetRepository _repository)
        {
            this.repository = _repository;
        }

        
        public AlbumSet Find(int Id)
        {
            return repository.Find(Id);
        }

        public void Insert(AlbumSet albumSet)
        {
            repository.Insert(albumSet);
        }

        public List<AlbumSetViewModel> ListViewModel()
        {
            List<AlbumSetViewModel> list = this.repository.Collection()
                .Select(obj => 
                    new AlbumSetViewModel() 
                    {
                        Id = obj.Id,
                        Name = obj.Name,
                        Image = obj.Image,
                        Price = obj.Price.ToString(),
                        SongSets = obj.SongSets
                    })
                .ToList<AlbumSetViewModel>();
            return list;
        }

        public void Update(AlbumSet albumSet)
        {
            repository.Update(albumSet);
        }

        public void Delete(int Id)
        {
            repository.Delete(Id);
        }
    }
}
