namespace Questions
{
	partial class FormW
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
			this.buttoтReg = new System.Windows.Forms.Button();
			this.buttonAut = new System.Windows.Forms.Button();
			this.Welcome = new System.Windows.Forms.Label();
			this.closeX = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttoтReg
			// 
			this.buttoтReg.BackColor = System.Drawing.Color.Cyan;
			this.buttoтReg.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttoтReg.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttoтReg.ForeColor = System.Drawing.Color.Blue;
			this.buttoтReg.Location = new System.Drawing.Point(117, 194);
			this.buttoтReg.Name = "buttoтReg";
			this.buttoтReg.Size = new System.Drawing.Size(189, 70);
			this.buttoтReg.TabIndex = 0;
			this.buttoтReg.Text = "Зарегистрироваться";
			this.buttoтReg.UseVisualStyleBackColor = false;
			this.buttoтReg.Click += new System.EventHandler(this.buttoтReg_Click);
			// 
			// buttonAut
			// 
			this.buttonAut.BackColor = System.Drawing.Color.Cyan;
			this.buttonAut.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonAut.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonAut.ForeColor = System.Drawing.Color.Blue;
			this.buttonAut.Location = new System.Drawing.Point(409, 194);
			this.buttonAut.Name = "buttonAut";
			this.buttonAut.Size = new System.Drawing.Size(189, 70);
			this.buttonAut.TabIndex = 1;
			this.buttonAut.Text = "Авторизоваться";
			this.buttonAut.UseVisualStyleBackColor = false;
			this.buttonAut.Click += new System.EventHandler(this.buttonAut_Click);
			// 
			// Welcome
			// 
			this.Welcome.AutoSize = true;
			this.Welcome.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Welcome.ForeColor = System.Drawing.Color.Red;
			this.Welcome.Location = new System.Drawing.Point(207, 96);
			this.Welcome.Name = "Welcome";
			this.Welcome.Size = new System.Drawing.Size(322, 44);
			this.Welcome.TabIndex = 2;
			this.Welcome.Text = "Викторина #Умный Я#";
			this.Welcome.Click += new System.EventHandler(this.Welcome_Click);
			// 
			// closeX
			// 
			this.closeX.AutoSize = true;
			this.closeX.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.closeX.Location = new System.Drawing.Point(626, 28);
			this.closeX.Name = "closeX";
			this.closeX.Size = new System.Drawing.Size(36, 37);
			this.closeX.TabIndex = 3;
			this.closeX.Text = "X";
			this.closeX.Click += new System.EventHandler(this.closeX_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(711, 418);
			this.Controls.Add(this.closeX);
			this.Controls.Add(this.Welcome);
			this.Controls.Add(this.buttonAut);
			this.Controls.Add(this.buttoтReg);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button buttoтReg;
		private Button buttonAut;
		private Label Welcome;
		private Label closeX;
	}
}