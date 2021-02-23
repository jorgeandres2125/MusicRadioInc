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
    public class ClientService : IClientService
    {
        private readonly IClientRepository repository;
        public ClientService(IClientRepository _repository)
        {
            this.repository = _repository;
        }

        public List<Client> List()
        {
            return this.repository.Collection().ToList<Client>();
        }

        public Client Find(string Id)
        {
            return this.Find(Id);
        }

        public async Task<Client> FindAsync(string Id)
        {
            return await this.FindAsync(Id);
        }

        public async Task InsertAsync(Client client)
        {
            this.repository.Insert(client);
            await this.repository.CommitAsync();
        }

        public async Task UpdateAsync(Client client)
        {
            this.repository.Update(client);
            await this.repository.CommitAsync();
        }

        public async Task DeleteAsync(string Id)
        {
            await this.repository.DeleteAsync(Id);
        }

        public Client Find(string Id,string Email)
        {
            return this.repository.Find(Id,Email);
        }

        public async Task<Client> FindAsync(string Id,string Email)
        {
            return await this.repository.FindAsync(Id,Email);
        }

    }
}
