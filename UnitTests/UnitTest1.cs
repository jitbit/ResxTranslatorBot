using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			string tst = ResxTranslator.TranslateApi.TranslateText("hi there #firstname#\nnew line", "ru");
		}
	}
}
