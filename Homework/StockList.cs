using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Homework
{
    public class StockList
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void ListProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Units: {product.UnitNumber}, Brand: {product.Brand}, Package Type: {product.PackageType}, Warehouse: {product.Warehouse}, Location: {product.Location}, Counting Date Time: {product.CountingDateTime}");
            }
        }

        public void EditProduct(string productName, int newUnitNumber)
        {
            var product = products.Find(p => p.Name == productName);
            if (product != null)
            {
                product.UnitNumber = newUnitNumber;
                Console.WriteLine("Product edited successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public void DeleteProduct(string productName)
        {
            var product = products.Find(p => p.Name == productName);
            if (product != null)
            {
                products.Remove(product);
                Console.WriteLine("Product deleted successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public void SearchProduct(string productName)
        {
            var product = products.Find(p => p.Name == productName);
            if (product != null)
            {
                Console.WriteLine("The product that you're looking for:");
                Console.WriteLine($"Name: {product.Name}, Units: {product.UnitNumber}, Brand: {product.Brand}, Package Type: {product.PackageType}, Warehouse: {product.Warehouse}, Location: {product.Location}, Counting Date Time: {product.CountingDateTime}");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public void SortProducts()
        {
            products.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
            Console.WriteLine("Products sorted by name.");
        }

        public void SaveToFile()
        {
            using (FileStream fs = new FileStream("stocklist.dat", FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, products);
                Console.WriteLine("Products saved to file.");
            }
        }

        public void LoadFromFile()
        {
            if (File.Exists("stocklist.dat"))
            {
                using (FileStream fs = new FileStream("stocklist.dat", FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    products = (List<Product>)bf.Deserialize(fs);
                    Console.WriteLine("Products loaded from file.");
                }
            }
            else
            {
                Console.WriteLine("No existing file found.");
            }
        }
    }
}
