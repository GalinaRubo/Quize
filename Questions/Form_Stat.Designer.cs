namespace Questions
{
	partial class Form_Stat
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
			this.HeadTextBox = new System.Windows.Forms.RichTextBox();
			this.StatTextBox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// HeadTextBox
			// 
			this.HeadTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.HeadTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.HeadTextBox.ForeColor = System.Drawing.Color.Blue;
			this.HeadTextBox.Location = new System.Drawing.Point(43, 14);
			this.HeadTextBox.Name = "HeadTextBox";
			this.HeadTextBox.Size = new System.Drawing.Size(754, 89);
			this.HeadTextBox.TabIndex = 3;
			this.HeadTextBox.Text = "";
			this.HeadTextBox.TextChanged += new System.EventHandler(this.HeadTextBox_TextChanged);
			// 
			// StatTextBox
			// 
			this.StatTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.StatTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.StatTextBox.ForeColor = System.Drawing.Color.Blue;
			this.StatTextBox.Location = new System.Drawing.Point(44, 101);
			this.StatTextBox.Name = "StatTextBox";
			this.StatTextBox.Size = new System.Drawing.Size(753, 588);
			this.StatTextBox.TabIndex = 4;
			this.StatTextBox.Text = "";
			this.StatTextBox.TextChanged += new System.EventHandler(this.StatTextBox_TextChanged);
			// 
			// Form_Stat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(836, 717);
			this.Controls.Add(this.StatTextBox);
			this.Controls.Add(this.HeadTextBox);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name = "Form_Stat";
			this.Text = "Form_Stat";
			this.ResumeLayout(false);

		}

		#endregion

		private RichTextBox HeadTextBox;
		private RichTextBox StatTextBox;
	}
}