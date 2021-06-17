using System;
using System.Collections.Generic;
using System.Text;

namespace BookReview.Shared
{
    public class BookReviews
    {
        public string BookTitle { get; set; }

        public string ReviewDiscription { get; set; }

        public Stairs StairRating { get; set; }

        public int Upvotes { get; set; }

        public int Downvotes { get; set; }


    }

    public enum Stairs
    {
        stair_1,
        stair_2,
        stair_3,
        stair_4,
        stair_5

    }
}
