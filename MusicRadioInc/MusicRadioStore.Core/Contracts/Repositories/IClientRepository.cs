using MusicRadioStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRadioStore.Core.Contracts.Repositories
{
    public interface IClientRepository
    {
        IQueryable<Client> Collection();
        Task CommitAsync();
        Task DeleteAsync(string Id);
        Client Find(string Id);
        Client Find(string Id,string Email);
        Task<Client> FindAsync(string Id);
        Task<Client> FindAsync(string Id,string Email);
        void Insert(Client client);
        void Update(Client client);
    }
}
