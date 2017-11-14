using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

namespace presentARClient 
{

	public class URLHandler : MonoBehaviour 
	{
		private AssetHandler assetHandler = new AssetHandler ();

		public string getModelName( string url ) 
		{
			Regex regex = new Regex (@"(?<=original\/)(.*)(?=\.unity3d)");
			string[] substrings = regex.Split (url);
			return substrings[1];
		}

		public IEnumerator WaitForRequest(string url) 
		{
			WWW www = new WWW(url);
			yield return www;
			AssetBundle bundle = www.assetBundle;
			if(www.error == null)
			{
				string modelName = getModelName(www.url);
				assetHandler.LoadAsset (bundle, modelName);
			}
			else
			{
				Debug.Log(www.error);
			}
		}

    }

}