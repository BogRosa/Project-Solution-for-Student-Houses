using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Solution_for_Student_Houses
{
    public class ComplaintService
    {
        public void SubmitComplaint(string title, DateTime submissionTime, string description, bool anonymous)
        {
            Complaint newComplaint = new Complaint
            {
                Title = title,
                SubmissionTime = submissionTime,
                Description = description,
                Anonymous = anonymous,
                Status = Status.Sent
            };
        }
    }
}
