using Ders_34_NesneRepositoryPattern.Entity;
namespace Ders_34_NesneRepositoryPattern.DataAcces.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {/* Interface olarak tanımlamamızın sebebi, kullanilacak yerler buradan kullansin degisken verilerini
        MySQL, SQL, NoSQL, Entity Framework vs gibi ayrı ayrı yazmak yerine buradan ortak olarak çeksinler.
    */
        // Product GetById(int id);
        // void Update(Product entity);
        // void Create(Product entity);
        // void Delete(int id);
        Product[] GetProductsByCategory(int id);
    }
}