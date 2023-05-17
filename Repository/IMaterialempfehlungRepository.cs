namespace Materialempfehlung.Repository
{
    public interface IMaterialempfehlungRepository<TEntity> : IDisposable
    {
        public List<TEntity> GetAll();

        public TEntity Add(TEntity entity);

        public TEntity Update(TEntity entity);

        public bool Delete(int id);
    }
}
