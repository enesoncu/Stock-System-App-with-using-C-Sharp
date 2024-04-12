using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            StockList stockList = new StockList();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("--Stock List Application--");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. List Products");
                Console.WriteLine("3. Edit Product");
                Console.WriteLine("4. Delete Product");
                Console.WriteLine("5. Search Product");
                Console.WriteLine("6. Sort Products");
                Console.WriteLine("7. Save to File");
                Console.WriteLine("8. Load from File");
                Console.WriteLine("9. Exit");
                Console.Write("\nEnter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddProduct(stockList);
                        break;
                    case "2":
                        stockList.ListProducts();
                        break;
                    case "3":
                        EditProduct(stockList);
                        break;
                    case "4":
                        DeleteProduct(stockList);
                        break;
                    case "5":
                        SearchProduct(stockList);
                        break;
                    case "6":
                        stockList.SortProducts();
                        break;
                    case "7":
                        stockList.SaveToFile();
                        break;
                    case "8":
                        stockList.LoadFromFile();
                        break;
                    case "9":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine(); 
            }
        }
        static void EditProduct(StockList stockList)
        {
            Console.Write("Enter product name to edit: ");
            string productName = Console.ReadLine();

            Console.Write("Enter new unit number: ");
            int newUnitNumber = int.Parse(Console.ReadLine());

            stockList.EditProduct(productName, newUnitNumber);
        }

        static void DeleteProduct(StockList stockList)
        {
            Console.Write("Enter product name to delete: ");
            string productName = Console.ReadLine();

            stockList.DeleteProduct(productName);
        }

        static void SearchProduct(StockList stockList)
        {
            Console.Write("Enter product name to search: ");
            string productName = Console.ReadLine();

            stockList.SearchProduct(productName);
        }

        static void AddProduct(StockList stockList)
        {
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();

            Console.Write("Enter unit number: ");
            int unitNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter brand: ");
            string brand = Console.ReadLine();

            Console.Write("Enter package type: ");
            string packageType = Console.ReadLine();

            Console.Write("Enter warehouse: ");
            string warehouse = Console.ReadLine();

            Console.Write("Enter location: ");
            string location = Console.ReadLine();

            DateTime countingDateTime = DateTime.Now;

            stockList.AddProduct(new Product
            {
                Name = name,
                UnitNumber = unitNumber,
                Brand = brand,
                PackageType = packageType,
                Warehouse = warehouse,
                Location = location,
                CountingDateTime = countingDateTime
            });

            Console.WriteLine("Product added successfully.");
        }

    }
}
