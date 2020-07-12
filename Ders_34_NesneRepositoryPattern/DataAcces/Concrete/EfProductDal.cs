using Ders_34_NesneRepositoryPattern.Entity;
using Ders_34_NesneRepositoryPattern.DataAcces.Abstract;

namespace Ders_34_NesneRepositoryPattern.DataAcces.Concrete
{//Projemizde veritabanı görevi gorecek. 

    public class EfProductDal:IProductRepository
    {
        public Product GetById(int id){
            return new Product();
        }
        public void Update(Product entity){

        }
        public void Create(Product entity){

        }
        public void Delete(int id){
            
        }
        public Product[] GetProductsByCategory(int id){

        }
    }
}