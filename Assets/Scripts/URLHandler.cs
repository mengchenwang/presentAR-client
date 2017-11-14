using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

namespace presentARClient {

	public class URLHandler {

		public string getModelName( string url ) {
			Regex regex = new Regex (@"(?<=original\/)(.*)(?=\.unity3d)");
			string[] substrings = regex.Split (url);
			return substrings[1];
		}

    }

}