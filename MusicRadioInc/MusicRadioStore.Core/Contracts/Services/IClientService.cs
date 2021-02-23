using MusicRadioStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRadioStore.Core.Contracts.Services
{
    public interface IClientService
    {
        List<Client> List();
        Client Find(string Id);
        Client Find(string Id, string Email);
        Task<Client> FindAsync(string Id);
        Task<Client> FindAsync(string Id,string Email);
        Task InsertAsync(Client client);
        Task UpdateAsync(Client client);
        Task DeleteAsync(string Id);
    }
}
