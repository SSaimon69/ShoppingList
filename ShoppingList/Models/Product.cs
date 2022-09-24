namespace ShoppingList.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public int Price { get; set; }
        public int PurchaseId { get; set; }
    }
}
