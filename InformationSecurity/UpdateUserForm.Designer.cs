namespace InformationSecurity
{
    partial class UpdateUserForm
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
            this.checkBoxIsBlocked = new System.Windows.Forms.CheckBox();
            this.checkBoxIsWithRestrictions = new System.Windows.Forms.CheckBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxIsBlocked
            // 
            this.checkBoxIsBlocked.AutoSize = true;
            this.checkBoxIsBlocked.Location = new System.Drawing.Point(13, 25);
            this.checkBoxIsBlocked.Name = "checkBoxIsBlocked";
            this.checkBoxIsBlocked.Size = new System.Drawing.Size(274, 21);
            this.checkBoxIsBlocked.TabIndex = 0;
            this.checkBoxIsBlocked.Text = "Блокирование работы пользователя";
            this.checkBoxIsBlocked.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsWithRestrictions
            // 
            this.checkBoxIsWithRestrictions.AutoSize = true;
            this.checkBoxIsWithRestrictions.Location = new System.Drawing.Point(13, 64);
            this.checkBoxIsWithRestrictions.Name = "checkBoxIsWithRestrictions";
            this.checkBoxIsWithRestrictions.Size = new System.Drawing.Size(285, 21);
            this.checkBoxIsWithRestrictions.TabIndex = 1;
            this.checkBoxIsWithRestrictions.Text = "Ограничения на пароль пользователя";
            this.checkBoxIsWithRestrictions.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(12, 108);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(394, 53);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(13, 186);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 17);
            this.labelError.TabIndex = 3;
            // 
            // UpdateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 215);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.checkBoxIsWithRestrictions);
            this.Controls.Add(this.checkBoxIsBlocked);
            this.Name = "UpdateUserForm";
            this.Text = "Обновление статусов пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxIsBlocked;
        private System.Windows.Forms.CheckBox checkBoxIsWithRestrictions;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelError;
    }
}