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
    public partial class UpdatePasswordForm : Form
    {
        private readonly IUserService service;

        public UpdatePasswordForm()
        {
            InitializeComponent();
            service = UserService.GetInstance();
        }

        private void buttonUpdatePassword_Click(object sender, EventArgs e)
        {
            if (service.isCorrectPassword(textBoxOldPassword.Text))
            {
                var result = service.UpdatePassword(textBoxNewPassword.Text);
                if (result == AuthStatus.UserNotFound)
                {
                    labelError.Text = "Пользователь не найден";
                    DialogResult = DialogResult.No;
                    Close();
                }
                else if (result == AuthStatus.PasswordIncorrect)
                {
                    labelError.Text = "Новый пароль некорректный";
                }
                else if (result == AuthStatus.Done)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                labelError.Text = "Старый пароль неверный";
            }
        }
    }
}
