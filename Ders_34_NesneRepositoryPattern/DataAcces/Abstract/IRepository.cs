using Ders_34_NesneRepositoryPattern.Entity;
namespace Ders_34_NesneRepositoryPattern.DataAcces.Abstract
{
    public interface IRepository<TEntity> //Generic class tanımlama < > içine ne gelirse ona gore 
    //çalisacak kategori veya product gelirse ona gore çalışacak
    {
        TEntity GetById(int id);
        void Update(TEntity entity);
        void Create(TEntity entity);
        void Delete(int id);
    }
}