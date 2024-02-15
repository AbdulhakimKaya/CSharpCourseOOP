namespace LinqProject;

class Program
{
    static void Main(string[] args)
    {
        List<Category> categories = new List<Category>
        {
            new Category { CategoryId = 1, CategoryName = "Bilgisayar" },
            new Category { CategoryId = 2, CategoryName = "Telefon" },
        };

        List<Product> products = new List<Product>
        {
            new Product
            {
                ProductId = 1, CategoryId = 1, ProductName = "Hp Pavilion", QuantityPerUnit = "16 GB RAM",
                UnitPrice = 16000, UnitsInStock = 7
            },
            new Product
            {
                ProductId = 2, CategoryId = 1, ProductName = "Dell Laptop", QuantityPerUnit = "8 GB RAM",
                UnitPrice = 15000, UnitsInStock = 5
            },
            new Product
            {
                ProductId = 3, CategoryId = 1, ProductName = "Asus Laptop", QuantityPerUnit = "32 GB RAM",
                UnitPrice = 70000, UnitsInStock = 3
            },
            new Product
            {
                ProductId = 4, CategoryId = 2, ProductName = "Apple Telefon", QuantityPerUnit = "6 GB RAM",
                UnitPrice = 65000, UnitsInStock = 9
            },
            new Product
            {
                ProductId = 5, CategoryId = 2, ProductName = "Samsung Telefon", QuantityPerUnit = "8 GB RAM",
                UnitPrice = 60000, UnitsInStock = 4
            },
        };

        // algorithms
        foreach (var product in products)
        {
            if (product.UnitPrice > 20000 && product.UnitsInStock > 5)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        // Linq
        var result = products.Where(
            p => p.UnitPrice > 20000 && p.UnitsInStock > 5
        );

        foreach (var product in result)
        {
            Console.WriteLine(product.ProductName);
        }

        GetProducts(products);
    }

    static List<Product> GetProducts(List<Product> products)
    {
        List<Product> filteredProducts = new List<Product>();

        foreach (var product in products)
        {
            if (product.UnitPrice > 20000 && product.UnitsInStock > 5)
            {
                filteredProducts.Add(product);
            }
        }

        return filteredProducts;
    }

    static List<Product> GetProductsLinq(List<Product> products)
    {
        return products.Where(
            p => p.UnitPrice > 20000 && p.UnitsInStock > 5
        ).ToList();
    }
}

class Product
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public string QuantityPerUnit { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
}

class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}