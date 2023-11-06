using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class FeedbackDAO
    {
        private static FeedbackDAO instance;
        private static object instanceLock = new object();

        private FeedbackDAO() { }

        public static FeedbackDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new FeedbackDAO();
                    }
                }
                return instance;
            }
        }

        public List<Feedback> GetFeedbacks()
        {
            using CageShopUni_Context context = new CageShopUni_Context();
            return context.Feedbacks.ToList();
        }

        public Feedback FindFeedbackById(int id)
        {
            var feedbacks = GetFeedbacks();
            return feedbacks.SingleOrDefault(f => f.FeedbackId == id);
        }

        public void AddFeedback(Feedback feedback)
        {
            using CageShopUni_Context context = new CageShopUni_Context();
            context.Feedbacks.Add(feedback);
            context.SaveChanges();
        }

        public void UpdateFeedback(Feedback feedback)
        {
            using CageShopUni_Context context = new CageShopUni_Context();
            context.Entry(feedback).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteFeedback(int id)
        {
            using CageShopUni_Context context = new CageShopUni_Context();
            var feedback = context.Feedbacks.SingleOrDefault(f => f.FeedbackId == id);
            if (feedback != null)
            {
                context.Feedbacks.Remove(feedback);
                context.SaveChanges();
            }
        }
    }
}
