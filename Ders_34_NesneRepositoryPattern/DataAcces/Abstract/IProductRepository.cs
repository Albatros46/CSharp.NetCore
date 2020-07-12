using Ders_34_NesneRepositoryPattern.Entity;
namespace Ders_34_NesneRepositoryPattern.DataAcces.Abstract
{
    public interface IProductRepository
    {
        Product GetById(int id);
        void Update(Product entity);
        void Create(Product entity);
        void Delete(int id);
        Product[] GetProductsByCategory(int id);
    }
}