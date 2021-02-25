using MusicRadioStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRadioStore.Core.Contracts.Repositories
{
    public interface IBasketRepository
    {
        IQueryable<Basket> Collection();
        void Commit();
        void Delete(string Id);
        Basket Find(string Id);
        void Insert(Basket basket);
        void Update(Basket basket);
    }
}
