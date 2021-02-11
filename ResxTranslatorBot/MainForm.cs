using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ResxTranslator
{
	public partial class MainForm : Form
	{
		TextWriter _writer = null;


		public MainForm()
		{
			InitializeComponent();

			foreach (string key in Translator.LanguageNamesList.Keys)
			{
				listLanguages.Items.Add(key, Settings.GetIfLanguageIsTranslated(key));
			}

			tbInputPath.Text = Settings.InputFolderPath;
			tbOutputPath.Text = Settings.OutputFolderPath;
			cbCreateSubFolderForEveryLang.Checked = Settings.CreateFoldersForEachLanguage;
			
			
			// Instantiate the writer
			_writer = new TextBoxStreamWriter(txtConsole);
			// Redirect the out Console stream
			Console.SetOut(_writer);

		}

		private void btnInputBrowse_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				tbInputPath.Text = folderBrowserDialog1.SelectedPath;

				//default output path value - is a parent dir to "inputpath"
				if (tbInputPath.Text.LastIndexOf("\\") != tbInputPath.Text.IndexOf("\\")) //if its not a root drive
					tbOutputPath.Text = tbInputPath.Text.Substring(0, tbInputPath.Text.LastIndexOf("\\"));
				else
					tbOutputPath.Text = tbInputPath.Text;
			}
		}

		private void btnOutputBrowse_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				tbOutputPath.Text = folderBrowserDialog1.SelectedPath;
			}
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			if (!Directory.Exists(tbInputPath.Text)) return;
			if (!Directory.Exists(tbOutputPath.Text)) return;

			txtConsole.Text = "";

			//saving settings for next run
			Settings.InputFolderPath = tbInputPath.Text;
			Settings.OutputFolderPath = tbOutputPath.Text;
			Settings.CreateFoldersForEachLanguage = cbCreateSubFolderForEveryLang.Checked;
			foreach (var item in listLanguages.Items) //reset all to fasle
			{
				Settings.SaveIfLanguageIsTranslated(item.ToString(), false);
			}

			foreach (var item in listLanguages.CheckedItems) //save checked
			{
				Settings.SaveIfLanguageIsTranslated(item.ToString(), true);
			}

			Translator translator = new Translator();
			translator.Translate(tbResName.Text);
		}

		private void lblSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			for (int i = 0; i < listLanguages.Items.Count; i++)
				listLanguages.SetItemChecked(i, true);
		}

		//this class redirect "Console.Write" to a textbox
		private class TextBoxStreamWriter : TextWriter
		{
			TextBox _output = null;

			public TextBoxStreamWriter(TextBox output)
			{
				_output = output;
			}

			public override void Write(char value)
			{
				base.Write(value);
				_output.AppendText(value.ToString()); // When character data is written, append it to the text box.
			}

			public override Encoding Encoding
			{
				get { return System.Text.Encoding.UTF8; }
			}
		}
	}
}
