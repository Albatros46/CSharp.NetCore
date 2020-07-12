namespace Ders_34_NesneRepositoryPattern.Entity
{
    public class Product:IEntity
    {
        public int Id{get; set;}//IEntity den çekilecek
        public string Name { get; set; }
        public double Price { get; set; }

    }
}