using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationSecurity
{
    public partial class ConfirmPasswordForm : Form
    {
        private readonly IUserService service;
        private string name;
        private string password;

        public ConfirmPasswordForm(string name, string password)
        {
            InitializeComponent();
            service = UserService.GetInstance();
            this.name = name;
            this.password = password;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Equals(password))
            {
                service.SavePassword(name, password);
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.No;
            }
        }
    }
}
