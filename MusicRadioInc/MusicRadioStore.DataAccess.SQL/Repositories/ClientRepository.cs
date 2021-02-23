using MusicRadioStore.Core.Contracts.Repositories;
using MusicRadioStore.Core.Models;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MusicRadioStore.DataAccess.SQL.Repositories
{
    public class ClientRepository : IClientRepository
    {
        internal DataContext context;
        internal DbSet<Client> dbClientSet;

        public ClientRepository(DataContext _context)
        {
            this.context = _context;
            this.dbClientSet = context.Set<Client>();
        }

        public IQueryable<Client> Collection()
        {
            return dbClientSet;
        }

        public async Task CommitAsync()
        {
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string Id)
        {
            var client = await FindAsync(Id);
            if (context.Entry(client).State == EntityState.Detached)
                dbClientSet.Attach(client);
            dbClientSet.Remove(client);
        }

        public Client Find(string Id)
        {
            return dbClientSet.Find(Id);
        }

        public async Task<Client> FindAsync(string Id)
        {
            return await dbClientSet.FindAsync(Id);
        }

        public Client Find(string Id, string Email)
        {
            return this.dbClientSet.Single<Client>(c => c.Id.ToLower().Equals(Id.ToLower()) || c.Mail.ToLower().Equals(Email.ToLower()));
        }

        public async Task<Client> FindAsync(string Id, string Email)
        {
            return await this.dbClientSet.FirstOrDefaultAsync<Client>(c => c.Id.ToLower().Equals(Id.ToLower()) || c.Mail.ToLower().Equals(Email.ToLower()));
        }

        public void Insert(Client client)
        {
            dbClientSet.Add(client);
        }

        public void Update(Client client)
        {
            dbClientSet.Attach(client);
            context.Entry(client).State = EntityState.Modified;
        }
    }
}
