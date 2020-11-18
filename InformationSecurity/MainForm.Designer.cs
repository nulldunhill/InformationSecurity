namespace InformationSecurity
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonChangeCurrentPassword = new System.Windows.Forms.Button();
            this.buttonUsersControl = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChangeCurrentPassword
            // 
            this.buttonChangeCurrentPassword.Location = new System.Drawing.Point(10, 11);
            this.buttonChangeCurrentPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChangeCurrentPassword.Name = "buttonChangeCurrentPassword";
            this.buttonChangeCurrentPassword.Size = new System.Drawing.Size(104, 61);
            this.buttonChangeCurrentPassword.TabIndex = 0;
            this.buttonChangeCurrentPassword.Text = "Сменить пароль текущего пользователя";
            this.buttonChangeCurrentPassword.UseVisualStyleBackColor = true;
            this.buttonChangeCurrentPassword.Click += new System.EventHandler(this.buttonChangeCurrentPassword_Click);
            // 
            // buttonUsersControl
            // 
            this.buttonUsersControl.Location = new System.Drawing.Point(118, 11);
            this.buttonUsersControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUsersControl.Name = "buttonUsersControl";
            this.buttonUsersControl.Size = new System.Drawing.Size(104, 61);
            this.buttonUsersControl.TabIndex = 1;
            this.buttonUsersControl.Text = "Управление пользователями";
            this.buttonUsersControl.UseVisualStyleBackColor = true;
            this.buttonUsersControl.Click += new System.EventHandler(this.buttonUsersControl_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(228, 11);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(104, 61);
            this.buttonInfo.TabIndex = 2;
            this.buttonInfo.Text = "Справка";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 95);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonUsersControl);
            this.Controls.Add(this.buttonChangeCurrentPassword);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Программа разграничения полномочий пользователей";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChangeCurrentPassword;
        private System.Windows.Forms.Button buttonUsersControl;
        private System.Windows.Forms.Button buttonInfo;
    }
}

