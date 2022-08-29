namespace Questions
{
    partial class FormR
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.reg = new System.Windows.Forms.Label();
			this.log = new System.Windows.Forms.Label();
			this.pas = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.login = new System.Windows.Forms.TextBox();
			this.password = new System.Windows.Forms.TextBox();
			this.enter = new System.Windows.Forms.Button();
			this.datebirth = new System.Windows.Forms.TextBox();
			this.dbth = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// reg
			// 
			this.reg.AutoSize = true;
			this.reg.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.reg.ForeColor = System.Drawing.Color.Blue;
			this.reg.Location = new System.Drawing.Point(35, 23);
			this.reg.Name = "reg";
			this.reg.Size = new System.Drawing.Size(185, 31);
			this.reg.TabIndex = 0;
			this.reg.Text = "Регистрация";
			this.reg.Click += new System.EventHandler(this.reg_Click);
			// 
			// log
			// 
			this.log.AutoSize = true;
			this.log.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.log.ForeColor = System.Drawing.Color.Red;
			this.log.Location = new System.Drawing.Point(52, 66);
			this.log.Name = "log";
			this.log.Size = new System.Drawing.Size(75, 23);
			this.log.TabIndex = 1;
			this.log.Text = "Логин*";
			this.log.Click += new System.EventHandler(this.label1_Click);
			// 
			// pas
			// 
			this.pas.AutoSize = true;
			this.pas.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.pas.ForeColor = System.Drawing.Color.Red;
			this.pas.Location = new System.Drawing.Point(52, 170);
			this.pas.Name = "pas";
			this.pas.Size = new System.Drawing.Size(88, 23);
			this.pas.TabIndex = 3;
			this.pas.Text = "Пароль*";
			this.pas.Click += new System.EventHandler(this.pas_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label1.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(410, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 33);
			this.label1.TabIndex = 4;
			this.label1.Text = "X";
			this.label1.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// login
			// 
			this.login.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.login.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.login.ForeColor = System.Drawing.Color.Blue;
			this.login.Location = new System.Drawing.Point(118, 102);
			this.login.Name = "login";
			this.login.Size = new System.Drawing.Size(230, 43);
			this.login.TabIndex = 5;
			this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
			// 
			// password
			// 
			this.password.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.password.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.password.ForeColor = System.Drawing.Color.Blue;
			this.password.Location = new System.Drawing.Point(118, 214);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(230, 43);
			this.password.TabIndex = 6;
			this.password.UseSystemPasswordChar = true;
			this.password.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// enter
			// 
			this.enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.enter.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.enter.ForeColor = System.Drawing.Color.Blue;
			this.enter.Location = new System.Drawing.Point(171, 406);
			this.enter.Name = "enter";
			this.enter.Size = new System.Drawing.Size(119, 47);
			this.enter.TabIndex = 7;
			this.enter.Text = "Ввод";
			this.enter.UseVisualStyleBackColor = false;
			this.enter.Click += new System.EventHandler(this.enter_Click);
			// 
			// datebirth
			// 
			this.datebirth.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.datebirth.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.datebirth.ForeColor = System.Drawing.Color.Blue;
			this.datebirth.Location = new System.Drawing.Point(118, 318);
			this.datebirth.Name = "datebirth";
			this.datebirth.Size = new System.Drawing.Size(230, 43);
			this.datebirth.TabIndex = 9;
			this.datebirth.TextChanged += new System.EventHandler(this.datebirth_TextChanged);
			// 
			// dbth
			// 
			this.dbth.AutoSize = true;
			this.dbth.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.dbth.ForeColor = System.Drawing.Color.Red;
			this.dbth.Location = new System.Drawing.Point(52, 276);
			this.dbth.Name = "dbth";
			this.dbth.Size = new System.Drawing.Size(168, 23);
			this.dbth.TabIndex = 8;
			this.dbth.Text = "Дата Рождения*";
			this.dbth.Click += new System.EventHandler(this.dbth_Click);
			// 
			// FormR
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(480, 519);
			this.Controls.Add(this.datebirth);
			this.Controls.Add(this.dbth);
			this.Controls.Add(this.enter);
			this.Controls.Add(this.password);
			this.Controls.Add(this.login);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pas);
			this.Controls.Add(this.log);
			this.Controls.Add(this.reg);
			this.Name = "FormR";
			this.Text = "FormR";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private Label reg;
		private Label log;
		private Label pas;
		private Label label1;
		private TextBox login;
		private TextBox password;
		private Button enter;
		private TextBox datebirth;
		private Label dbth;
	}
}