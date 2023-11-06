using BusinessObject.Models;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class FeedbackRepository : IFeedbackRepository
    {
        public IEnumerable<Feedback> GetFeedbacks() => FeedbackDAO.Instance.GetFeedbacks();

        public Feedback FindFeedbackById(int id) => FeedbackDAO.Instance.FindFeedbackById(id);

        public void AddFeedback(Feedback feedback) => FeedbackDAO.Instance.AddFeedback(feedback);

        public void UpdateFeedback(Feedback feedback) => FeedbackDAO.Instance.UpdateFeedback(feedback);

        public void DeleteFeedback(int id) => FeedbackDAO.Instance.DeleteFeedback(id);
    }
}
