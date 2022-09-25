namespace ShoppingList.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public int ShopID { get; set; }
        public virtual List<Product> ProductList { get; set; }
    }
}
