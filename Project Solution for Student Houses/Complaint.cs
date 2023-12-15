using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Solution_for_Student_Houses
{
    public class Complaint
    {
        public string Title { get; set; }
        public DateTime SubmissionTime { get; set; }
        public List<Complaint> Complaints { get; set; }
        public string Description { get; set; }
        public bool Anonymous { get; set; }
        public Status Status { get; set; }

        public Complaint()
        {
            Complaints = new List<Complaint>();
        }

        public void AddComplaint(Complaint complaint)
        {
            Complaints.Add(complaint);
        }

        public void RemoveComplaint(Complaint complaint)
        {
            Complaints.Remove(complaint);
        }
    }
}

