using Microsoft.EntityFrameworkCore;
using mySmartWallet2022.Models.Data.Entities;
using mySmartWallet2022.Models.Data.Interface;

namespace mySmartWallet2022.Models.Data.Reposiory
{
    public class Repository<TEntity, Tkey> : IRepository<TEntity, Tkey> where TEntity :  BaseClass2 <Tkey>
    {

        private readonly ApplicationDbContext _CustomerRepo;

        public Repository(ApplicationDbContext customerRepo)
        {
            _CustomerRepo = customerRepo;
        }

        public async Task<List<TEntity>> GetAll()
        {
            var customer = await _CustomerRepo.Set<TEntity>().ToListAsync();
            return customer;
        }
        public async Task<TEntity> GetSingle(Tkey id)
        {
            var model = await _CustomerRepo.Set<TEntity>().FirstOrDefaultAsync(c => c.Id!.Equals(id));
            return model;
        }
        public async Task Create(TEntity model)
        {
            await _CustomerRepo.Set<TEntity>().AddAsync(model);
            await _CustomerRepo.SaveChangesAsync();
        }
        public async Task<TEntity> Edit(Tkey id)
        {
            var model = await _CustomerRepo.Set<TEntity>().FirstOrDefaultAsync(c => c.Id!.Equals(id));
            Console.Write(model);

            return model;
        }
        public async Task Delete(Tkey id)
        {
            var model = await _CustomerRepo.Set<TEntity>().FirstOrDefaultAsync(c => c.Id!.Equals(id));

            if (model != null)
            {
                _CustomerRepo.Set<TEntity>().Remove(model);
                await _CustomerRepo.SaveChangesAsync();
            }
        }

        public async Task Update(TEntity model)
        {
            _CustomerRepo.Set<TEntity>().Update(model);

            await _CustomerRepo.SaveChangesAsync();
        }
    }
}
