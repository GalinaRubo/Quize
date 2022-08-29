namespace Questions
{
	partial class FormA
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
			this.Login = new System.Windows.Forms.TextBox();
			this.Password = new System.Windows.Forms.TextBox();
			this.Entry = new System.Windows.Forms.Button();
			this.closeX = new System.Windows.Forms.Label();
			this.log = new System.Windows.Forms.Label();
			this.pas = new System.Windows.Forms.Label();
			this.Autor = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Login
			// 
			this.Login.BackColor = System.Drawing.Color.Silver;
			this.Login.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.Login.Location = new System.Drawing.Point(174, 138);
			this.Login.Name = "Login";
			this.Login.Size = new System.Drawing.Size(264, 35);
			this.Login.TabIndex = 0;
			this.Login.TextChanged += new System.EventHandler(this.Login_TextChanged);
			// 
			// Password
			// 
			this.Password.BackColor = System.Drawing.Color.Silver;
			this.Password.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.Password.ForeColor = System.Drawing.Color.Black;
			this.Password.Location = new System.Drawing.Point(174, 264);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(264, 35);
			this.Password.TabIndex = 1;
			this.Password.UseSystemPasswordChar = true;
			this.Password.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// Entry
			// 
			this.Entry.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.Entry.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Entry.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.Entry.ForeColor = System.Drawing.SystemColors.Highlight;
			this.Entry.Location = new System.Drawing.Point(246, 361);
			this.Entry.Name = "Entry";
			this.Entry.Size = new System.Drawing.Size(115, 40);
			this.Entry.TabIndex = 2;
			this.Entry.Text = "Вход";
			this.Entry.UseVisualStyleBackColor = false;
			this.Entry.Click += new System.EventHandler(this.Entry_Click);
			// 
			// closeX
			// 
			this.closeX.AutoSize = true;
			this.closeX.Cursor = System.Windows.Forms.Cursors.Hand;
			this.closeX.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.closeX.Location = new System.Drawing.Point(542, 26);
			this.closeX.Name = "closeX";
			this.closeX.Size = new System.Drawing.Size(35, 37);
			this.closeX.TabIndex = 3;
			this.closeX.Text = "X";
			this.closeX.Click += new System.EventHandler(this.closeX_Click);
			// 
			// log
			// 
			this.log.AutoSize = true;
			this.log.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.log.ForeColor = System.Drawing.Color.Red;
			this.log.Location = new System.Drawing.Point(174, 95);
			this.log.Name = "log";
			this.log.Size = new System.Drawing.Size(110, 37);
			this.log.TabIndex = 4;
			this.log.Text = "Логин*";
			this.log.Click += new System.EventHandler(this.log_Click);
			// 
			// pas
			// 
			this.pas.AutoSize = true;
			this.pas.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.pas.ForeColor = System.Drawing.Color.Red;
			this.pas.Location = new System.Drawing.Point(174, 208);
			this.pas.Name = "pas";
			this.pas.Size = new System.Drawing.Size(129, 37);
			this.pas.TabIndex = 5;
			this.pas.Text = "Пароль*";
			this.pas.Click += new System.EventHandler(this.pas_Click);
			// 
			// Autor
			// 
			this.Autor.AutoSize = true;
			this.Autor.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.Autor.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Autor.Location = new System.Drawing.Point(216, 26);
			this.Autor.Name = "Autor";
			this.Autor.Size = new System.Drawing.Size(193, 37);
			this.Autor.TabIndex = 6;
			this.Autor.Text = "Авторизация";
			// 
			// FormA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(613, 468);
			this.Controls.Add(this.Autor);
			this.Controls.Add(this.pas);
			this.Controls.Add(this.log);
			this.Controls.Add(this.closeX);
			this.Controls.Add(this.Entry);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.Login);
			this.Name = "FormA";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public TextBox Login;
		private TextBox Password;
		private Button Entry;
		private Label closeX;
		private Label log;
		private Label pas;
		private Label Autor;
	}
}