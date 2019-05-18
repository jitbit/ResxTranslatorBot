using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ResxTranslator
{
	class Translator
	{
		public static readonly Dictionary<string, string> LanguageNamesList = new Dictionary<string, string>
		                                                                      	{
		                                                                      		{"ar-SA", "ar"},
		                                                                      		{"cs-CZ", "cs"},
		                                                                      		{"da-DK", "da"},
		                                                                      		{"de-DE", "de"},
		                                                                      		{"es-ES", "es"},
		                                                                      		{"fr-FR", "fr"},
																					{"fi-FI", "fi"},
		                                                                      		{"he-IL", "he"},
		                                                                      		{"hi-IN", "hi"},
		                                                                      		{"it-IT", "it"},
		                                                                      		{"nb-NO", "no"},
		                                                                      		{"nl-NL", "nl"},
		                                                                      		{"pl-PL", "pl"},
		                                                                      		{"pt-PT", "pt"},
		                                                                      		{"ru-RU", "ru"},
		                                                                      		{"sv-SE", "sv"},
		                                                                      		{"tr-TR", "tr"},
		                                                                      		{"zh-CN", "zh-CN"}
		                                                                      	};

		public void Translate()
		{
			TranslateFiles(Settings.InputFolderPath);

			Console.Write("Finished!");
		}

		private void TranslateFiles(string folder)
		{
			string[] files = Directory.GetFiles(folder, "*.resx");
			if (files.Length == 0) return;

			List<string> locales = new List<string>(LanguageNamesList.Keys);
			foreach (string locale in locales)
			{
				if (!Settings.GetIfLanguageIsTranslated(locale)) continue;

				bool creatDirs = Settings.CreateFoldersForEachLanguage;
				string newDir = Settings.OutputFolderPath;
				if (creatDirs)
				{
					newDir += "\\" + locale;

					if (Directory.Exists(newDir))
					{
						Console.WriteLine("Directory " + newDir + " already exists.");
					}
					else
					{
						Console.WriteLine("Creating directory " + newDir);
						Directory.CreateDirectory(newDir);
					}
				}
				foreach (string file in files)
				{
					if (Regex.IsMatch(file.ToLower(), @"\.[a-zA-Z]{2}\-[a-zA-Z]{2}\.resx$")) continue; //skip non-english files

					TranslateFile(file, locale, newDir);
				}
			}
		}

		private void TranslateFile(string filename, string locale, string newDir)
		{
			string shortName = Path.GetFileName(filename);
			string nameWithoutExt = Path.GetFileNameWithoutExtension(filename);
			string newname = nameWithoutExt + "." + locale + ".resx";
			newname = newDir + "\\" + newname;

			//if file already exists
			bool fileExists = File.Exists(newname);
			Dictionary<string, string> existing = new Dictionary<string, string>();
			if (fileExists)
			{
				Console.WriteLine("File " + newname + " already exists. Existing resources in it will be preserved.");
				//get existing keys list
				ResXResourceReader readerNewFile = new ResXResourceReader(newname);
				foreach (DictionaryEntry d in readerNewFile)
					existing.Add(d.Key.ToString(), d.Value.ToString());
				readerNewFile.Close();
			}
			else
			{
				Console.WriteLine("Creating file " + newname);
			}

			Console.WriteLine("Translating file " + shortName + " to " + locale + "....");

			Application.DoEvents(); //I know its bad but can't go multithreading, since I have to update UI

			ResXResourceReader reader = new ResXResourceReader(filename);
			ResXResourceWriter writer = new ResXResourceWriter(newname);
			foreach (DictionaryEntry d in reader)
			{
				//leave existing text intact (if its not empty)
				if (fileExists
					&& existing.Keys.Contains(d.Key.ToString())
					&& !string.IsNullOrEmpty(existing[d.Key.ToString()]))
				{
					writer.AddResource(d.Key.ToString(), existing[d.Key.ToString()]);
				}
				else
				{
					string originalString = d.Value.ToString();
					if (!string.IsNullOrEmpty(originalString.Trim()))
					{
						string translatedString = TranslateApi.TranslateText(originalString, LanguageNamesList[locale]);
						writer.AddResource(d.Key.ToString(), translatedString);
						Thread.Sleep(500); //to prevent spam detector at google
					}
				}
			}
			writer.Close();
			reader.Close();
		}
	}
}
