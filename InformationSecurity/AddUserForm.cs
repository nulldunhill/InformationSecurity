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
    public partial class AddUserForm : Form
    {
        private readonly IUserService service;

        public AddUserForm()
        {
            InitializeComponent();
            service = UserService.GetInstance();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length == 0)
            {
                labelError.Text = "Имя пользователя не может быть пустым";
                return;
            }
            var result = service.AddUser(textBoxName.Text, 
                checkBoxIsBlocked.CheckState == CheckState.Checked, 
                checkBoxIsWithRestrictions.CheckState == CheckState.Checked);
            if (result)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                labelError.Text = "Пользователь с таким именем уже существует";
            }
        }
    }
}
