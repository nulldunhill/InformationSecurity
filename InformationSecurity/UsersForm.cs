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
    public partial class UsersForm : Form
    {
        private readonly IUserService service;

        public UsersForm()
        {
            InitializeComponent();
            service = UserService.GetInstance();

            SetData();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            var form = new AddUserForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                SetData();
            }
        }

        private void buttonUpdateUser_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var user = service.GetUser(dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                var form = new UpdateUserForm(user.Name, user.IsBlocked, user.IsWithRestrictions);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SetData();
                }
            }
        }

        private void SetData()
        {
            dataGridView.DataSource = new List<User>();
            dataGridView.DataSource = service.GetUsers();
            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[1].Visible = false;
            dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
