using Vuforia;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace presentARClient 
{
	public class CloudHandler : MonoBehaviour, ICloudRecoEventHandler {
		private CloudRecoBehaviour mCloudRecoBehaviour;
		private bool mIsScanning = false;
		private string mTargetMetadata = "";
		public ImageTargetBehaviour ImageTargetTemplate;
		private GameObject modelInstance;
		private URLHandler urlHandler = new URLHandler();

		// Use this for initialization
		void Start () {
			// register this event handler at the cloud reco behaviour
			mCloudRecoBehaviour = GetComponent<CloudRecoBehaviour>();

			if (mCloudRecoBehaviour)
			{
				mCloudRecoBehaviour.RegisterEventHandler(this);
			}
		}

		public void OnInitialized() {
			Debug.Log ("Cloud Reco initialized");
		}
		public void OnInitError(TargetFinder.InitState initError) {
			Debug.Log ("Cloud Reco init error " + initError.ToString());
		}
		public void OnUpdateError(TargetFinder.UpdateState updateError) {
			Debug.Log ("Cloud Reco update error " + updateError.ToString());
		}

		public void OnStateChanged(bool scanning) {
			mIsScanning = scanning;
			if (scanning)
			{
				// clear all known trackables
				var tracker = TrackerManager.Instance.GetTracker<ObjectTracker>();
				tracker.TargetFinder.ClearTrackables(false);
			}
		}

		public void OnNewSearchResult(TargetFinder.TargetSearchResult targetSearchResult) {
			mTargetMetadata = targetSearchResult.MetaData;
			string url = mTargetMetadata;

			WWW www = new WWW(url);
			// stop the target finder (i.e. stop scanning the cloud)
			mCloudRecoBehaviour.CloudRecoEnabled = false;

			if (ImageTargetTemplate) {
				// enable the new result with the same ImageTargetBehaviour:
				// make thing a child of image template
				ObjectTracker tracker = TrackerManager.Instance.GetTracker<ObjectTracker>();
				ImageTargetBehaviour imageTargetBehaviour =
					(ImageTargetBehaviour)tracker.TargetFinder.EnableTracking(
						targetSearchResult, ImageTargetTemplate.gameObject);

				StartCoroutine(urlHandler.WaitForRequest(url));
			}
		}

		void OnGUI() {
			// Display current 'scanning' status
			GUI.Box (new Rect(100,100,200,50), mIsScanning ? "Scanning" : "Not scanning");
			// Display metadata of latest detected cloud-target
			GUI.Box (new Rect(100,200,200,50), "Metadata: " + mTargetMetadata);
			// If not scanning, show button
			// so that user can restart cloud scanning
			if (!mIsScanning) {
				if (GUI.Button(new Rect(100,300,200,50), "Restart Scanning")) {
					// Restart TargetFinder
					mCloudRecoBehaviour.CloudRecoEnabled = true;
				}
			}
		}
	}
}