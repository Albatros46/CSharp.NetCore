using System;
using System;
using Ders_34_NesneRepositoryPattern.Entity;
using Ders_34_NesneRepositoryPattern.DataAcces.Abstract;
using Ders_34_NesneRepositoryPattern.DataAcces.Concrete;

namespace Ders_34_NesneRepositoryPattern
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
    
    class Program
    {
        static void Main(string[] args)
        {
            var productDal=new EfProductDal();
            productDal.Create(new Product());

        }
    }
}
