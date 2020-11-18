namespace InformationSecurity
{
    partial class AddUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.checkBoxIsBlocked = new System.Windows.Forms.CheckBox();
            this.checkBoxIsWithRestrictions = new System.Windows.Forms.CheckBox();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя пользователя";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(16, 45);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(304, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 167);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(304, 67);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // checkBoxIsBlocked
            // 
            this.checkBoxIsBlocked.AutoSize = true;
            this.checkBoxIsBlocked.Location = new System.Drawing.Point(16, 87);
            this.checkBoxIsBlocked.Name = "checkBoxIsBlocked";
            this.checkBoxIsBlocked.Size = new System.Drawing.Size(274, 21);
            this.checkBoxIsBlocked.TabIndex = 5;
            this.checkBoxIsBlocked.Text = "Блокирование работы пользователя";
            this.checkBoxIsBlocked.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsWithRestrictions
            // 
            this.checkBoxIsWithRestrictions.AutoSize = true;
            this.checkBoxIsWithRestrictions.Location = new System.Drawing.Point(16, 127);
            this.checkBoxIsWithRestrictions.Name = "checkBoxIsWithRestrictions";
            this.checkBoxIsWithRestrictions.Size = new System.Drawing.Size(285, 21);
            this.checkBoxIsWithRestrictions.TabIndex = 6;
            this.checkBoxIsWithRestrictions.Text = "Ограничения на пароль пользователя";
            this.checkBoxIsWithRestrictions.UseVisualStyleBackColor = true;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(12, 254);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 17);
            this.labelError.TabIndex = 7;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 297);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.checkBoxIsWithRestrictions);
            this.Controls.Add(this.checkBoxIsBlocked);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "AddUserForm";
            this.Text = "Добавление пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.CheckBox checkBoxIsBlocked;
        private System.Windows.Forms.CheckBox checkBoxIsWithRestrictions;
        private System.Windows.Forms.Label labelError;
    }
}