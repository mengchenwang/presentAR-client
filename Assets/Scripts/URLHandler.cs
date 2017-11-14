using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

namespace presentARClient {

	public class URLHandler : MonoBehaviour {

		public string getModelName( string url ) 
		{
			Regex regex = new Regex (@"(?<=original\/)(.*)(?=\.unity3d)");
			string[] substrings = regex.Split (url);
			return substrings[1];
		}

		public IEnumerator WaitForRequest(string url) {
			WWW www = new WWW(url);
			yield return www;
			AssetBundle bundle = www.assetBundle;
			if(www.error == null){
				string modelName = getModelName(www.url);
				GameObject model = (GameObject)bundle.LoadAsset(modelName);
				GameObject modelInstance = Instantiate(model);
				modelInstance.transform.parent = GameObject.Find ("ImageTarget").transform;
				modelInstance.transform.localScale = new Vector3 (0.002F, 0.002F, 0.002F);
			}
			else{
				Debug.Log(www.error);
			}
		}

    }

}