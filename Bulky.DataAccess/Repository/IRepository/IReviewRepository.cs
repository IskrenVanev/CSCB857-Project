﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IReviewRepository : IRepository<Review>
    {
        void Update(Review obj);
         bool AddNewReview(Review review);

         Task AddReviewAsync(string content, int ProductId, string userId, string email, int rating);
         //List<Review> GetReviews(int reviewId, int productId);
    }
}
