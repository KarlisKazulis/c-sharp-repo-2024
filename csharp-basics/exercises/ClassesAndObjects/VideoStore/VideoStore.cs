using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO.Enumeration;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> _videoCollection;

        public VideoStore()
        {
            _videoCollection = new List<Video>();
        }

        public void AddNewVideo(string title)
        {
            _videoCollection.Add(new Video(title));
        }

        public void CheckoutVideo(string title)
        {
            Video video = FindVideo(title);
            if (video != null && !video.IsVideoCheckedOut())
            {
                video.RentVideo();
                Console.WriteLine($"{title} is checked out.");
            }
            else
            {
                Console.WriteLine($"{title} was not found in the inventory.");
            }
        }

        public void AcceptReturnedVideo(string title)
        {
            Video video = FindVideo(title);
            if (video != null && !video.IsVideoCheckedOut())
            {
                video.ReturnVideo();
                Console.WriteLine($"{title} was returned");
            }
            else
            {
                Console.WriteLine($"{title} was never checked out.");
            }
        }

        public void UserRating(string title, int rating)
        {
            Video video = FindVideo(title);
            if (video != null)
            {
                video.AddUserRating(rating);
                Console.WriteLine($"{title} was given a rating of {rating}");
            }
            else
            {
                Console.WriteLine($"{title} was not found in the inventory");
            }
        }

        public void ShowInventory()
        {
            if (_videoCollection.Count == 0)
            {
                Console.WriteLine("Video inventory is empty.");
                return;
            }

            foreach (var video in _videoCollection)
            {
                string videoAvailability;

                if (video.IsVideoCheckedOut())
                {
                    videoAvailability = "Checked out";
                }
                else
                {
                    videoAvailability = "Available";
                }

                Console.WriteLine($"{video.GetVideoTitle()} - Rating: {video.CalculateAverageRating()} " +
                                  $"- Status: {videoAvailability}");
            }
        }

        private Video FindVideo(string title)
        {
            string lowerCaseTitle = title.ToLower();
            
            foreach (var video in _videoCollection)
            {
                if (video.GetVideoTitle().ToLower() == lowerCaseTitle) //allows for case-insensitive comparison
                {
                    return video;
                }
            }

            return null;
        }
    }

}
