using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAccommodationPortal
{
    public class Review
    {
        public User Reviewer { get; private set; }
        public Accommodation Accommodation { get; private set; }
        public string ReviewerComment { get; private set; }
        public int Rating { get; private set; }
        public DateTime ReviewDate { get; private set; }    

        public Review(User reviewer, Accommodation accommodation, string reviewerComment, int rating, DateTime reviewDate)
        {
            this.Reviewer = reviewer;
            this.Accommodation = accommodation;
            this.ReviewerComment = reviewerComment;
            this.Rating = rating;
            this.ReviewDate = reviewDate;
        }

        
    }


}
