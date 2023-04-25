using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Product product1 = new Product()
        {
            Name = "Zeonчик)",
            Count = 20,
            Price = 24,
            Manufacturer = "Intel",
            DateOfReceiptInStock = DateOnly.Parse("2022.12.06"),
        };
        Product product2 = new Product()
        {
            Name = "Zeonчик)))))",
            Count = 25,
            Price = 24,
            Manufacturer = "Intel",
            DateOfReceiptInStock = DateOnly.Parse("2022.12.07"),
        };
        Product product3 = new Product()
        {
            Name = "Zeonчик))",
            Count = 200,
            Price = 24,
            Manufacturer = "Intel",
            DateOfReceiptInStock = DateOnly.Parse("2022.12.08"),
        };
        Product product4 = new Product()
        {
            Name = "Zeonчик))))",
            Count = 8,
            Price = 24,
            Manufacturer = "Intel",
            DateOfReceiptInStock = DateOnly.Parse("2022.12.09"),
        };
        Product product5 = new Product()
        {
            Name = "Zeonчик)))",
            Count = 3,
            Price = 24,
            Manufacturer = "Intel",
            DateOfReceiptInStock = DateOnly.Parse("2022.12.10"),
        };
        Product[] products = new Product[5] { product1, product2, product3, product4, product5 };
        List<int> res = new List<int>();
        for (int i = 0; i < products.Length; i++)
        {
            if (products[i].Count > 5) products[i].Print();
        }
    }

    struct Product
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public string Manufacturer { get; set; }
        public DateOnly DateOfReceiptInStock { get; set; }

        public Product(string name, int count, int price, string manufacturer, DateOnly dateOfReceiptInStock)
        {
            Name = name;
            Count = count;
            Price = price;
            Manufacturer = manufacturer;
            DateOfReceiptInStock = dateOfReceiptInStock;
        }

        public void Print()
        {
            Console.WriteLine($"Фамилия: {Name}, Амплуа: {Count}, Возраст: {Price}, Матчей сыграно: {Manufacturer}, Кол-во голов: {DateOfReceiptInStock}");
        }
    }
}