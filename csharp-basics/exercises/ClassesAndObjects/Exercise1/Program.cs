namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product mouse = new Product("Logitech mouse", 70.00, 14);
            mouse.PrintProduct();

            Product iPhone = new Product("iPhone 5s", 999.99, 3);
            iPhone.PrintProduct();

            Product projector = new Product("Epson EB-U05", 440.46, 1);
            projector.PrintProduct();

            mouse.ChangePrice(420.69);
            iPhone.ChangeQuantity(500);
            projector.ChangePrice(22.00);
        }
    }

    public class Product
    {
        private string _name;
        private double _price;
        private int amount;

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            this.name = name;
            this.price = priceAtStart;
            this.amount = amountAtStart;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{name}, price {price} EUR, amount {amount} units.");
        }

        public void ChangeQuantity(int newAmount)
        {
            this.amount = newAmount;
        }

        public void ChangePrice(double newPrice)
        {
            this.price = newPrice;
        }
    }
}
