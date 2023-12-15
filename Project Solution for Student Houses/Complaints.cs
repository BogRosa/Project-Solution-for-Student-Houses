using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Solution_for_Student_Houses
{
    public partial class Complaints : Form
    {
        private ComplaintService complaintService;
        public Complaints()
        {
            InitializeComponent();
            complaintService = new ComplaintService();
            chkAnonymous.Checked = false;
        }

        private void submitComplaint_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            DateTime submissionTime = dateTimeOccurred.Value;
            string description = txtDescription.Text;
            bool anonymous = chkAnonymous.Checked;

            // Call the ComplaintsService to submit the complaint
            complaintService.SubmitComplaint(title, submissionTime, description, anonymous);

            // Optionally, you can clear the textboxes or do other UI updates
            ClearForm();
        }
        private void ClearForm()
        {
            txtTitle.Clear();
            dateTimeOccurred.Value = DateTime.Now;
            txtDescription.Clear();
            chkAnonymous.Checked = false;
        }
       
    }
}
