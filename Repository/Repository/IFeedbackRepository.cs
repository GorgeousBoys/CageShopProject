using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public interface IFeedbackRepository
    {
        // Feed back
        IEnumerable<Feedback> GetFeedbacks();
        Feedback FindFeedbackById(int id);
        void AddFeedback(Feedback feedback);
        void UpdateFeedback(Feedback feedback);
        void DeleteFeedback(int id);
    }
}
