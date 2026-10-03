using Online_Store_Order_Processing.Models;

namespace Online_Store_Order_Processing.Data
{
    public static class ProductCatalog
    {
        public static List<Product> Products = new()
        {
            new Product { Id = 1, Name = "Smartphone", Category = "Electronics", Price = 699.99, Stock = 50 },
            new Product { Id = 2, Name = "Laptop", Category = "Electronics", Price = 999.99, Stock = 30 },
            new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 19.99, Stock = 100 },
            new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 49.99, Stock = 60 },
            new Product { Id = 5, Name = "Chocolate Bar", Category = "Food", Price = 1.99, Stock = 200 },
            new Product { Id = 6, Name = "Organic Apples", Category = "Food", Price = 3.99, Stock = 150 },
            new Product { Id = 7, Name = "Novel Book", Category = "Books", Price = 14.99, Stock = 80 },
            new Product { Id = 8, Name = "Science Textbook", Category = "Books", Price = 59.99, Stock = 40 }
        };
    }
}
