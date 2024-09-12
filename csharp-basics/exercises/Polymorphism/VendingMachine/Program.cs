using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingmachine = new VendingMachine("Skibidi");

            vendingmachine.AddProduct("šprotes", new Money() { Euros = 2, Cents = 50 }, 40);
            vendingmachine.AddProduct("uzgriežņi", new Money() { Euros = 5, Cents = 0 }, 10);
            vendingmachine.AddProduct("koliņa", new Money() { Euros = 1, Cents = 20 }, 50);

            Console.WriteLine($"{vendingmachine.Manufacturer}");
            Console.WriteLine("Items in the vending machine");
            foreach (var product in vendingmachine.Products)
            {
                Console.WriteLine(
                    $"{product.Name}: {product.Price.Euros} Euros, {product.Price.Cents} Cents, {product.Available} in stock");
            }

            InsertAndDisplayChange(vendingmachine, new Money { Euros = 1, Cents = 0 });
            InsertAndDisplayChange(vendingmachine, new Money { Euros = 2, Cents = 0 });
            InsertAndDisplayChange(vendingmachine, new Money { Euros = 0, Cents = 20 });
            InsertAndDisplayChange(vendingmachine, new Money { Euros = 0, Cents = 30 });
            InsertAndDisplayChange(vendingmachine, new Money { Euros = 3, Cents = 0 });

            Console.WriteLine($"Your current amount: {vendingmachine.Amount.Euros} Euros, {vendingmachine.Amount.Cents} cents");
            
            Console.WriteLine($"You have selected 'koliņa' ");
            bool purchaseSuccessful = vendingmachine.PurchaseProduct("koliņa");

            if (purchaseSuccessful)
            {
                Console.WriteLine("Purchase successful");
            }
            else
            {
                Console.WriteLine("Purchase unsuccessful");
            }

            Console.WriteLine(
                $"Remaining money: {vendingmachine.Amount.Euros} Euros, {vendingmachine.Amount.Cents} cents");

            Money refundMoney = vendingmachine.ReturnMoney();
            Console.WriteLine(
                $"Money returned: {refundMoney.Euros} EUros, {refundMoney.Cents} cents");
        }

        private static void InsertAndDisplayChange(VendingMachine vendingmachine, Money coin)
        {
            Money change = vendingmachine.InsertCoin(coin);
            if (change.Euros == 0 && change.Cents == 0)
            {
                Console.WriteLine($"Inserted coin: {coin.Euros} Euro(s), {coin.Cents} cents");
            }
            else
            {
                Console.WriteLine($"Invalid coin inserted. {change.Euros} Euro(s) {change.Cents} Cents returned.");
            }
        }
    }
}
