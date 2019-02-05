//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Problem_07._Andrey_and_Billiard
//{
//    class AndreyBilliard
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            List<Product> products = new List<Product>();
//            GetProducts(n, products);

//            List<Client> clients = new List<Client>();
//            string line = Console.ReadLine();
//            while (line != "end of clients")
//            {
//                GetClientOrder(products, clients, line);
//                line = Console.ReadLine();
//            }


//        }

//        static void GetClientOrder(List<Product> products, List<Client> clients, string line)
//        {
//            string[] tokens = line.Split("-,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

//            string clientName = tokens[0];
//            string clientOrder = tokens[1];
//            int clientQuantity = int.Parse(tokens[2]);
//            decimal bill = 0M;
//            if (clients.Any(c => c.Name == clientName) == false)
//            {
//                if (products.Any(product => product.Name == clientOrder))
//                {
//                    decimal price = 0;
//                    foreach (var item in products)
//                    {
//                        if (item.Name == clientOrder)
//                        {
//                            price = item.Price;
//                            break;
//                        }
//                    }

//                    bill = clientQuantity * price;
//                    Client client = new Client(clientName, clientOrder, bill);
//                }
//            }
//            else
//            {
//                bool isValidProduct = products.Any(p => p.Name == clientOrder);

//                var price = 0m;
//                foreach (var item in clients)
//                {
//                    if (item.Name == clientName && isValidProduct)
//                    {
//                        foreach (var product in products)
//                        {
//                            if (product.Name == clientOrder)
//                            {
//                                price = product.Price;
//                            }
//                        }

//                        item.Bill += clientQuantity * price;
//                        break;
//                    }
//                }
//            }
//        }

//        static void GetProducts(int n, List<Product> products)
//        {
//            for (int i = 0; i < n; i++)
//            {
//                string[] productToken = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);
//                string name = productToken[0];
//                decimal price = decimal.Parse(productToken[1]);
//                Product product = new Product(name, price);

//                if (products.Any(p => p.Name == product.Name) == false)
//                {
//                    products.Add(product);
//                }
//                else
//                {
//                    foreach (var item in products)
//                    {
//                        if (item.Name == name)
//                        {
//                            item.Price = price;
//                        }
//                    }
//                }
//            }
//        }
//    }

//    class Client
//    {
//        public string Name { get; set; }
//        public Dictionary<string, int> OrderQuantity { get; set; }
//        public decimal Bill { get; set; }
//        public Client(string name, Dictionary<string, int> quantity, decimal bill)
//        {
//            this.Name = name;
//            this.OrderQuantity = quantity;
//            this.Bill = bill;
//        }
//    }


//    class Product
//    {
//        public string Name { get; set; }
//        public decimal Price { get; set; }

//        public Product(string name, decimal price)
//        {
//            this.Name = name;
//            this.Price = price;
//        }

//    }
//}
