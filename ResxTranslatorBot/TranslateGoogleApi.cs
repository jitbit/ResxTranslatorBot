using Google.Cloud.Translation.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResxTranslator
{
	public static class TranslateGoogleApi
	{
		public static string TranslateText(string input, string targetLanguage)
		{
			if (string.IsNullOrWhiteSpace(input)) return "";
			if (string.IsNullOrWhiteSpace(targetLanguage)) throw new ArgumentException("Target lang not set");

			TranslationClient client = TranslationClient.Create();
			var response = client.TranslateText(input, targetLanguage, "en");
			return response.TranslatedText;
		}
	}
}
