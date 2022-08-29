using System.Windows.Forms;
namespace Questions
{
	partial class Quize
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
			this.quest = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.qw1 = new System.Windows.Forms.TextBox();
			this.qw2 = new System.Windows.Forms.TextBox();
			this.qw3 = new System.Windows.Forms.TextBox();
			this.qw4 = new System.Windows.Forms.TextBox();
			this.history = new System.Windows.Forms.Label();
			this.Gography = new System.Windows.Forms.Label();
			this.Biology = new System.Windows.Forms.Label();
			this.Literature = new System.Windows.Forms.Label();
			this.Go = new System.Windows.Forms.Button();
			this.his = new System.Windows.Forms.Button();
			this.geo = new System.Windows.Forms.Button();
			this.bio = new System.Windows.Forms.Button();
			this.lit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.check = new System.Windows.Forms.Button();
			this.wrong = new System.Windows.Forms.Label();
			this.right = new System.Windows.Forms.Label();
			this.RightBox1 = new System.Windows.Forms.TextBox();
			this.WrongBox2 = new System.Windows.Forms.TextBox();
			this.NextQ = new System.Windows.Forms.Button();
			this.OkUn = new System.Windows.Forms.TextBox();
			this.labelOkUnswer = new System.Windows.Forms.Label();
			this.HelpButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.RankButton = new System.Windows.Forms.Button();
			this.PastButton = new System.Windows.Forms.Button();
			this.Rank20Button = new System.Windows.Forms.Button();
			this.Best20label = new System.Windows.Forms.Label();
			this.PastResultslabel = new System.Windows.Forms.Label();
			this.RankLabel = new System.Windows.Forms.Label();
			this.ProfileButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// quest
			// 
			this.quest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.quest.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.quest.ForeColor = System.Drawing.Color.Blue;
			this.quest.Location = new System.Drawing.Point(82, 186);
			this.quest.Name = "quest";
			this.quest.Size = new System.Drawing.Size(465, 86);
			this.quest.TabIndex = 2;
			this.quest.Text = "";
			this.quest.TextChanged += new System.EventHandler(this.quest_TextChanged);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button1.Location = new System.Drawing.Point(82, 306);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(45, 34);
			this.button1.TabIndex = 3;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button2.Location = new System.Drawing.Point(82, 360);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(45, 34);
			this.button2.TabIndex = 4;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button3.Location = new System.Drawing.Point(82, 416);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(45, 34);
			this.button3.TabIndex = 5;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button4.Location = new System.Drawing.Point(82, 473);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(45, 34);
			this.button4.TabIndex = 6;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// qw1
			// 
			this.qw1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.qw1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.qw1.ForeColor = System.Drawing.Color.Blue;
			this.qw1.Location = new System.Drawing.Point(199, 306);
			this.qw1.Name = "qw1";
			this.qw1.Size = new System.Drawing.Size(348, 29);
			this.qw1.TabIndex = 8;
			this.qw1.TextChanged += new System.EventHandler(this.qw1_TextChanged);
			// 
			// qw2
			// 
			this.qw2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.qw2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.qw2.ForeColor = System.Drawing.Color.Blue;
			this.qw2.Location = new System.Drawing.Point(199, 360);
			this.qw2.Name = "qw2";
			this.qw2.Size = new System.Drawing.Size(348, 29);
			this.qw2.TabIndex = 9;
			this.qw2.TextChanged += new System.EventHandler(this.qw2_TextChanged);
			// 
			// qw3
			// 
			this.qw3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.qw3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.qw3.ForeColor = System.Drawing.Color.Blue;
			this.qw3.Location = new System.Drawing.Point(199, 416);
			this.qw3.Name = "qw3";
			this.qw3.Size = new System.Drawing.Size(348, 29);
			this.qw3.TabIndex = 10;
			this.qw3.TextChanged += new System.EventHandler(this.qw3_TextChanged);
			// 
			// qw4
			// 
			this.qw4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.qw4.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.qw4.ForeColor = System.Drawing.Color.Blue;
			this.qw4.Location = new System.Drawing.Point(199, 473);
			this.qw4.Name = "qw4";
			this.qw4.Size = new System.Drawing.Size(348, 29);
			this.qw4.TabIndex = 11;
			this.qw4.TextChanged += new System.EventHandler(this.qw4_TextChanged);
			// 
			// history
			// 
			this.history.AutoSize = true;
			this.history.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.history.ForeColor = System.Drawing.Color.Red;
			this.history.Location = new System.Drawing.Point(82, 79);
			this.history.Name = "history";
			this.history.Size = new System.Drawing.Size(83, 23);
			this.history.TabIndex = 12;
			this.history.Text = "История";
			this.history.Click += new System.EventHandler(this.label1_Click);
			// 
			// Gography
			// 
			this.Gography.AutoSize = true;
			this.Gography.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.Gography.ForeColor = System.Drawing.Color.Red;
			this.Gography.Location = new System.Drawing.Point(448, 79);
			this.Gography.Name = "Gography";
			this.Gography.Size = new System.Drawing.Size(99, 23);
			this.Gography.TabIndex = 13;
			this.Gography.Text = "География";
			// 
			// Biology
			// 
			this.Biology.AutoSize = true;
			this.Biology.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.Biology.ForeColor = System.Drawing.Color.Red;
			this.Biology.Location = new System.Drawing.Point(343, 79);
			this.Biology.Name = "Biology";
			this.Biology.Size = new System.Drawing.Size(88, 23);
			this.Biology.TabIndex = 14;
			this.Biology.Text = "Биология";
			// 
			// Literature
			// 
			this.Literature.AutoSize = true;
			this.Literature.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.Literature.ForeColor = System.Drawing.Color.Red;
			this.Literature.Location = new System.Drawing.Point(199, 79);
			this.Literature.Name = "Literature";
			this.Literature.Size = new System.Drawing.Size(115, 23);
			this.Literature.TabIndex = 15;
			this.Literature.Text = "Литература";
			this.Literature.Click += new System.EventHandler(this.label3_Click);
			// 
			// Go
			// 
			this.Go.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Go.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Go.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.Go.Location = new System.Drawing.Point(682, 65);
			this.Go.Name = "Go";
			this.Go.Size = new System.Drawing.Size(141, 54);
			this.Go.TabIndex = 16;
			this.Go.Text = "Начать викторину!";
			this.Go.UseVisualStyleBackColor = false;
			this.Go.Click += new System.EventHandler(this.button5_Click);
			// 
			// his
			// 
			this.his.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.his.Cursor = System.Windows.Forms.Cursors.Hand;
			this.his.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.his.Location = new System.Drawing.Point(106, 114);
			this.his.Name = "his";
			this.his.Size = new System.Drawing.Size(30, 31);
			this.his.TabIndex = 17;
			this.his.Text = "-";
			this.his.UseVisualStyleBackColor = false;
			this.his.Click += new System.EventHandler(this.his_Click);
			// 
			// geo
			// 
			this.geo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.geo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.geo.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.geo.Location = new System.Drawing.Point(471, 114);
			this.geo.Name = "geo";
			this.geo.Size = new System.Drawing.Size(30, 31);
			this.geo.TabIndex = 18;
			this.geo.Text = "-";
			this.geo.UseVisualStyleBackColor = false;
			this.geo.Click += new System.EventHandler(this.geo_Click);
			// 
			// bio
			// 
			this.bio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.bio.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bio.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.bio.Location = new System.Drawing.Point(367, 114);
			this.bio.Name = "bio";
			this.bio.Size = new System.Drawing.Size(30, 31);
			this.bio.TabIndex = 19;
			this.bio.Text = "-";
			this.bio.UseVisualStyleBackColor = false;
			this.bio.Click += new System.EventHandler(this.bio_Click);
			// 
			// lit
			// 
			this.lit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lit.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lit.Location = new System.Drawing.Point(238, 114);
			this.lit.Name = "lit";
			this.lit.Size = new System.Drawing.Size(30, 31);
			this.lit.TabIndex = 20;
			this.lit.Text = "-";
			this.lit.UseVisualStyleBackColor = false;
			this.lit.Click += new System.EventHandler(this.lit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(214, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(208, 22);
			this.label1.TabIndex = 21;
			this.label1.Text = "Категории вопросов";
			// 
			// check
			// 
			this.check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.check.Cursor = System.Windows.Forms.Cursors.Hand;
			this.check.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.check.Location = new System.Drawing.Point(716, 395);
			this.check.Name = "check";
			this.check.Size = new System.Drawing.Size(118, 36);
			this.check.TabIndex = 22;
			this.check.Text = "Проверить!";
			this.check.UseVisualStyleBackColor = false;
			this.check.Click += new System.EventHandler(this.check_Click);
			// 
			// wrong
			// 
			this.wrong.AutoSize = true;
			this.wrong.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.wrong.ForeColor = System.Drawing.Color.Red;
			this.wrong.Location = new System.Drawing.Point(345, 544);
			this.wrong.Name = "wrong";
			this.wrong.Size = new System.Drawing.Size(90, 22);
			this.wrong.TabIndex = 24;
			this.wrong.Text = "неверно";
			this.wrong.Click += new System.EventHandler(this.wrong_Click);
			// 
			// right
			// 
			this.right.AutoSize = true;
			this.right.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.right.ForeColor = System.Drawing.Color.Red;
			this.right.Location = new System.Drawing.Point(108, 549);
			this.right.Name = "right";
			this.right.Size = new System.Drawing.Size(68, 22);
			this.right.TabIndex = 26;
			this.right.Text = "верно";
			this.right.Click += new System.EventHandler(this.right_Click);
			// 
			// RightBox1
			// 
			this.RightBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.RightBox1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RightBox1.ForeColor = System.Drawing.Color.Blue;
			this.RightBox1.Location = new System.Drawing.Point(199, 543);
			this.RightBox1.Name = "RightBox1";
			this.RightBox1.Size = new System.Drawing.Size(97, 29);
			this.RightBox1.TabIndex = 27;
			this.RightBox1.TextChanged += new System.EventHandler(this.rightBox1_TextChanged);
			// 
			// WrongBox2
			// 
			this.WrongBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.WrongBox2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.WrongBox2.ForeColor = System.Drawing.Color.Blue;
			this.WrongBox2.Location = new System.Drawing.Point(450, 537);
			this.WrongBox2.Name = "WrongBox2";
			this.WrongBox2.Size = new System.Drawing.Size(97, 29);
			this.WrongBox2.TabIndex = 28;
			this.WrongBox2.TextChanged += new System.EventHandler(this.WrongBox2_TextChanged);
			// 
			// NextQ
			// 
			this.NextQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NextQ.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NextQ.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.NextQ.Location = new System.Drawing.Point(641, 146);
			this.NextQ.Name = "NextQ";
			this.NextQ.Size = new System.Drawing.Size(262, 44);
			this.NextQ.TabIndex = 32;
			this.NextQ.Text = "Следующий вопрос";
			this.NextQ.UseVisualStyleBackColor = false;
			this.NextQ.Click += new System.EventHandler(this.NextQ_Click);
			// 
			// OkUn
			// 
			this.OkUn.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.OkUn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.OkUn.ForeColor = System.Drawing.Color.Blue;
			this.OkUn.Location = new System.Drawing.Point(673, 264);
			this.OkUn.Multiline = true;
			this.OkUn.Name = "OkUn";
			this.OkUn.Size = new System.Drawing.Size(203, 111);
			this.OkUn.TabIndex = 33;
			this.OkUn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// labelOkUnswer
			// 
			this.labelOkUnswer.AutoSize = true;
			this.labelOkUnswer.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelOkUnswer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.labelOkUnswer.Location = new System.Drawing.Point(706, 231);
			this.labelOkUnswer.Name = "labelOkUnswer";
			this.labelOkUnswer.Size = new System.Drawing.Size(128, 18);
			this.labelOkUnswer.TabIndex = 35;
			this.labelOkUnswer.Text = "Верный ответ";
			// 
			// HelpButton
			// 
			this.HelpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.HelpButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.HelpButton.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.HelpButton.Location = new System.Drawing.Point(614, 9);
			this.HelpButton.Name = "HelpButton";
			this.HelpButton.Size = new System.Drawing.Size(148, 36);
			this.HelpButton.TabIndex = 39;
			this.HelpButton.Text = "Правила викторины";
			this.HelpButton.UseVisualStyleBackColor = false;
			this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ExitButton.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ExitButton.Location = new System.Drawing.Point(816, 9);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(118, 36);
			this.ExitButton.TabIndex = 40;
			this.ExitButton.Text = "Выход";
			this.ExitButton.UseVisualStyleBackColor = false;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// RankButton
			// 
			this.RankButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.RankButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.RankButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.RankButton.Location = new System.Drawing.Point(630, 461);
			this.RankButton.Name = "RankButton";
			this.RankButton.Size = new System.Drawing.Size(30, 31);
			this.RankButton.TabIndex = 41;
			this.RankButton.Text = "*";
			this.RankButton.UseVisualStyleBackColor = false;
			this.RankButton.Click += new System.EventHandler(this.RankButton_Click);
			// 
			// PastButton
			// 
			this.PastButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.PastButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.PastButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.PastButton.Location = new System.Drawing.Point(630, 546);
			this.PastButton.Name = "PastButton";
			this.PastButton.Size = new System.Drawing.Size(30, 31);
			this.PastButton.TabIndex = 43;
			this.PastButton.Text = "*";
			this.PastButton.UseVisualStyleBackColor = false;
			this.PastButton.Click += new System.EventHandler(this.PastButton_Click);
			// 
			// Rank20Button
			// 
			this.Rank20Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.Rank20Button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Rank20Button.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.Rank20Button.Location = new System.Drawing.Point(630, 505);
			this.Rank20Button.Name = "Rank20Button";
			this.Rank20Button.Size = new System.Drawing.Size(30, 31);
			this.Rank20Button.TabIndex = 44;
			this.Rank20Button.Text = "*";
			this.Rank20Button.UseVisualStyleBackColor = false;
			this.Rank20Button.Click += new System.EventHandler(this.Rank20Button_Click);
			// 
			// Best20label
			// 
			this.Best20label.AutoSize = true;
			this.Best20label.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.Best20label.ForeColor = System.Drawing.Color.Red;
			this.Best20label.Location = new System.Drawing.Point(673, 508);
			this.Best20label.Name = "Best20label";
			this.Best20label.Size = new System.Drawing.Size(293, 23);
			this.Best20label.TabIndex = 45;
			this.Best20label.Text = "Лучшие 20 в выбранной категории";
			this.Best20label.Click += new System.EventHandler(this.Best20label_Click);
			// 
			// PastResultslabel
			// 
			this.PastResultslabel.AutoSize = true;
			this.PastResultslabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.PastResultslabel.ForeColor = System.Drawing.Color.Red;
			this.PastResultslabel.Location = new System.Drawing.Point(673, 549);
			this.PastResultslabel.Name = "PastResultslabel";
			this.PastResultslabel.Size = new System.Drawing.Size(224, 23);
			this.PastResultslabel.TabIndex = 46;
			this.PastResultslabel.Text = "История Ваших викторин";
			this.PastResultslabel.Click += new System.EventHandler(this.PastResultslabel_Click);
			// 
			// RankLabel
			// 
			this.RankLabel.AutoSize = true;
			this.RankLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.RankLabel.ForeColor = System.Drawing.Color.Red;
			this.RankLabel.Location = new System.Drawing.Point(673, 464);
			this.RankLabel.Name = "RankLabel";
			this.RankLabel.Size = new System.Drawing.Size(358, 23);
			this.RankLabel.TabIndex = 47;
			this.RankLabel.Text = "Ваше место в данной категории вопросов";
			this.RankLabel.Click += new System.EventHandler(this.RankLabel_Click);
			// 
			// ProfileButton
			// 
			this.ProfileButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ProfileButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ProfileButton.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.ProfileButton.Location = new System.Drawing.Point(12, 9);
			this.ProfileButton.Name = "ProfileButton";
			this.ProfileButton.Size = new System.Drawing.Size(141, 54);
			this.ProfileButton.TabIndex = 49;
			this.ProfileButton.Text = "Логин";
			this.ProfileButton.UseVisualStyleBackColor = false;
			this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
			// 
			// Quize
			// 
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1030, 604);
			this.Controls.Add(this.ProfileButton);
			this.Controls.Add(this.RankLabel);
			this.Controls.Add(this.PastResultslabel);
			this.Controls.Add(this.Best20label);
			this.Controls.Add(this.Rank20Button);
			this.Controls.Add(this.PastButton);
			this.Controls.Add(this.RankButton);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.HelpButton);
			this.Controls.Add(this.labelOkUnswer);
			this.Controls.Add(this.OkUn);
			this.Controls.Add(this.NextQ);
			this.Controls.Add(this.WrongBox2);
			this.Controls.Add(this.RightBox1);
			this.Controls.Add(this.right);
			this.Controls.Add(this.wrong);
			this.Controls.Add(this.check);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lit);
			this.Controls.Add(this.bio);
			this.Controls.Add(this.geo);
			this.Controls.Add(this.his);
			this.Controls.Add(this.Go);
			this.Controls.Add(this.Literature);
			this.Controls.Add(this.Biology);
			this.Controls.Add(this.Gography);
			this.Controls.Add(this.history);
			this.Controls.Add(this.qw4);
			this.Controls.Add(this.qw3);
			this.Controls.Add(this.qw2);
			this.Controls.Add(this.qw1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.quest);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Name = "Quize";
			this.Text = "FormQ";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private RichTextBox quest;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private TextBox qw1;
		private TextBox qw2;
		private TextBox qw3;
		private TextBox qw4;
		private Label history;
		private Label Gography;
		private Label Biology;
		private Label Literature;
		private Button Go;
		private Button his;
		private Button geo;
		private Button bio;
		private Button lit;
		private Label label1;
		private Button check;
		private Label wrong;
		private Label right;
		private TextBox RightBox1;
		private TextBox WrongBox2;
		private Button NextQ;
		private TextBox OkUn;
		private Label labelOkUnswer;
        private Button HelpButton;
        private Button ExitButton;
		private Button RankButton;
		private Button PastButton;
		private Button Rank20Button;
		private Label Best20label;
		private Label PastResultslabel;
		private Label RankLabel;
		private Button ProfileButton;
	}
}