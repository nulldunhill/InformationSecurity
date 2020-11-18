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
    public partial class MainForm : Form
    {
        private readonly IUserService service;

        public MainForm()
        {
            InitializeComponent();
            service = UserService.GetInstance();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var form = new AuthForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!service.IsAdmin())
                {
                    buttonUsersControl.Hide();
                }
            }
            else
            {
                Close();
            }
        }

        private void buttonChangeCurrentPassword_Click(object sender, EventArgs e)
        {
            var form = new UpdatePasswordForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Пароль успешно изменен");
            }
        }

        private void buttonUsersControl_Click(object sender, EventArgs e)
        {
            new UsersForm().ShowDialog();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            new InfoForm().ShowDialog();
        }
    }
}
