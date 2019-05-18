namespace ResxTranslator
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.listLanguages = new System.Windows.Forms.CheckedListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnGo = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbOutputPath = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnOutputBrowse = new System.Windows.Forms.Button();
			this.btnInputBrowse = new System.Windows.Forms.Button();
			this.tbInputPath = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbCreateSubFolderForEveryLang = new System.Windows.Forms.CheckBox();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.lblSelectAll = new System.Windows.Forms.LinkLabel();
			this.txtConsole = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listLanguages
			// 
			this.listLanguages.CheckOnClick = true;
			this.listLanguages.FormattingEnabled = true;
			this.listLanguages.Location = new System.Drawing.Point(15, 25);
			this.listLanguages.Name = "listLanguages";
			this.listLanguages.Size = new System.Drawing.Size(276, 289);
			this.listLanguages.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Translate into:";
			// 
			// btnGo
			// 
			this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnGo.Location = new System.Drawing.Point(657, 321);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(75, 23);
			this.btnGo.TabIndex = 2;
			this.btnGo.Text = "GO";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbOutputPath);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.btnOutputBrowse);
			this.groupBox1.Controls.Add(this.btnInputBrowse);
			this.groupBox1.Controls.Add(this.tbInputPath);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cbCreateSubFolderForEveryLang);
			this.groupBox1.Location = new System.Drawing.Point(316, 25);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(422, 197);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Options";
			// 
			// tbOutputPath
			// 
			this.tbOutputPath.Location = new System.Drawing.Point(9, 100);
			this.tbOutputPath.Name = "tbOutputPath";
			this.tbOutputPath.Size = new System.Drawing.Size(326, 20);
			this.tbOutputPath.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Output folder:";
			// 
			// btnOutputBrowse
			// 
			this.btnOutputBrowse.Location = new System.Drawing.Point(341, 98);
			this.btnOutputBrowse.Name = "btnOutputBrowse";
			this.btnOutputBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnOutputBrowse.TabIndex = 4;
			this.btnOutputBrowse.Text = "browse...";
			this.btnOutputBrowse.UseVisualStyleBackColor = true;
			this.btnOutputBrowse.Click += new System.EventHandler(this.btnOutputBrowse_Click);
			// 
			// btnInputBrowse
			// 
			this.btnInputBrowse.Location = new System.Drawing.Point(341, 45);
			this.btnInputBrowse.Name = "btnInputBrowse";
			this.btnInputBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnInputBrowse.TabIndex = 3;
			this.btnInputBrowse.Text = "browse...";
			this.btnInputBrowse.UseVisualStyleBackColor = true;
			this.btnInputBrowse.Click += new System.EventHandler(this.btnInputBrowse_Click);
			// 
			// tbInputPath
			// 
			this.tbInputPath.Location = new System.Drawing.Point(9, 47);
			this.tbInputPath.Name = "tbInputPath";
			this.tbInputPath.Size = new System.Drawing.Size(326, 20);
			this.tbInputPath.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(219, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Input folder (that contains English resources):";
			// 
			// cbCreateSubFolderForEveryLang
			// 
			this.cbCreateSubFolderForEveryLang.AutoSize = true;
			this.cbCreateSubFolderForEveryLang.Location = new System.Drawing.Point(9, 149);
			this.cbCreateSubFolderForEveryLang.Name = "cbCreateSubFolderForEveryLang";
			this.cbCreateSubFolderForEveryLang.Size = new System.Drawing.Size(385, 17);
			this.cbCreateSubFolderForEveryLang.TabIndex = 0;
			this.cbCreateSubFolderForEveryLang.Text = "Create a sub-directory for each language in the output folder (recommended)\r\n";
			this.cbCreateSubFolderForEveryLang.UseVisualStyleBackColor = true;
			// 
			// lblSelectAll
			// 
			this.lblSelectAll.AutoSize = true;
			this.lblSelectAll.Location = new System.Drawing.Point(241, 9);
			this.lblSelectAll.Name = "lblSelectAll";
			this.lblSelectAll.Size = new System.Drawing.Size(50, 13);
			this.lblSelectAll.TabIndex = 4;
			this.lblSelectAll.TabStop = true;
			this.lblSelectAll.Text = "check all";
			this.lblSelectAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSelectAll_LinkClicked);
			// 
			// txtConsole
			// 
			this.txtConsole.Location = new System.Drawing.Point(12, 362);
			this.txtConsole.Multiline = true;
			this.txtConsole.Name = "txtConsole";
			this.txtConsole.ReadOnly = true;
			this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtConsole.Size = new System.Drawing.Size(726, 209);
			this.txtConsole.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(313, 235);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(387, 65);
			this.label4.TabIndex = 7;
			this.label4.Text = resources.GetString("label4.Text");
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(750, 583);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtConsole);
			this.Controls.Add(this.lblSelectAll);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listLanguages);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Translator Bot";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckedListBox listLanguages;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tbInputPath;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox cbCreateSubFolderForEveryLang;
		private System.Windows.Forms.TextBox tbOutputPath;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnOutputBrowse;
		private System.Windows.Forms.Button btnInputBrowse;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.LinkLabel lblSelectAll;
		private System.Windows.Forms.TextBox txtConsole;
		private System.Windows.Forms.Label label4;
	}
}