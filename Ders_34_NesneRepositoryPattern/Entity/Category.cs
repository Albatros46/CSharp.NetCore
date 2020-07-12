namespace Ders_34_NesneRepositoryPattern.Entity
{
    public class Category:IEntity
    {
        public int Id { get; set; }//IEntity den çekilecek
        public string Name { get; set; }
    }
}