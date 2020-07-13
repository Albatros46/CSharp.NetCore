using System;
using System;
using Ders_34_NesneRepositoryPattern.Entity;
using Ders_34_NesneRepositoryPattern.DataAcces.Abstract;
using Ders_34_NesneRepositoryPattern.DataAcces.Concrete;

namespace Ders_34_NesneRepositoryPattern
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
    class ProductManager:IProductRepository{//Injection gorev gorecek
        IProductRepository _repository;
        public ProductManager(IProductRepository repository)
        {
            //ProductManager ile EfProductDal ilişkilendirilecek
            _repository=repository;
        }
        public Product GetById(int id){

        }
        public void Update(Product entity){

        }
        public void Create(Product entity){
            _repository.Create(entity);//EfProductDal içindeki create cagirildi.
        }
        public void Delete(int id){

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //  var productDal=new EfProductDal();
            //  productDal.Create(new Product());

            // var productDal1=new MySQLProductDal();
            // productDal1.Create(new Product());

            //ProductManager kullnarak cagiracagiz.
            var productDal=new ProductManager(new MySQLProductDal());
            productDal.Create(new Product());
            //Injection->IProductRepository->EfProductDal()/MySQLProductDal()
        }
    }
}
