using System;
using System.Collections.Generic;
using System.Threading;


namespace VendingMachine
{
    internal class VendingMachine : IVendingMachine
    {
        private string _manufacturer;
        private Money _currentAmount;
        private List<Product> _products;

        public string Manufacturer => _manufacturer;

        public bool HasProducts => _products.Count > 0;

        public Money Amount => _currentAmount;

        public Product[] Products => _products.ToArray();

        public VendingMachine(string manufacturer)
        {
            _manufacturer = manufacturer;
            _currentAmount = new Money { Euros = 0, Cents = 0 };
            _products = new List<Product>();
        }

        public Money InsertCoin(Money coin)
        {
            if (IsValidCoin(coin))
            {
                _currentAmount = AddMoney(_currentAmount, coin);
                return new Money { Euros = 0, Cents = 0 };
            }
            else
            {
                return coin;
            }
        }

        public Money ReturnMoney()
        {
            Money refund = _currentAmount;
            _currentAmount = new Money { Euros = 0, Cents = 0 };
            return refund;
        }

        public bool AddProduct(string productName, Money productPrice, int quantity)
        {
            if (quantity <= 0 || string.IsNullOrEmpty(productName))
                return false;

            _products.Add(new Product
            {
                Name = productName,
                Price = productPrice,
                Available = quantity
            });

            return true;
        }

        public bool UpdateProduct(int productIndex, string name, Money? price, int quantity)
        {
            if (productIndex < 0 || productIndex >= _products.Count)
            {
                return false;
            }

            Product product = _products[productIndex];

            if (!string.IsNullOrEmpty(name))
            {
                product.Name = name;
            }

            if (price.HasValue)
            {
                product.Price = price.Value;
            }

            if (quantity >= 0)
            {
                product.Available = quantity;
            }

            _products[productIndex] = product;

            return true;
        }

        public bool PurchaseProduct(string productName)
        {
            var product = _products.Find(p => p.Name == productName);
            if (product.Name == null || product.Available <= 0)
            {
                Console.WriteLine($"Product '{productName} is not available");
                return false;
            }

            if (Amount.Euros < product.Price.Euros ||
                (Amount.Euros == product.Price.Euros && Amount.Cents < product.Price.Cents))
            {
                Console.WriteLine("Not enough money");
                return false;
            }

            _currentAmount = SubtractMoney(_currentAmount, product.Price);
            product.Available--;
            _products[_products.FindIndex(p => p.Name == productName)] = product;

            Console.WriteLine($"Purchased {productName} successfully");
            return true;
        }

        private bool IsValidCoin(Money coin)
        {
            return (coin.Euros == 0 && (coin.Cents == 10 || coin.Cents == 20 || coin.Cents == 50)) ||
                   (coin.Euros == 1 && coin.Cents == 0) ||
                   (coin.Euros == 2 && coin.Cents == 0);
        }

        private Money AddMoney(Money currentAmount, Money amountToAdd)
        {
            int cents = currentAmount.Cents + amountToAdd.Cents;
            int euros = currentAmount.Euros + amountToAdd.Euros;

            if (cents >= 100)
            {
                euros += cents / 100;
                cents %= 100;
            }

            return new Money { Euros = euros, Cents = cents };
        }

        private Money SubtractMoney(Money currentAmount, Money amountToSubtract)
        {
            int cents = currentAmount.Cents - amountToSubtract.Cents;
            int euros = currentAmount.Euros - amountToSubtract.Euros;

            if (cents < 0)
            {
                euros--;
                cents += 100;
            }

            return new Money { Euros = euros, Cents = cents };
        }
    }
}
