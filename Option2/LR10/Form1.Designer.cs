
namespace LR10
{
	partial class Form1
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
			this.FirstArgumentTextBox = new System.Windows.Forms.TextBox();
			this.SecondArgumentTextBox = new System.Windows.Forms.TextBox();
			this.ResaultTextBox = new System.Windows.Forms.TextBox();
			this.EqualLabel = new System.Windows.Forms.Label();
			this.AvgButton = new System.Windows.Forms.Button();
			this.LcmButton = new System.Windows.Forms.Button();
			this.GcdButton = new System.Windows.Forms.Button();
			this.ClearScreenButton = new System.Windows.Forms.Button();
			this.MessageLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// FirstArgumentTextBox
			// 
			this.FirstArgumentTextBox.Location = new System.Drawing.Point(13, 13);
			this.FirstArgumentTextBox.Name = "FirstArgumentTextBox";
			this.FirstArgumentTextBox.Size = new System.Drawing.Size(63, 23);
			this.FirstArgumentTextBox.TabIndex = 0;
			// 
			// SecondArgumentTextBox
			// 
			this.SecondArgumentTextBox.Location = new System.Drawing.Point(82, 13);
			this.SecondArgumentTextBox.Name = "SecondArgumentTextBox";
			this.SecondArgumentTextBox.Size = new System.Drawing.Size(63, 23);
			this.SecondArgumentTextBox.TabIndex = 1;
			// 
			// ResaultTextBox
			// 
			this.ResaultTextBox.Location = new System.Drawing.Point(166, 12);
			this.ResaultTextBox.Name = "ResaultTextBox";
			this.ResaultTextBox.Size = new System.Drawing.Size(114, 23);
			this.ResaultTextBox.TabIndex = 2;
			// 
			// EqualLabel
			// 
			this.EqualLabel.AutoSize = true;
			this.EqualLabel.Location = new System.Drawing.Point(145, 15);
			this.EqualLabel.Name = "EqualLabel";
			this.EqualLabel.Size = new System.Drawing.Size(15, 15);
			this.EqualLabel.TabIndex = 3;
			this.EqualLabel.Text = "=";
			// 
			// AvgButton
			// 
			this.AvgButton.Location = new System.Drawing.Point(13, 43);
			this.AvgButton.Name = "AvgButton";
			this.AvgButton.Size = new System.Drawing.Size(63, 39);
			this.AvgButton.TabIndex = 4;
			this.AvgButton.Text = "AVG";
			this.AvgButton.UseVisualStyleBackColor = true;
			// 
			// LcmButton
			// 
			this.LcmButton.Location = new System.Drawing.Point(82, 43);
			this.LcmButton.Name = "LcmButton";
			this.LcmButton.Size = new System.Drawing.Size(63, 39);
			this.LcmButton.TabIndex = 5;
			this.LcmButton.Text = "НОК";
			this.LcmButton.UseVisualStyleBackColor = true;
			// 
			// GcdButton
			// 
			this.GcdButton.Location = new System.Drawing.Point(13, 88);
			this.GcdButton.Name = "GcdButton";
			this.GcdButton.Size = new System.Drawing.Size(63, 39);
			this.GcdButton.TabIndex = 6;
			this.GcdButton.Text = "НОД";
			this.GcdButton.UseVisualStyleBackColor = true;
			// 
			// ClearScreenButton
			// 
			this.ClearScreenButton.Location = new System.Drawing.Point(166, 43);
			this.ClearScreenButton.Name = "ClearScreenButton";
			this.ClearScreenButton.Size = new System.Drawing.Size(114, 39);
			this.ClearScreenButton.TabIndex = 8;
			this.ClearScreenButton.Text = "Отчистить экран";
			this.ClearScreenButton.UseVisualStyleBackColor = true;
			this.ClearScreenButton.Click += new System.EventHandler(this.ClearScreenButton_Click);
			// 
			// MessageLabel
			// 
			this.MessageLabel.AutoSize = true;
			this.MessageLabel.Location = new System.Drawing.Point(12, 130);
			this.MessageLabel.Name = "MessageLabel";
			this.MessageLabel.Size = new System.Drawing.Size(77, 15);
			this.MessageLabel.TabIndex = 9;
			this.MessageLabel.Text = "Калькулятор";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 339);
			this.Controls.Add(this.MessageLabel);
			this.Controls.Add(this.ClearScreenButton);
			this.Controls.Add(this.GcdButton);
			this.Controls.Add(this.LcmButton);
			this.Controls.Add(this.AvgButton);
			this.Controls.Add(this.EqualLabel);
			this.Controls.Add(this.ResaultTextBox);
			this.Controls.Add(this.SecondArgumentTextBox);
			this.Controls.Add(this.FirstArgumentTextBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox FirstArgumentTextBox;
		private System.Windows.Forms.TextBox SecondArgumentTextBox;
		private System.Windows.Forms.TextBox ResaultTextBox;
		private System.Windows.Forms.Label EqualLabel;
		private System.Windows.Forms.Button AvgButton;
		private System.Windows.Forms.Button LcmButton;
		private System.Windows.Forms.Button GcdButton;
		private System.Windows.Forms.Button ClearScreenButton;
		private System.Windows.Forms.Label MessageLabel;
	}
}

