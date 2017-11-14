using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LoadAsset (AssetBundle bundle, string modelName) 
	{
		GameObject model = (GameObject)bundle.LoadAsset (modelName);
		GameObject modelInstance = Instantiate (model);
		TransformAsset (modelInstance);
	}

	public void TransformAsset (GameObject modelInstance)
	{
		modelInstance.transform.parent = GameObject.Find ("ImageTarget").transform;
		modelInstance.transform.localScale = new Vector3 (0.002F, 0.002F, 0.002F);
	}
		
}
