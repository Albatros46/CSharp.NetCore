using Ders_34_NesneRepositoryPattern.Entity;
namespace Ders_34_NesneRepositoryPattern.DataAcces.Abstract
{/* Interface olarak tanımlamamızın sebebi, kullanilacak yerler buradan kullansin degisken verilerini
        MySQL, SQL, NoSQL, Entity Framework vs gibi ayrı ayrı yazmak yerine buradan ortak olarak çeksinler.
    */
    public interface ICategoryRepository:IRepository<Category>//Generic yapidaki IRepository burda categori olarak calisacak.
    {
        
    }
}