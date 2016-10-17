using UnityEngine;
using System.Collections;

public class DrawLineManager : MonoBehaviour {

	public Material lMat;

	public SteamVR_TrackedObject LeftTrackedObj; 

	public SteamVR_TrackedObject RightTrackedObj;

	private MeshLineRenderer currLine;

	private int numClicks = 0;

	private GameObject meshes;

	void Update () {
		SteamVR_Controller.Device deviceL = SteamVR_Controller.Input((int)LeftTrackedObj.index);
			if (deviceL.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger)){
				GameObject go = new GameObject(); 
				go.AddComponent<MeshFilter>();
				go.AddComponent<MeshRenderer>();
				go.AddComponent<MeshCollider>();
				currLine = go.AddComponent<MeshLineRenderer> ();
				currLine.lmat = new Material(lMat);
				currLine.setWidth(.1f);
				currLine.tag = "MarkUp";
			} else if (deviceL.GetTouch (SteamVR_Controller.ButtonMask.Trigger)){ 
				currLine.AddPoint(LeftTrackedObj.transform.position);
				numClicks++;
				//need to add markup tag to created objects
			} else if(deviceL.GetTouchUp (SteamVR_Controller.ButtonMask.Trigger)){ 
				numClicks = 0;
				currLine = null;
			} 
			if (currLine != null){ 
				currLine.lmat.color = ColorManager.Instance.GetCurrentColor();
			}

		SteamVR_Controller.Device deviceR = SteamVR_Controller.Input((int)RightTrackedObj.index);
		if (deviceR.GetTouchDown (SteamVR_Controller.ButtonMask.Trigger)) {
			meshes = GameObject.FindWithTag ("MarkUp");
			Destroy (meshes);
		}
	}
}
