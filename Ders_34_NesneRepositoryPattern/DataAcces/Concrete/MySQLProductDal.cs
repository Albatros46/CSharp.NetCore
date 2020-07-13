using System;
using Ders_34_NesneRepositoryPattern.Entity;
using Ders_34_NesneRepositoryPattern.DataAcces.Abstract;

namespace Ders_34_NesneRepositoryPattern.DataAcces.Concrete
{
    public class MySQLProductDal:IProductRepository
    {
        public Product GetById(int id){
            return new Product();
        }
        public void Update(Product entity){

        }
        public void Create(Product entity){
            Console.WriteLine("MySQLProductDal-Create Calisiyor.");
        }
        public void Delete(int id){
            
        }
        public Product[] GetPopulerProducts(){

        }
        public Product[] GetProductsByCategory(int id){

        }
    }
}