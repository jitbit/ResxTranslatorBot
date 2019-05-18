using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;

namespace ResxTranslator
{
	public static class TranslateApi
	{
		/// <summary>
		/// Translate Text using api.mymemory.translated.net
		/// </summary>
		/// <param name="input">The string you want translated</param>
		/// <param name="toLanguage">2 letter Language
		/// e.g. "da" language pair means to translate from English to Danish</param>
		/// <returns>Translated to String</returns>
		public static string TranslateText(string input, string toLanguage)
		{
			if (input.Length > 100) return "";

			string url = String.Format("http://api.mymemory.translated.net/get?q={0}&langpair=en|{1}&de=insertyouremail@gmail.com", Uri.EscapeUriString(input).Replace("#", "%23"), toLanguage);
			WebClient webClient = new WebClient();
			webClient.Encoding = System.Text.Encoding.UTF8;
			string result = webClient.DownloadStringUsingResponseEncoding(url);

			dynamic x = JsonConvert.DeserializeObject(result);
			result = x.responseData.translatedText;

			return result.Trim();
		}

		private static string DownloadStringUsingResponseEncoding(this WebClient client, string address)
		{
			if (client == null) throw new ArgumentNullException("client");
			return DownloadStringUsingResponseEncodingImpl(client, client.DownloadData(address));
		}

		private static string DownloadStringUsingResponseEncodingImpl(WebClient client, byte[] data)
		{
			Debug.Assert(client != null);
			Debug.Assert(data != null);

			var contentType = client.GetResponseContentType();

			var encoding = contentType == null || string.IsNullOrEmpty(contentType.CharSet)
						 ? client.Encoding
						 : Encoding.GetEncoding(contentType.CharSet);

			return encoding.GetString(data);
		}

		private static ContentType GetResponseContentType(this WebClient client)
		{
			if (client == null) throw new ArgumentNullException("client");

			var headers = client.ResponseHeaders;
			if (headers == null)
				throw new InvalidOperationException("Response headers not available.");

			var header = headers["Content-Type"];

			return !string.IsNullOrEmpty(header)
				 ? new ContentType(header)
				 : null;
		}
	}
}
