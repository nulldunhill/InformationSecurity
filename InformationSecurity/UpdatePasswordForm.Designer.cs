namespace InformationSecurity
{
    partial class UpdatePasswordForm
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
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.buttonUpdatePassword = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Старый пароль";
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Location = new System.Drawing.Point(13, 44);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.Size = new System.Drawing.Size(357, 22);
            this.textBoxOldPassword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Новый пароль";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(13, 123);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(357, 22);
            this.textBoxNewPassword.TabIndex = 3;
            // 
            // buttonUpdatePassword
            // 
            this.buttonUpdatePassword.Location = new System.Drawing.Point(12, 170);
            this.buttonUpdatePassword.Name = "buttonUpdatePassword";
            this.buttonUpdatePassword.Size = new System.Drawing.Size(357, 66);
            this.buttonUpdatePassword.TabIndex = 4;
            this.buttonUpdatePassword.Text = "Изменить пароль";
            this.buttonUpdatePassword.UseVisualStyleBackColor = true;
            this.buttonUpdatePassword.Click += new System.EventHandler(this.buttonUpdatePassword_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(12, 256);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 17);
            this.labelError.TabIndex = 5;
            // 
            // UpdatePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 303);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonUpdatePassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOldPassword);
            this.Controls.Add(this.label1);
            this.Name = "UpdatePasswordForm";
            this.Text = "Обновление пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Button buttonUpdatePassword;
        private System.Windows.Forms.Label labelError;
    }
}