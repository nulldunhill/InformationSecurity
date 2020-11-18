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
    public partial class UpdateUserForm : Form
    {
        private readonly IUserService service;
        private string name;

        public UpdateUserForm(string name, bool isBlocked, bool isWithRestrictions)
        {
            InitializeComponent();
            service = UserService.GetInstance();

            this.name = name;
            checkBoxIsBlocked.CheckState = isBlocked ? CheckState.Checked : CheckState.Unchecked;
            checkBoxIsWithRestrictions.CheckState = isWithRestrictions ? CheckState.Checked : CheckState.Unchecked;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var result = service.UpdateUser(name,
                checkBoxIsBlocked.CheckState == CheckState.Checked,
                checkBoxIsWithRestrictions.CheckState == CheckState.Checked);
            if (result)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                labelError.Text = "Пользователя с таким именем не существует";
            }
        }
    }
}
