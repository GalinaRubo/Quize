namespace Questions
{
	partial class FormProfile
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
			this.ProfileDatebirthText = new System.Windows.Forms.TextBox();
			this.ProfileDbth = new System.Windows.Forms.Label();
			this.ProfileEnter = new System.Windows.Forms.Button();
			this.ProfilePasswordText = new System.Windows.Forms.TextBox();
			this.ProfileLginText = new System.Windows.Forms.TextBox();
			this.ProfileClose = new System.Windows.Forms.Label();
			this.ProfilePassword = new System.Windows.Forms.Label();
			this.ProfileLogin = new System.Windows.Forms.Label();
			this.YourProfile = new System.Windows.Forms.Label();
			this.ProfileNewPasswordText = new System.Windows.Forms.TextBox();
			this.ProfileNewPassword = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ProfileDatebirthText
			// 
			this.ProfileDatebirthText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ProfileDatebirthText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ProfileDatebirthText.ForeColor = System.Drawing.Color.Blue;
			this.ProfileDatebirthText.Location = new System.Drawing.Point(279, 470);
			this.ProfileDatebirthText.Name = "ProfileDatebirthText";
			this.ProfileDatebirthText.Size = new System.Drawing.Size(230, 43);
			this.ProfileDatebirthText.TabIndex = 21;
			this.ProfileDatebirthText.TextChanged += new System.EventHandler(this.ProfileDatebirthText_TextChanged);
			// 
			// ProfileDbth
			// 
			this.ProfileDbth.AutoSize = true;
			this.ProfileDbth.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ProfileDbth.ForeColor = System.Drawing.Color.Red;
			this.ProfileDbth.Location = new System.Drawing.Point(213, 428);
			this.ProfileDbth.Name = "ProfileDbth";
			this.ProfileDbth.Size = new System.Drawing.Size(168, 23);
			this.ProfileDbth.TabIndex = 17;
			this.ProfileDbth.Text = "Дата Рождения*";
			this.ProfileDbth.Click += new System.EventHandler(this.ProfileDbth_Click);
			// 
			// ProfileEnter
			// 
			this.ProfileEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ProfileEnter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ProfileEnter.ForeColor = System.Drawing.Color.Blue;
			this.ProfileEnter.Location = new System.Drawing.Point(334, 579);
			this.ProfileEnter.Name = "ProfileEnter";
			this.ProfileEnter.Size = new System.Drawing.Size(119, 47);
			this.ProfileEnter.TabIndex = 16;
			this.ProfileEnter.Text = "Сохранить";
			this.ProfileEnter.UseVisualStyleBackColor = false;
			this.ProfileEnter.Click += new System.EventHandler(this.ProfileEnter_Click);
			// 
			// ProfilePasswordText
			// 
			this.ProfilePasswordText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ProfilePasswordText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ProfilePasswordText.ForeColor = System.Drawing.Color.Blue;
			this.ProfilePasswordText.Location = new System.Drawing.Point(279, 227);
			this.ProfilePasswordText.Name = "ProfilePasswordText";
			this.ProfilePasswordText.Size = new System.Drawing.Size(230, 43);
			this.ProfilePasswordText.TabIndex = 15;
			this.ProfilePasswordText.UseSystemPasswordChar = true;
			this.ProfilePasswordText.TextChanged += new System.EventHandler(this.ProfilePasswordText_TextChanged);
			// 
			// ProfileLginText
			// 
			this.ProfileLginText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ProfileLginText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ProfileLginText.ForeColor = System.Drawing.Color.Blue;
			this.ProfileLginText.Location = new System.Drawing.Point(279, 108);
			this.ProfileLginText.Name = "ProfileLginText";
			this.ProfileLginText.Size = new System.Drawing.Size(230, 43);
			this.ProfileLginText.TabIndex = 14;
			this.ProfileLginText.TextChanged += new System.EventHandler(this.ProfileLginText_TextChanged);
			// 
			// ProfileClose
			// 
			this.ProfileClose.AutoSize = true;
			this.ProfileClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ProfileClose.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ProfileClose.ForeColor = System.Drawing.Color.Black;
			this.ProfileClose.Location = new System.Drawing.Point(687, 23);
			this.ProfileClose.Name = "ProfileClose";
			this.ProfileClose.Size = new System.Drawing.Size(33, 33);
			this.ProfileClose.TabIndex = 13;
			this.ProfileClose.Text = "X";
			this.ProfileClose.Click += new System.EventHandler(this.ProfileClose_Click);
			// 
			// ProfilePassword
			// 
			this.ProfilePassword.AutoSize = true;
			this.ProfilePassword.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ProfilePassword.ForeColor = System.Drawing.Color.Red;
			this.ProfilePassword.Location = new System.Drawing.Point(213, 183);
			this.ProfilePassword.Name = "ProfilePassword";
			this.ProfilePassword.Size = new System.Drawing.Size(88, 23);
			this.ProfilePassword.TabIndex = 12;
			this.ProfilePassword.Text = "Пароль*";
			this.ProfilePassword.Click += new System.EventHandler(this.ProfilePassword_Click);
			// 
			// ProfileLogin
			// 
			this.ProfileLogin.AutoSize = true;
			this.ProfileLogin.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ProfileLogin.ForeColor = System.Drawing.Color.Red;
			this.ProfileLogin.Location = new System.Drawing.Point(213, 72);
			this.ProfileLogin.Name = "ProfileLogin";
			this.ProfileLogin.Size = new System.Drawing.Size(75, 23);
			this.ProfileLogin.TabIndex = 11;
			this.ProfileLogin.Text = "Логин*";
			this.ProfileLogin.Click += new System.EventHandler(this.ProfileLogin_Click);
			// 
			// YourProfile
			// 
			this.YourProfile.AutoSize = true;
			this.YourProfile.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.YourProfile.ForeColor = System.Drawing.Color.Blue;
			this.YourProfile.Location = new System.Drawing.Point(289, 12);
			this.YourProfile.Name = "YourProfile";
			this.YourProfile.Size = new System.Drawing.Size(199, 31);
			this.YourProfile.TabIndex = 10;
			this.YourProfile.Text = "Ваш профиль";
			this.YourProfile.Click += new System.EventHandler(this.YourProfile_Click);
			// 
			// ProfileNewPasswordText
			// 
			this.ProfileNewPasswordText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ProfileNewPasswordText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ProfileNewPasswordText.ForeColor = System.Drawing.Color.Blue;
			this.ProfileNewPasswordText.Location = new System.Drawing.Point(279, 348);
			this.ProfileNewPasswordText.Name = "ProfileNewPasswordText";
			this.ProfileNewPasswordText.Size = new System.Drawing.Size(230, 43);
			this.ProfileNewPasswordText.TabIndex = 20;
			this.ProfileNewPasswordText.UseSystemPasswordChar = true;
			this.ProfileNewPasswordText.TextChanged += new System.EventHandler(this.ProfileNewPasswordText_TextChanged);
			// 
			// ProfileNewPassword
			// 
			this.ProfileNewPassword.AutoSize = true;
			this.ProfileNewPassword.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ProfileNewPassword.ForeColor = System.Drawing.Color.Red;
			this.ProfileNewPassword.Location = new System.Drawing.Point(213, 304);
			this.ProfileNewPassword.Name = "ProfileNewPassword";
			this.ProfileNewPassword.Size = new System.Drawing.Size(153, 23);
			this.ProfileNewPassword.TabIndex = 19;
			this.ProfileNewPassword.Text = "Новый пароль*";
			this.ProfileNewPassword.Click += new System.EventHandler(this.ProfileNewPassword_Click);
			// 
			// FormProfile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 661);
			this.Controls.Add(this.ProfileNewPasswordText);
			this.Controls.Add(this.ProfileNewPassword);
			this.Controls.Add(this.ProfileDatebirthText);
			this.Controls.Add(this.ProfileDbth);
			this.Controls.Add(this.ProfileEnter);
			this.Controls.Add(this.ProfilePasswordText);
			this.Controls.Add(this.ProfileLginText);
			this.Controls.Add(this.ProfileClose);
			this.Controls.Add(this.ProfilePassword);
			this.Controls.Add(this.ProfileLogin);
			this.Controls.Add(this.YourProfile);
			this.Name = "FormProfile";
			this.Text = "FormProfile";
			this.Load += new System.EventHandler(this.FormProfile_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox ProfileDatebirthText;
		private Label ProfileDbth;
		private Button ProfileEnter;
		private TextBox ProfilePasswordText;
		private TextBox ProfileLginText;
		private Label ProfileClose;
		private Label ProfilePassword;
		private Label ProfileLogin;
		private Label YourProfile;
		private TextBox ProfileNewPasswordText;
		private Label ProfileNewPassword;
	}
}