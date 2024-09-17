using System.Collections.Generic;

namespace VideoStore
{
    class Video
    {
        private string _title;
        private bool _isCheckedOut;
        private List<int> _userRatings;

        public Video(string title)
        {
            _title = title;
            _isCheckedOut = false;
            _userRatings = new List<int>();
        }

        public string GetVideoTitle()
        {
            return _title;
        }

        public bool IsVideoCheckedOut()
        {
            return _isCheckedOut;
        }

        public void RentVideo()
        {
            _isCheckedOut = true;
        }

        public void ReturnVideo()
        {
            _isCheckedOut = false;
        }

        public void AddUserRating(int rating)
        {
            if (rating >= 1 && rating <= 5)
            {
                _userRatings.Add(rating);
            }
        }

        public double CalculateAverageRating()
        {
            if (_userRatings.Count == 0)
            {
                return 0;
            }

            double total = 0;

            foreach (var rating in _userRatings)
            {
                total += rating;
            }

            return total / _userRatings.Count;
        }
    }

    
}
