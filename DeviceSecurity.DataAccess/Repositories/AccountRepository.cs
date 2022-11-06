using AutoMapper;
using DeviceSecurity.Shared.Data;
using DeviceSecurity.Shared.Request;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceSecurity.DataAccess.Repositories
{

    public interface Repository<T> where T : EntityBase
    {
        public ApplicationContext Context { get; set; }
        public abstract Task AddAsync(T entity);
        public abstract Task<T?> GetAsync(int id);
        public abstract Task<T> UpdateAsync(T entity);
        public async Task SaveChangesAsync()
        {
            await Context.SaveChangesAsync(); 
        }
    }
    public interface IAccountRepository : Repository<Account>
    {
        public Task AddAsync(AccountData accountData);
        public Task<Account?> Get(AccountData accountData);
        public Task<Account?> Get(string login, string password);
        public Task<Account?> Get(string login);
    }
    public class AccountRepository : IAccountRepository
    {
        public AccountRepository(
            IMapper mapper,
            ApplicationContext applicationContext) {
            Context = applicationContext;
            Mapper = mapper;
        }

        public ApplicationContext Context { get; set; }
        public IMapper Mapper { get; private set; }
        public Task AddAsync(Account entity)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(AccountData accountData)
        {
            throw new NotImplementedException();
        }

        public async Task<Account?> Get(string login, string password)
        {
            return await Context.Accounts.FirstOrDefaultAsync(x => x.Login == login && x.Password == password);
        }

        public Task<Account> Get(string login)
        {
            throw new NotImplementedException();
        }

        public Task<Account?> Get(AccountData accountData)
        {
            throw new NotImplementedException();
        }

        public Task<Account> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Account> UpdateAsync(Account entity)
        {
            throw new NotImplementedException();
        }
    }
}
