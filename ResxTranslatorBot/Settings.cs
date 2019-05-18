using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace ResxTranslator
{
	static class Settings
	{
		public const string SUBKEY = "Software\\Jitbit\\ResTranslator";

		private static string _inputFolderPath;
		public static string InputFolderPath
		{
			get { return _inputFolderPath; }
			set
			{
				Registry.CurrentUser.CreateSubKey(SUBKEY).SetValue("InputFolderPath", value);
				_inputFolderPath = value;
			}
		}

		private static string _outputFolderPath;
		public static string OutputFolderPath
		{
			get { return _outputFolderPath; }
			set
			{
				Registry.CurrentUser.CreateSubKey(SUBKEY).SetValue("OutputFolderPath", value);
				_outputFolderPath = value;
			}
		}

		private static bool _createFoldersForEachLanguage;
		public static bool CreateFoldersForEachLanguage
		{
			get { return _createFoldersForEachLanguage; }
			set
			{
				Registry.CurrentUser.CreateSubKey(SUBKEY).SetValue("CreateFoldersForEachLanguage", value);
				_createFoldersForEachLanguage = value;
			}
		}

		public static void SaveIfLanguageIsTranslated(string language, bool translate)
		{
			Registry.CurrentUser.CreateSubKey(SUBKEY).SetValue("lang-" + language, translate);
		}

		public static bool GetIfLanguageIsTranslated(string language)
		{
			return Convert.ToBoolean(Registry.CurrentUser.CreateSubKey(SUBKEY).GetValue("lang-" + language));
		}

		static Settings()
		{
			RegistryKey regKey = Registry.CurrentUser.OpenSubKey(SUBKEY);
			if (regKey == null) regKey = Registry.CurrentUser.CreateSubKey(SUBKEY);


			_inputFolderPath = regKey.GetValue("InputFolderPath", "").ToString();
			_outputFolderPath = regKey.GetValue("OutputFolderPath", "").ToString();
			_createFoldersForEachLanguage = Convert.ToBoolean(regKey.GetValue("CreateFoldersForEachLanguage", true));
		}
	}
}
