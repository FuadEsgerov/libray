using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void Registerlink(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (RegistrationForm frm = new RegistrationForm())
            {
                frm.ShowDialog();
                this.Close();
            }

        }

  
   
    }
}
