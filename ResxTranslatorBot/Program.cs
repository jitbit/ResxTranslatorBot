using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Resources;
using System.Collections;
using System.Configuration;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace ResxTranslator
{
	class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
			return;
		}

	}
}
