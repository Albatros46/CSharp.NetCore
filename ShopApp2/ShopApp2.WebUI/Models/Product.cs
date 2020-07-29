namespace ShopApp2.WebUI.Models
{
    public class Product
    {
        public string Name { get; set; }//Ürün Adı
        public double Price { get; set; }//Ürün Fiyatı
        public string Description { get; set; }//Ürün Hakkında
        public bool isApproved{ get; set; }//Onaylı mı?
    }
}