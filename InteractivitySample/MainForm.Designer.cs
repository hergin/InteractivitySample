namespace InteractivitySample
{
	partial class MainForm
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
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.button_StartAlgo = new System.Windows.Forms.Button();
			this.checkBox_askToUser = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// button_StartAlgo
			// 
			this.button_StartAlgo.Location = new System.Drawing.Point(66, 113);
			this.button_StartAlgo.Name = "button_StartAlgo";
			this.button_StartAlgo.Size = new System.Drawing.Size(134, 66);
			this.button_StartAlgo.TabIndex = 0;
			this.button_StartAlgo.Text = "Start algorithm";
			this.button_StartAlgo.UseVisualStyleBackColor = true;
			this.button_StartAlgo.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkBox_askToUser
			// 
			this.checkBox_askToUser.AutoSize = true;
			this.checkBox_askToUser.Location = new System.Drawing.Point(85, 60);
			this.checkBox_askToUser.Name = "checkBox_askToUser";
			this.checkBox_askToUser.Size = new System.Drawing.Size(85, 17);
			this.checkBox_askToUser.TabIndex = 1;
			this.checkBox_askToUser.Text = "Ask to user?";
			this.checkBox_askToUser.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(257, 264);
			this.Controls.Add(this.checkBox_askToUser);
			this.Controls.Add(this.button_StartAlgo);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main Form";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Button button_StartAlgo;
		private System.Windows.Forms.CheckBox checkBox_askToUser;
	}
}

