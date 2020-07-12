using Ders_34_NesneRepositoryPattern.Entity;
namespace Ders_34_NesneRepositoryPattern.DataAcces.Concrete
{//Projemizde veritabanı görevi gorecek. 
    public class EfProductDal
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
    }
}