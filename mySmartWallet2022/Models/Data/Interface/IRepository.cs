using mySmartWallet2022.Models.Data.Entities;

namespace mySmartWallet2022.Models.Data.Interface
{
    public interface IRepository<TEntity, Tkey> where TEntity : BaseClass2<Tkey>
    {
        public Task<List<TEntity>> GetAll();
        public Task<TEntity> GetSingle(Tkey id);
        public Task Create(TEntity model);
        public Task<TEntity> Edit(Tkey id);
        public Task Delete(Tkey id);
        public Task Update(TEntity model);
    }
}
