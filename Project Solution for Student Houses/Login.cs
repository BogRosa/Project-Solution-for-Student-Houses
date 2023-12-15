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
    public partial class Login : Form
    {
        private User hardcodedUser = new User
        {
            UserID = 1,
            Name = "Ivan Ivanov",
            Username = "ivan_ivanov",
            Password = "ivan123",
            PhoneNumber = "123-456-7890",
            Address = new Address
            {
                Street = "123 Main St",
                City = "Eindhoven",
                PostalCode = "12345"
            }
        };
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;

            // Check if the entered username and password match the hardcoded values
            if (enteredUsername == hardcodedUser.Username && enteredPassword == hardcodedUser.Password)
            {
                this.Hide();
                Complaints complaints = new Complaints();
                complaints.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
