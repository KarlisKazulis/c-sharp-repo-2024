using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    internal class VideoStoreTest
    {
        public static void StoreTest()
        {
            VideoStore store = new VideoStore();

            store.AddNewVideo("The Matrix");
            store.AddNewVideo("Godfather II");
            store.AddNewVideo("Star Wars Episode IV: A New Hope");

            store.UserRating("The Matrix", 1);
            store.UserRating("Godfather II", 2);
            store.UserRating("Godfather II", 3);
            store.UserRating("Star Wars Episode IV: A New Hope", 4);

            store.CheckoutVideo("The Matrix");
            store.CheckoutVideo("Godfather II");
            store.CheckoutVideo("Star Wars Episode IV: A New Hope");

            store.AcceptReturnedVideo("The Matrix");
            store.AcceptReturnedVideo("Godfather II");
            store.AcceptReturnedVideo("Star Wars Episode IV: A New Hope");

            store.CheckoutVideo("Godfather II");
            Console.WriteLine("Inventory afte Godrather has been rented out:");
            store.ShowInventory();
        }
    }
}
