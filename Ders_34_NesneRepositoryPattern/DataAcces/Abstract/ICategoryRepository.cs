using Ders_34_NesneRepositoryPattern.Entity;
namespace Ders_34_NesneRepositoryPattern.DataAcces.Abstract
{/* Interface olarak tanımlamamızın sebebi, kullanilacak yerler buradan kullansin degisken verilerini
        MySQL, SQL, NoSQL, Entity Framework vs gibi ayrı ayrı yazmak yerine buradan ortak olarak çeksinler.
    */
    public interface ICategoryRepository
    {
        Category GetById(int id){
            return new Category();
        }
        void Update(Category entity){

        }
        void Create(Category entity){

        }
        void Delete(int id){
            
        }
    }
}