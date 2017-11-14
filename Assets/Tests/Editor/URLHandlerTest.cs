using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;


namespace presentARClient  {

	public class URLHandlerTests {

		private URLHandler urlHandler = new URLHandler();

		public string url1 = "http://s3-eu-west-2.amazonaws.com/presentar-files/assets/uploaded_files/000/000/002/original/chuck.unity3d";
		public string url2 = "http://s3-eu-west-2.amazonaws.com/presentar-files/assets/uploaded_files/000/000/002/original/norris.unity3d";
		// pass a url string
		// split url by obj name in and pass to new public var and return model name
		// new www request

		[SetUp]
		public void BeforeTest () {

		}
			
		[Test]
		public void GetModelNameTest ()
		{
			string modelName1 = urlHandler.getModelName (url1);
			Assert.AreEqual ("chuck", modelName1);

			string modelName2 = urlHandler.getModelName (url2);
			Assert.AreEqual ("norris", modelName2); 
		}

	}

}