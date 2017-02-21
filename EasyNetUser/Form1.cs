using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyNetUser
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void getUsernamesButton_Click(object sender, EventArgs e)
        {
            getUsername getUsername = new getUsername();
            string usernameReturn = getUsername.getUsernames();
            outputWindow.Text = usernameReturn;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void runNetUserButton_Click(object sender, EventArgs e)
        {
            if (manualUsernameTextbox.Text != "")
            {
                string usernamePass = manualUsernameTextbox.Text;
                getUsername getUsername2 = new getUsername();
                string netUserReturn = getUsername2.runNetUserOnUsername(usernamePass);
                netUserWindow.Text = netUserReturn;
            } else
            {
                netUserWindow.Text = "PLEASE ENTER A USERNAME IN BOX NUMBER 2!";
            }
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            manualUsernameTextbox.Clear();
            outputWindow.Clear();
            netUserWindow.Clear();

        }
    }
}
