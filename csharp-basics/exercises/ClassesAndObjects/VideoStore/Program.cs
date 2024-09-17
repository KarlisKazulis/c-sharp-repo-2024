using System;

namespace VideoStore
{

    class Program
    {
        public static void Main(string[] args)
        {
            VideoStore store = new VideoStore();

            while (true)
            {
                Console.WriteLine("Choose the operation you want to perform ");
                Console.WriteLine("Choose 0 for EXIT");
                Console.WriteLine("Choose 1 to fill video store");
                Console.WriteLine("Choose 2 to rent video (as user)");
                Console.WriteLine("Choose 3 to return video (as user)");
                Console.WriteLine("Choose 4 to rate video");
                Console.WriteLine("Choose 5 to show the inventory");

                int n = Convert.ToByte(Console.ReadLine());

                switch (n)
                {
                    case 0:
                        return;
                    case 1:
                        Console.WriteLine("Enter video title:");
                        string addTitle = Console.ReadLine();
                        store.AddNewVideo(addTitle);
                        break;
                    case 2:
                        Console.WriteLine("Enter video title you want to checkout:");
                        string checkoutTitle = Console.ReadLine();
                        store.CheckoutVideo(checkoutTitle);
                        break;
                    case 3:
                        Console.WriteLine("Enter video title you want to return:");
                        string returnTitle = Console.ReadLine();
                        store.AcceptReturnedVideo(returnTitle);
                        break;
                    case 4:
                        Console.WriteLine("Enter video title you want to rate:");
                        string rateTitle = Console.ReadLine();
                        Console.WriteLine("Enter rating (1-5):");
                        int rating = Convert.ToInt32(Console.ReadLine());
                        store.UserRating(rateTitle, rating);
                        break;
                    case 5:
                        store.ShowInventory();
                        break;
                    default:
                        Console.WriteLine("Error. Pick between 1-5");
                        return;
                }
            }
        }
    }
}
