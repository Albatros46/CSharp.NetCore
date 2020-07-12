using Ders_34_NesneRepositoryPattern.Entity;
using Ders_34_NesneRepositoryPattern.DataAcces.Abstract;

namespace Ders_34_NesneRepositoryPattern.DataAcces.Concrete
{//Projemizde veritabanı görevi gorecek.
    public class EfCategoryDal:ICategoryRepository
    {
        public Category GetById(int id){
            return new Category();
        }
        public void Update(Category entity){

        }
        public void Create(Category entity){

        }
        public void Delete(int id){
            
        }
    }
}