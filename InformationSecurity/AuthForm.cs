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
    public partial class AuthForm : Form
    {
        private int enterCounter = 0;
        private readonly IUserService service;

        public AuthForm()
        {
            InitializeComponent();
            service = UserService.GetInstance();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (enterCounter > 2)
            {
                DialogResult = DialogResult.No;
                Close();
            }
            enterCounter++;
            if (textBoxName.Text.Length == 0)
            {
                labelError.Text = "Введите имя пользователя";
                return;
            }
            if (textBoxPassword.Text.Length == 0)
            {
                labelError.Text = "Введите пароль";
                return;
            }

            var result = service.Auth(textBoxName.Text, textBoxPassword.Text);

            switch (result)
            {
                case AuthStatus.Done:
                    DialogResult = DialogResult.OK;
                    Close();
                    break;
                case AuthStatus.PasswordWrong:
                    labelError.Text = "Пароль неверный";
                    break;
                case AuthStatus.UserNotFound:
                    labelError.Text = "Пользователя с таким именем не существует";
                    break;
                case AuthStatus.UserFirstAuth:
                    var form = new ConfirmPasswordForm(textBoxName.Text, textBoxPassword.Text);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        labelError.Text = "Пароли не совпали";
                    }
                    break;
                case AuthStatus.UserBlocked:
                    labelError.Text = "Данный пользователь заблокирован";
                    break;
                case AuthStatus.PasswordIncorrect:
                    labelError.Text = "Пароль некорректный";
                    break;
            }
        }
    }
}
