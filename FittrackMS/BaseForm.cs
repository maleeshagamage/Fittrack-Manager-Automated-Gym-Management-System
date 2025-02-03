using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FittrackMS
{
    public class BaseForm : Form
    {
        protected int UserID => UserSession.UserID;
        protected int StaffID => UserSession.StaffID;
        protected string Role => UserSession.Role;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (UserSession.UserID == 0 || UserSession.Role == null)
            {
                MessageBox.Show("Session expired. Please log in again.");
                this.Hide();
                var loginForm = new Login();
                loginForm.Show();
            }
        }
    }


}
