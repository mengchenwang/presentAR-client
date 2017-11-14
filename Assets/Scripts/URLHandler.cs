using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

namespace presentARClient {

	public class URLHandler {

		public string getModelName( string url ) 
		{
			Regex regex = new Regex (@"(?<=original\/)(.*)(?=\.unity3d)");
			string[] substrings = regex.Split (url);
			return substrings[1];
		}

//		IEnumerator WaitForRequest(string url) {
//			WWW www = new WWW(url);
//			yield return www;
//			AssetBundle bundle = www.assetBundle;
//			if(www.error == null){
//				string modelName = getModelName(url);
//				GameObject model = (GameObject)bundle.LoadAsset(modelName);
//				GameObject model_instance = Instantiate(modelName);
//				model_instance.transform.parent = GameObject.Find ("ImageTarget").transform;
//				model_instance.transform.localScale = new Vector3 (0.002F, 0.002F, 0.002F);
//			}
//			else{
//				Debug.Log(www.error);
//			}
//		}

    }

}