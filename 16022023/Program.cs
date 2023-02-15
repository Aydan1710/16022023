using System;

namespace _16022023
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store(5, 0.4m);
            Product product1 = new Product("Product1", 10m);
            Product product2 = new Drink("Product2", 20m, 0.3m);
            Product product3 = new Dairy("Product3", 30m, 0.2m);
            Product product4 = new Dairy("Product4", 40m, 0.3m);
            Product product5 = new Drink("Product5", 50m, 0.5m);

            store.AddProduct(product1);
            store.AddProduct(product2);
            store.AddProduct(product3);
            store.AddProduct(product4);
            store.AddProduct(product5);

            Console.WriteLine("Dairy Products:");
            foreach (Product product in store.GetDairyProducts())
            {
                Console.WriteLine($"{product.No} {product.Name} {product.Price} {((Dairy)product).FatPercent}");
            }

            Console.WriteLine("\nDrink Products:");
            foreach (Product product in store.GetDrinkProducts())
            {
                Console.WriteLine($"{product.No} {product.Name} {product.Price} {((Drink)product).AlcoholPercent}");
            }

            Console.WriteLine($"\nProduct with No 3 exists in Store: {store.HasProductByNo(3)}");
            Console.WriteLine($"Product with No 10 exists in Store: {store.HasProductByNo(10)}");

            Console.ReadLine();
        }
    }
    }
}

